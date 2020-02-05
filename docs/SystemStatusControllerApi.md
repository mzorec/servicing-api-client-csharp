# LoanStreet.LoanServicing.Api.SystemStatusControllerApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Index**](SystemStatusControllerApi.md#index) | **GET** /v1/public/status | 


<a name="index"></a>
# **Index**
> SystemStatusResponse Index ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class IndexExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemStatusControllerApi(Configuration.Default);

            try
            {
                SystemStatusResponse result = apiInstance.Index();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemStatusControllerApi.Index: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SystemStatusResponse**](SystemStatusResponse.md)

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

