# LoanStreet.LoanServicing.Api.LoanSyndicationsControllerApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSyndication**](LoanSyndicationsControllerApi.md#createsyndication) | **POST** /v1/private/loans/{loanId}/syndications | 
[**GetSyndication**](LoanSyndicationsControllerApi.md#getsyndication) | **GET** /v1/private/loans/{loanId}/syndications/{institutionId} | 
[**ListSyndications**](LoanSyndicationsControllerApi.md#listsyndications) | **GET** /v1/private/loans/{loanId}/syndications | 


<a name="createsyndication"></a>
# **CreateSyndication**
> Object CreateSyndication (string loanId, RecordLoanSaleRequest recordLoanSaleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class CreateSyndicationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            var apiInstance = new LoanSyndicationsControllerApi(Configuration.Default);
            var loanId = loanId_example;  // string | 
            var recordLoanSaleRequest = new RecordLoanSaleRequest(); // RecordLoanSaleRequest |  (optional) 

            try
            {
                Object result = apiInstance.CreateSyndication(loanId, recordLoanSaleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoanSyndicationsControllerApi.CreateSyndication: " + e.Message );
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
 **recordLoanSaleRequest** | [**RecordLoanSaleRequest**](RecordLoanSaleRequest.md)|  | [optional] 

### Return type

**Object**

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

<a name="getsyndication"></a>
# **GetSyndication**
> Object GetSyndication (string loanId, string institutionId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class GetSyndicationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            var apiInstance = new LoanSyndicationsControllerApi(Configuration.Default);
            var loanId = loanId_example;  // string | 
            var institutionId = institutionId_example;  // string | 

            try
            {
                Object result = apiInstance.GetSyndication(loanId, institutionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoanSyndicationsControllerApi.GetSyndication: " + e.Message );
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
 **institutionId** | **string**|  | 

### Return type

**Object**

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

<a name="listsyndications"></a>
# **ListSyndications**
> List&lt;Object&gt; ListSyndications (string loanId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class ListSyndicationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            var apiInstance = new LoanSyndicationsControllerApi(Configuration.Default);
            var loanId = loanId_example;  // string | 

            try
            {
                List<Object> result = apiInstance.ListSyndications(loanId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoanSyndicationsControllerApi.ListSyndications: " + e.Message );
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

**List<Object>**

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

