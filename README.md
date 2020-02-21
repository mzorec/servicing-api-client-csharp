
# LoanStreet Loan Servicing API Client 

[![LoanStreet on Nuget](https://img.shields.io/nuget/v/LoanStreet.LoanServicing?color=419572&style=plastic)](https://www.nuget.org/packages/LoanStreet.LoanServicing/)
![.NET Core](https://github.com/loanstreet-usa/LoanServicingAPI-Client/workflows/.NET%20Core/badge.svg)

- SDK version: 0.0.12

- [Servicing API Documentation](https://api.loan-street.com/docs/index.html)
- [Swagger File](https://api.loan-street.com:8443/v1/api-docs)

## Examples

#### Fixed Payment Facility

- [Create a Fixed Payment Term Loan](src/LoanStreet.LoanServicing.Examples/FixedPaymentFacility/Originate.cs)
- [Raise an Invoice and Issue Payment](src/LoanStreet.LoanServicing.Examples/FixedPaymentFacility/RaiseInvoiceAndIssuePayment.cs)

#### Institutions

- [Create and Read Institutions](src/LoanStreet.LoanServicing.Examples/Institutions/CreateInstitution.cs)


## Glossary

* **Facility**: A Facility can have one or more Tranches. Lender and Co-Lender Ownership is recorded at the Tranche level. Invoices are created at the Tranche level by summing the Borrowing payments due for each Borrowing.

* **Tranche**: A Tranche can have one or more Borrowings. Interest elections are managed at this level. Interest is calculated at this level.

* **Invoice**: A list of the principal, interest, fees and expenses charged against the tranche to the Borrower for a date period.

* **Payment**: An amount that is credited to the tranche balance owed by the Borrower.

<a name="getting-started"></a>
## Getting Started
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            ClientFactory.SetCredentials("YourUsername", "YourPassword");

            var client = ClientFactory.GetInstitutionsController()

            try
            {
                var result = client.CreateInstitution(new Institution());
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling Institution.Create: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```


