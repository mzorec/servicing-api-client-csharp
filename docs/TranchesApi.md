# LoanStreet.LoanServicing.Api.TranchesApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInvoice**](TranchesApi.md#createinvoice) | **POST** /v1/private/facilities/{facilityId}/tranches/{trancheId}/invoices | 
[**CreatePayment**](TranchesApi.md#createpayment) | **POST** /v1/private/facilities/{facilityId}/tranches/{trancheId}/payments | 
[**GetTranche**](TranchesApi.md#gettranche) | **GET** /v1/private/facilities/{facilityId}/tranches/{trancheId} | 
[**ListTranches**](TranchesApi.md#listtranches) | **GET** /v1/private/facilities/{facilityId}/tranches | 


<a name="createinvoice"></a>
# **CreateInvoice**
> Invoice CreateInvoice (string facilityId, string trancheId, Invoice invoice = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class CreateInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranchesApi(config);
            var facilityId = facilityId_example;  // string | 
            var trancheId = trancheId_example;  // string | 
            var invoice = new Invoice(); // Invoice |  (optional) 

            try
            {
                Invoice result = apiInstance.CreateInvoice(facilityId, trancheId, invoice);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranchesApi.CreateInvoice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **facilityId** | **string**|  | 
 **trancheId** | **string**|  | 
 **invoice** | [**Invoice**](Invoice.md)|  | [optional] 

### Return type

[**Invoice**](Invoice.md)

### Authorization

[bearer-token](../README.md#bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpayment"></a>
# **CreatePayment**
> Payment CreatePayment (string facilityId, string trancheId, Payment payment = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class CreatePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranchesApi(config);
            var facilityId = facilityId_example;  // string | 
            var trancheId = trancheId_example;  // string | 
            var payment = new Payment(); // Payment |  (optional) 

            try
            {
                Payment result = apiInstance.CreatePayment(facilityId, trancheId, payment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranchesApi.CreatePayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **facilityId** | **string**|  | 
 **trancheId** | **string**|  | 
 **payment** | [**Payment**](Payment.md)|  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

[bearer-token](../README.md#bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettranche"></a>
# **GetTranche**
> Tranche GetTranche (string facilityId, string trancheId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class GetTrancheExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranchesApi(config);
            var facilityId = facilityId_example;  // string | 
            var trancheId = trancheId_example;  // string | 

            try
            {
                Tranche result = apiInstance.GetTranche(facilityId, trancheId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranchesApi.GetTranche: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **facilityId** | **string**|  | 
 **trancheId** | **string**|  | 

### Return type

[**Tranche**](Tranche.md)

### Authorization

[bearer-token](../README.md#bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtranches"></a>
# **ListTranches**
> List&lt;Tranche&gt; ListTranches (string facilityId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class ListTranchesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranchesApi(config);
            var facilityId = facilityId_example;  // string | 

            try
            {
                List<Tranche> result = apiInstance.ListTranches(facilityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranchesApi.ListTranches: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **facilityId** | **string**|  | 

### Return type

[**List&lt;Tranche&gt;**](Tranche.md)

### Authorization

[bearer-token](../README.md#bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

