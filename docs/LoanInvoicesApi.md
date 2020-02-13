# LoanStreet.LoanServicing.Api.LoanInvoicesApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInvoice**](LoanInvoicesApi.md#createinvoice) | **POST** /v1/private/loans/{loanId}/invoices | 
[**GetInvoice**](LoanInvoicesApi.md#getinvoice) | **GET** /v1/private/loans/{loanId}/invoices/{invoiceId} | 
[**ListInvoiceHistory**](LoanInvoicesApi.md#listinvoicehistory) | **GET** /v1/private/loans/{loanId}/invoices | 


<a name="createinvoice"></a>
# **CreateInvoice**
> Invoice CreateInvoice (string loanId, Invoice invoice = null)



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
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoanInvoicesApi(Configuration.Default);
            var loanId = loanId_example;  // string | 
            var invoice = new Invoice(); // Invoice |  (optional) 

            try
            {
                Invoice result = apiInstance.CreateInvoice(loanId, invoice);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoanInvoicesApi.CreateInvoice: " + e.Message );
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
 **loanId** | **string**|  | 
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

<a name="getinvoice"></a>
# **GetInvoice**
> Invoice GetInvoice (string loanId, string invoiceId)



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
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoanInvoicesApi(Configuration.Default);
            var loanId = loanId_example;  // string | 
            var invoiceId = invoiceId_example;  // string | 

            try
            {
                Invoice result = apiInstance.GetInvoice(loanId, invoiceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoanInvoicesApi.GetInvoice: " + e.Message );
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
 **loanId** | **string**|  | 
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

<a name="listinvoicehistory"></a>
# **ListInvoiceHistory**
> List&lt;Invoice&gt; ListInvoiceHistory (string loanId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class ListInvoiceHistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoanInvoicesApi(Configuration.Default);
            var loanId = loanId_example;  // string | 

            try
            {
                List<Invoice> result = apiInstance.ListInvoiceHistory(loanId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoanInvoicesApi.ListInvoiceHistory: " + e.Message );
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
 **loanId** | **string**|  | 

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

