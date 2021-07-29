/* 
 * Influx OSS API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using InfluxDB.Client.Api.Client;
using InfluxDB.Client.Api.Domain;

namespace InfluxDB.Client.Api.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRoutesService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List all top level routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <returns>Routes</returns>
        Routes GetRoutes (string zapTraceSpan = null);

        /// <summary>
        /// List all top level routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <returns>ApiResponse of Routes</returns>
        ApiResponse<Routes> GetRoutesWithHttpInfo (string zapTraceSpan = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List all top level routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Task of Routes</returns>
        System.Threading.Tasks.Task<Routes> GetRoutesAsync (string zapTraceSpan = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// List all top level routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Task of ApiResponse (Routes)</returns>
        System.Threading.Tasks.Task<ApiResponse<Routes>> GetRoutesAsyncWithHttpInfo (string zapTraceSpan = null, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RoutesService : IRoutesService
    {
        private InfluxDB.Client.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesService"/> class.
        /// </summary>
        /// <returns></returns>
        public RoutesService(String basePath)
        {
            this.Configuration = new InfluxDB.Client.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = InfluxDB.Client.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RoutesService(InfluxDB.Client.Api.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = InfluxDB.Client.Api.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = InfluxDB.Client.Api.Client.Configuration.DefaultExceptionFactory;
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
        public InfluxDB.Client.Api.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public InfluxDB.Client.Api.Client.ExceptionFactory ExceptionFactory
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
        /// List all top level routes 
        /// </summary>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <returns>Routes</returns>
        public Routes GetRoutes (string zapTraceSpan = null)
        {
             ApiResponse<Routes> localVarResponse = GetRoutesWithHttpInfo(zapTraceSpan);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all top level routes 
        /// </summary>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <returns>ApiResponse of Routes</returns>
        public ApiResponse< Routes > GetRoutesWithHttpInfo (string zapTraceSpan = null)
        {

            var localVarPath = "/api/v2/";
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

            if (zapTraceSpan != null) localVarHeaderParams.Add("Zap-Trace-Span", this.Configuration.ApiClient.ParameterToString(zapTraceSpan)); // header parameter

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };

            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null && !localVarHeaderParams.ContainsKey("Accept"))
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRoutes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Routes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Routes) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Routes)));
        }

        /// <summary>
        /// List all top level routes 
        /// </summary>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>ApiResponse of Routes</returns>
        public async System.Threading.Tasks.Task<IRestResponse> GetRoutesWithIRestResponseAsync (string zapTraceSpan = null, CancellationToken cancellationToken = default)
        {

            var localVarPath = "/api/v2/";
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

            if (zapTraceSpan != null) localVarHeaderParams.Add("Zap-Trace-Span", this.Configuration.ApiClient.ParameterToString(zapTraceSpan)); // header parameter

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };

            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null && !localVarHeaderParams.ContainsKey("Accept"))
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken).ConfigureAwait(false);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRoutes", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all top level routes 
        /// </summary>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <returns>ApiResponse of Routes</returns>
        public IRestResponse GetRoutesWithIRestResponse (string zapTraceSpan = null)
        {

            var localVarPath = "/api/v2/";
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

            if (zapTraceSpan != null) localVarHeaderParams.Add("Zap-Trace-Span", this.Configuration.ApiClient.ParameterToString(zapTraceSpan)); // header parameter

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };

            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null && !localVarHeaderParams.ContainsKey("Accept"))
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRoutes", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }
        
        /// <summary>
        /// List all top level routes 
        /// </summary>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <returns>ApiResponse of Routes</returns>
        public RestRequest GetRoutesWithRestRequest (string zapTraceSpan = null)
        {

            var localVarPath = "/api/v2/";
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

            if (zapTraceSpan != null) localVarHeaderParams.Add("Zap-Trace-Span", this.Configuration.ApiClient.ParameterToString(zapTraceSpan)); // header parameter

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };

            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null && !localVarHeaderParams.ContainsKey("Accept"))
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            return this.Configuration.ApiClient.PrepareRequest(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);
        }

        /// <summary>
        /// List all top level routes 
        /// </summary>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Task of Routes</returns>
        public async System.Threading.Tasks.Task<Routes> GetRoutesAsync (string zapTraceSpan = null, CancellationToken cancellationToken = default)
        {
             ApiResponse<Routes> localVarResponse = await GetRoutesAsyncWithHttpInfo(zapTraceSpan, cancellationToken).ConfigureAwait(false);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all top level routes 
        /// </summary>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Task of ApiResponse (Routes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Routes>> GetRoutesAsyncWithHttpInfo (string zapTraceSpan = null, CancellationToken cancellationToken = default)
        {
            // make the HTTP request
            IRestResponse localVarResponse = await GetRoutesAsyncWithIRestResponse(zapTraceSpan, cancellationToken).ConfigureAwait(false);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRoutes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Routes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Routes) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Routes)));
        }
            
        /// <summary>
        /// List all top level routes 
        /// </summary>
        /// <exception cref="InfluxDB.Client.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zapTraceSpan">OpenTracing span context (optional)</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Task of IRestResponse (Routes)</returns>
        public async System.Threading.Tasks.Task<IRestResponse> GetRoutesAsyncWithIRestResponse (string zapTraceSpan = null, CancellationToken cancellationToken = default)
        {

            var localVarPath = "/api/v2/";
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

            if (zapTraceSpan != null) localVarHeaderParams.Add("Zap-Trace-Span", this.Configuration.ApiClient.ParameterToString(zapTraceSpan)); // header parameter

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };

            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null && !localVarHeaderParams.ContainsKey("Accept"))
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRoutes", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}