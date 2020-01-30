# LoanStreet.LoanServicing.Api.LoanSyndicationsControllerApi

All URIs are relative to *https://api.loan-street.com:8443*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSyndication**](LoanSyndicationsControllerApi.md#createsyndication) | **POST** /v1/private/loans/{loanId}/syndications | 


<a name="createsyndication"></a>
# **CreateSyndication**
> Sale CreateSyndication (string loanId, Sale sale = null)



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
            var sale = new Sale(); // Sale |  (optional) 

            try
            {
                Sale result = apiInstance.CreateSyndication(loanId, sale);
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
 **sale** | [**Sale**](Sale.md)|  | [optional] 

### Return type

[**Sale**](Sale.md)

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

