using System;
using System.Collections.Generic;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;
using System;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;
using Xunit;

namespace LoanStreet.LoanServicing.Examples
{
    public class LoansCRUD
    {
        protected T Execute<T>(Func<LoansControllerApi, T> todo)
        {
            try
            {
                var controller = ClientFactory.GetLoansControllerApi();

                var created = todo(controller);
                return created;
            }
            catch (ApiException ae)
            {
                Console.WriteLine("Likely Business Logic Error");
                Console.WriteLine(ae);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        [Fact]
        public List<Loan> ListLoans()
        {
            var res = Execute((api => api.ListLoans()));
            return res;
        }
        
    }
}