# LoanStreet.LoanServicing.Api.ChargesApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharge**](ChargesApi.md#getcharge) | **GET** /v1/private/facilities/{facilityId}/charges/{chargeId} | 
[**ListCharges**](ChargesApi.md#listcharges) | **GET** /v1/private/facilities/{facilityId}/charges | 


<a name="getcharge"></a>
# **GetCharge**
> Charge GetCharge (string facilityId, string chargeId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class GetChargeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ChargesApi(config);
            var facilityId = facilityId_example;  // string | 
            var chargeId = chargeId_example;  // string | 

            try
            {
                Charge result = apiInstance.GetCharge(facilityId, chargeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargesApi.GetCharge: " + e.Message );
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
 **chargeId** | **string**|  | 

### Return type

[**Charge**](Charge.md)

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

<a name="listcharges"></a>
# **ListCharges**
> List&lt;Charge&gt; ListCharges (string facilityId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class ListChargesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ChargesApi(config);
            var facilityId = facilityId_example;  // string | 

            try
            {
                List<Charge> result = apiInstance.ListCharges(facilityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargesApi.ListCharges: " + e.Message );
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

[**List&lt;Charge&gt;**](Charge.md)

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

