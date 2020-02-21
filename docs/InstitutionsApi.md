# LoanStreet.LoanServicing.Api.InstitutionsApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInstitution**](InstitutionsApi.md#createinstitution) | **POST** /v1/private/institutions | 
[**GetInstitution**](InstitutionsApi.md#getinstitution) | **GET** /v1/private/institutions/{institutionId} | 
[**ListFunds**](InstitutionsApi.md#listfunds) | **GET** /v1/private/institutions/{institutionId}/funds | 
[**ListInstitutions**](InstitutionsApi.md#listinstitutions) | **GET** /v1/private/institutions | 
[**PostFund**](InstitutionsApi.md#postfund) | **POST** /v1/private/institutions/{institutionId}/funds | 
[**UpdateInstitution**](InstitutionsApi.md#updateinstitution) | **PUT** /v1/private/institutions/{institutionId} | 


<a name="createinstitution"></a>
# **CreateInstitution**
> Institution CreateInstitution (Institution institution = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class CreateInstitutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);
            var institution = new Institution(); // Institution |  (optional) 

            try
            {
                Institution result = apiInstance.CreateInstitution(institution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.CreateInstitution: " + e.Message );
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

<a name="getinstitution"></a>
# **GetInstitution**
> Institution GetInstitution (string institutionId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class GetInstitutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);
            var institutionId = institutionId_example;  // string | 

            try
            {
                Institution result = apiInstance.GetInstitution(institutionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.GetInstitution: " + e.Message );
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

<a name="listfunds"></a>
# **ListFunds**
> List&lt;Fund&gt; ListFunds (string institutionId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class ListFundsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);
            var institutionId = institutionId_example;  // string | 

            try
            {
                List<Fund> result = apiInstance.ListFunds(institutionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.ListFunds: " + e.Message );
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

[**List&lt;Fund&gt;**](Fund.md)

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

<a name="listinstitutions"></a>
# **ListInstitutions**
> List&lt;Institution&gt; ListInstitutions ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class ListInstitutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);

            try
            {
                List<Institution> result = apiInstance.ListInstitutions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.ListInstitutions: " + e.Message );
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

<a name="postfund"></a>
# **PostFund**
> Fund PostFund (string institutionId, Fund fund = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class PostFundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);
            var institutionId = institutionId_example;  // string | 
            var fund = new Fund(); // Fund |  (optional) 

            try
            {
                Fund result = apiInstance.PostFund(institutionId, fund);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.PostFund: " + e.Message );
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
 **fund** | [**Fund**](Fund.md)|  | [optional] 

### Return type

[**Fund**](Fund.md)

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

<a name="updateinstitution"></a>
# **UpdateInstitution**
> Object UpdateInstitution (string institutionId, Object body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class UpdateInstitutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);
            var institutionId = institutionId_example;  // string | 
            var body = ;  // Object |  (optional) 

            try
            {
                Object result = apiInstance.UpdateInstitution(institutionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.UpdateInstitution: " + e.Message );
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

