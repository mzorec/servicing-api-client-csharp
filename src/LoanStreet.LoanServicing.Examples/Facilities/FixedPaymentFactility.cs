using System;
using System.Collections.Generic;
using System.Linq;
using LoanStreet.LoanServicing.Model;
using Xunit;


namespace LoanStreet.LoanServicing.Examples.Facilities
{
    public class FixedPaymentFactility : TestBase
    {
        public static Facility GetFacilityInstance()
        {
            SingleDrawRules drawRules = new SingleDrawRules(
                commitment: new Money(amount: "10400000", currency: "USD"),
                effectiveDate: new DateTime(2019, 1, 1),
                type: "SINGLE_DRAW"
            );

            FixedPaymentInterestRules interestRules = new FixedPaymentInterestRules(
                annualRate: 0.0475d,
                compounding: FixedPaymentInterestRules.CompoundingEnum.SIMPLE,
                dayCount: FixedPaymentInterestRules.DayCountEnum.ACTUAL360,
                numPeriods: 360,
                paymentFrequency: FixedPaymentInterestRules.PaymentFrequencyEnum.MONTHLY,
                paymentAmount: new Money(amount: "54251.32", currency: "USD"),
                effectiveDate: new DateTime(2019, 1, 1),
                type: "FIXED_PAYMENT"
            );

            Tranche tranche = new Tranche(
                name: "Tranche A",
                draw: drawRules,
                interest: interestRules
            );

            Facility res = new Facility(
                name: Guid.NewGuid().ToString(),
                timeZoneId: "America/New_York",
                institutions: new List<FacilityInstitutionDto>(),
                tranches: new List<Tranche>()
                {
                    tranche
                },
                borrowings: new List<Borrowing>()
            );

            return res;
        }


        public Facility CreateFacility(Facility toCreate)
        {
            /*
             * Create a Facility, including a Tranche
             */

            var client = ClientFactory.GetFacilityiesController();

            Facility created = client.CreateFacility(toCreate);

            return created;
        }


        public Borrowing CreateDraw(string facilityId, Money drawAmount)
        {
            var client = ClientFactory.GetTranchesController();

            List<Tranche> tranches = client.ListTranches(facilityId);

            // Get the tranche that we will draw against
            var trancheId = tranches.First().TrancheId;

            // Create the Draw Instance
            var draw = new Draw(
                dated: new DateTime(2019, 1, 2),
                firstPaymentDate: new DateTime(2019, 2, 1),
                amount: drawAmount
            );

            // Inform the API that we are Drawing against the tranche, resulting in a Borrowing
            Borrowing borrowing = client.CreateDraw(
                facilityId: facilityId,
                trancheId: trancheId,
                draw: draw
            );

            return borrowing;
        }


        [Fact]
        public void FixedPaymemntFacilityExample()
        {
            // 1) Set Credentials
            // ClientFactory.SetCredentials("YourUsername", "YourPassword");

            // 2) Get the Fixed Payment Facility instance
            var facility = GetFacilityInstance();

            // 3) Inform the API we wish to create a Facility
            facility = CreateFacility(facility);

            // Assert that creation was successful
            Assert.NotNull(facility);
            
            // 4) Create a Draw, resulting in a Borrowing (Loan)
            Money drawAmount = new Money(amount: "10400000.00", currency: "USD");

            var borrowing = CreateDraw(facility.FacilityId, drawAmount);

            // Assert that we received a borrowing
            Assert.NotNull(borrowing);
            Assert.Equal(borrowing.Principal.Amount, drawAmount.Amount);
        }
    }
}