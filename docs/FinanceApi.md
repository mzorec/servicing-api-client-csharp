# LoanStreet.LoanServicing.Api.FinanceApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNextBusinessDay**](FinanceApi.md#getnextbusinessday) | **GET** /v1/public/finance/next-business-day/{inputDate} | 
[**GetPreviousBusinessDay**](FinanceApi.md#getpreviousbusinessday) | **GET** /v1/public/finance/previous-business-day/{inputDate} | 


<a name="getnextbusinessday"></a>
# **GetNextBusinessDay**
> BusinessDayResponse GetNextBusinessDay (DateTime inputDate)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class GetNextBusinessDayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            var apiInstance = new FinanceApi(config);
            var inputDate = 2013-10-20;  // DateTime | 

            try
            {
                BusinessDayResponse result = apiInstance.GetNextBusinessDay(inputDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinanceApi.GetNextBusinessDay: " + e.Message );
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
 **inputDate** | **DateTime**|  | 

### Return type

[**BusinessDayResponse**](BusinessDayResponse.md)

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

<a name="getpreviousbusinessday"></a>
# **GetPreviousBusinessDay**
> BusinessDayResponse GetPreviousBusinessDay (DateTime inputDate)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class GetPreviousBusinessDayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            var apiInstance = new FinanceApi(config);
            var inputDate = 2013-10-20;  // DateTime | 

            try
            {
                BusinessDayResponse result = apiInstance.GetPreviousBusinessDay(inputDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinanceApi.GetPreviousBusinessDay: " + e.Message );
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
 **inputDate** | **DateTime**|  | 

### Return type

[**BusinessDayResponse**](BusinessDayResponse.md)

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

