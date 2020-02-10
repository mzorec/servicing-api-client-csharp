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

            // Optional: Change URL
            // ClientFactory.BasePath = "https://api-staging.loan-street.com:8443";
            
            // Set Credentials, you only need to do this once
            ClientFactory.SetCredentials("YourUser", "YourPassword");

            try
            {
                // Get the Institution Client
                var institutionClient = ClientFactory.GetInstitutionsController();
                
                // Create an Institution       
                var created = institutionClient.Create(new Institution());

                Debug.WriteLine(created);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthorizationApi.Auth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api-staging.loan-street.com:8443*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorizationApi* | [**Auth**](docs/AuthorizationApi.md#auth) | **GET** /v1/public/auth | 
*AuthorizationApi* | [**Principal**](docs/AuthorizationApi.md#principal) | **GET** /v1/public/principal | 
*AuthorizationApi* | [**Token**](docs/AuthorizationApi.md#token) | **POST** /v1/public/token | 
*DealsApi* | [**CreateDeal**](docs/DealsApi.md#createdeal) | **POST** /v1/private/deals | 
*DealsApi* | [**FetchDeal**](docs/DealsApi.md#fetchdeal) | **GET** /v1/private/deals/{dealId} | 
*DealsApi* | [**FetchDeals**](docs/DealsApi.md#fetchdeals) | **GET** /v1/private/deals | 
*DealsApi* | [**UpdateDeal**](docs/DealsApi.md#updatedeal) | **PUT** /v1/private/deals/{dealId} | 
*FinanceApi* | [**NextBusinessDayResponse**](docs/FinanceApi.md#nextbusinessdayresponse) | **GET** /v1/public/finance/next-business-day/{inputDate} | 
*FinanceApi* | [**PreviousBusinessDayResponse**](docs/FinanceApi.md#previousbusinessdayresponse) | **GET** /v1/public/finance/previous-business-day/{inputDate} | 
*InstitutionsApi* | [**Create**](docs/InstitutionsApi.md#create) | **POST** /v1/private/institutions | 
*InstitutionsApi* | [**Fetch**](docs/InstitutionsApi.md#fetch) | **GET** /v1/private/institutions/{institutionId} | 
*InstitutionsApi* | [**FetchAll**](docs/InstitutionsApi.md#fetchall) | **GET** /v1/private/institutions | 
*InstitutionsApi* | [**Update**](docs/InstitutionsApi.md#update) | **PUT** /v1/private/institutions/{institutionId} | 
*LoanInvoicesApi* | [**CreateInvoice**](docs/LoanInvoicesApi.md#createinvoice) | **POST** /v1/private/loans/{loanId}/invoices | 
*LoanInvoicesApi* | [**GetInvoice**](docs/LoanInvoicesApi.md#getinvoice) | **GET** /v1/private/loans/{loanId}/invoices/{invoiceId} | 
*LoanInvoicesApi* | [**ListInvoiceHistory**](docs/LoanInvoicesApi.md#listinvoicehistory) | **GET** /v1/private/loans/{loanId}/invoices | 
*LoanPaymentsApi* | [**CreatePayment**](docs/LoanPaymentsApi.md#createpayment) | **POST** /v1/private/loans/{loanId}/payments | 
*LoanPaymentsApi* | [**GetPayment**](docs/LoanPaymentsApi.md#getpayment) | **GET** /v1/private/loans/{loanId}/payments/{paymentId} | 
*LoanPaymentsApi* | [**ListPayments**](docs/LoanPaymentsApi.md#listpayments) | **GET** /v1/private/loans/{loanId}/payments | 
*LoanSyndicationsApi* | [**CreateSyndication**](docs/LoanSyndicationsApi.md#createsyndication) | **POST** /v1/private/loans/{loanId}/syndications | 
*LoansApi* | [**CreateLoan**](docs/LoansApi.md#createloan) | **POST** /v1/private/loans | 
*LoansApi* | [**GetLoan**](docs/LoansApi.md#getloan) | **GET** /v1/private/loans/{loanId} | 
*LoansApi* | [**ListLoans**](docs/LoansApi.md#listloans) | **GET** /v1/private/loans | 
*SystemStatusApi* | [**Index**](docs/SystemStatusApi.md#index) | **GET** /v1/public/status | 
*UsersApi* | [**Create1**](docs/UsersApi.md#create1) | **POST** /v1/private/users | 
*UsersApi* | [**Fetch1**](docs/UsersApi.md#fetch1) | **GET** /v1/private/users/{userId} | 
*UsersApi* | [**List**](docs/UsersApi.md#list) | **GET** /v1/private/users | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Address](docs/Address.md)
 - [Model.Authentication](docs/Authentication.md)
 - [Model.BusinessDayResponse](docs/BusinessDayResponse.md)
 - [Model.Charge](docs/Charge.md)
 - [Model.CreateUserRequest](docs/CreateUserRequest.md)
 - [Model.Deal](docs/Deal.md)
 - [Model.Facility](docs/Facility.md)
 - [Model.FixedPaymentInterestTerms](docs/FixedPaymentInterestTerms.md)
 - [Model.FixedPaymentInterestTermsAllOf](docs/FixedPaymentInterestTermsAllOf.md)
 - [Model.GrantedAuthority](docs/GrantedAuthority.md)
 - [Model.Identity](docs/Identity.md)
 - [Model.Institution](docs/Institution.md)
 - [Model.InterestCharge](docs/InterestCharge.md)
 - [Model.InterestTerms](docs/InterestTerms.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.Jwt](docs/Jwt.md)
 - [Model.JwtAuthenticationToken](docs/JwtAuthenticationToken.md)
 - [Model.Loan](docs/Loan.md)
 - [Model.LoanRole](docs/LoanRole.md)
 - [Model.LocalDatePeriod](docs/LocalDatePeriod.md)
 - [Model.Money](docs/Money.md)
 - [Model.PasswordAuthRequest](docs/PasswordAuthRequest.md)
 - [Model.PasswordAuthResponse](docs/PasswordAuthResponse.md)
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

