# LoanStreet.LoanServicing.Api.InvoicesApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInvoice**](InvoicesApi.md#getinvoice) | **GET** /v1/private/facilities/{facilityId}/invoices/{invoiceId} | 
[**ListInvoices**](InvoicesApi.md#listinvoices) | **GET** /v1/private/facilities/{facilityId}/invoices | 


<a name="getinvoice"></a>
# **GetInvoice**
> Invoice GetInvoice (string facilityId, string invoiceId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InvoicesApi(config);
            var facilityId = facilityId_example;  // string | 
            var invoiceId = invoiceId_example;  // string | 

            try
            {
                Invoice result = apiInstance.GetInvoice(facilityId, invoiceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoice: " + e.Message );
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
 **invoiceId** | **string**|  | 

### Return type

[**Invoice**](Invoice.md)

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

<a name="listinvoices"></a>
# **ListInvoices**
> List&lt;Invoice&gt; ListInvoices (string facilityId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class ListInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InvoicesApi(config);
            var facilityId = facilityId_example;  // string | 

            try
            {
                List<Invoice> result = apiInstance.ListInvoices(facilityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.ListInvoices: " + e.Message );
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

[**List&lt;Invoice&gt;**](Invoice.md)

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

