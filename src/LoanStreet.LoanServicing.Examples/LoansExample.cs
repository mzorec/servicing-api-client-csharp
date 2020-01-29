using System;
using System.Collections.Generic;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;


namespace LoanStreet.LoanServicing.Examples
{
    public class LoansExample
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

        public Loan OriginateLoan()
        {
            var firstPaymentDate = new DateTime(2019, 2, 1);
            var principal = new Money("10400000", "USD");
            var name = "TestLoan";


            /*
            var terms = new FixedPaymentInterestTerms(
                new Money("54251.54", "USD"),
                new DateTime(2019, 1, 1),
                "0.0475",
                InterestTerms.DayCountEnum.ACTUAL360,
                InterestTerms.CompoundingEnum.Simple,
                0,
                360,
                InterestTerms.PaymentFrequencyEnum.MONTHLY,
                null,
                360,
                InterestTerms.InterestTypeEnum.FIXEDPAYMENT
            );
            */
            var terms = new FixedPaymentInterestTerms(
                new Money("54251.54", "USD"),
                new DateTime(2019, 1, 1),
                "0.0475",
                InterestTerms.DayCountEnum.ACTUAL360,
                InterestTerms.CompoundingEnum.Simple,
                null,
                InterestTerms.InterestTypeEnum.FIXEDPAYMENT,
                360,
                0,
                360,
                InterestTerms.PaymentFrequencyEnum.MONTHLY
            );
            
            var loan = new Loan(
                firstPaymentDate,
                terms,
                new Dictionary<string, Loan.InnerEnum>(),
                principal,
                "0.9",
                name,
                "America/New_York");


            var res = Execute((api => api.CreateLoan(loan)));

            return res;
        }

        public Loan GetLoan(string loanId)
        {
            var res = Execute((api => api.GetLoan(loanId)));
            return res;
        }

        public List<Loan> ListLoans()
        {
            var res = Execute((api => api.ListLoans()));
            return res;
        }
        
    }
}