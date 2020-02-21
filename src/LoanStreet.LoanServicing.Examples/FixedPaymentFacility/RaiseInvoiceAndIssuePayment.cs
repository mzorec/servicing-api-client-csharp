using System;
using System.Linq;
using LoanStreet.LoanServicing.Model;
using Xunit;

namespace LoanStreet.LoanServicing.Examples.FixedPaymentFacility
{
    public class RaiseInvoiceAndIssuePayment : TestBase
    {
        public static Invoice RunRaiseInvoiceAndIssuePayment()
        {
            // Create Test Facility & Borrowing
            var facilityAndBorrowingId = Originate.OriginateExample();

            var facilityId = facilityAndBorrowingId.Item1;
            var borrowingId = facilityAndBorrowingId.Item2;
            var tranche = GetTranche(facilityId);


            // Raise n Invoice for it's first Period
            var invoice = RaiseInvoice(facilityId, tranche.TrancheId, borrowingId);

            // Issue a Payment against the Tranche, this fulfilling the outstanding invoice
            IssuePayment(facilityId, tranche.TrancheId);

            return invoice;
        }

        public static Invoice RaiseInvoice(string facilityId, string trancheId, string borrowingId)
        {
            /*
             * Raise an Invoice for the first period of the Borrowing 
             *
             *    Invoice		
             *        PaymentDueDate	2019-10-01	
             *
             *    Expect
             *        Total amount	36437.56	
             *        Principal due	11937.56	
             *        Interest due	24500	 
             */

            var client = ClientFactory.GetTranchesController();

            var toCreate = new Invoice(
                FixedPaymentExampleData.FirstInvoiceDueDate,
                new LocalDatePeriod(
                    FixedPaymentExampleData.OriginationDate,
                    FixedPaymentExampleData.FirstInvoiceDueDate.AddDays(-1)
                )
            );

            var invoice = client.CreateInvoice(
                facilityId,
                trancheId,
                toCreate
            );

            Assert.NotNull(invoice);

            var invoicesController = ClientFactory.GetInvoicesController();

            invoice = invoicesController.GetInvoice(facilityId, invoice.InvoiceId);

            Assert.NotNull(invoice);

            return invoice;
        }

        public static void IssuePayment(string facilityId, string trancheId)
        {
            /*
             * Issue Payment Against Tranche
             *    PaymentAmount: 36437.56
             */

            var client = ClientFactory.GetTranchesController();

            var pendingPayment = new Payment(
                new DateTime(2019, 10, 1),
                new Money(
                    "36437.56",
                    "USD"
                )
            );

            var payment = client.CreatePayment(facilityId, trancheId, pendingPayment);

            Assert.NotNull(payment);
        }


        public static Tranche GetTranche(string facilityId)
        {
            var client = ClientFactory.GetTranchesController();

            var tranches = client.ListTranches(facilityId);

            return tranches.First();
        }

        [Fact]
        public void RaiseInvoiceAndIssuePaymentExample()
        {
            RunRaiseInvoiceAndIssuePayment();
        }
    }
}