# LoanStreet Loan Servicing API Client 

![.NET Core](https://github.com/loanstreet-usa/LoanServicingAPI-Client/workflows/.NET%20Core/badge.svg)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

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
using LoanStreet.LoanServicing.Examples;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            ClientFactory.SetBearerToken("Your Bearer Token");
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
*LoanSyndicationsControllerApi* | [**GetSyndication**](docs/LoanSyndicationsControllerApi.md#getsyndication) | **GET** /v1/private/loans/{loanId}/syndications/{institutionId} | 
*LoanSyndicationsControllerApi* | [**ListSyndications**](docs/LoanSyndicationsControllerApi.md#listsyndications) | **GET** /v1/private/loans/{loanId}/syndications | 
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
 - [Model.LoanSaleData](docs/LoanSaleData.md)
 - [Model.Money](docs/Money.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PrincipalCharge](docs/PrincipalCharge.md)
 - [Model.ProfileData](docs/ProfileData.md)
 - [Model.RecordLoanSaleRequest](docs/RecordLoanSaleRequest.md)
 - [Model.SystemStatusResponse](docs/SystemStatusResponse.md)
 - [Model.Tranche](docs/Tranche.md)
 - [Model.User](docs/User.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.