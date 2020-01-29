using System;
using System.Collections.Generic;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;
using System.Threading.Tasks;

namespace LoanStreet.LoanServicing.Examples
{
    public class InstutitionsExample
    {
        protected T Execute<T>(Func<InstitutionsControllerApi, T> toExecute)
        {
            // Generic Institutions Controller execution method
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
        
        
        public Institution CreateInstitution()
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
            var pending = new Institution(
                name,
                ticker,
                address
            );

            try
            {
                var controller = ClientFactory.GetInstitutionsControllerApi();

                var created = controller.Create(pending);
                return created;
            }
            catch (ApiException ae)
            {
                Console.WriteLine(ae);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("General Failure");
                Console.WriteLine(e);
                throw;
            }
            
        }


        public Institution GetInstitution(string institutionId)
        {
            var institution = Execute((api => api.Fetch(institutionId)));

            return institution;
        }

        public List<Institution> ListInstitutions()
        {
            var controller = ClientFactory.GetInstitutionsControllerApi();

            var all = controller.FetchAll();

            return all;
        }
        
        
    }
}