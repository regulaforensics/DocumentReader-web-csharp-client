using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Regula.DocumentReader.WebClient.Api;
using Regula.DocumentReader.WebClient.Model;
using Regula.DocumentReader.WebClient.Model.Ext;
using Regula.DocumentReader.WebClient.Model.Ext.Autheticity;

namespace Regula.DocumentReader.NetCoreExample
{
	internal static class Program
	{
		private const string API_BASE_PATH = "API_BASE_PATH";
		private const string TEST_LICENSE = "TEST_LICENSE";
		private const string LICENSE_FILE_NAME = "regula.license";

		public static void Main()
		{
			var apiBaseUrl = Environment.GetEnvironmentVariable(API_BASE_PATH) ?? "https://api.regulaforensics.com";

			var licenseFromEnv =
				Environment.GetEnvironmentVariable(TEST_LICENSE); // optional, used here only for smoke test purposes
			var licenseFromFile = File.Exists(LICENSE_FILE_NAME)
				? File.ReadAllBytes(LICENSE_FILE_NAME)
				: null;

			var whitePage0 = File.ReadAllBytes("WHITE.jpg");
			var irPage0 = File.ReadAllBytes("IR.jpg");
			var uvPage0 = File.ReadAllBytes("UV.jpg");

			var requestParams = new RecognitionParams()
				.WithScenario(Scenario.FULL_AUTH)
				.WithResultTypeOutput(new List<int>
				{
					// actual results
					Result.STATUS, Result.AUTHENTICITY, Result.TEXT, Result.IMAGES,
					Result.DOCUMENT_TYPE, Result.DOCUMENT_TYPE_CANDIDATES, Result.DOCUMENT_POSITION,
					// legacy results
					Result.MRZ_TEXT, Result.VISUAL_TEXT, Result.BARCODE_TEXT, Result.RFID_TEXT,
					Result.VISUAL_GRAPHICS, Result.BARCODE_GRAPHICS, Result.RFID_GRAPHICS,
					Result.LEXICAL_ANALYSIS, Result.IMAGE_QUALITY
				})
				.WithLog(false);

			var request = new RecognitionRequest(requestParams, new List<ProcessRequestImage>
			{
				new ProcessRequestImage(new ImageDataExt(whitePage0), Light.WHITE),
				new ProcessRequestImage(new ImageDataExt(irPage0), Light.IR),
				new ProcessRequestImage(new ImageDataExt(uvPage0), Light.UV)
			});
			var api = licenseFromEnv != null
				? new DocumentReaderApi(apiBaseUrl).WithLicense(licenseFromEnv)
				: new DocumentReaderApi(apiBaseUrl).WithLicense(licenseFromFile);

			//var response = api.Process(request);

			var response = api.ProcessAsync(request).GetAwaiter().GetResult();

			// var authHeaders = new Dictionary<string, string>()
			// {
			// 	{ "Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes("USER:PASSWORD"))}" }
			// };
			// var response = api.Process(request, headers: authHeaders);

            Console.WriteLine(response.Log());

			// overall status results 
			var status = response.Status();
			var docOverallStatus = status.OverallStatus == CheckResult.OK ? "valid" : "not valid";
			var docOpticalTextStatus = status.DetailsOptical.Text == CheckResult.OK ? "valid" : "not valid";

			// text results
			var docNumberField = response.Text().GetField(TextFieldType.DOCUMENT_NUMBER);
			var docNumberVisual = docNumberField.GetValue(Source.VISUAL);
			var docNumberMrz = docNumberField.GetValue(Source.MRZ);
			var docNumberVisualValidity = docNumberField.SourceValidity(Source.VISUAL);
			var docNumberMrzValidity = docNumberField.SourceValidity(Source.MRZ);
			var docNumberMrzVisualMatching = docNumberField.CrossSourceComparison(Source.MRZ, Source.VISUAL);

			var docType = response.DocumentType();
			
			
			var docAuthenticity = response.Authenticity();
			var docIRB900 = docAuthenticity.IrB900Checks();
			var docIRB900Blank = docIRB900?.ChecksByElement(SecurityFeatureType.BLANK);

			var docImagePattern = docAuthenticity.ImagePatternChecks();
			var docImagePatternBlank = docImagePattern?.ChecksByElement(SecurityFeatureType.BLANK);

			var docImageQuality = response.ImageQualityChecks();

			var info = api.Ping();
			// var info = api.Ping(headers: authHeaders);
			
			Console.WriteLine("-----------------------------------------------------------------");
			Console.WriteLine($"                API Version: {info.Version}");
			Console.WriteLine("-----------------------------------------------------------------");
			Console.WriteLine($"           Document Overall Status: {docOverallStatus}");
			Console.WriteLine($"      Document Optical Text Status: {docOpticalTextStatus}");
			Console.WriteLine($"            Document Number Visual: {docNumberVisual}");
			Console.WriteLine($"            Document Number MRZ: {docNumberMrz}", docNumberMrz);
			Console.WriteLine($"            Document Name: {docType.DocumentName}");
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