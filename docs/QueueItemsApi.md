# IO.Swagger.Api.QueueItemsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionQueueItemsCommitPut**](QueueItemsApi.md#apivapiversionqueueitemscommitput) | **PUT** /api/v{apiVersion}/QueueItems/Commit | Commit queue item
[**ApiVapiVersionQueueItemsCountGet**](QueueItemsApi.md#apivapiversionqueueitemscountget) | **GET** /api/v{apiVersion}/QueueItems/count | Gets count of queue items in database
[**ApiVapiVersionQueueItemsDequeueGet**](QueueItemsApi.md#apivapiversionqueueitemsdequeueget) | **GET** /api/v{apiVersion}/QueueItems/Dequeue | Dequeue queue item
[**ApiVapiVersionQueueItemsEnqueuePost**](QueueItemsApi.md#apivapiversionqueueitemsenqueuepost) | **POST** /api/v{apiVersion}/QueueItems/Enqueue | Enqueue queue item
[**ApiVapiVersionQueueItemsExtendPut**](QueueItemsApi.md#apivapiversionqueueitemsextendput) | **PUT** /api/v{apiVersion}/QueueItems/Extend | Extend queue item
[**ApiVapiVersionQueueItemsGet**](QueueItemsApi.md#apivapiversionqueueitemsget) | **GET** /api/v{apiVersion}/QueueItems | Provides a list of all queue items
[**ApiVapiVersionQueueItemsIdDelete**](QueueItemsApi.md#apivapiversionqueueitemsiddelete) | **DELETE** /api/v{apiVersion}/QueueItems/{id} | Deletes a queue item with a specified id from the queue items
[**ApiVapiVersionQueueItemsIdPatch**](QueueItemsApi.md#apivapiversionqueueitemsidpatch) | **PATCH** /api/v{apiVersion}/QueueItems/{id} | Updates partial details of queue item
[**ApiVapiVersionQueueItemsIdPut**](QueueItemsApi.md#apivapiversionqueueitemsidput) | **PUT** /api/v{apiVersion}/QueueItems/{id} | 
[**ApiVapiVersionQueueItemsIdStatePut**](QueueItemsApi.md#apivapiversionqueueitemsidstateput) | **PUT** /api/v{apiVersion}/QueueItems/{id}/state | Updates the state and state message of the queue item
[**ApiVapiVersionQueueItemsRollbackPut**](QueueItemsApi.md#apivapiversionqueueitemsrollbackput) | **PUT** /api/v{apiVersion}/QueueItems/Rollback | Rollback queue item
[**ApiVapiVersionQueueItemsViewGet**](QueueItemsApi.md#apivapiversionqueueitemsviewget) | **GET** /api/v{apiVersion}/QueueItems/view | Provides a view model list of all queue items and corresponding file ids
[**ApiVapiVersionQueueItemsViewIdGet**](QueueItemsApi.md#apivapiversionqueueitemsviewidget) | **GET** /api/v{apiVersion}/QueueItems/view/{id} | Provides a queue item&#x27;s view model details for a particular queue item id
[**GetQueueItem**](QueueItemsApi.md#getqueueitem) | **GET** /api/v{apiVersion}/QueueItems/{id} | Provides queue item details for a particular queue item id

<a name="apivapiversionqueueitemscommitput"></a>
# **ApiVapiVersionQueueItemsCommitPut**
> IActionResult ApiVapiVersionQueueItemsCommitPut (string apiVersion, string transactionKey = null, string resultJSON = null)

Commit queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsCommitPutExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var apiVersion = apiVersion_example;  // string | 
            var transactionKey = transactionKey_example;  // string | Transaction key id to be verified (optional) 
            var resultJSON = resultJSON_example;  // string |  (optional) 

            try
            {
                // Commit queue item
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsCommitPut(apiVersion, transactionKey, resultJSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsCommitPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **transactionKey** | **string**| Transaction key id to be verified | [optional] 
 **resultJSON** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemscountget"></a>
# **ApiVapiVersionQueueItemsCountGet**
> void ApiVapiVersionQueueItemsCountGet (string apiVersion, string filter = null)

Gets count of queue items in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsCountGetExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of queue items in database
                apiInstance.ApiVapiVersionQueueItemsCountGet(apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsCountGet: " + e.Message );
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
<a name="apivapiversionqueueitemsdequeueget"></a>
# **ApiVapiVersionQueueItemsDequeueGet**
> QueueItemViewModel ApiVapiVersionQueueItemsDequeueGet (string apiVersion, string agentId = null, string queueId = null)

Dequeue queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsDequeueGetExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var apiVersion = apiVersion_example;  // string | 
            var agentId = agentId_example;  // string |  (optional) 
            var queueId = queueId_example;  // string |  (optional) 

            try
            {
                // Dequeue queue item
                QueueItemViewModel result = apiInstance.ApiVapiVersionQueueItemsDequeueGet(apiVersion, agentId, queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsDequeueGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **agentId** | **string**|  | [optional] 
 **queueId** | **string**|  | [optional] 

### Return type

[**QueueItemViewModel**](QueueItemViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsenqueuepost"></a>
# **ApiVapiVersionQueueItemsEnqueuePost**
> QueueItemViewModel ApiVapiVersionQueueItemsEnqueuePost (string apiVersion, QueueItem body = null)

Enqueue queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsEnqueuePostExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new QueueItem(); // QueueItem | Value of the queue item to be added (optional) 

            try
            {
                // Enqueue queue item
                QueueItemViewModel result = apiInstance.ApiVapiVersionQueueItemsEnqueuePost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsEnqueuePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**QueueItem**](QueueItem.md)| Value of the queue item to be added | [optional] 

### Return type

[**QueueItemViewModel**](QueueItemViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsextendput"></a>
# **ApiVapiVersionQueueItemsExtendPut**
> IActionResult ApiVapiVersionQueueItemsExtendPut (string apiVersion, string transactionKey = null)

Extend queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsExtendPutExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var apiVersion = apiVersion_example;  // string | 
            var transactionKey = transactionKey_example;  // string | Transaction key id to be verified (optional) 

            try
            {
                // Extend queue item
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsExtendPut(apiVersion, transactionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsExtendPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **transactionKey** | **string**| Transaction key id to be verified | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsget"></a>
# **ApiVapiVersionQueueItemsGet**
> QueueItemPaginatedList ApiVapiVersionQueueItemsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all queue items

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsGetExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all queue items
                QueueItemPaginatedList result = apiInstance.ApiVapiVersionQueueItemsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsGet: " + e.Message );
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

[**QueueItemPaginatedList**](QueueItemPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsiddelete"></a>
# **ApiVapiVersionQueueItemsIdDelete**
> IActionResult ApiVapiVersionQueueItemsIdDelete (string id, string apiVersion, string driveName = null)

Deletes a queue item with a specified id from the queue items

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var id = id_example;  // string | Queue item id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Deletes a queue item with a specified id from the queue items
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsIdDelete(id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Queue item id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsidpatch"></a>
# **ApiVapiVersionQueueItemsIdPatch**
> IActionResult ApiVapiVersionQueueItemsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var id = id_example;  // string | Queue item identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the queue item to be updated (optional) 

            try
            {
                // Updates partial details of queue item
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Queue item identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the queue item to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsidput"></a>
# **ApiVapiVersionQueueItemsIdPut**
> QueueItemViewModel ApiVapiVersionQueueItemsIdPut (string id, string apiVersion)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsIdPutExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                QueueItemViewModel result = apiInstance.ApiVapiVersionQueueItemsIdPut(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsIdPut: " + e.Message );
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

[**QueueItemViewModel**](QueueItemViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsidstateput"></a>
# **ApiVapiVersionQueueItemsIdStatePut**
> IActionResult ApiVapiVersionQueueItemsIdStatePut (string apiVersion, string id, string transactionKey = null, string state = null, string stateMessage = null, string errorCode = null, string errorMessage = null)

Updates the state and state message of the queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsIdStatePutExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var apiVersion = apiVersion_example;  // string | 
            var id = id_example;  // string | 
            var transactionKey = transactionKey_example;  // string |  (optional) 
            var state = state_example;  // string |  (optional) 
            var stateMessage = stateMessage_example;  // string |  (optional) 
            var errorCode = errorCode_example;  // string |  (optional) 
            var errorMessage = errorMessage_example;  // string |  (optional) 

            try
            {
                // Updates the state and state message of the queue item
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsIdStatePut(apiVersion, id, transactionKey, state, stateMessage, errorCode, errorMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsIdStatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **id** | **string**|  | 
 **transactionKey** | **string**|  | [optional] 
 **state** | **string**|  | [optional] 
 **stateMessage** | **string**|  | [optional] 
 **errorCode** | **string**|  | [optional] 
 **errorMessage** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsrollbackput"></a>
# **ApiVapiVersionQueueItemsRollbackPut**
> IActionResult ApiVapiVersionQueueItemsRollbackPut (string apiVersion, string transactionKey = null, string errorCode = null, string errorMessage = null, bool? isFatal = null)

Rollback queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsRollbackPutExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var apiVersion = apiVersion_example;  // string | 
            var transactionKey = transactionKey_example;  // string | Transaction key id to be verified (optional) 
            var errorCode = errorCode_example;  // string | Error code that has occurred while processing queue item (optional) 
            var errorMessage = errorMessage_example;  // string | Error message that has occurred while processing queue item (optional) 
            var isFatal = true;  // bool? | Limit to how many retries a queue item can have (optional)  (default to false)

            try
            {
                // Rollback queue item
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsRollbackPut(apiVersion, transactionKey, errorCode, errorMessage, isFatal);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsRollbackPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **transactionKey** | **string**| Transaction key id to be verified | [optional] 
 **errorCode** | **string**| Error code that has occurred while processing queue item | [optional] 
 **errorMessage** | **string**| Error message that has occurred while processing queue item | [optional] 
 **isFatal** | **bool?**| Limit to how many retries a queue item can have | [optional] [default to false]

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsviewget"></a>
# **ApiVapiVersionQueueItemsViewGet**
> AllQueueItemsViewModelPaginatedList ApiVapiVersionQueueItemsViewGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a view model list of all queue items and corresponding file ids

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsViewGetExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a view model list of all queue items and corresponding file ids
                AllQueueItemsViewModelPaginatedList result = apiInstance.ApiVapiVersionQueueItemsViewGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsViewGet: " + e.Message );
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

[**AllQueueItemsViewModelPaginatedList**](AllQueueItemsViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsviewidget"></a>
# **ApiVapiVersionQueueItemsViewIdGet**
> QueueItemViewModel ApiVapiVersionQueueItemsViewIdGet (string id, string apiVersion)

Provides a queue item's view model details for a particular queue item id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsViewIdGetExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var id = id_example;  // string | Queue item id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a queue item's view model details for a particular queue item id
                QueueItemViewModel result = apiInstance.ApiVapiVersionQueueItemsViewIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.ApiVapiVersionQueueItemsViewIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Queue item id | 
 **apiVersion** | **string**|  | 

### Return type

[**QueueItemViewModel**](QueueItemViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getqueueitem"></a>
# **GetQueueItem**
> QueueItemPaginatedList GetQueueItem (string id, string apiVersion)

Provides queue item details for a particular queue item id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQueueItemExample
    {
        public void main()
        {

            var apiInstance = new QueueItemsApi();
            var id = id_example;  // string | queue item id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides queue item details for a particular queue item id
                QueueItemPaginatedList result = apiInstance.GetQueueItem(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemsApi.GetQueueItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| queue item id | 
 **apiVersion** | **string**|  | 

### Return type

[**QueueItemPaginatedList**](QueueItemPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
