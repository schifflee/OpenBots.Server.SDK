# IO.Swagger.Api.IntegrationEventLogsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionIntegrationEventLogsExportPayloadIdGet**](IntegrationEventLogsApi.md#apivapiversionintegrationeventlogsexportpayloadidget) | **GET** /api/v{apiVersion}/IntegrationEventLogs/ExportPayload/{id} | Exports the JSONPayload for the specified IntegrationEventLog
[**ApiVapiVersionIntegrationEventLogsGet**](IntegrationEventLogsApi.md#apivapiversionintegrationeventlogsget) | **GET** /api/v{apiVersion}/IntegrationEventLogs | Provides a list of all IntegrationEventLogs
[**ApiVapiVersionIntegrationEventLogsIntegrationEventLogsLookupGet**](IntegrationEventLogsApi.md#apivapiversionintegrationeventlogsintegrationeventlogslookupget) | **GET** /api/v{apiVersion}/IntegrationEventLogs/IntegrationEventLogsLookup | Provides a list of all integration event logs by name
[**GetIntegrationEventLogs**](IntegrationEventLogsApi.md#getintegrationeventlogs) | **GET** /api/v{apiVersion}/IntegrationEventLogs/{id} | Provides an IntegrationEventLog&#x27;s details for a particular IntegrationEventLog id

<a name="apivapiversionintegrationeventlogsexportpayloadidget"></a>
# **ApiVapiVersionIntegrationEventLogsExportPayloadIdGet**
> void ApiVapiVersionIntegrationEventLogsExportPayloadIdGet (string id, string apiVersion)

Exports the JSONPayload for the specified IntegrationEventLog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventLogsExportPayloadIdGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventLogsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Exports the JSONPayload for the specified IntegrationEventLog
                apiInstance.ApiVapiVersionIntegrationEventLogsExportPayloadIdGet(id, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventLogsApi.ApiVapiVersionIntegrationEventLogsExportPayloadIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **apiVersion** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionintegrationeventlogsget"></a>
# **ApiVapiVersionIntegrationEventLogsGet**
> IntegrationEventLogPaginatedList ApiVapiVersionIntegrationEventLogsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all IntegrationEventLogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventLogsGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all IntegrationEventLogs
                IntegrationEventLogPaginatedList result = apiInstance.ApiVapiVersionIntegrationEventLogsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventLogsApi.ApiVapiVersionIntegrationEventLogsGet: " + e.Message );
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

[**IntegrationEventLogPaginatedList**](IntegrationEventLogPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionintegrationeventlogsintegrationeventlogslookupget"></a>
# **ApiVapiVersionIntegrationEventLogsIntegrationEventLogsLookupGet**
> List<IntegrationEventLogLookupViewModel> ApiVapiVersionIntegrationEventLogsIntegrationEventLogsLookupGet (string apiVersion)

Provides a list of all integration event logs by name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventLogsIntegrationEventLogsLookupGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventLogsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a list of all integration event logs by name
                List&lt;IntegrationEventLogLookupViewModel&gt; result = apiInstance.ApiVapiVersionIntegrationEventLogsIntegrationEventLogsLookupGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventLogsApi.ApiVapiVersionIntegrationEventLogsIntegrationEventLogsLookupGet: " + e.Message );
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

[**List<IntegrationEventLogLookupViewModel>**](IntegrationEventLogLookupViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getintegrationeventlogs"></a>
# **GetIntegrationEventLogs**
> IntegrationEventLog GetIntegrationEventLogs (string id, string apiVersion)

Provides an IntegrationEventLog's details for a particular IntegrationEventLog id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIntegrationEventLogsExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventLogsApi();
            var id = id_example;  // string | IntegrationEventLog id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides an IntegrationEventLog's details for a particular IntegrationEventLog id
                IntegrationEventLog result = apiInstance.GetIntegrationEventLogs(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventLogsApi.GetIntegrationEventLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| IntegrationEventLog id | 
 **apiVersion** | **string**|  | 

### Return type

[**IntegrationEventLog**](IntegrationEventLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
