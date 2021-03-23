# IO.Swagger.Api.QueueItemAttachmentsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsCountGet**](QueueItemAttachmentsApi.md#apivapiversionqueueitemsqueueitemidqueueitemattachmentscountget) | **GET** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments/count | Gets count of queue item attachments related to a queue item in the database
[**ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsDelete**](QueueItemAttachmentsApi.md#apivapiversionqueueitemsqueueitemidqueueitemattachmentsdelete) | **DELETE** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments | Delete all queue item attachments with a specified queue item id from list of queue item attachments
[**ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsFilesPost**](QueueItemAttachmentsApi.md#apivapiversionqueueitemsqueueitemidqueueitemattachmentsfilespost) | **POST** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments/files | Adds queue item attachments using existing files to the existing queue item attachments
[**ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsGet**](QueueItemAttachmentsApi.md#apivapiversionqueueitemsqueueitemidqueueitemattachmentsget) | **GET** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments | Provides all queue item attachments for a queue item
[**ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdDelete**](QueueItemAttachmentsApi.md#apivapiversionqueueitemsqueueitemidqueueitemattachmentsiddelete) | **DELETE** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments/{id} | Delete specific queue item attachment from list of queue item attachments
[**ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdPatch**](QueueItemAttachmentsApi.md#apivapiversionqueueitemsqueueitemidqueueitemattachmentsidpatch) | **PATCH** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments/{id} | Updates partial details of queue item attachment
[**ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdUpdatePut**](QueueItemAttachmentsApi.md#apivapiversionqueueitemsqueueitemidqueueitemattachmentsidupdateput) | **PUT** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments/{id}/Update | Updates a queue item attachment with file
[**ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsPost**](QueueItemAttachmentsApi.md#apivapiversionqueueitemsqueueitemidqueueitemattachmentspost) | **POST** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments | Attach files to a queue item
[**ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsViewGet**](QueueItemAttachmentsApi.md#apivapiversionqueueitemsqueueitemidqueueitemattachmentsviewget) | **GET** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments/view | Provides all queue item attachments view for a queue item
[**ExportQueueItemAttachment**](QueueItemAttachmentsApi.md#exportqueueitemattachment) | **GET** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments/{id}/Export | Export/download a queue item attachment file
[**GetQueueItemAttachments**](QueueItemAttachmentsApi.md#getqueueitemattachments) | **GET** /api/v{apiVersion}/QueueItems/{queueItemId}/QueueItemAttachments/{id} | Get queue item attachment by id

<a name="apivapiversionqueueitemsqueueitemidqueueitemattachmentscountget"></a>
# **ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsCountGet**
> void ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsCountGet (string queueItemId, string apiVersion, string filter = null)

Gets count of queue item attachments related to a queue item in the database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsCountGetExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var queueItemId = queueItemId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of queue item attachments related to a queue item in the database
                apiInstance.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsCountGet(queueItemId, apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueItemId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsqueueitemidqueueitemattachmentsdelete"></a>
# **ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsDelete**
> IActionResult ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsDelete (string queueItemId, string apiVersion, string driveName = null)

Delete all queue item attachments with a specified queue item id from list of queue item attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsDeleteExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var queueItemId = queueItemId_example;  // string | Queue item id to delete all queue item attachments from - throws bad request if null or empty Guid/
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Delete all queue item attachments with a specified queue item id from list of queue item attachments
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsDelete(queueItemId, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueItemId** | **string**| Queue item id to delete all queue item attachments from - throws bad request if null or empty Guid/ | 
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
<a name="apivapiversionqueueitemsqueueitemidqueueitemattachmentsfilespost"></a>
# **ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsFilesPost**
> IActionResult ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsFilesPost (string queueItemId, string apiVersion, List<string> body = null, string driveName = null)

Adds queue item attachments using existing files to the existing queue item attachments

Adds the queue item attachments with unique queue item attachment ids to the existing queue item attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsFilesPostExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var queueItemId = queueItemId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<string>(); // List<string> |  (optional) 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Adds queue item attachments using existing files to the existing queue item attachments
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsFilesPost(queueItemId, apiVersion, body, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsFilesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueItemId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **driveName** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsqueueitemidqueueitemattachmentsget"></a>
# **ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsGet**
> IActionResult ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsGet (string queueItemId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides all queue item attachments for a queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsGetExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var queueItemId = queueItemId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides all queue item attachments for a queue item
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsGet(queueItemId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueItemId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsqueueitemidqueueitemattachmentsiddelete"></a>
# **ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdDelete**
> IActionResult ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdDelete (string id, string apiVersion, string queueItemId, string driveName = null)

Delete specific queue item attachment from list of queue item attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var id = id_example;  // string | Queue item attachment id to be deleted - throws bad request if null or empty Guid/
            var apiVersion = apiVersion_example;  // string | 
            var queueItemId = queueItemId_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Delete specific queue item attachment from list of queue item attachments
                IActionResult result = apiInstance.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdDelete(id, apiVersion, queueItemId, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Queue item attachment id to be deleted - throws bad request if null or empty Guid/ | 
 **apiVersion** | **string**|  | 
 **queueItemId** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsqueueitemidqueueitemattachmentsidpatch"></a>
# **ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdPatch**
> EmailAttachment ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdPatch (string id, string apiVersion, string queueItemId, List<Operation> body = null)

Updates partial details of queue item attachment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var queueItemId = queueItemId_example;  // string | 
            var body = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Updates partial details of queue item attachment
                EmailAttachment result = apiInstance.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdPatch(id, apiVersion, queueItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdPatch: " + e.Message );
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
 **queueItemId** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)|  | [optional] 

### Return type

[**EmailAttachment**](EmailAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsqueueitemidqueueitemattachmentsidupdateput"></a>
# **ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdUpdatePut**
> QueueItemAttachment ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdUpdatePut (string queueItemId, string id, string apiVersion, string driveName = null)

Updates a queue item attachment with file

Provides an action to update a queue item attachment with file, when queue item attachment id and the new details of the queue item attachment are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdUpdatePutExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var queueItemId = queueItemId_example;  // string | Queue item id
            var id = id_example;  // string | Queue item attachment id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Updates a queue item attachment with file
                QueueItemAttachment result = apiInstance.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdUpdatePut(queueItemId, id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsIdUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueItemId** | **string**| Queue item id | 
 **id** | **string**| Queue item attachment id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**QueueItemAttachment**](QueueItemAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsqueueitemidqueueitemattachmentspost"></a>
# **ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsPost**
> QueueItemAttachment ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsPost (string queueItemId, string apiVersion, string driveName = null)

Attach files to a queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsPostExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var queueItemId = queueItemId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Attach files to a queue item
                QueueItemAttachment result = apiInstance.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsPost(queueItemId, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueItemId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**QueueItemAttachment**](QueueItemAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionqueueitemsqueueitemidqueueitemattachmentsviewget"></a>
# **ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsViewGet**
> AllQueueItemAttachmentsViewModelPaginatedList ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsViewGet (string queueItemId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides all queue item attachments view for a queue item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsViewGetExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var queueItemId = queueItemId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides all queue item attachments view for a queue item
                AllQueueItemAttachmentsViewModelPaginatedList result = apiInstance.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsViewGet(queueItemId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ApiVapiVersionQueueItemsQueueItemIdQueueItemAttachmentsViewGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueItemId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**AllQueueItemAttachmentsViewModelPaginatedList**](AllQueueItemAttachmentsViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportqueueitemattachment"></a>
# **ExportQueueItemAttachment**
> MemoryStream ExportQueueItemAttachment (string id, string apiVersion, string queueItemId, string driveName = null)

Export/download a queue item attachment file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportQueueItemAttachmentExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var queueItemId = queueItemId_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Export/download a queue item attachment file
                MemoryStream result = apiInstance.ExportQueueItemAttachment(id, apiVersion, queueItemId, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.ExportQueueItemAttachment: " + e.Message );
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
 **queueItemId** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**MemoryStream**](MemoryStream.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getqueueitemattachments"></a>
# **GetQueueItemAttachments**
> QueueItemAttachmentPaginatedList GetQueueItemAttachments (string id, string apiVersion, string queueItemId)

Get queue item attachment by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQueueItemAttachmentsExample
    {
        public void main()
        {

            var apiInstance = new QueueItemAttachmentsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var queueItemId = queueItemId_example;  // string | 

            try
            {
                // Get queue item attachment by id
                QueueItemAttachmentPaginatedList result = apiInstance.GetQueueItemAttachments(id, apiVersion, queueItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueItemAttachmentsApi.GetQueueItemAttachments: " + e.Message );
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
 **queueItemId** | **string**|  | 

### Return type

[**QueueItemAttachmentPaginatedList**](QueueItemAttachmentPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
