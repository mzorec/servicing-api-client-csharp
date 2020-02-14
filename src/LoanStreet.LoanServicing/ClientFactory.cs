using System;
using System.Security.Authentication;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace LoanStreet.LoanServicing
{
    /// <summary>
    ///     Loan Servicing API Client Factory.  This class encapsulates Authentication and access
    ///     to the Loan Servicing API
    /// </summary>
    public class ClientFactory
    {
        private const string AuthScheme = "bearer-token";
        private const string BearerPrefix = "Bearer";
        private const string AuthorizationHeader = "Authorization";

        /// <summary>
        ///     Root URL of the Loan Servicing API Instance
        /// </summary>
        public static string BasePath = "https://api.loan-street.com:8443";

        private static string Username = "";
        private static string Password = "";
        private static string BearerToken;
        
        private static bool AuthenticateUser()
        {
            BearerToken = null;

            if (string.IsNullOrEmpty(Username)) throw new AuthenticationException("Username must be provided!");

            if (string.IsNullOrEmpty(Password)) throw new AuthenticationException("Password must be provided!");

            try
            {
                var controller = new AuthorizationApi();

                var request = new PasswordAuthRequest(Username, Password);

                var response = controller.Token(request);

                BearerToken = response.Token;

                Console.WriteLine("Authenticated!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to authenticate!");
                Console.WriteLine(e);
                throw e;
            }

            return true;
        }

        private static void RequireBearerToken()
        {
            if (string.IsNullOrEmpty(BearerToken))
                throw new AuthenticationException("Failed to Authenticate the client!");
        }

        private static Configuration GetConfig()
        {
            if (string.IsNullOrEmpty(BearerToken)) AuthenticateUser();

            RequireBearerToken();

            var config = new Configuration();

            /*
             * The generated ApiClient still does not understand the use of the Bearer token,
             * it's trying to use Basic Auth.  This workaround exists to explicitly set the Authorization
             * header
             */
            config.AddApiKey(AuthScheme, BearerToken);
            config.AddApiKeyPrefix(AuthScheme, BearerPrefix);
            config.DefaultHeaders[AuthorizationHeader] = config.GetApiKeyWithPrefix(AuthScheme);

            return config;
        }

        /// <summary>
        ///     Sets Credentials for Authenticating with the Loan Servicing API
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        public static void SetCredentials(string username, string password)
        {
            Authenticate(username, password);
        }

        /// <summary>
        ///     Set credentials and authenticate with the Loan Servicing API.  This method is provided
        ///     for testing convenience, and does not need to be explicitly invoked.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public static bool Authenticate(string username, string password)
        {
            Username = username;
            Password = password;
            BearerToken = null;

            return AuthenticateUser();
        }

        private static T CreateClient<T>(Func<Configuration, T> ctor)
        {
            RequireBearerToken();

            return ctor(GetConfig());
        }
        
        public static FacilitiesApi GetFacilityiesController() => CreateClient(c => new FacilitiesApi(c));

        public static FinanceApi GetFinanceController() => CreateClient(c => new FinanceApi(c));

        public static TranchesApi GetTranchesController() => CreateClient(c => new TranchesApi(c));

        public static UsersApi GetUsersController() => CreateClient(c => new UsersApi(c));
        
        public static BorrowingsApi GetBorrowingsApi()
        {
            return CreateClient(c => new BorrowingsApi(c));
        }

        public static InstitutionsApi GetInstitutionsController()
        {
            return CreateClient(c => new InstitutionsApi(c));
        }

        public static InvoicesApi GetInvoicesController()
        {
            return CreateClient(c => new InvoicesApi(c));
        }

        public static PaymentsApi GetPaymentsController()
        {
            return CreateClient(c => new PaymentsApi(c));
        }
    }
}