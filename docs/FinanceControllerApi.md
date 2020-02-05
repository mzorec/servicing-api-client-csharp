# LoanStreet.LoanServicing.Api.FinanceControllerApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NextBusinessDayResponse**](FinanceControllerApi.md#nextbusinessdayresponse) | **GET** /v1/public/finance/next-business-day/{inputDate} | 
[**PreviousBusinessDayResponse**](FinanceControllerApi.md#previousbusinessdayresponse) | **GET** /v1/public/finance/previous-business-day/{inputDate} | 


<a name="nextbusinessdayresponse"></a>
# **NextBusinessDayResponse**
> BusinessDayResponse NextBusinessDayResponse (DateTime inputDate)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class NextBusinessDayResponseExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FinanceControllerApi(Configuration.Default);
            var inputDate = 2013-10-20;  // DateTime | 

            try
            {
                BusinessDayResponse result = apiInstance.NextBusinessDayResponse(inputDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinanceControllerApi.NextBusinessDayResponse: " + e.Message );
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

[bearer-token](../README.md#bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="previousbusinessdayresponse"></a>
# **PreviousBusinessDayResponse**
> BusinessDayResponse PreviousBusinessDayResponse (DateTime inputDate)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class PreviousBusinessDayResponseExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FinanceControllerApi(Configuration.Default);
            var inputDate = 2013-10-20;  // DateTime | 

            try
            {
                BusinessDayResponse result = apiInstance.PreviousBusinessDayResponse(inputDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinanceControllerApi.PreviousBusinessDayResponse: " + e.Message );
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

[bearer-token](../README.md#bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

