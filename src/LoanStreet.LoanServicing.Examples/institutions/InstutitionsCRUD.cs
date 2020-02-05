using System;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;
using Xunit;

namespace LoanStreet.LoanServicing.Examples.institutions
{
    public class InstutitionsCRUD
    {

        public InstutitionsCRUD()
        {
            ClientFactory.SetBearerToken("YourToken");
        }
        
        public static T Execute<T>(Func<InstitutionsControllerApi, T> toExecute)
        {
            try
            {
                var controller = ClientFactory.GetInstitutionsControllerApi();

                var created = toExecute(controller);
                return created;
            }
            catch (ApiException ae)
            {
                Console.WriteLine(ae);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
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
                address
            );
            
            
        }

    
        
        [Fact]
        public void ListInstitutions()
        {
            var allInstitutions = Execute(api => api.FetchAll());
            Assert.NotNull(allInstitutions);
        }

        [Fact]
        public void CreateInstitution()
        {

            var institution = GetTestInstitution();

            var createdInstitution = Execute(api => api.Create(institution));
            
            Assert.NotNull(createdInstitution);
        }


        [Fact]
        public void GetInstitution()
        {

            var createdInstitution = Execute(api => api.Create(GetTestInstitution()));
            
            Assert.NotNull(createdInstitution);

            var loadedById = Execute(api => api.Fetch(createdInstitution.InstitutionId));
            
            Assert.NotNull(loadedById);
        }
        
    }
}