using System;
using Regula.DocumentReader.WebClient.Model;
using Regula.DocumentReader.WebClient.Model.Ext;

namespace Regula.DocumentReader.WebClient.Api
{
    public class DocumentReaderApi : DefaultApi
    {
        public DocumentReaderApi(string basePath)
            : base(basePath) { }

        private string License { get; set; }
        
        public RecognitionResponse Process(ProcessRequest processRequest) 
        {
            if (processRequest.SystemInfo == null)
                processRequest.SystemInfo = new ProcessSystemInfo(License);
            else
                processRequest.SystemInfo.License = License;

            return new RecognitionResponse(ApiProcess(processRequest));
        }
        
        public DocumentReaderApi WithLicense(string license) 
        {
            License = license;
            return this;
        }
        
        public DocumentReaderApi WithLicense(byte[] license) 
        {
            License = license != null ? Convert.ToBase64String(license) : null;
            return this;
        }
    }
}
