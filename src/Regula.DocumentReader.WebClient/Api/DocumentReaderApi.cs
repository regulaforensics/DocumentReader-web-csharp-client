using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Regula.DocumentReader.WebClient.Client;
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

        public Configuration Configuration
        {
            get => this._processApi.Configuration;
            set => this._processApi.Configuration = value;
        }

        private string License { get; set; }



        public RecognitionResponse Process(ProcessRequest processRequest)
        {
            return Process(processRequest, new Dictionary<String, String>(), default(string));
        }

        public RecognitionResponse Process(ProcessRequest processRequest, Dictionary<String, String> headers)
        {
            return Process(processRequest, headers, default(string));
        }

        public RecognitionResponse Process(ProcessRequest processRequest, String xRequestID)
        {
            return Process(processRequest, new Dictionary<String, String>(), xRequestID);
        }

        public RecognitionResponse Process(ProcessRequest processRequest, Dictionary<String, String> headers, String xRequestID) 
        {
            if (processRequest.SystemInfo == null)
                processRequest.SystemInfo = new ProcessSystemInfo(License);
            else
                processRequest.SystemInfo.License = License;

            return new RecognitionResponse(this._processApi.ApiProcess(processRequest, headers, xRequestID));
        }


        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest)
        {
            return await ProcessAsync(processRequest, new Dictionary<String, String>(), default(string));
        }

        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest, Dictionary<String, String> headers)
        {
            return await ProcessAsync(processRequest, headers, default(string));
        }

        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest, String xRequestID)
        {
            return await ProcessAsync(processRequest, new Dictionary<String, String>(), xRequestID);
        }

        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest, Dictionary<String, String> headers, String xRequestID, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (processRequest.SystemInfo == null)
                processRequest.SystemInfo = new ProcessSystemInfo(License);
            else
                processRequest.SystemInfo.License = License;

            var response = await this._processApi.ApiProcessAsync(processRequest, headers, xRequestID, cancellationToken);

            return new RecognitionResponse(response);
        }

        public DeviceInfo Ping(string xRequestID)
        {
            return this._defaultApi.Ping(new Dictionary<String, String>(), xRequestID);
        }
 
        public DeviceInfo Ping()
        {
            return this._defaultApi.Ping(new Dictionary<String, String>());
        }

        public DeviceInfo Ping(string xRequestID, Dictionary<String, String> headers)
        {
            return this._defaultApi.Ping(headers, xRequestID);
        }

        public DeviceInfo Ping(Dictionary<String, String> headers)
        {
            return this._defaultApi.Ping(headers);
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
