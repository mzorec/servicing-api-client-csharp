
<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.loan-street.com:8443*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ACLsApi* | [**List**](docs/ACLsApi.md#list) | **GET** /v1/private/acls/{oid} | 
*AuthorizationApi* | [**Auth**](docs/AuthorizationApi.md#auth) | **GET** /v1/public/auth | 
*AuthorizationApi* | [**AuthInstitution**](docs/AuthorizationApi.md#authinstitution) | **GET** /v1/public/auth/inst | 
*AuthorizationApi* | [**Principal**](docs/AuthorizationApi.md#principal) | **GET** /v1/public/principal | 
*AuthorizationApi* | [**Token**](docs/AuthorizationApi.md#token) | **POST** /v1/public/token | 
*BorrowingsApi* | [**GetBorrowing**](docs/BorrowingsApi.md#getborrowing) | **GET** /v1/private/facilities/{facilityId}/borrowings/{borrowingId} | 
*BorrowingsApi* | [**ListBorrowings**](docs/BorrowingsApi.md#listborrowings) | **GET** /v1/private/facilities/{facilityId}/borrowings | 
*ChargesApi* | [**GetCharge**](docs/ChargesApi.md#getcharge) | **GET** /v1/private/facilities/{facilityId}/charges/{chargeId} | 
*ChargesApi* | [**ListCharges**](docs/ChargesApi.md#listcharges) | **GET** /v1/private/facilities/{facilityId}/charges | 
*FacilitiesApi* | [**CreateFacility**](docs/FacilitiesApi.md#createfacility) | **POST** /v1/private/facilities | 
*FacilitiesApi* | [**GetFacility**](docs/FacilitiesApi.md#getfacility) | **GET** /v1/private/facilities/{facilityId} | 
*FacilitiesApi* | [**ListFacilities**](docs/FacilitiesApi.md#listfacilities) | **GET** /v1/private/facilities | 
*FinanceApi* | [**GetNextBusinessDay**](docs/FinanceApi.md#getnextbusinessday) | **GET** /v1/public/finance/next-business-day/{inputDate} | 
*FinanceApi* | [**GetPreviousBusinessDay**](docs/FinanceApi.md#getpreviousbusinessday) | **GET** /v1/public/finance/previous-business-day/{inputDate} | 
*InstitutionsApi* | [**CreateInstitution**](docs/InstitutionsApi.md#createinstitution) | **POST** /v1/private/institutions | 
*InstitutionsApi* | [**GetInstitution**](docs/InstitutionsApi.md#getinstitution) | **GET** /v1/private/institutions/{institutionId} | 
*InstitutionsApi* | [**ListFunds**](docs/InstitutionsApi.md#listfunds) | **GET** /v1/private/institutions/{institutionId}/funds | 
*InstitutionsApi* | [**ListInstitutions**](docs/InstitutionsApi.md#listinstitutions) | **GET** /v1/private/institutions | 
*InstitutionsApi* | [**PostFund**](docs/InstitutionsApi.md#postfund) | **POST** /v1/private/institutions/{institutionId}/funds | 
*InstitutionsApi* | [**UpdateInstitution**](docs/InstitutionsApi.md#updateinstitution) | **PUT** /v1/private/institutions/{institutionId} | 
*InvoicesApi* | [**GetInvoice**](docs/InvoicesApi.md#getinvoice) | **GET** /v1/private/facilities/{facilityId}/invoices/{invoiceId} | 
*InvoicesApi* | [**ListInvoices**](docs/InvoicesApi.md#listinvoices) | **GET** /v1/private/facilities/{facilityId}/invoices | 
*LoansApi* | [**CreateLoan**](docs/LoansApi.md#createloan) | **POST** /v1/private/loans | 
*LoansApi* | [**GetLoan**](docs/LoansApi.md#getloan) | **GET** /v1/private/loans/{facilityId} | 
*PaymentsApi* | [**GetPayment**](docs/PaymentsApi.md#getpayment) | **GET** /v1/private/facilities/{facilityId}/payments/{paymentId} | 
*PaymentsApi* | [**ListPayments**](docs/PaymentsApi.md#listpayments) | **GET** /v1/private/facilities/{facilityId}/payments | 
*SystemStatusApi* | [**Index**](docs/SystemStatusApi.md#index) | **GET** /v1/public/status | 
*TranchesApi* | [**CreateDraw**](docs/TranchesApi.md#createdraw) | **POST** /v1/private/facilities/{facilityId}/tranches/{trancheId}/draw | 
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
 - [Model.Draw](docs/Draw.md)
 - [Model.DrawRules](docs/DrawRules.md)
 - [Model.Facility](docs/Facility.md)
 - [Model.FacilityInstitutionDto](docs/FacilityInstitutionDto.md)
 - [Model.FixedPaymentInterestRules](docs/FixedPaymentInterestRules.md)
 - [Model.FixedPaymentInterestRulesAllOf](docs/FixedPaymentInterestRulesAllOf.md)
 - [Model.FixedPaymentInterestTerms](docs/FixedPaymentInterestTerms.md)
 - [Model.FloatingInterestRules](docs/FloatingInterestRules.md)
 - [Model.FloatingInterestRulesAllOf](docs/FloatingInterestRulesAllOf.md)
 - [Model.FloatingInterestTerms](docs/FloatingInterestTerms.md)
 - [Model.FloatingInterestTermsAllOf](docs/FloatingInterestTermsAllOf.md)
 - [Model.Fund](docs/Fund.md)
 - [Model.GrantedAuthority](docs/GrantedAuthority.md)
 - [Model.Identity](docs/Identity.md)
 - [Model.Institution](docs/Institution.md)
 - [Model.InterestCharge](docs/InterestCharge.md)
 - [Model.InterestRules](docs/InterestRules.md)
 - [Model.InterestTerms](docs/InterestTerms.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.Jwt](docs/Jwt.md)
 - [Model.JwtAuthenticationToken](docs/JwtAuthenticationToken.md)
 - [Model.Loan](docs/Loan.md)
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
