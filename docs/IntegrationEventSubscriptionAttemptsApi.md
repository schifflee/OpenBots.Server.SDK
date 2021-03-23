# IO.Swagger.Api.IntegrationEventSubscriptionAttemptsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionIntegrationEventSubscriptionAttemptsGet**](IntegrationEventSubscriptionAttemptsApi.md#apivapiversionintegrationeventsubscriptionattemptsget) | **GET** /api/v{apiVersion}/IntegrationEventSubscriptionAttempts | Provides a list of all IntegrationEventSubscriptionAttempts
[**ApiVapiVersionIntegrationEventSubscriptionAttemptsViewGet**](IntegrationEventSubscriptionAttemptsApi.md#apivapiversionintegrationeventsubscriptionattemptsviewget) | **GET** /api/v{apiVersion}/IntegrationEventSubscriptionAttempts/view | Provides a view model list of all SubscriptionAttempts
[**ApiVapiVersionIntegrationEventSubscriptionAttemptsViewIdGet**](IntegrationEventSubscriptionAttemptsApi.md#apivapiversionintegrationeventsubscriptionattemptsviewidget) | **GET** /api/v{apiVersion}/IntegrationEventSubscriptionAttempts/view/{id} | Provides a SubscriptionAttempt&#x27;s view model details for a particular SubscriptionAttempt id
[**GetIntegrationEventSubscriptionAttempt**](IntegrationEventSubscriptionAttemptsApi.md#getintegrationeventsubscriptionattempt) | **GET** /api/v{apiVersion}/IntegrationEventSubscriptionAttempts/{id} | Provides an IntegrationEventSubscriptionAttempt&#x27;s details for a particular id

<a name="apivapiversionintegrationeventsubscriptionattemptsget"></a>
# **ApiVapiVersionIntegrationEventSubscriptionAttemptsGet**
> IntegrationEventSubscriptionAttemptPaginatedList ApiVapiVersionIntegrationEventSubscriptionAttemptsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all IntegrationEventSubscriptionAttempts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventSubscriptionAttemptsGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionAttemptsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all IntegrationEventSubscriptionAttempts
                IntegrationEventSubscriptionAttemptPaginatedList result = apiInstance.ApiVapiVersionIntegrationEventSubscriptionAttemptsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionAttemptsApi.ApiVapiVersionIntegrationEventSubscriptionAttemptsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**IntegrationEventSubscriptionAttemptPaginatedList**](IntegrationEventSubscriptionAttemptPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionintegrationeventsubscriptionattemptsviewget"></a>
# **ApiVapiVersionIntegrationEventSubscriptionAttemptsViewGet**
> SubscriptionAttemptViewModelPaginatedList ApiVapiVersionIntegrationEventSubscriptionAttemptsViewGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a view model list of all SubscriptionAttempts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventSubscriptionAttemptsViewGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionAttemptsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a view model list of all SubscriptionAttempts
                SubscriptionAttemptViewModelPaginatedList result = apiInstance.ApiVapiVersionIntegrationEventSubscriptionAttemptsViewGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionAttemptsApi.ApiVapiVersionIntegrationEventSubscriptionAttemptsViewGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**SubscriptionAttemptViewModelPaginatedList**](SubscriptionAttemptViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionintegrationeventsubscriptionattemptsviewidget"></a>
# **ApiVapiVersionIntegrationEventSubscriptionAttemptsViewIdGet**
> SubscriptionAttemptViewModel ApiVapiVersionIntegrationEventSubscriptionAttemptsViewIdGet (string id, string apiVersion)

Provides a SubscriptionAttempt's view model details for a particular SubscriptionAttempt id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventSubscriptionAttemptsViewIdGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionAttemptsApi();
            var id = id_example;  // string | SubscriptionAttempt id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a SubscriptionAttempt's view model details for a particular SubscriptionAttempt id
                SubscriptionAttemptViewModel result = apiInstance.ApiVapiVersionIntegrationEventSubscriptionAttemptsViewIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionAttemptsApi.ApiVapiVersionIntegrationEventSubscriptionAttemptsViewIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| SubscriptionAttempt id | 
 **apiVersion** | **string**|  | 

### Return type

[**SubscriptionAttemptViewModel**](SubscriptionAttemptViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getintegrationeventsubscriptionattempt"></a>
# **GetIntegrationEventSubscriptionAttempt**
> IntegrationEventSubscriptionAttempt GetIntegrationEventSubscriptionAttempt (string id, string apiVersion)

Provides an IntegrationEventSubscriptionAttempt's details for a particular id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIntegrationEventSubscriptionAttemptExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionAttemptsApi();
            var id = id_example;  // string | IntegrationEventSubscriptionAttempt id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides an IntegrationEventSubscriptionAttempt's details for a particular id
                IntegrationEventSubscriptionAttempt result = apiInstance.GetIntegrationEventSubscriptionAttempt(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionAttemptsApi.GetIntegrationEventSubscriptionAttempt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| IntegrationEventSubscriptionAttempt id | 
 **apiVersion** | **string**|  | 

### Return type

[**IntegrationEventSubscriptionAttempt**](IntegrationEventSubscriptionAttempt.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
