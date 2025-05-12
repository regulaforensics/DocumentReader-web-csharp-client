using Regula.DocumentReader.WebClient.Api;
using Regula.DocumentReader.WebClient.Client;
using Regula.DocumentReader.WebClient.Model;
using Regula.DocumentReader.WebClient.Model.Ext;
using System.Text;

namespace Regula.DocumentReader.NetCoreExamplePortraitComparison
{
	internal static class Program
	{
		private const string API_BASE_PATH = "API_BASE_PATH";

		public static void Main()
		{
			// ************************************************************************************************
			// * This example demonstrates how to perform a full document processing with portrait comparison *
			// * using FaceAPI Web Server                                                                     *
			// ************************************************************************************************
			
			var apiBaseUrl = Environment.GetEnvironmentVariable(API_BASE_PATH) ?? "https://api.regulaforensics.com";
   
			var whitePage0 = File.ReadAllBytes("WHITE.jpg");
   
			var requestParams = new RecognitionParams { AlreadyCropped = true }
				.WithScenario(Scenario.FULL_PROCESS)
				// .WithResultTypeOutput(new List<int>
				// {
				// 	// actual results
				// 	Result.STATUS, Result.AUTHENTICITY, Result.TEXT, Result.IMAGES,
				// 	Result.DOCUMENT_TYPE, Result.DOCUMENT_TYPE_CANDIDATES, Result.DOCUMENT_POSITION,
				// 	// Portrait comparison
				// 	Result.PORTRAIT_COMPARISON
				// })
				.WithFaceApi("https://faceapi.regulaforensics.com")
				.WithAuthParam(new AuthParams(checkPhotoComparison: true))
				.WithLog(false);
			
			var configuration = new Configuration
			{
				BasePath = apiBaseUrl,
				// DefaultHeaders = new Dictionary<string, string>
				// {
				// 	{ "Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes("USER:PASSWORD"))}" },
				// }
			};
			var api = new DocumentReaderApi(configuration);
			
			var request = new RecognitionRequest(requestParams, new List<ProcessRequestImage>
			{
				new ProcessRequestImage(new ImageDataExt(whitePage0), Light.WHITE),
			});
			request.ExtPortrait = Convert.ToBase64String(File.ReadAllBytes("portrait.png"));
			
			var response = api.Process(request);
			var comparison = response.PortraitComparison();
   
            Console.WriteLine(response.Log());
   
			// overall status results 
			var status = response.Status();
			var docOverallStatus = status.OverallStatus == CheckResult.OK ? "valid" : "not valid";
			var docOpticalTextStatus = status.DetailsOptical.Text == CheckResult.OK ? "valid" : "not valid";
   
			var docType = response.DocumentType();
			var info = api.Health();
			
			Console.WriteLine("-----------------------------------------------------------------");
			Console.WriteLine($"                API Version: {info.VarVersion}");
			Console.WriteLine("-----------------------------------------------------------------");
			Console.WriteLine($"           Document Overall Status: {docOverallStatus}");
			Console.WriteLine($"      Document Optical Text Status: {docOpticalTextStatus}");
			Console.WriteLine($"            Document Name: {docType.DocumentName}");
			Console.WriteLine($"      Portrait Comparison Percents: {comparison.AuthenticityCheckList.List[0].List[0].PercentValue}");
			Console.WriteLine("-----------------------All Text Fields------------------------");
			foreach (var field in response.Text().FieldList)
			{
				Console.WriteLine($"Source: {field.FieldName}, Value: {field.Value}");	
			}
			Console.WriteLine("-----------------------------------------------------------------");
   
   
			// images results     
			var documentImage = response.Images().GetField(GraphicFieldType.DOCUMENT_FRONT).GetValue();
			var portraitField = response.Images().GetField(GraphicFieldType.PORTRAIT);
			var portraitFromVisual = portraitField.GetValue(Source.VISUAL);
   
			File.WriteAllBytes("document-image.jpg", documentImage);
			File.WriteAllBytes("portrait.jpg", portraitFromVisual);
		}
	}
}