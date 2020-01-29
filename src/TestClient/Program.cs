using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;
using LoanStreet.LoanServicing.Examples;

namespace TestClient
{
    internal class Program
    {

        private static void SetAuth()
        {
            ClientFactory.BasePath = "https://api.loan-street.com:8443";
            ClientFactory.Token = "";
        }
        
        private static void Institutions()
        {
            SetAuth();
            
            Console.WriteLine("Start Institutions Test...");
            var instExample = new InstutitionsExample();
            
            Console.WriteLine("Create Institution");
            var created = instExample.CreateInstitution();
            Console.WriteLine($"Created {created.InstitutionId}");

            Console.WriteLine("Load Institution");
            var loaded = instExample.GetInstitution(created.InstitutionId);
            Console.WriteLine($"Loaded {loaded.InstitutionId}");
            
            Console.WriteLine("List Institutions");
            var all = instExample.ListInstitutions();
            Console.WriteLine($"Found {all.Count} Institutions");
            
            Console.WriteLine("Done");
            
        }
        
        private static void Main(string[] args)
        {
            Institutions();
            
        }
    }
}