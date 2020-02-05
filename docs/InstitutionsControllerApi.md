# LoanStreet.LoanServicing.Api.InstitutionsControllerApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](InstitutionsControllerApi.md#create) | **POST** /v1/private/institutions | 
[**Fetch**](InstitutionsControllerApi.md#fetch) | **GET** /v1/private/institutions/{institutionId} | 
[**FetchAll**](InstitutionsControllerApi.md#fetchall) | **GET** /v1/private/institutions | 
[**Update**](InstitutionsControllerApi.md#update) | **PUT** /v1/private/institutions/{institutionId} | 


<a name="create"></a>
# **Create**
> Institution Create (Institution institution = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class CreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsControllerApi(Configuration.Default);
            var institution = new Institution(); // Institution |  (optional) 

            try
            {
                Institution result = apiInstance.Create(institution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsControllerApi.Create: " + e.Message );
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
 **institution** | [**Institution**](Institution.md)|  | [optional] 

### Return type

[**Institution**](Institution.md)

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

<a name="fetch"></a>
# **Fetch**
> Institution Fetch (string institutionId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class FetchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsControllerApi(Configuration.Default);
            var institutionId = institutionId_example;  // string | 

            try
            {
                Institution result = apiInstance.Fetch(institutionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsControllerApi.Fetch: " + e.Message );
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
 **institutionId** | **string**|  | 

### Return type

[**Institution**](Institution.md)

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

<a name="fetchall"></a>
# **FetchAll**
> List&lt;Institution&gt; FetchAll ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class FetchAllExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsControllerApi(Configuration.Default);

            try
            {
                List<Institution> result = apiInstance.FetchAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsControllerApi.FetchAll: " + e.Message );
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

[**List&lt;Institution&gt;**](Institution.md)

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

<a name="update"></a>
# **Update**
> Object Update (string institutionId, Object body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class UpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsControllerApi(Configuration.Default);
            var institutionId = institutionId_example;  // string | 
            var body = ;  // Object |  (optional) 

            try
            {
                Object result = apiInstance.Update(institutionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsControllerApi.Update: " + e.Message );
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
 **institutionId** | **string**|  | 
 **body** | **Object**|  | [optional] 

### Return type

**Object**

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

