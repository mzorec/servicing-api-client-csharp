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
    public interface ILoanSyndicationsControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="sale"> (optional)</param>
        /// <returns>Sale</returns>
        Sale CreateSyndication (string loanId, Sale sale = default(Sale));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="sale"> (optional)</param>
        /// <returns>ApiResponse of Sale</returns>
        ApiResponse<Sale> CreateSyndicationWithHttpInfo (string loanId, Sale sale = default(Sale));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoanSyndicationsControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="sale"> (optional)</param>
        /// <returns>Task of Sale</returns>
        System.Threading.Tasks.Task<Sale> CreateSyndicationAsync (string loanId, Sale sale = default(Sale));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="sale"> (optional)</param>
        /// <returns>Task of ApiResponse (Sale)</returns>
        System.Threading.Tasks.Task<ApiResponse<Sale>> CreateSyndicationAsyncWithHttpInfo (string loanId, Sale sale = default(Sale));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoanSyndicationsControllerApi : ILoanSyndicationsControllerApiSync, ILoanSyndicationsControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LoanSyndicationsControllerApi : ILoanSyndicationsControllerApi
    {
        private LoanStreet.LoanServicing.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanSyndicationsControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoanSyndicationsControllerApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanSyndicationsControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoanSyndicationsControllerApi(String basePath)
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
        /// Initializes a new instance of the <see cref="LoanSyndicationsControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoanSyndicationsControllerApi(LoanStreet.LoanServicing.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="LoanSyndicationsControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LoanSyndicationsControllerApi(LoanStreet.LoanServicing.Client.ISynchronousClient client,LoanStreet.LoanServicing.Client.IAsynchronousClient asyncClient, LoanStreet.LoanServicing.Client.IReadableConfiguration configuration)
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
        /// <param name="loanId"></param>
        /// <param name="sale"> (optional)</param>
        /// <returns>Sale</returns>
        public Sale CreateSyndication (string loanId, Sale sale = default(Sale))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Sale> localVarResponse = CreateSyndicationWithHttpInfo(loanId, sale);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="sale"> (optional)</param>
        /// <returns>ApiResponse of Sale</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< Sale > CreateSyndicationWithHttpInfo (string loanId, Sale sale = default(Sale))
        {
            // verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'loanId' when calling LoanSyndicationsControllerApi->CreateSyndication");

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

            if (loanId != null)
                localVarRequestOptions.PathParameters.Add("loanId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(loanId)); // path parameter
            localVarRequestOptions.Data = sale;


            // make the HTTP request
            var localVarResponse = this.Client.Post< Sale >("/v1/private/loans/{loanId}/syndications", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateSyndication", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="sale"> (optional)</param>
        /// <returns>Task of Sale</returns>
        public async System.Threading.Tasks.Task<Sale> CreateSyndicationAsync (string loanId, Sale sale = default(Sale))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Sale> localVarResponse = await CreateSyndicationAsyncWithHttpInfo(loanId, sale);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="sale"> (optional)</param>
        /// <returns>Task of ApiResponse (Sale)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<Sale>> CreateSyndicationAsyncWithHttpInfo (string loanId, Sale sale = default(Sale))
        {
            // verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'loanId' when calling LoanSyndicationsControllerApi->CreateSyndication");


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
            
            if (loanId != null)
                localVarRequestOptions.PathParameters.Add("loanId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(loanId)); // path parameter
            localVarRequestOptions.Data = sale;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Sale>("/v1/private/loans/{loanId}/syndications", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateSyndication", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
