/* 
 * OpenAPI definition
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace LoanStreet.LoanServicing.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDealsControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deal"> (optional)</param>
        /// <returns>Deal</returns>
        Deal CreateDeal (Deal deal = default(Deal));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deal"> (optional)</param>
        /// <returns>ApiResponse of Deal</returns>
        ApiResponse<Deal> CreateDealWithHttpInfo (Deal deal = default(Deal));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <returns>Deal</returns>
        Deal FetchDeal (string dealId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <returns>ApiResponse of Deal</returns>
        ApiResponse<Deal> FetchDealWithHttpInfo (string dealId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Deal&gt;</returns>
        List<Deal> FetchDeals ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Deal&gt;</returns>
        ApiResponse<List<Deal>> FetchDealsWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <param name="deal"> (optional)</param>
        /// <returns>Deal</returns>
        Deal UpdateDeal (string dealId, Deal deal = default(Deal));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <param name="deal"> (optional)</param>
        /// <returns>ApiResponse of Deal</returns>
        ApiResponse<Deal> UpdateDealWithHttpInfo (string dealId, Deal deal = default(Deal));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDealsControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deal"> (optional)</param>
        /// <returns>Task of Deal</returns>
        System.Threading.Tasks.Task<Deal> CreateDealAsync (Deal deal = default(Deal));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deal"> (optional)</param>
        /// <returns>Task of ApiResponse (Deal)</returns>
        System.Threading.Tasks.Task<ApiResponse<Deal>> CreateDealAsyncWithHttpInfo (Deal deal = default(Deal));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <returns>Task of Deal</returns>
        System.Threading.Tasks.Task<Deal> FetchDealAsync (string dealId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <returns>Task of ApiResponse (Deal)</returns>
        System.Threading.Tasks.Task<ApiResponse<Deal>> FetchDealAsyncWithHttpInfo (string dealId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Deal&gt;</returns>
        System.Threading.Tasks.Task<List<Deal>> FetchDealsAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Deal&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Deal>>> FetchDealsAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <param name="deal"> (optional)</param>
        /// <returns>Task of Deal</returns>
        System.Threading.Tasks.Task<Deal> UpdateDealAsync (string dealId, Deal deal = default(Deal));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <param name="deal"> (optional)</param>
        /// <returns>Task of ApiResponse (Deal)</returns>
        System.Threading.Tasks.Task<ApiResponse<Deal>> UpdateDealAsyncWithHttpInfo (string dealId, Deal deal = default(Deal));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDealsControllerApi : IDealsControllerApiSync, IDealsControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DealsControllerApi : IDealsControllerApi
    {
        private LoanStreet.LoanServicing.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DealsControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DealsControllerApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DealsControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DealsControllerApi(String basePath)
        {
            this.Configuration = LoanStreet.LoanServicing.Client.Configuration.MergeConfigurations(
                LoanStreet.LoanServicing.Client.GlobalConfiguration.Instance,
                new LoanStreet.LoanServicing.Client.Configuration { BasePath = basePath }
            );
            this.Client = new LoanStreet.LoanServicing.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new LoanStreet.LoanServicing.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = LoanStreet.LoanServicing.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DealsControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DealsControllerApi(LoanStreet.LoanServicing.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = LoanStreet.LoanServicing.Client.Configuration.MergeConfigurations(
                LoanStreet.LoanServicing.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new LoanStreet.LoanServicing.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new LoanStreet.LoanServicing.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = LoanStreet.LoanServicing.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DealsControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DealsControllerApi(LoanStreet.LoanServicing.Client.ISynchronousClient client,LoanStreet.LoanServicing.Client.IAsynchronousClient asyncClient, LoanStreet.LoanServicing.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = LoanStreet.LoanServicing.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public LoanStreet.LoanServicing.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public LoanStreet.LoanServicing.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public LoanStreet.LoanServicing.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public LoanStreet.LoanServicing.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deal"> (optional)</param>
        /// <returns>Deal</returns>
        public Deal CreateDeal (Deal deal = default(Deal))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Deal> localVarResponse = CreateDealWithHttpInfo(deal);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deal"> (optional)</param>
        /// <returns>ApiResponse of Deal</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< Deal > CreateDealWithHttpInfo (Deal deal = default(Deal))
        {
            LoanStreet.LoanServicing.Client.RequestOptions localVarRequestOptions = new LoanStreet.LoanServicing.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = LoanStreet.LoanServicing.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = LoanStreet.LoanServicing.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = deal;

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< Deal >("/v1/private/deals", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateDeal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deal"> (optional)</param>
        /// <returns>Task of Deal</returns>
        public async System.Threading.Tasks.Task<Deal> CreateDealAsync (Deal deal = default(Deal))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Deal> localVarResponse = await CreateDealAsyncWithHttpInfo(deal);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deal"> (optional)</param>
        /// <returns>Task of ApiResponse (Deal)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<Deal>> CreateDealAsyncWithHttpInfo (Deal deal = default(Deal))
        {

            LoanStreet.LoanServicing.Client.RequestOptions localVarRequestOptions = new LoanStreet.LoanServicing.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = deal;

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Deal>("/v1/private/deals", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateDeal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <returns>Deal</returns>
        public Deal FetchDeal (string dealId)
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Deal> localVarResponse = FetchDealWithHttpInfo(dealId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <returns>ApiResponse of Deal</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< Deal > FetchDealWithHttpInfo (string dealId)
        {
            // verify the required parameter 'dealId' is set
            if (dealId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'dealId' when calling DealsControllerApi->FetchDeal");

            LoanStreet.LoanServicing.Client.RequestOptions localVarRequestOptions = new LoanStreet.LoanServicing.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = LoanStreet.LoanServicing.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = LoanStreet.LoanServicing.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (dealId != null)
                localVarRequestOptions.PathParameters.Add("dealId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(dealId)); // path parameter

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< Deal >("/v1/private/deals/{dealId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchDeal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <returns>Task of Deal</returns>
        public async System.Threading.Tasks.Task<Deal> FetchDealAsync (string dealId)
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Deal> localVarResponse = await FetchDealAsyncWithHttpInfo(dealId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <returns>Task of ApiResponse (Deal)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<Deal>> FetchDealAsyncWithHttpInfo (string dealId)
        {
            // verify the required parameter 'dealId' is set
            if (dealId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'dealId' when calling DealsControllerApi->FetchDeal");


            LoanStreet.LoanServicing.Client.RequestOptions localVarRequestOptions = new LoanStreet.LoanServicing.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (dealId != null)
                localVarRequestOptions.PathParameters.Add("dealId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(dealId)); // path parameter

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Deal>("/v1/private/deals/{dealId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchDeal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Deal&gt;</returns>
        public List<Deal> FetchDeals ()
        {
             LoanStreet.LoanServicing.Client.ApiResponse<List<Deal>> localVarResponse = FetchDealsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Deal&gt;</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< List<Deal> > FetchDealsWithHttpInfo ()
        {
            LoanStreet.LoanServicing.Client.RequestOptions localVarRequestOptions = new LoanStreet.LoanServicing.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = LoanStreet.LoanServicing.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = LoanStreet.LoanServicing.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< List<Deal> >("/v1/private/deals", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchDeals", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Deal&gt;</returns>
        public async System.Threading.Tasks.Task<List<Deal>> FetchDealsAsync ()
        {
             LoanStreet.LoanServicing.Client.ApiResponse<List<Deal>> localVarResponse = await FetchDealsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Deal&gt;)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<List<Deal>>> FetchDealsAsyncWithHttpInfo ()
        {

            LoanStreet.LoanServicing.Client.RequestOptions localVarRequestOptions = new LoanStreet.LoanServicing.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Deal>>("/v1/private/deals", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchDeals", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <param name="deal"> (optional)</param>
        /// <returns>Deal</returns>
        public Deal UpdateDeal (string dealId, Deal deal = default(Deal))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Deal> localVarResponse = UpdateDealWithHttpInfo(dealId, deal);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <param name="deal"> (optional)</param>
        /// <returns>ApiResponse of Deal</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< Deal > UpdateDealWithHttpInfo (string dealId, Deal deal = default(Deal))
        {
            // verify the required parameter 'dealId' is set
            if (dealId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'dealId' when calling DealsControllerApi->UpdateDeal");

            LoanStreet.LoanServicing.Client.RequestOptions localVarRequestOptions = new LoanStreet.LoanServicing.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = LoanStreet.LoanServicing.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = LoanStreet.LoanServicing.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (dealId != null)
                localVarRequestOptions.PathParameters.Add("dealId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(dealId)); // path parameter
            localVarRequestOptions.Data = deal;

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put< Deal >("/v1/private/deals/{dealId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateDeal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <param name="deal"> (optional)</param>
        /// <returns>Task of Deal</returns>
        public async System.Threading.Tasks.Task<Deal> UpdateDealAsync (string dealId, Deal deal = default(Deal))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Deal> localVarResponse = await UpdateDealAsyncWithHttpInfo(dealId, deal);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dealId"></param>
        /// <param name="deal"> (optional)</param>
        /// <returns>Task of ApiResponse (Deal)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<Deal>> UpdateDealAsyncWithHttpInfo (string dealId, Deal deal = default(Deal))
        {
            // verify the required parameter 'dealId' is set
            if (dealId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'dealId' when calling DealsControllerApi->UpdateDeal");


            LoanStreet.LoanServicing.Client.RequestOptions localVarRequestOptions = new LoanStreet.LoanServicing.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (dealId != null)
                localVarRequestOptions.PathParameters.Add("dealId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(dealId)); // path parameter
            localVarRequestOptions.Data = deal;

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Deal>("/v1/private/deals/{dealId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateDeal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
