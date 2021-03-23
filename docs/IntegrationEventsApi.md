# IO.Swagger.Api.IntegrationEventsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionIntegrationEventsGet**](IntegrationEventsApi.md#apivapiversionintegrationeventsget) | **GET** /api/v{apiVersion}/IntegrationEvents | Provides a list of all IntegrationEvents
[**ApiVapiVersionIntegrationEventsIntegrationEventLookupGet**](IntegrationEventsApi.md#apivapiversionintegrationeventsintegrationeventlookupget) | **GET** /api/v{apiVersion}/IntegrationEvents/IntegrationEventLookup | Provides a list of all IntegrationEvent Entity names
[**GetIntegrationEvent**](IntegrationEventsApi.md#getintegrationevent) | **GET** /api/v{apiVersion}/IntegrationEvents/{id} | Provides an IntegrationEvent&#x27;s details for a particular IntegrationEvent id

<a name="apivapiversionintegrationeventsget"></a>
# **ApiVapiVersionIntegrationEventsGet**
> IntegrationEventPaginatedList ApiVapiVersionIntegrationEventsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all IntegrationEvents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventsGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all IntegrationEvents
                IntegrationEventPaginatedList result = apiInstance.ApiVapiVersionIntegrationEventsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventsApi.ApiVapiVersionIntegrationEventsGet: " + e.Message );
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

[**IntegrationEventPaginatedList**](IntegrationEventPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionintegrationeventsintegrationeventlookupget"></a>
# **ApiVapiVersionIntegrationEventsIntegrationEventLookupGet**
> List<IntegrationEventEntitiesLookupViewModel> ApiVapiVersionIntegrationEventsIntegrationEventLookupGet (string apiVersion)

Provides a list of all IntegrationEvent Entity names

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventsIntegrationEventLookupGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a list of all IntegrationEvent Entity names
                List&lt;IntegrationEventEntitiesLookupViewModel&gt; result = apiInstance.ApiVapiVersionIntegrationEventsIntegrationEventLookupGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventsApi.ApiVapiVersionIntegrationEventsIntegrationEventLookupGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 

### Return type

[**List<IntegrationEventEntitiesLookupViewModel>**](IntegrationEventEntitiesLookupViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getintegrationevent"></a>
# **GetIntegrationEvent**
> IntegrationEvent GetIntegrationEvent (string id, string apiVersion)

Provides an IntegrationEvent's details for a particular IntegrationEvent id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIntegrationEventExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventsApi();
            var id = id_example;  // string | IntegrationEvent id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides an IntegrationEvent's details for a particular IntegrationEvent id
                IntegrationEvent result = apiInstance.GetIntegrationEvent(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventsApi.GetIntegrationEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| IntegrationEvent id | 
 **apiVersion** | **string**|  | 

### Return type

[**IntegrationEvent**](IntegrationEvent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
