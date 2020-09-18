# Regula.OpenAPI.WebClient - the C# library for the Regula Document Reader Web API

Regula Document Reader Web API

- API version: 5.2.0
- SDK version: 1.0.0

## Frameworks supported

- .NET Standard 2.0
- .NET 4.6.1 or later
- .Net Core 2.0 or later

## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.5 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.7.0 or later
- [Microsoft.CSharp](https://www.nuget.org/packages/Microsoft.CSharp) - 4.7.0 or later
- [NETStandard.Library](https://www.nuget.org/packages/NETStandard.Library) - 2.0.3 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

## Getting Started

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using Regula.OpenApi.WebClient.Api;
using Regula.OpenApi.WebClient.Model;
using Regula.OpenApi.WebClient.Model.Ext;

namespace Regula.OpenApi.Example
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
        }
    }
}
```
