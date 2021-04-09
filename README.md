# Regula.DocumentReader.WebClient - the C# library for the Regula Document Reader Web API

[![NuGet version (Regula.OpenApi.WebClient)](https://img.shields.io/nuget/v/Regula.DocumentReader.WebClient.svg?style=flat-square)](https://www.nuget.org/packages/Regula.DocumentReader.WebClient/)
[![OpenAPI](https://img.shields.io/badge/OpenAPI-defs-8c0a56?style=flat-square)](https://github.com/regulaforensics/DocumentReader-web-openapi)
[![documentation](https://img.shields.io/badge/docs-en-f6858d?style=flat-square)](https://support.regulaforensics.com/hc/en-us/articles/115000916306-Documentation)
[![live](https://img.shields.io/badge/live-demo-0a8c42?style=flat-square)](https://api.regulaforensics.com/)


Documents recognition as easy as reading two bytes.

If you have any problems with or questions about this client, please contact us
through a [GitHub issue](https://github.com/regulaforensics/DocumentReader-web-csharp-client/issues).
You are invited to contribute [new features, fixes, or updates](https://github.com/regulaforensics/DocumentReader-web-csharp-client/issues?q=is%3Aissue+is%3Aopen+label%3A%22help+wanted%22), large or small. 
We are always thrilled to receive pull requests, and do our best to process them as fast as we can.

## Frameworks supported

- .NET Standard 2.0
- .NET Framework 4.6.1 or later
- .Net Core 2.0 or later

## Install package
`Regula.DocumentReader.WebClient` is on the NuGet Package Index:

```bash
PM> Install-Package Regula.DocumentReader.WebClient -Version 5.2.0
```

## Example

Performing request:
```csharp
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
```

Parsing results:
```csharp
var response = api.Process(request);

// status examples
var status = response.Status();
string docOverallStatus = status.OverallStatus == CheckResult.OK ? "valid" : "not valid";
string docOpticalTextStatus = status.DetailsOptical.Text == CheckResult.OK ? "valid" : "not valid";

// text fields examples
var docNumberField = response.Text().GetField(TextFieldType.DOCUMENT_NUMBER);
string docNumberVisual = docNumberField.GetValue(Source.VISUAL);
string docNumberMrz = docNumberField.GetValue(Source.MRZ);
int docNumberVisualValidity = docNumberField.SourceValidity(Source.VISUAL);
int docNumberMrzValidity = docNumberField.SourceValidity(Source.MRZ);
int docNumberMrzVisualMatching = docNumberField.CrossSourceComparison(Source.MRZ, Source.VISUAL);

// images fields examples
var documentImage = response.Images().GetField(GraphicFieldType.DOCUMENT_FRONT).GetValue();
var portraitField = response.Images().GetField(GraphicFieldType.PORTRAIT);
var portraitFromVisual = portraitField.GetValue(Source.VISUAL);
```
You can find this sample in [the example](https://github.com/regulaforensics/DocumentReader-web-csharp-client/tree/master/src/Regula.DocumentReader.NetCoreExample).
