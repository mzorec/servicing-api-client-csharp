using System;
using System.Collections.Generic;
using LoanStreet.LoanServicing.Model;

namespace LoanStreet.LoanServicing.Examples.FixedPaymentFacility
{
    /// <summary>
    ///     Sample Data used to construct a Fixed Payment Single Draw Facility
    /// </summary>
    public static class FixedPaymentExampleData
    {
        public static readonly double InterestRate = 0.04375d;
        public static readonly Money FixedPaymentAmount = new Money("36437.56", "USD");
        public static readonly Money CommitmentAmount = new Money("7300000.00", "USD");
        public static readonly DateTime OriginationDate = new DateTime(2019, 9, 3);
        public static DateTime FirstInvoiceDueDate = new DateTime(2019, 10, 1);
        public static DateTime FacilityMaturityDate = new DateTime(2024, 9, 1);

        public static readonly FixedPaymentInterestRules.DayCountEnum DayCount =
            FixedPaymentInterestRules.DayCountEnum.ACTUAL365;

        /// <summary>
        ///     Generate a new instance of a Fixed Payment Facility.  This instance will need to
        ///     be sent to the API
        /// </summary>
        /// <returns>Facility</returns>
        public static Facility GetSampleFacility()
        {
            // Create Single Draw Rules
            var drawRules = new SingleDrawRules(
                CommitmentAmount,
                OriginationDate,
                "SINGLE_DRAW"
            );

            // Create Interest Rules
            var interestRules = new FixedPaymentInterestRules(
                InterestRate,
                FixedPaymentInterestRules.CompoundingEnum.SIMPLE,
                DayCount,
                60,
                paymentFrequency: FixedPaymentInterestRules.PaymentFrequencyEnum.MONTHLY,
                paymentAmount: FixedPaymentAmount,
                effectiveDate: OriginationDate,
                type: "FIXED_PAYMENT"
            );

            // Create a Single Draw, Fixed Payment Tranche
            var tranche = new Tranche(
                "Tranche A",
                drawRules,
                interestRules
            );

            // Create the Facility Instance
            var res = new Facility(
                Guid.NewGuid().ToString(),
                "America/New_York",
                new List<FacilityInstitutionDto>(),
                new List<Tranche>
                {
                    tranche
                },
                new List<Borrowing>()
            );

            // API-Ready Facility instance, this will need to be sent to the API
            return res;
        }

        /// <summary>
        ///     Create a Draw for the specified amount
        /// </summary>
        public static Draw GetSampleDraw(Money drawAmount)
        {
            return new Draw(
                OriginationDate,
                FirstInvoiceDueDate,
                drawAmount
            );
        }
    }
}