using System;
using System.Linq;
using LoanStreet.LoanServicing.Model;
using Xunit;

namespace LoanStreet.LoanServicing.Examples.FixedPaymentFacility
{
    public class Originate : TestBase
    {
        public static Facility CreateFacility(Facility toCreate)
        {
            /*
             * Notify the API that we wish to create the provided Facility
             */

            // Get the client
            var client = ClientFactory.GetFacilityiesController();

            // Create and Get the Faciity
            var created = client.CreateFacility(toCreate);

            return created;
        }


        public static Borrowing CreateDraw(string facilityId, Money drawAmount)
        {
            /*
             * Perform a Draw against facility for the proivided amount
             */

            // Load our Facility's Tranche
            var tranchesController = ClientFactory.GetTranchesController();

            var tranches = tranchesController.ListTranches(facilityId);

            // Get the trancheId that we will draw against
            var trancheId = tranches.First().TrancheId;

            // Create the Draw Instance
            var draw = FixedPaymentExampleData.GetSampleDraw(drawAmount);

            // Inform the API that we are Drawing against the tranche, resulting in a Borrowing
            var borrowing = tranchesController.CreateDraw(
                facilityId,
                trancheId,
                draw
            );

            // Our Borrowing Principal matches the DrawAmount
            Assert.Equal(borrowing.Principal.ToDecimal(), drawAmount.ToDecimal());

            return borrowing;
        }

        public static Tuple<string, string> OriginateExample()
        {
            // 1) Set Credentials
            // ClientFactory.SetCredentials("YourUsername", "YourPassword");

            // 2) Get the Fixed Payment Facility instance
            var facility = FixedPaymentExampleData.GetSampleFacility();

            // 3) Inform the API we wish to create a Facility
            facility = CreateFacility(facility);

            // Assert that creation was successful
            Assert.NotNull(facility);

            // 4) Create a Draw, resulting in a Borrowing (Loan)
            var drawAmount = FixedPaymentExampleData.CommitmentAmount;

            var borrowing = CreateDraw(facility.FacilityId, drawAmount);

            // Assert that we received a borrowing
            Assert.NotNull(borrowing);

            return new Tuple<string, string>(facility.FacilityId, borrowing.BorrowingId);
        }

        [Fact]
        public void RunOriginateExample()
        {
            OriginateExample();
        }
    }
}