# IO.Swagger.Api.QueuesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionQueuesCountGet**](QueuesApi.md#apivapiversionqueuescountget) | **GET** /api/v{apiVersion}/Queues/count | Gets count of queues in database
[**ApiVapiVersionQueuesGet**](QueuesApi.md#apivapiversionqueuesget) | **GET** /api/v{apiVersion}/Queues | Provides a list of all queues
[**ApiVapiVersionQueuesIdDelete**](QueuesApi.md#apivapiversionqueuesiddelete) | **DELETE** /api/v{apiVersion}/Queues/{id} | Deletes a queue with a specified id from the queues
[**ApiVapiVersionQueuesIdPatch**](QueuesApi.md#apivapiversionqueuesidpatch) | **PATCH** /api/v{apiVersion}/Queues/{id} | Updates partial details of queue
[**ApiVapiVersionQueuesIdPut**](QueuesApi.md#apivapiversionqueuesidput) | **PUT** /api/v{apiVersion}/Queues/{id} | Updates a queue
[**ApiVapiVersionQueuesPost**](QueuesApi.md#apivapiversionqueuespost) | **POST** /api/v{apiVersion}/Queues | Adds a new queue
[**GetQueue**](QueuesApi.md#getqueue) | **GET** /api/v{apiVersion}/Queues/{id} | Provides queue details for a particular queue id

<a name="apivapiversionqueuescountget"></a>
# **ApiVapiVersionQueuesCountGet**
> void ApiVapiVersionQueuesCountGet (string apiVersion, string filter = null)

Gets count of queues in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueuesCountGetExample
    {
        public void main()
        {

            var apiInstance = new QueuesApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of queues in database
                apiInstance.ApiVapiVersionQueuesCountGet(apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.ApiVapiVersionQueuesCountGet: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueuesget"></a>
# **ApiVapiVersionQueuesGet**
> QueuePaginatedList ApiVapiVersionQueuesGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all queues

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueuesGetExample
    {
        public void main()
        {

            var apiInstance = new QueuesApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all queues
                QueuePaginatedList result = apiInstance.ApiVapiVersionQueuesGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.ApiVapiVersionQueuesGet: " + e.Message );
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

[**QueuePaginatedList**](QueuePaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueuesiddelete"></a>
# **ApiVapiVersionQueuesIdDelete**
> IActionResult ApiVapiVersionQueuesIdDelete (string id, string apiVersion)

Deletes a queue with a specified id from the queues

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueuesIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new QueuesApi();
            var id = id_example;  // string | Queue id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes a queue with a specified id from the queues
                IActionResult result = apiInstance.ApiVapiVersionQueuesIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.ApiVapiVersionQueuesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Queue id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueuesidpatch"></a>
# **ApiVapiVersionQueuesIdPatch**
> IActionResult ApiVapiVersionQueuesIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of queue

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueuesIdPatchExample
    {
        public void main()
        {

            var apiInstance = new QueuesApi();
            var id = id_example;  // string | Queue identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the queue to be updated (optional) 

            try
            {
                // Updates partial details of queue
                IActionResult result = apiInstance.ApiVapiVersionQueuesIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.ApiVapiVersionQueuesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Queue identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the queue to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueuesidput"></a>
# **ApiVapiVersionQueuesIdPut**
> IActionResult ApiVapiVersionQueuesIdPut (string id, string apiVersion, QueueViewModel body = null)

Updates a queue

Provides an action to update an queue, when queue id and the new details of the queue are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueuesIdPutExample
    {
        public void main()
        {

            var apiInstance = new QueuesApi();
            var id = id_example;  // string | Queue id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new QueueViewModel(); // QueueViewModel | Queue details to be updated (optional) 

            try
            {
                // Updates a queue
                IActionResult result = apiInstance.ApiVapiVersionQueuesIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.ApiVapiVersionQueuesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Queue id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**QueueViewModel**](QueueViewModel.md)| Queue details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueuespost"></a>
# **ApiVapiVersionQueuesPost**
> Queue ApiVapiVersionQueuesPost (string apiVersion, Queue body = null)

Adds a new queue

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueuesPostExample
    {
        public void main()
        {

            var apiInstance = new QueuesApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new Queue(); // Queue |  (optional) 

            try
            {
                // Adds a new queue
                Queue result = apiInstance.ApiVapiVersionQueuesPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.ApiVapiVersionQueuesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**Queue**](Queue.md)|  | [optional] 

### Return type

[**Queue**](Queue.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getqueue"></a>
# **GetQueue**
> Queue GetQueue (string id, string apiVersion)

Provides queue details for a particular queue id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQueueExample
    {
        public void main()
        {

            var apiInstance = new QueuesApi();
            var id = id_example;  // string | Queue id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides queue details for a particular queue id
                Queue result = apiInstance.GetQueue(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.GetQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Queue id | 
 **apiVersion** | **string**|  | 

### Return type

[**Queue**](Queue.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
