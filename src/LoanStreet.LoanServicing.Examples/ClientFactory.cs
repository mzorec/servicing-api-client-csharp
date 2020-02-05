using System;
using System.Collections.Generic;
using System.Security.Authentication;
using LoanStreet.LoanServicing.Api;

namespace LoanStreet.LoanServicing.Examples
{
    public class ClientFactory
    {
        public static string BasePath = "https://api.loan-street.com:8443";
        private static string BearerToken = "";

        
        public static void SetBearerToken(string bearerToken)
        {
            BearerToken = bearerToken;
        }

   
        
        private static void RequireBearerToken()
        {
           
            
            if (String.IsNullOrEmpty(ClientFactory.BearerToken))
            {
                throw new AuthenticationException("Bearer Token not provided, unable to configure client!");
            }
        }
        
        public static LoanStreet.LoanServicing.Client.Configuration GetConfig()
        {
            RequireBearerToken();
            
            var defaultHeaders = new Dictionary<string, string>();

            defaultHeaders["Authorization"] = $"Bearer {ClientFactory.BearerToken}";

            var config = new LoanStreet.LoanServicing.Client.Configuration(
                defaultHeaders,
                new Dictionary<string, string>(),
                new Dictionary<string, string>(),
                ClientFactory.BasePath
            );
            return config;
        }
        
        public static InstitutionsControllerApi GetInstitutionsControllerApi()
        {
            RequireBearerToken();
            
            return new InstitutionsControllerApi(ClientFactory.GetConfig());
        }

        public static LoansControllerApi GetLoansControllerApi()
        {
            RequireBearerToken();
            
            return new LoansControllerApi(ClientFactory.GetConfig());
        }


        public static DealsControllerApi GetDealsControllerApi()
        {
            RequireBearerToken();
            
            return new DealsControllerApi(ClientFactory.GetConfig());
        }
    }
}