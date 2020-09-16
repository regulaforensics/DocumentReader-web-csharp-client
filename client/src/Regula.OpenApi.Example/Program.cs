using System;
using System.IO;
using Regula.OpenApi.WebClient.Api;
using Regula.OpenApi.WebClient.Model;

namespace Regula.OpenApi.Example
{
    internal class Program
    {
        private const string ApiBasePath = "API_BASE_PATH";
        private const string TestLicense = "TEST_LICENSE";
        
        public static void Main(string[] args)
        {
            string apiBaseUrl = Environment.GetEnvironmentVariable(ApiBasePath) ?? "http://localhost:8080";
            
            string licensePath = Environment.GetEnvironmentVariable(TestLicense); // optional, used here only for smoke test purposes
            var licenseData = licensePath != null ? File.ReadAllBytes(licensePath) : null;
            
            var imageBytes = File.ReadAllBytes("australia_passport.jpg");
            var image = new ProcessRequestImage(new ImageData(imageBytes), (int)Light.WHITE);
            
            // var requestParams = new RecognitionParams()
            //     .withScenario(Scenario.FULL_PROCESS)
            //     .withResultTypeOutput(Result.STATUS, Result.TEXT, Result.IMAGES, Result.DOCUMENT_TYPE);

            var api = new DocumentReaderApi(apiBaseUrl);
        }
    }
}
