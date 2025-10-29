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
        private readonly HealthcheckApi _healthcheckApi;
        private readonly ProcessApi _processApi;
        private readonly ResourcesApi _resourcesApi;

        public DocumentReaderApi(string basePath)
        {
            this._healthcheckApi = new HealthcheckApi(basePath);
            this._processApi = new ProcessApi(basePath);
            this._resourcesApi = new ResourcesApi(basePath);
        }
        
        public DocumentReaderApi(Configuration configuration)
        {
            this._healthcheckApi = new HealthcheckApi(configuration);
            this._processApi = new ProcessApi(configuration);
            this._resourcesApi = new ResourcesApi(configuration);
        }

        public IReadableConfiguration Configuration
        {
            get => this._processApi.Configuration;
            set
            {
                this._healthcheckApi.Configuration = value;
                this._processApi.Configuration = value;
                this._resourcesApi.Configuration = value;
            }
        }

        private string License { get; set; }

        public RecognitionResponse Process(ProcessRequest processRequest)
        {
            return Process(processRequest, default(string));
        }
        public RecognitionResponse Process(ProcessRequest processRequest, String xRequestID) 
        {
            if (processRequest.SystemInfo == null)
                processRequest.SystemInfo = new ProcessSystemInfo(License);
            else
                processRequest.SystemInfo.License = License;

            var response = this._processApi.ApiProcessWithHttpInfo(processRequest, xRequestID);

            return new RecognitionResponse(response);
        }

        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest)
        {
            return await ProcessAsync(processRequest, default(string));
        }

        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest, String xRequestID)
        {
            return await ProcessAsync(processRequest, xRequestID, new CancellationToken());
        }

        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest, String xRequestID, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (processRequest.SystemInfo == null)
                processRequest.SystemInfo = new ProcessSystemInfo(License);
            else
                processRequest.SystemInfo.License = License;

            var response = await this._processApi.ApiProcessWithHttpInfoAsync(processRequest, xRequestID, cancellationToken);

            return new RecognitionResponse(response);
        }

        public DatabaseDocumentList Doclist()
        {
            return this._resourcesApi.Doclist();
        }

        public async Task<DatabaseDocumentList> DoclistAsync()
        {
            return await DoclistAsync(new CancellationToken());
        }

        public async Task<DatabaseDocumentList> DoclistAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await this._resourcesApi.DoclistAsync(cancellationToken);
        }

        public DeviceInfo Ping(string xRequestID)
        {
            return this._healthcheckApi.Ping(xRequestID);
        }
 
        public DeviceInfo Ping()
        {
            return this._healthcheckApi.Ping();
        }

        public Healthcheck Health(string xRequestID)
        {
            return this._healthcheckApi.Healthz(xRequestID);
        }
 
        public Healthcheck Health()
        {
            return this._healthcheckApi.Healthz();
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
