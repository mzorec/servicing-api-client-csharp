using System;
using System.Collections.Generic;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;


namespace LoanStreet.LoanServicing.Examples
{
    public class ClientFactory
    {
        public static string BasePath = "https://api.loan-street.com:8443";
        public static string Token = "";
        
        public static LoanStreet.LoanServicing.Client.Configuration GetConfig()
        {
            var defaultHeaders = new Dictionary<string, string>();

            defaultHeaders["Authorization"] = $"Bearer {ClientFactory.Token}";

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
            return new InstitutionsControllerApi(ClientFactory.GetConfig());
        }

        public static LoansControllerApi GetLoansControllerApi()
        {
            return new LoansControllerApi(ClientFactory.GetConfig());
        }
    }
}