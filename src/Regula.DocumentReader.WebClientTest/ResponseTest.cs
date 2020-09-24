using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;
using Regula.DocumentReader.WebClient.Model;
using Regula.DocumentReader.WebClient.Model.Ext;

namespace Regula.DocumentReader.WebClientTest
{
    public class ResponseTest
    {
        [Test]
        public void ShouldProcessValidResponse()
        {
            var response = GetResponseFromFile("response.json");
            
            Assert.AreEqual(CheckResult.ERROR, response.Status().OverallStatus);
            Assert.AreEqual(CheckResult.ERROR, response.Status().DetailsOptical.Text);

            var docNumber = response.Text().GetField(TextFieldType.DOCUMENT_NUMBER);
            Assert.AreEqual("U0996738", docNumber.Value);
            Assert.AreEqual("U0996738", docNumber.GetValue(Source.VISUAL));
            Assert.AreEqual("U0996738", docNumber.GetValue(Source.MRZ));
            Assert.AreEqual(2, docNumber.SourceValidity(Source.VISUAL));
            Assert.AreEqual(1, docNumber.SourceValidity(Source.MRZ));
            Assert.AreEqual(1, docNumber.CrossSourceComparison(Source.MRZ, Source.VISUAL));
        }
        
        [Test]
        public void ShouldProcessRawResultType()
        {
            Assert.Fail();
        }

        private static RecognitionResponse GetResponseFromFile(string fileName)
        {
            string responseJson = File.ReadAllText(fileName);
            
            var processResponse = JsonConvert.DeserializeObject<ProcessResponse>(responseJson, new JsonSerializerSettings
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            });
            
            var response = new RecognitionResponse(processResponse);
            return response;
        }
    }
}
