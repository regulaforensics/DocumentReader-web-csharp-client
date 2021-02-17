using System;
using System.Collections.Generic;
using System.IO;
using Regula.DocumentReader.WebClient.Api;
using Regula.DocumentReader.WebClient.Model;
using Regula.DocumentReader.WebClient.Model.Ext;

namespace Regula.DocumentReader.NetCoreExample
{
    internal static class Program
    {
        private const string API_BASE_PATH = "API_BASE_PATH";
        private const string TEST_LICENSE = "TEST_LICENSE";
        private const string LICENSE_FILE_NAME = "regula.license";
        
        public static void Main()
        {
            string apiBaseUrl = Environment.GetEnvironmentVariable(API_BASE_PATH) ?? "http://localhost:8080";

            string licenseFromEnv = Environment.GetEnvironmentVariable(TEST_LICENSE); // optional, used here only for smoke test purposes
            var licenseFromFile = File.Exists(LICENSE_FILE_NAME) 
                ? File.ReadAllBytes(LICENSE_FILE_NAME) 
                : null;
            
            var whitePage0 = File.ReadAllBytes("WHITE.jpg");
            var irPage0 = File.ReadAllBytes("IR.jpg");
            var uvPage0 = File.ReadAllBytes("UV.jpg");
            
            var requestParams = new RecognitionParams()
                .WithScenario(Scenario.FULL_PROCESS)
                .WithResultTypeOutput(new List<int>
                {
                    // actual results, keep only required
                    Result.STATUS, Result.TEXT, Result.IMAGES, Result.DOCUMENT_TYPE,
                    // legacy results
                    Result.MRZ_TEXT, Result.VISUAL_TEXT, Result.BARCODE_TEXT, Result.RFID_TEXT,
                    Result.VISUAL_GRAPHICS, Result.BARCODE_GRAPHICS, Result.RFID_GRAPHICS,
                    Result.LEXICAL_ANALYSIS
                });
            
            var request = new RecognitionRequest(requestParams, new List<ProcessRequestImage>{
                    new ProcessRequestImage(new ImageData(whitePage0), Light.WHITE),
                    new ProcessRequestImage(new ImageData(irPage0), Light.IR),
                    new ProcessRequestImage(new ImageData(uvPage0), Light.UV),
                });
            var api = licenseFromEnv != null 
                ? new DocumentReaderApi(apiBaseUrl).WithLicense(licenseFromEnv)
                : new DocumentReaderApi(apiBaseUrl).WithLicense(licenseFromFile);
            
            var response = api.Process(request);
            
            // overall status results 
            var status = response.Status();
            string docOverallStatus = status.OverallStatus == CheckResult.OK ? "valid" : "not valid";
            string docOpticalTextStatus = status.DetailsOptical.Text == CheckResult.OK ? "valid" : "not valid";

            // text results 
            var docNumberField = response.Text().GetField(TextFieldType.DOCUMENT_NUMBER);
            string docNumberVisual = docNumberField.GetValue(Source.VISUAL);
            string docNumberMrz = docNumberField.GetValue(Source.MRZ);
            int docNumberVisualValidity = docNumberField.SourceValidity(Source.VISUAL);
            int docNumberMrzValidity = docNumberField.SourceValidity(Source.MRZ);
            int docNumberMrzVisualMatching = docNumberField.CrossSourceComparison(Source.MRZ, Source.VISUAL);

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