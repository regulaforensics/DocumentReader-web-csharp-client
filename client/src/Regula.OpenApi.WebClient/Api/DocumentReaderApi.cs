using System;
using Regula.OpenApi.WebClient.Model;
using Regula.OpenApi.WebClient.Model.Ext;

namespace Regula.OpenApi.WebClient.Api
{
    public class DocumentReaderApi : DefaultApi
    {
        public DocumentReaderApi(string basePath) 
            : base(basePath)
        {
        }
        
        public string License { get; set; }
        
        public RecognitionResponse Process(ProcessRequest processRequest) 
        {
            processRequest.SystemInfo.License = License;
            return new RecognitionResponse(ApiProcess(processRequest));
        }
        
        public DocumentReaderApi WithLicense(string license) 
        {
            License = license;
            return this;
        }
        
        public void SetLicense(byte[] license) 
        {
            License = Convert.ToBase64String(license);
        }
    }
}