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
    public interface ILoansApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loan"> (optional)</param>
        /// <returns>Object</returns>
        Object CreateLoan (Loan loan = default(Loan));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loan"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> CreateLoanWithHttpInfo (Loan loan = default(Loan));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="facilityId"></param>
        /// <returns>Loan</returns>
        Loan GetLoan (string facilityId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="facilityId"></param>
        /// <returns>ApiResponse of Loan</returns>
        ApiResponse<Loan> GetLoanWithHttpInfo (string facilityId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoansApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loan"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> CreateLoanAsync (Loan loan = default(Loan));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loan"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateLoanAsyncWithHttpInfo (Loan loan = default(Loan));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="facilityId"></param>
        /// <returns>Task of Loan</returns>
        System.Threading.Tasks.Task<Loan> GetLoanAsync (string facilityId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="facilityId"></param>
        /// <returns>Task of ApiResponse (Loan)</returns>
        System.Threading.Tasks.Task<ApiResponse<Loan>> GetLoanAsyncWithHttpInfo (string facilityId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoansApi : ILoansApiSync, ILoansApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LoansApi : ILoansApi
    {
        private LoanStreet.LoanServicing.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoansApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoansApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoansApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoansApi(String basePath)
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
        /// Initializes a new instance of the <see cref="LoansApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoansApi(LoanStreet.LoanServicing.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="LoansApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LoansApi(LoanStreet.LoanServicing.Client.ISynchronousClient client,LoanStreet.LoanServicing.Client.IAsynchronousClient asyncClient, LoanStreet.LoanServicing.Client.IReadableConfiguration configuration)
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
        /// <param name="loan"> (optional)</param>
        /// <returns>Object</returns>
        public Object CreateLoan (Loan loan = default(Loan))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Object> localVarResponse = CreateLoanWithHttpInfo(loan);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loan"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< Object > CreateLoanWithHttpInfo (Loan loan = default(Loan))
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

            localVarRequestOptions.Data = loan;

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< Object >("/v1/private/loans", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateLoan", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loan"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> CreateLoanAsync (Loan loan = default(Loan))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Object> localVarResponse = await CreateLoanAsyncWithHttpInfo(loan);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loan"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<Object>> CreateLoanAsyncWithHttpInfo (Loan loan = default(Loan))
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
            
            localVarRequestOptions.Data = loan;

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/v1/private/loans", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateLoan", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="facilityId"></param>
        /// <returns>Loan</returns>
        public Loan GetLoan (string facilityId)
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Loan> localVarResponse = GetLoanWithHttpInfo(facilityId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="facilityId"></param>
        /// <returns>ApiResponse of Loan</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< Loan > GetLoanWithHttpInfo (string facilityId)
        {
            // verify the required parameter 'facilityId' is set
            if (facilityId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'facilityId' when calling LoansApi->GetLoan");

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

            if (facilityId != null)
                localVarRequestOptions.PathParameters.Add("facilityId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(facilityId)); // path parameter

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< Loan >("/v1/private/loans/{facilityId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLoan", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="facilityId"></param>
        /// <returns>Task of Loan</returns>
        public async System.Threading.Tasks.Task<Loan> GetLoanAsync (string facilityId)
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Loan> localVarResponse = await GetLoanAsyncWithHttpInfo(facilityId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="facilityId"></param>
        /// <returns>Task of ApiResponse (Loan)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<Loan>> GetLoanAsyncWithHttpInfo (string facilityId)
        {
            // verify the required parameter 'facilityId' is set
            if (facilityId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'facilityId' when calling LoansApi->GetLoan");


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
            
            if (facilityId != null)
                localVarRequestOptions.PathParameters.Add("facilityId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(facilityId)); // path parameter

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Loan>("/v1/private/loans/{facilityId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLoan", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
