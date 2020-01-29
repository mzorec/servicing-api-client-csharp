# LoanStreet.LoanServicing.Api.LoanPaymentsControllerApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePayment**](LoanPaymentsControllerApi.md#createpayment) | **POST** /v1/private/loans/{loanId}/payments | 
[**GetPayment**](LoanPaymentsControllerApi.md#getpayment) | **GET** /v1/private/loans/{loanId}/payments/{paymentId} | 
[**ListPayments**](LoanPaymentsControllerApi.md#listpayments) | **GET** /v1/private/loans/{loanId}/payments | 


<a name="createpayment"></a>
# **CreatePayment**
> Payment CreatePayment (string loanId, Payment payment = null)



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
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            var apiInstance = new LoanPaymentsControllerApi(Configuration.Default);
            var loanId = loanId_example;  // string | 
            var payment = new Payment(); // Payment |  (optional) 

            try
            {
                Payment result = apiInstance.CreatePayment(loanId, payment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoanPaymentsControllerApi.CreatePayment: " + e.Message );
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
 **payment** | [**Payment**](Payment.md)|  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayment"></a>
# **GetPayment**
> Payment GetPayment (string loanId, string paymentId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class GetPaymentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            var apiInstance = new LoanPaymentsControllerApi(Configuration.Default);
            var loanId = loanId_example;  // string | 
            var paymentId = paymentId_example;  // string | 

            try
            {
                Payment result = apiInstance.GetPayment(loanId, paymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoanPaymentsControllerApi.GetPayment: " + e.Message );
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
 **paymentId** | **string**|  | 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpayments"></a>
# **ListPayments**
> List&lt;Payment&gt; ListPayments (string loanId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class ListPaymentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            var apiInstance = new LoanPaymentsControllerApi(Configuration.Default);
            var loanId = loanId_example;  // string | 

            try
            {
                List<Payment> result = apiInstance.ListPayments(loanId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoanPaymentsControllerApi.ListPayments: " + e.Message );
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

[**List&lt;Payment&gt;**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

