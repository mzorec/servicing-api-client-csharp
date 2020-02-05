# LoanStreet Loan Servicing API Client 

![.NET Core](https://github.com/loanstreet-usa/LoanServicingAPI-Client/workflows/.NET%20Core/badge.svg)

- [Servicing API Documentation](https://api.loan-street.com/docs/index.html)
- [Swagger File](https://api.loan-street.com:8443/v1/api-docs)

## Examples

- [Institutions Create and Read](src/LoanStreet.LoanServicing.Examples/institutions/InstutitionsCRUD.cs)


<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.6.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [CompareNETObjects](https://www.nuget.org/packages/CompareNETObjects) - 4.57.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
Install-Package CompareNETObjects
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;
```
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
            ClientFactory.SetBearerToken("YourBearerToken");

            var apiInstance = ClientFactory.GetDealsControllerApi();
            var deal = new Deal(); // Deal |  (optional) 

            try
            {
                Deal result = apiInstance.CreateDeal(deal);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DealsControllerApi.CreateDeal: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.loan-street.com:8443*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DealsControllerApi* | [**CreateDeal**](docs/DealsControllerApi.md#createdeal) | **POST** /v1/private/deals | 
*DealsControllerApi* | [**FetchDeal**](docs/DealsControllerApi.md#fetchdeal) | **GET** /v1/private/deals/{dealId} | 
*DealsControllerApi* | [**FetchDeals**](docs/DealsControllerApi.md#fetchdeals) | **GET** /v1/private/deals | 
*DealsControllerApi* | [**UpdateDeal**](docs/DealsControllerApi.md#updatedeal) | **PUT** /v1/private/deals/{dealId} | 
*FinanceControllerApi* | [**NextBusinessDayResponse**](docs/FinanceControllerApi.md#nextbusinessdayresponse) | **GET** /v1/public/finance/next-business-day/{inputDate} | 
*FinanceControllerApi* | [**PreviousBusinessDayResponse**](docs/FinanceControllerApi.md#previousbusinessdayresponse) | **GET** /v1/public/finance/previous-business-day/{inputDate} | 
*InstitutionsControllerApi* | [**Create**](docs/InstitutionsControllerApi.md#create) | **POST** /v1/private/institutions | 
*InstitutionsControllerApi* | [**Fetch**](docs/InstitutionsControllerApi.md#fetch) | **GET** /v1/private/institutions/{institutionId} | 
*InstitutionsControllerApi* | [**FetchAll**](docs/InstitutionsControllerApi.md#fetchall) | **GET** /v1/private/institutions | 
*InstitutionsControllerApi* | [**Update**](docs/InstitutionsControllerApi.md#update) | **PUT** /v1/private/institutions/{institutionId} | 
*LoanInvoicesControllerApi* | [**CreateInvoice**](docs/LoanInvoicesControllerApi.md#createinvoice) | **POST** /v1/private/loans/{loanId}/invoices | 
*LoanInvoicesControllerApi* | [**GetInvoice**](docs/LoanInvoicesControllerApi.md#getinvoice) | **GET** /v1/private/loans/{loanId}/invoices/{invoiceId} | 
*LoanInvoicesControllerApi* | [**ListInvoiceHistory**](docs/LoanInvoicesControllerApi.md#listinvoicehistory) | **GET** /v1/private/loans/{loanId}/invoices | 
*LoanPaymentsControllerApi* | [**CreatePayment**](docs/LoanPaymentsControllerApi.md#createpayment) | **POST** /v1/private/loans/{loanId}/payments | 
*LoanPaymentsControllerApi* | [**GetPayment**](docs/LoanPaymentsControllerApi.md#getpayment) | **GET** /v1/private/loans/{loanId}/payments/{paymentId} | 
*LoanPaymentsControllerApi* | [**ListPayments**](docs/LoanPaymentsControllerApi.md#listpayments) | **GET** /v1/private/loans/{loanId}/payments | 
*LoanSyndicationsControllerApi* | [**CreateSyndication**](docs/LoanSyndicationsControllerApi.md#createsyndication) | **POST** /v1/private/loans/{loanId}/syndications | 
*LoansControllerApi* | [**CreateLoan**](docs/LoansControllerApi.md#createloan) | **POST** /v1/private/loans | 
*LoansControllerApi* | [**GetLoan**](docs/LoansControllerApi.md#getloan) | **GET** /v1/private/loans/{loanId} | 
*LoansControllerApi* | [**ListLoans**](docs/LoansControllerApi.md#listloans) | **GET** /v1/private/loans | 
*SystemStatusControllerApi* | [**Index**](docs/SystemStatusControllerApi.md#index) | **GET** /v1/public/status | 
*UsersControllerApi* | [**Create1**](docs/UsersControllerApi.md#create1) | **POST** /v1/private/users | 
*UsersControllerApi* | [**Fetch1**](docs/UsersControllerApi.md#fetch1) | **GET** /v1/private/users/{userId} | 
*UsersControllerApi* | [**List**](docs/UsersControllerApi.md#list) | **GET** /v1/private/users | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Address](docs/Address.md)
 - [Model.BusinessDayResponse](docs/BusinessDayResponse.md)
 - [Model.Charge](docs/Charge.md)
 - [Model.CreateUserRequest](docs/CreateUserRequest.md)
 - [Model.Deal](docs/Deal.md)
 - [Model.Facility](docs/Facility.md)
 - [Model.FixedPaymentInterestTerms](docs/FixedPaymentInterestTerms.md)
 - [Model.FixedPaymentInterestTermsAllOf](docs/FixedPaymentInterestTermsAllOf.md)
 - [Model.Identity](docs/Identity.md)
 - [Model.Institution](docs/Institution.md)
 - [Model.InterestCharge](docs/InterestCharge.md)
 - [Model.InterestTerms](docs/InterestTerms.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.Loan](docs/Loan.md)
 - [Model.Money](docs/Money.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PrincipalCharge](docs/PrincipalCharge.md)
 - [Model.ProfileData](docs/ProfileData.md)
 - [Model.Sale](docs/Sale.md)
 - [Model.SystemStatusResponse](docs/SystemStatusResponse.md)
 - [Model.Tranche](docs/Tranche.md)
 - [Model.User](docs/User.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearer-token"></a>
### bearer-token

- **Type**: HTTP basic authentication

