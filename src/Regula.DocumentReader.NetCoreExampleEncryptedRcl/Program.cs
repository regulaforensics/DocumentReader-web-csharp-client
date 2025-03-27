using System;
using System.Collections.Generic;
using System.IO;
using Regula.DocumentReader.WebClient.Api;
using Regula.DocumentReader.WebClient.Model;
using Regula.DocumentReader.WebClient.Model.Ext;
using Regula.DocumentReader.WebClient.Model.Ext.Autheticity;

namespace Regula.DocumentReader.NetCoreExampleEncryptedRcl
{
    internal static class Program
    {
        private const string API_BASE_PATH = "API_BASE_PATH";
        
        public static void Main()
        {
            var apiBaseUrl = Environment.GetEnvironmentVariable(API_BASE_PATH) 
                             ?? "https://api.regulaforensics.com";
            
            var requestParams = new RecognitionParams()
                .WithScenario(Scenario.FULL_PROCESS)
                .WithResultTypeOutput(new List<Result>
                {
                    // actual results
                    Result.STATUS, Result.AUTHENTICITY, Result.TEXT, Result.IMAGES,
                    Result.DOCUMENT_TYPE, Result.DOCUMENT_TYPE_CANDIDATES, Result.DOCUMENT_POSITION,
                    // legacy results
                    Result.MRZ_TEXT, Result.VISUAL_TEXT, Result.BARCODE_TEXT, Result.RFID_TEXT,
                    Result.VISUAL_GRAPHICS, Result.BARCODE_GRAPHICS, Result.RFID_GRAPHICS,
                    Result.LEXICAL_ANALYSIS, Result.IMAGE_QUALITY
                });

            var licenseString = File.ReadAllText("license.txt");
            var encryptedRclString = File.ReadAllText("encrypted-rcl.txt");

            var licenseData = Convert.FromBase64String(licenseString);
            var encryptedRclData = Convert.FromBase64String(encryptedRclString);

            var request = new RecognitionRequest(requestParams, new ContainerList(list: new List<ResultItem>()
            {
                new LicenseResult(licenseData, licenseData.Length, 0, 0, 0, Result.LICENSE),
                new EncryptedRCLResult(encryptedRclData, encryptedRclData.Length, 0, 0, 0, Result.ENCRYPTED_RCL)
            }));
            
            var api = new DocumentReaderApi(apiBaseUrl);

            var response = api.Process(request);

            // overall status results 
            var status = response.Status();
            var docOverallStatus = status.OverallStatus == CheckResult.OK ? "valid" : "not valid";
            var docOpticalTextStatus = status.DetailsOptical.Text == CheckResult.OK ? "valid" : "not valid";

            // text results 
            var docNumberField = response.Text().GetField(TextFieldType.DOCUMENT_NUMBER);
            Console.WriteLine(docNumberField);
            var docNumberVisual = docNumberField.GetValue(Source.VISUAL);
            var docNumberMrz = docNumberField.GetValue(Source.MRZ);
            var docNumberVisualValidity = docNumberField.SourceValidity(Source.VISUAL);
            var docNumberMrzValidity = docNumberField.SourceValidity(Source.MRZ);
            var docNumberMrzVisualMatching = docNumberField.CrossSourceComparison(Source.MRZ, Source.VISUAL);

            var docAuthenticity = response.Authenticity();
            var docIRB900 = docAuthenticity.IrB900Checks();
            var docIRB900Blank = docIRB900?.ChecksByElement(SecurityFeatureType.BLANK);

            var docImagePattern = docAuthenticity.ImagePatternChecks();
            var docImagePatternBlank = docImagePattern?.ChecksByElement(SecurityFeatureType.BLANK);

            var docImageQuality = response.ImageQualityChecks();

            var info = api.Ping();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"                API Version: {info.VarVersion}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"           Document Overall Status: {docOverallStatus}");
            Console.WriteLine($"      Document Optical Text Status: {docOpticalTextStatus}");
            Console.WriteLine($"            Document Number Visual: {docNumberVisual}");
            Console.WriteLine($"               Document Number MRZ: {docNumberMrz}", docNumberMrz);
            Console.WriteLine($"Validity Of Document Number Visual: {docNumberVisualValidity}");
            Console.WriteLine($"   Validity Of Document Number MRZ: {docNumberMrzValidity}");
            Console.WriteLine($"      MRZ-Visual values comparison: {docNumberMrzVisualMatching}");
            Console.WriteLine("-----------------------------------------------------------------");

            // images results     
            var documentImage = response.Images().GetField(GraphicFieldType.DOCUMENT_FRONT).GetValue();
            var portraitField = response.Images().GetField(GraphicFieldType.PORTRAIT);
            var portraitFromVisual = portraitField.GetValue(Source.VISUAL);

            File.WriteAllBytes("document-image.jpg", documentImage);
            File.WriteAllBytes("portrait.jpg", portraitFromVisual);

            // how to get low lvl individual results
            // var lexResult = response.ResultByType<LexicalAnalysisResult>(Result.LEXICAL_ANALYSIS);
        }
    }
}