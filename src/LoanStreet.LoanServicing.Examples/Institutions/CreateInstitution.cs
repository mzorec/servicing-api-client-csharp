using System;
using System.Collections.Generic;
using LoanStreet.LoanServicing.Model;
using Xunit;

namespace LoanStreet.LoanServicing.Examples.Institutions
{
    public class CreateInstitution : TestBase
    {
        public static Institution GetTestInstitution()
        {
            var name = Guid.NewGuid().ToString();
            var ticker = name.Substring(0, 5);
            var address = new Address(
                "West 30th Street",
                "8th Floor",
                "New York",
                "NY",
                "10025"
            );
            return new Institution(
                name,
                ticker,
                address,
                new List<Fund>()
            );
        }


        public static Institution CreateAnInstitution()
        {
            // 1) Instantiate an Institution
            var name = Guid.NewGuid().ToString();
            var ticker = name.Substring(0, 5);
            var address = new Address(
                "West 30th Street",
                "8th Floor",
                "New York",
                "NY",
                "10025"
            );
            var pending = new Institution(
                name,
                ticker,
                address,
                new List<Fund>()
            );

            var client = ClientFactory.GetInstitutionsController();

            var institution = client.CreateInstitution(pending);

            return institution;
        }

        [Fact]
        public void CreateInstitutionExample()
        {
            // 1) Set Credentials.  You will need to uncomment and set the following line
            // ClientFactory.SetCredentials("YourUser", "YourPassword")

            // 2) Create an Institution Model Instance
            var institution = GetTestInstitution();

            // 3) Get the Institutions Client
            var client = ClientFactory.GetInstitutionsController();

            // 4) Send the Institution model to the Servicing API!

            var createdInstitution = client.CreateInstitution(institution);

            // 5) The API will respond with an instance of the institution it created.  This instance will have
            //     a populated `institutionId` property, this is the unique identifier the Servicing system has
            //     assign to the Institution.
            //
            //     When creating or updating, we should always use the instance returned by the client, rather
            //     than the instance we sent to the API 
            //    
            //    Strictly for testing purposes, verify that we received a response
            Assert.NotNull(createdInstitution);
        }

        [Fact(Skip = "Pending Permissions Correction")]
        public void GetInstitution()
        {
            // 1) Set Credentials.  You will need to uncomment and set the following line
            // ClientFactory.SetCredentials("YourUser", "YourPassword");

            // 2) Get the institutions client
            var client = ClientFactory.GetInstitutionsController();

            // 3) Load Your User's Institution
            var loadedById = client.GetInstitution(Context.institutionId);

            // 5) Strictly for testing purposes, load the institution by id
            Assert.NotNull(loadedById);
        }


        [Fact]
        public void ListInstitutions()
        {
            // 1) Set Credentials.  You will need to uncomment and set the following line
            // ClientFactory.SetCredentials("YourUser", "YourPassword");

            // 2) Get the Institutions client
            var client = ClientFactory.GetInstitutionsController();

            // 3) List institutions my user is permitted to view
            var allInstitutions = client.ListInstitutions();

            // 4) Strictly for testing purposes, assert that we received a response.
            Assert.NotNull(allInstitutions);
        }
    }
}