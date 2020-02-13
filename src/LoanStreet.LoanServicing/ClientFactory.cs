using System;
using System.Collections.Generic;
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
        /// <summary>
        ///     Root URL of the Loan Servicing API Instance
        /// </summary>
        public static string BasePath = "https://api-staging.loan-street.com:8443";

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

            var defaultHeaders = new Dictionary<string, string>();

            defaultHeaders["Authorization"] = $"Bearer {BearerToken}";

            var config = new Configuration(
                defaultHeaders,
                new Dictionary<string, string>(),
                new Dictionary<string, string>(),
                BasePath
            );

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


        /// <summary>
        ///     Get an instance of the Institutions Client
        /// </summary>
        /// <returns>InstitutionsControllerApi</returns>
        public static InstitutionsControllerApi GetInstitutionsController()
        {
            RequireBearerToken();

            return new InstitutionsControllerApi(GetConfig());
        }

        /// <summary>
        ///     Get an instance of the Loans Client
        /// </summary>
        /// <returns>LoansControllerApi</returns>
        public static LoansControllerApi GetLoansController()
        {
            RequireBearerToken();

            return new LoansControllerApi(GetConfig());
        }


        /// <summary>
        ///     Get an instance of the Deals Client
        /// </summary>
        /// <returns>DealsControllerApi</returns>
        public static DealsControllerApi GetDealsController()
        {
            RequireBearerToken();

            return new DealsControllerApi(GetConfig());
        }
    }
}