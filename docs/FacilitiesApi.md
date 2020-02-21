# LoanStreet.LoanServicing.Api.FacilitiesApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFacility**](FacilitiesApi.md#createfacility) | **POST** /v1/private/facilities | 
[**GetFacility**](FacilitiesApi.md#getfacility) | **GET** /v1/private/facilities/{facilityId} | 
[**ListFacilities**](FacilitiesApi.md#listfacilities) | **GET** /v1/private/facilities | 


<a name="createfacility"></a>
# **CreateFacility**
> Facility CreateFacility (Facility facility = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class CreateFacilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new FacilitiesApi(config);
            var facility = new Facility(); // Facility |  (optional) 

            try
            {
                Facility result = apiInstance.CreateFacility(facility);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FacilitiesApi.CreateFacility: " + e.Message );
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
 **facility** | [**Facility**](Facility.md)|  | [optional] 

### Return type

[**Facility**](Facility.md)

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

<a name="getfacility"></a>
# **GetFacility**
> Facility GetFacility (string facilityId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class GetFacilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new FacilitiesApi(config);
            var facilityId = facilityId_example;  // string | 

            try
            {
                Facility result = apiInstance.GetFacility(facilityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FacilitiesApi.GetFacility: " + e.Message );
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

[**Facility**](Facility.md)

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

<a name="listfacilities"></a>
# **ListFacilities**
> List&lt;Facility&gt; ListFacilities (string borrower = null, string fund = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Model;

namespace Example
{
    public class ListFacilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.loan-street.com:8443";
            // Configure HTTP basic authorization: bearer-token
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new FacilitiesApi(config);
            var borrower = borrower_example;  // string |  (optional) 
            var fund = fund_example;  // string |  (optional) 

            try
            {
                List<Facility> result = apiInstance.ListFacilities(borrower, fund);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FacilitiesApi.ListFacilities: " + e.Message );
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
 **borrower** | **string**|  | [optional] 
 **fund** | **string**|  | [optional] 

### Return type

[**List&lt;Facility&gt;**](Facility.md)

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

