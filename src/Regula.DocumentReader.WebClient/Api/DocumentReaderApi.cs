using System;
using Regula.DocumentReader.WebClient.Model;
using Regula.DocumentReader.WebClient.Model.Ext;

namespace Regula.DocumentReader.WebClient.Api
{
    public class DocumentReaderApi
    {
        private readonly DefaultApi _defaultApi;
        private readonly ProcessApi _processApi;

        public DocumentReaderApi(string basePath)
        {
            this._defaultApi = new DefaultApi(basePath);
            this._processApi = new ProcessApi(basePath);
        }

        private string License { get; set; }
        
        public RecognitionResponse Process(ProcessRequest processRequest) 
        {
            if (processRequest.SystemInfo == null)
                processRequest.SystemInfo = new ProcessSystemInfo(License);
            else
                processRequest.SystemInfo.License = License;

            return new RecognitionResponse(this._processApi.ApiProcess(processRequest));
        }
        public DeviceInfo Ping ()
        {
            return this._defaultApi.Ping();
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
