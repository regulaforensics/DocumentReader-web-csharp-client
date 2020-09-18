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
        private const string ApiBasePath = "API_BASE_PATH";
        private const string TestLicense = "TEST_LICENSE";
        private const string LicenseFileName = "regula.license";
        
        public static void Main()
        {
            string apiBaseUrl = Environment.GetEnvironmentVariable(ApiBasePath) ?? "http://localhost:8083";

            string licenseFromEnv = Environment.GetEnvironmentVariable(TestLicense); // optional, used here only for smoke test purposes
            var licenseFromFile = File.Exists(LicenseFileName) 
                ? File.ReadAllBytes(LicenseFileName) 
                : null;
            
            var imageBytes = File.ReadAllBytes("australia_passport.jpg");
            var image = new ProcessRequestImage(new ImageData(imageBytes), Light.WHITE);
            
            var requestParams = new RecognitionParams()
                .WithScenario(Scenario.FULL_PROCESS)
                .WithResultTypeOutput(new List<int> { Result.STATUS, Result.TEXT, Result.IMAGES, Result.DOCUMENT_TYPE });
            
            var request = new RecognitionRequest(requestParams, image);
            var api = licenseFromEnv != null 
                ? new DocumentReaderApi(apiBaseUrl).WithLicense(licenseFromEnv)
                : new DocumentReaderApi(apiBaseUrl).WithLicense(licenseFromFile);
            
            var response = api.Process(request);
            
            var status = response.Status();
            string docOverallStatus = status.OverallStatus == CheckResult.OK ? "valid" : "not valid";
            string docOpticalTextStatus = status.DetailsOptical.Text == CheckResult.OK ? "valid" : "not valid";

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
