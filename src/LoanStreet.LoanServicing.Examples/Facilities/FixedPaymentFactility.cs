using System;
using System.Collections.Generic;
using LoanStreet.LoanServicing.Model;
using Xunit;


namespace LoanStreet.LoanServicing.Examples.Facilities
{
    public class FixedPaymentFactility
    {


        public static Facility GetFacilityInstance()
        {
            var tranche = new Tranche(
                name: "Tranche A",
                draw: new SingleDrawRules(
                    commitment: new Money("10400000"),
                    date: new DateTime(2019, 1, 1)
                ),
                interest: new FixedPaymentInterestRules(
                    annualRate: 0.0475d,
                    compounding: FixedPaymentInterestRules.CompoundingEnum.SIMPLE,
                    dayCount: FixedPaymentInterestRules.DayCountEnum.ACTUAL360,
                    numPayments: 360,
                    paymentFrequency: FixedPaymentInterestRules.PaymentFrequencyEnum.MONTHLY,
                    date: new DateTime(2019, 1, 1)
                ));
            
            var res = new Facility(
                name: Guid.NewGuid().ToString(),
                timeZoneId: "America/New_York",
                institutions: new List<FacilityInstitutionDto>(),
                tranches: new List<Tranche>(),
                borrowings: new List<Borrowing>()
            );

            return res;
        }

        public Facility CreateFacility(Facility toCreate)
        {
            var client = ClientFactory.GetFacilitiesController();

            var response = client.CreateFacility(toCreate);

            return response;
        }

        [Fact]
        public void OriginateFacility()
        {
            var toOriginate = GetFacilityInstance();

            var created = CreateFacility(toOriginate);
            
            Assert.NotNull(created);
        }
    }
}