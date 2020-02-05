using System;
using System.Collections.Generic;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Examples.institutions;
using LoanStreet.LoanServicing.Model;
using Xunit;

namespace LoanStreet.LoanServicing.Examples
{
    public class LoansCRUD
    {
        
        public LoansCRUD()
        {
            ClientFactory.SetBearerToken("YourToken");
        }

        
        protected T Execute<T>(Func<LoansControllerApi, T> todo)
        {
            var controller = ClientFactory.GetLoansControllerApi();
            var created = todo(controller);
            return created;
        }

        private Institution getInstitution()
        {
            var toCreate = InstutitionsCRUD.GetTestInstitution();
            var created = InstutitionsCRUD.Execute(api => api.Create(toCreate));
            Assert.NotNull(created);
            return created;
        }
        
        private Loan GetTestLoanTerms()
        {
            var lender = getInstitution();
            var borrower = getInstitution();
            
            var paymentAmount = new Money("54251.32", "USD");
            var firstPaymentDate = new DateTime(2019, 2, 1);
            var principal = new Money("10400000", "USD");
            
            var permissions = new Dictionary<string, Loan.InnerEnum>()
            {
                {lender.InstitutionId, Loan.InnerEnum.LENDER },
                {borrower.InstitutionId, Loan.InnerEnum.BORROWER}
            };
            
            var terms = new FixedPaymentInterestTerms(
                paymentAmount: paymentAmount,    
                effectiveDate: new DateTime(2019, 1, 1),
                annualRate:"0.0475",
                dayCount: InterestTerms.DayCountEnum.ACTUAL360,
                compounding: InterestTerms.CompoundingEnum.Simple,
                benchmark: null,
                interestType: InterestTerms.InterestTypeEnum.FIXEDPAYMENT,
                numAmortizationPeriods: 360,
                numInterestOnlyPeriods: 0,
                numPeriods: 360,
                paymentFrequency: InterestTerms.PaymentFrequencyEnum.MONTHLY
            );
            
            
            var loan = new Loan(
                firstPaymentDate: firstPaymentDate,
                interestTerms: terms,
                permissions: permissions,
                principalAmount: principal,
                maxParticipationPercent: "0.9",
                name: new Guid().ToString(),
                timeZoneId: "America/New_York"
            );

            return loan;
        }

        [Fact]
        public void OriginateLoan()
        {

            var toOriginate = GetTestLoanTerms();

            var originated = Execute(api => api.CreateLoan(toOriginate));
            
            Assert.NotNull(originated);
        }
        
        
        [Fact]
        public void ListLoans()
        {
            var res = Execute((api => api.ListLoans()));
            
            Assert.NotNull(res);
            Assert.NotEmpty(res);
            
        }
        
    }
}