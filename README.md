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

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
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
                Debug.Print("Exception when calling Institutions controller: " + e.Message );
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
*ACLsApi* | [**List**](docs/ACLsApi.md#list) | **GET** /v1/private/acls/{oid} | 
*AuthorizationApi* | [**Auth**](docs/AuthorizationApi.md#auth) | **GET** /v1/public/auth | 
*AuthorizationApi* | [**Principal**](docs/AuthorizationApi.md#principal) | **GET** /v1/public/principal | 
*AuthorizationApi* | [**Token**](docs/AuthorizationApi.md#token) | **POST** /v1/public/token | 
*FacilitiesApi* | [**CreateFacility**](docs/FacilitiesApi.md#createfacility) | **POST** /v1/private/facilities | 
*FacilitiesApi* | [**GetFacility**](docs/FacilitiesApi.md#getfacility) | **GET** /v1/private/facilities/{facilityId} | 
*FacilitiesApi* | [**ListFacilities**](docs/FacilitiesApi.md#listfacilities) | **GET** /v1/private/facilities | 
*FinanceApi* | [**GetNextBusinessDay**](docs/FinanceApi.md#getnextbusinessday) | **GET** /v1/public/finance/next-business-day/{inputDate} | 
*FinanceApi* | [**GetPreviousBusinessDay**](docs/FinanceApi.md#getpreviousbusinessday) | **GET** /v1/public/finance/previous-business-day/{inputDate} | 
*InstitutionsApi* | [**CreateInstitution**](docs/InstitutionsApi.md#createinstitution) | **POST** /v1/private/institutions | 
*InstitutionsApi* | [**GetInstitution**](docs/InstitutionsApi.md#getinstitution) | **GET** /v1/private/institutions/{institutionId} | 
*InstitutionsApi* | [**ListInstitutions**](docs/InstitutionsApi.md#listinstitutions) | **GET** /v1/private/institutions | 
*InstitutionsApi* | [**UpdateInstitution**](docs/InstitutionsApi.md#updateinstitution) | **PUT** /v1/private/institutions/{institutionId} | 
*InvoicesApi* | [**GetInvoice**](docs/InvoicesApi.md#getinvoice) | **GET** /v1/private/facilities/{facilityId}/invoices/{invoiceId} | 
*InvoicesApi* | [**ListInvoices**](docs/InvoicesApi.md#listinvoices) | **GET** /v1/private/facilities/{facilityId}/invoices | 
*PaymentsApi* | [**GetPayment**](docs/PaymentsApi.md#getpayment) | **GET** /v1/private/facilities/{facilityId}/payments/{paymentId} | 
*PaymentsApi* | [**ListPayments**](docs/PaymentsApi.md#listpayments) | **GET** /v1/private/facilities/{facilityId}/payments | 
*SystemStatusApi* | [**Index**](docs/SystemStatusApi.md#index) | **GET** /v1/public/status | 
*TranchesApi* | [**CreateInvoice**](docs/TranchesApi.md#createinvoice) | **POST** /v1/private/facilities/{facilityId}/tranches/{trancheId}/invoices | 
*TranchesApi* | [**CreatePayment**](docs/TranchesApi.md#createpayment) | **POST** /v1/private/facilities/{facilityId}/tranches/{trancheId}/payments | 
*TranchesApi* | [**GetTranche**](docs/TranchesApi.md#gettranche) | **GET** /v1/private/facilities/{facilityId}/tranches/{trancheId} | 
*TranchesApi* | [**ListTranches**](docs/TranchesApi.md#listtranches) | **GET** /v1/private/facilities/{facilityId}/tranches | 
*UsersApi* | [**CreateUser**](docs/UsersApi.md#createuser) | **POST** /v1/private/users | 
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /v1/private/users/{userId} | 
*UsersApi* | [**ListUsers**](docs/UsersApi.md#listusers) | **GET** /v1/private/users | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AclDto](docs/AclDto.md)
 - [Model.AclEntryDto](docs/AclEntryDto.md)
 - [Model.Address](docs/Address.md)
 - [Model.Authentication](docs/Authentication.md)
 - [Model.Borrowing](docs/Borrowing.md)
 - [Model.BusinessDayResponse](docs/BusinessDayResponse.md)
 - [Model.Charge](docs/Charge.md)
 - [Model.CreateUserRequest](docs/CreateUserRequest.md)
 - [Model.DrawRules](docs/DrawRules.md)
 - [Model.Facility](docs/Facility.md)
 - [Model.FacilityInstitutionDto](docs/FacilityInstitutionDto.md)
 - [Model.FixedPaymentInterestRules](docs/FixedPaymentInterestRules.md)
 - [Model.FixedPaymentInterestRulesAllOf](docs/FixedPaymentInterestRulesAllOf.md)
 - [Model.FloatingInterestRules](docs/FloatingInterestRules.md)
 - [Model.FloatingInterestRulesAllOf](docs/FloatingInterestRulesAllOf.md)
 - [Model.FloatingInterestTerms](docs/FloatingInterestTerms.md)
 - [Model.FloatingInterestTermsAllOf](docs/FloatingInterestTermsAllOf.md)
 - [Model.GrantedAuthority](docs/GrantedAuthority.md)
 - [Model.Identity](docs/Identity.md)
 - [Model.Institution](docs/Institution.md)
 - [Model.InterestCharge](docs/InterestCharge.md)
 - [Model.InterestRules](docs/InterestRules.md)
 - [Model.InterestTerms](docs/InterestTerms.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.Jwt](docs/Jwt.md)
 - [Model.JwtAuthenticationToken](docs/JwtAuthenticationToken.md)
 - [Model.LocalDatePeriod](docs/LocalDatePeriod.md)
 - [Model.Money](docs/Money.md)
 - [Model.MultipleDrawRules](docs/MultipleDrawRules.md)
 - [Model.MultipleDrawRulesAllOf](docs/MultipleDrawRulesAllOf.md)
 - [Model.PasswordAuthRequest](docs/PasswordAuthRequest.md)
 - [Model.PasswordAuthResponse](docs/PasswordAuthResponse.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.Permission](docs/Permission.md)
 - [Model.PrincipalCharge](docs/PrincipalCharge.md)
 - [Model.ProfileData](docs/ProfileData.md)
 - [Model.RevolverDrawRules](docs/RevolverDrawRules.md)
 - [Model.RevolverDrawRulesAllOf](docs/RevolverDrawRulesAllOf.md)
 - [Model.SingleDrawRules](docs/SingleDrawRules.md)
 - [Model.SystemStatusResponse](docs/SystemStatusResponse.md)
 - [Model.Tranche](docs/Tranche.md)
 - [Model.User](docs/User.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearer-token"></a>
### bearer-token

- **Type**: HTTP basic authentication

