# LoanStreet.LoanServicing.Api.DealsControllerApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDeal**](DealsControllerApi.md#createdeal) | **POST** /v1/private/deals | 
[**FetchDeal**](DealsControllerApi.md#fetchdeal) | **GET** /v1/private/deals/{dealId} | 
[**FetchDeals**](DealsControllerApi.md#fetchdeals) | **GET** /v1/private/deals | 
[**UpdateDeal**](DealsControllerApi.md#updatedeal) | **PUT** /v1/private/deals/{dealId} | 


<a name="createdeal"></a>
# **CreateDeal**
> Deal CreateDeal (Deal deal = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class CreateDealExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DealsControllerApi(Configuration.Default);
            var deal = new Deal(); // Deal |  (optional) 

            try
            {
                Deal result = apiInstance.CreateDeal(deal);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DealsControllerApi.CreateDeal: " + e.Message );
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
 **deal** | [**Deal**](Deal.md)|  | [optional] 

### Return type

[**Deal**](Deal.md)

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

<a name="fetchdeal"></a>
# **FetchDeal**
> Deal FetchDeal (string dealId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class FetchDealExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DealsControllerApi(Configuration.Default);
            var dealId = dealId_example;  // string | 

            try
            {
                Deal result = apiInstance.FetchDeal(dealId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DealsControllerApi.FetchDeal: " + e.Message );
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
 **dealId** | **string**|  | 

### Return type

[**Deal**](Deal.md)

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

<a name="fetchdeals"></a>
# **FetchDeals**
> List&lt;Deal&gt; FetchDeals ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class FetchDealsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DealsControllerApi(Configuration.Default);

            try
            {
                List<Deal> result = apiInstance.FetchDeals();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DealsControllerApi.FetchDeals: " + e.Message );
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

[**List&lt;Deal&gt;**](Deal.md)

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

<a name="updatedeal"></a>
# **UpdateDeal**
> Deal UpdateDeal (string dealId, Deal deal = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class UpdateDealExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DealsControllerApi(Configuration.Default);
            var dealId = dealId_example;  // string | 
            var deal = new Deal(); // Deal |  (optional) 

            try
            {
                Deal result = apiInstance.UpdateDeal(dealId, deal);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DealsControllerApi.UpdateDeal: " + e.Message );
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
 **dealId** | **string**|  | 
 **deal** | [**Deal**](Deal.md)|  | [optional] 

### Return type

[**Deal**](Deal.md)

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

