/* 
 * Regula Document Reader Web API
 *
 * Regula Document Reader Web API
 *
 * The version of the OpenAPI document: 5.2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Regula.DocumentReader.WebClient.Client;
using Regula.DocumentReader.WebClient.Model;

namespace Regula.DocumentReader.WebClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Process list of documents images and return extracted data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processRequest"></param>
        /// <returns>ProcessResponse</returns>
        ProcessResponse ApiProcess (ProcessRequest processRequest);

        /// <summary>
        /// Process list of documents images and return extracted data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processRequest"></param>
        /// <returns>ApiResponse of ProcessResponse</returns>
        ApiResponse<ProcessResponse> ApiProcessWithHttpInfo (ProcessRequest processRequest);
        /// <summary>
        /// Server health check
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DeviceInfo</returns>
        DeviceInfo Ping ();

        /// <summary>
        /// Server health check
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DeviceInfo</returns>
        ApiResponse<DeviceInfo> PingWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Process list of documents images and return extracted data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ProcessResponse</returns>
        System.Threading.Tasks.Task<ProcessResponse> ApiProcessAsync (ProcessRequest processRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Process list of documents images and return extracted data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ProcessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProcessResponse>> ApiProcessWithHttpInfoAsync (ProcessRequest processRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Server health check
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of DeviceInfo</returns>
        System.Threading.Tasks.Task<DeviceInfo> PingAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Server health check
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (DeviceInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceInfo>> PingWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultApi : IDefaultApi
    {
        private Regula.DocumentReader.WebClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Regula.DocumentReader.WebClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Regula.DocumentReader.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// </summary>
        /// <returns></returns>
        public DefaultApi()
        {
            this.Configuration = Regula.DocumentReader.WebClient.Client.Configuration.Default;

            ExceptionFactory = Regula.DocumentReader.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Regula.DocumentReader.WebClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Regula.DocumentReader.WebClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Regula.DocumentReader.WebClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Regula.DocumentReader.WebClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Regula.DocumentReader.WebClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Process list of documents images and return extracted data 
        /// </summary>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processRequest"></param>
        /// <returns>ProcessResponse</returns>
        public ProcessResponse ApiProcess (ProcessRequest processRequest)
        {
             ApiResponse<ProcessResponse> localVarResponse = ApiProcessWithHttpInfo(processRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process list of documents images and return extracted data 
        /// </summary>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processRequest"></param>
        /// <returns>ApiResponse of ProcessResponse</returns>
        public ApiResponse<ProcessResponse> ApiProcessWithHttpInfo (ProcessRequest processRequest)
        {
            // verify the required parameter 'processRequest' is set
            if (processRequest == null)
                throw new ApiException(400, "Missing required parameter 'processRequest' when calling DefaultApi->ApiProcess");

            var localVarPath = "/api/process";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (processRequest != null && processRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(processRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = processRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiProcess", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProcessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProcessResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProcessResponse)));
        }

        /// <summary>
        /// Process list of documents images and return extracted data 
        /// </summary>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ProcessResponse</returns>
        public async System.Threading.Tasks.Task<ProcessResponse> ApiProcessAsync (ProcessRequest processRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ProcessResponse> localVarResponse = await ApiProcessWithHttpInfoAsync(processRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Process list of documents images and return extracted data 
        /// </summary>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ProcessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProcessResponse>> ApiProcessWithHttpInfoAsync (ProcessRequest processRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'processRequest' is set
            if (processRequest == null)
                throw new ApiException(400, "Missing required parameter 'processRequest' when calling DefaultApi->ApiProcess");

            var localVarPath = "/api/process";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (processRequest != null && processRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(processRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = processRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiProcess", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProcessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProcessResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProcessResponse)));
        }

        /// <summary>
        /// Server health check 
        /// </summary>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DeviceInfo</returns>
        public DeviceInfo Ping ()
        {
             ApiResponse<DeviceInfo> localVarResponse = PingWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Server health check 
        /// </summary>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DeviceInfo</returns>
        public ApiResponse<DeviceInfo> PingWithHttpInfo ()
        {

            var localVarPath = "/api/ping";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Ping", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeviceInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DeviceInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceInfo)));
        }

        /// <summary>
        /// Server health check 
        /// </summary>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of DeviceInfo</returns>
        public async System.Threading.Tasks.Task<DeviceInfo> PingAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<DeviceInfo> localVarResponse = await PingWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Server health check 
        /// </summary>
        /// <exception cref="Regula.DocumentReader.WebClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (DeviceInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceInfo>> PingWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/api/ping";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Ping", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeviceInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DeviceInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceInfo)));
        }

    }
}