using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Regula.DocumentReader.WebClient.Client;
using Regula.DocumentReader.WebClient.Model;
using Regula.DocumentReader.WebClient.Model.Ext;

namespace Regula.DocumentReader.WebClient.Api
{
    public class DocumentReaderApi
    {
        private readonly HealthcheckApi _healthcheckApi;
        private readonly ProcessApi _processApi;

        public DocumentReaderApi(string basePath)
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
            });

            ILogger<HealthcheckApi> healthcheckLogger = loggerFactory.CreateLogger<HealthcheckApi>();
            ILogger<ProcessApi> processLogger = loggerFactory.CreateLogger<ProcessApi>();

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(basePath)
            };

            var jsonSerializerOptionsProvider = new JsonSerializerOptionsProvider(new JsonSerializerOptions());

            var healthcheckApiEvents = new HealthcheckApiEvents();
            var processApiEvents = new ProcessApiEvents();

            this._healthcheckApi = new HealthcheckApi(
                healthcheckLogger,
                loggerFactory,
                httpClient,
                jsonSerializerOptionsProvider,
                healthcheckApiEvents
            );
            this._processApi = new ProcessApi(
                processLogger,
                loggerFactory,
                httpClient,
                jsonSerializerOptionsProvider,
                processApiEvents
            );
        }

        private string License { get; set; }

        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest)
        {
            return await ProcessAsync(processRequest);
        }

        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest, String xRequestID)
        {
            return await ProcessAsync(processRequest, xRequestID);
        }

        public async Task<RecognitionResponse> ProcessAsync(ProcessRequest processRequest, string xRequestID = default, CancellationToken cancellationToken = default)
        {
            if (processRequest.SystemInfo == null)
                processRequest.SystemInfo = new ProcessSystemInfo(License);
            else
                processRequest.SystemInfo.License = License;

            var response = await this._processApi.ApiProcessAsync(processRequest, xRequestID, cancellationToken);

            return new RecognitionResponse(response);
        }

        public async Task<IPingApiResponse> PingAsync(string xRequestID)
        {
            return await this._healthcheckApi.PingAsync(xRequestID);
        }
 
        public async Task<IPingApiResponse> PingAsync()
        {
            return await this._healthcheckApi.PingAsync();
        }
        
        public async Task<IHealthzApiResponse> HealthAsync(string xRequestID)
        {
            return await this._healthcheckApi.HealthzAsync(xRequestID);
        }
 
        public async Task<IHealthzApiResponse> HealthAsync()
        {
            return await this._healthcheckApi.HealthzAsync();
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
