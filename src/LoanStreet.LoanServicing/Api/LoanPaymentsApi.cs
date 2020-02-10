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
    public interface ILoanPaymentsApiSync : IApiAccessor
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
        /// <param name="payment"> (optional)</param>
        /// <returns>Payment</returns>
        Payment CreatePayment (string loanId, Payment payment = default(Payment));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="payment"> (optional)</param>
        /// <returns>ApiResponse of Payment</returns>
        ApiResponse<Payment> CreatePaymentWithHttpInfo (string loanId, Payment payment = default(Payment));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="paymentId"></param>
        /// <returns>Payment</returns>
        Payment GetPayment (string loanId, string paymentId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="paymentId"></param>
        /// <returns>ApiResponse of Payment</returns>
        ApiResponse<Payment> GetPaymentWithHttpInfo (string loanId, string paymentId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <returns>List&lt;Payment&gt;</returns>
        List<Payment> ListPayments (string loanId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <returns>ApiResponse of List&lt;Payment&gt;</returns>
        ApiResponse<List<Payment>> ListPaymentsWithHttpInfo (string loanId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoanPaymentsApiAsync : IApiAccessor
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
        /// <param name="payment"> (optional)</param>
        /// <returns>Task of Payment</returns>
        System.Threading.Tasks.Task<Payment> CreatePaymentAsync (string loanId, Payment payment = default(Payment));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="payment"> (optional)</param>
        /// <returns>Task of ApiResponse (Payment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Payment>> CreatePaymentAsyncWithHttpInfo (string loanId, Payment payment = default(Payment));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="paymentId"></param>
        /// <returns>Task of Payment</returns>
        System.Threading.Tasks.Task<Payment> GetPaymentAsync (string loanId, string paymentId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="paymentId"></param>
        /// <returns>Task of ApiResponse (Payment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Payment>> GetPaymentAsyncWithHttpInfo (string loanId, string paymentId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <returns>Task of List&lt;Payment&gt;</returns>
        System.Threading.Tasks.Task<List<Payment>> ListPaymentsAsync (string loanId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <returns>Task of ApiResponse (List&lt;Payment&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Payment>>> ListPaymentsAsyncWithHttpInfo (string loanId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoanPaymentsApi : ILoanPaymentsApiSync, ILoanPaymentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LoanPaymentsApi : ILoanPaymentsApi
    {
        private LoanStreet.LoanServicing.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanPaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoanPaymentsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanPaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoanPaymentsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="LoanPaymentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoanPaymentsApi(LoanStreet.LoanServicing.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="LoanPaymentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LoanPaymentsApi(LoanStreet.LoanServicing.Client.ISynchronousClient client,LoanStreet.LoanServicing.Client.IAsynchronousClient asyncClient, LoanStreet.LoanServicing.Client.IReadableConfiguration configuration)
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
        /// <param name="payment"> (optional)</param>
        /// <returns>Payment</returns>
        public Payment CreatePayment (string loanId, Payment payment = default(Payment))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Payment> localVarResponse = CreatePaymentWithHttpInfo(loanId, payment);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="payment"> (optional)</param>
        /// <returns>ApiResponse of Payment</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< Payment > CreatePaymentWithHttpInfo (string loanId, Payment payment = default(Payment))
        {
            // verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'loanId' when calling LoanPaymentsApi->CreatePayment");

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
            localVarRequestOptions.Data = payment;

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< Payment >("/v1/private/loans/{loanId}/payments", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePayment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="payment"> (optional)</param>
        /// <returns>Task of Payment</returns>
        public async System.Threading.Tasks.Task<Payment> CreatePaymentAsync (string loanId, Payment payment = default(Payment))
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Payment> localVarResponse = await CreatePaymentAsyncWithHttpInfo(loanId, payment);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="payment"> (optional)</param>
        /// <returns>Task of ApiResponse (Payment)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<Payment>> CreatePaymentAsyncWithHttpInfo (string loanId, Payment payment = default(Payment))
        {
            // verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'loanId' when calling LoanPaymentsApi->CreatePayment");


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
            localVarRequestOptions.Data = payment;

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Payment>("/v1/private/loans/{loanId}/payments", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePayment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="paymentId"></param>
        /// <returns>Payment</returns>
        public Payment GetPayment (string loanId, string paymentId)
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Payment> localVarResponse = GetPaymentWithHttpInfo(loanId, paymentId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="paymentId"></param>
        /// <returns>ApiResponse of Payment</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< Payment > GetPaymentWithHttpInfo (string loanId, string paymentId)
        {
            // verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'loanId' when calling LoanPaymentsApi->GetPayment");

            // verify the required parameter 'paymentId' is set
            if (paymentId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'paymentId' when calling LoanPaymentsApi->GetPayment");

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

            if (loanId != null)
                localVarRequestOptions.PathParameters.Add("loanId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(loanId)); // path parameter
            if (paymentId != null)
                localVarRequestOptions.PathParameters.Add("paymentId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(paymentId)); // path parameter

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< Payment >("/v1/private/loans/{loanId}/payments/{paymentId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPayment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="paymentId"></param>
        /// <returns>Task of Payment</returns>
        public async System.Threading.Tasks.Task<Payment> GetPaymentAsync (string loanId, string paymentId)
        {
             LoanStreet.LoanServicing.Client.ApiResponse<Payment> localVarResponse = await GetPaymentAsyncWithHttpInfo(loanId, paymentId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <param name="paymentId"></param>
        /// <returns>Task of ApiResponse (Payment)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<Payment>> GetPaymentAsyncWithHttpInfo (string loanId, string paymentId)
        {
            // verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'loanId' when calling LoanPaymentsApi->GetPayment");

            // verify the required parameter 'paymentId' is set
            if (paymentId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'paymentId' when calling LoanPaymentsApi->GetPayment");


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
            
            if (loanId != null)
                localVarRequestOptions.PathParameters.Add("loanId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(loanId)); // path parameter
            if (paymentId != null)
                localVarRequestOptions.PathParameters.Add("paymentId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(paymentId)); // path parameter

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Payment>("/v1/private/loans/{loanId}/payments/{paymentId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPayment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <returns>List&lt;Payment&gt;</returns>
        public List<Payment> ListPayments (string loanId)
        {
             LoanStreet.LoanServicing.Client.ApiResponse<List<Payment>> localVarResponse = ListPaymentsWithHttpInfo(loanId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <returns>ApiResponse of List&lt;Payment&gt;</returns>
        public LoanStreet.LoanServicing.Client.ApiResponse< List<Payment> > ListPaymentsWithHttpInfo (string loanId)
        {
            // verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'loanId' when calling LoanPaymentsApi->ListPayments");

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

            if (loanId != null)
                localVarRequestOptions.PathParameters.Add("loanId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(loanId)); // path parameter

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< List<Payment> >("/v1/private/loans/{loanId}/payments", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPayments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <returns>Task of List&lt;Payment&gt;</returns>
        public async System.Threading.Tasks.Task<List<Payment>> ListPaymentsAsync (string loanId)
        {
             LoanStreet.LoanServicing.Client.ApiResponse<List<Payment>> localVarResponse = await ListPaymentsAsyncWithHttpInfo(loanId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="LoanStreet.LoanServicing.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId"></param>
        /// <returns>Task of ApiResponse (List&lt;Payment&gt;)</returns>
        public async System.Threading.Tasks.Task<LoanStreet.LoanServicing.Client.ApiResponse<List<Payment>>> ListPaymentsAsyncWithHttpInfo (string loanId)
        {
            // verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new LoanStreet.LoanServicing.Client.ApiException(400, "Missing required parameter 'loanId' when calling LoanPaymentsApi->ListPayments");


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
            
            if (loanId != null)
                localVarRequestOptions.PathParameters.Add("loanId", LoanStreet.LoanServicing.Client.ClientUtils.ParameterToString(loanId)); // path parameter

            // authentication (bearer-token) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + LoanStreet.LoanServicing.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Payment>>("/v1/private/loans/{loanId}/payments", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPayments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
