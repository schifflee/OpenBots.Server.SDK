# IO.Swagger.Api.AutomationExecutionLogsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionAutomationExecutionLogsCountGet**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogscountget) | **GET** /api/v{apiVersion}/AutomationExecutionLogs/Count | Provides a Count of AutomationExecutionLogs
[**ApiVapiVersionAutomationExecutionLogsGet**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogsget) | **GET** /api/v{apiVersion}/AutomationExecutionLogs | Provides a list of all AutomationExecutionLogs
[**ApiVapiVersionAutomationExecutionLogsIdDelete**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogsiddelete) | **DELETE** /api/v{apiVersion}/AutomationExecutionLogs/{id} | Deletes a AutomationExecutionLog with a specified id from the AutomationExecutionLog.
[**ApiVapiVersionAutomationExecutionLogsIdEndAutomationPut**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogsidendautomationput) | **PUT** /api/v{apiVersion}/AutomationExecutionLogs/{id}/EndAutomation | Agent is able to update a AutomationExecutionLog End status
[**ApiVapiVersionAutomationExecutionLogsIdPatch**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogsidpatch) | **PATCH** /api/v{apiVersion}/AutomationExecutionLogs/{id} | Updates partial details of AutomationExecutionLog.
[**ApiVapiVersionAutomationExecutionLogsIdPut**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogsidput) | **PUT** /api/v{apiVersion}/AutomationExecutionLogs/{id} | Updates a AutomationExecutionLog
[**ApiVapiVersionAutomationExecutionLogsPost**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogspost) | **POST** /api/v{apiVersion}/AutomationExecutionLogs | Adds a new AutomationExecutionLog to the existing AutomationExecutionLogs
[**ApiVapiVersionAutomationExecutionLogsStartAutomationPost**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogsstartautomationpost) | **POST** /api/v{apiVersion}/AutomationExecutionLogs/StartAutomation | Allows Agent to add a new AutomationExecutionLog to the existing AutomationExecutionLogs
[**ApiVapiVersionAutomationExecutionLogsViewGet**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogsviewget) | **GET** /api/v{apiVersion}/AutomationExecutionLogs/view | Provides a viewmodel list of all AutomationExecutionLogs
[**ApiVapiVersionAutomationExecutionLogsViewIdGet**](AutomationExecutionLogsApi.md#apivapiversionautomationexecutionlogsviewidget) | **GET** /api/v{apiVersion}/AutomationExecutionLogs/View/{id} | Provides a AutomationExecution&#x27;s details for a particular AutomationExecution id
[**GetAutomationExecutionLog**](AutomationExecutionLogsApi.md#getautomationexecutionlog) | **GET** /api/v{apiVersion}/AutomationExecutionLogs/{id} | Provides a AutomationExecutionLog&#x27;s details for a particular AutomationExecutionLog Id.

<a name="apivapiversionautomationexecutionlogscountget"></a>
# **ApiVapiVersionAutomationExecutionLogsCountGet**
> int? ApiVapiVersionAutomationExecutionLogsCountGet (string apiVersion, string filter = null)

Provides a Count of AutomationExecutionLogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsCountGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationExecutionLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Provides a Count of AutomationExecutionLogs
                int? result = apiInstance.ApiVapiVersionAutomationExecutionLogsCountGet(apiVersion, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsCountGet: " + e.Message );
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

**int?**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationexecutionlogsget"></a>
# **ApiVapiVersionAutomationExecutionLogsGet**
> AutomationExecutionLogPaginatedList ApiVapiVersionAutomationExecutionLogsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all AutomationExecutionLogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationExecutionLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all AutomationExecutionLogs
                AutomationExecutionLogPaginatedList result = apiInstance.ApiVapiVersionAutomationExecutionLogsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsGet: " + e.Message );
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

[**AutomationExecutionLogPaginatedList**](AutomationExecutionLogPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationexecutionlogsiddelete"></a>
# **ApiVapiVersionAutomationExecutionLogsIdDelete**
> IActionResult ApiVapiVersionAutomationExecutionLogsIdDelete (string id, string apiVersion)

Deletes a AutomationExecutionLog with a specified id from the AutomationExecutionLog.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new AutomationExecutionLogsApi();
            var id = id_example;  // string | AutomationExecutionLog ID to be deleted- throws BadRequest if null or empty Guid/
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes a AutomationExecutionLog with a specified id from the AutomationExecutionLog.
                IActionResult result = apiInstance.ApiVapiVersionAutomationExecutionLogsIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| AutomationExecutionLog ID to be deleted- throws BadRequest if null or empty Guid/ | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationexecutionlogsidendautomationput"></a>
# **ApiVapiVersionAutomationExecutionLogsIdEndAutomationPut**
> IActionResult ApiVapiVersionAutomationExecutionLogsIdEndAutomationPut (string id, string apiVersion, AutomationExecutionLog body = null)

Agent is able to update a AutomationExecutionLog End status

Provides an action to update a AutomationExecutionLog, when AutomationExecutionLog id and the new details of AutomationExecutionLog are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsIdEndAutomationPutExample
    {
        public void main()
        {
            var apiInstance = new AutomationExecutionLogsApi();
            var id = id_example;  // string | AutomationExecutionLog Id,produces Bad request if Id is null or Id's don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new AutomationExecutionLog(); // AutomationExecutionLog | AutomationExecutionLog details to be updated (optional) 

            try
            {
                // Agent is able to update a AutomationExecutionLog End status
                IActionResult result = apiInstance.ApiVapiVersionAutomationExecutionLogsIdEndAutomationPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsIdEndAutomationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| AutomationExecutionLog Id,produces Bad request if Id is null or Id&#x27;s don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**AutomationExecutionLog**](AutomationExecutionLog.md)| AutomationExecutionLog details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationexecutionlogsidpatch"></a>
# **ApiVapiVersionAutomationExecutionLogsIdPatch**
> IActionResult ApiVapiVersionAutomationExecutionLogsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of AutomationExecutionLog.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new AutomationExecutionLogsApi();
            var id = id_example;  // string | AutomationExecutionLog identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the AutomationExecutionLog to be updated. (optional) 

            try
            {
                // Updates partial details of AutomationExecutionLog.
                IActionResult result = apiInstance.ApiVapiVersionAutomationExecutionLogsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| AutomationExecutionLog identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the AutomationExecutionLog to be updated. | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationexecutionlogsidput"></a>
# **ApiVapiVersionAutomationExecutionLogsIdPut**
> IActionResult ApiVapiVersionAutomationExecutionLogsIdPut (string id, string apiVersion, AutomationExecutionLog body = null)

Updates a AutomationExecutionLog

Provides an action to update a AutomationExecutionLog, when AutomationExecutionLog id and the new details of AutomationExecutionLog are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsIdPutExample
    {
        public void main()
        {

            var apiInstance = new AutomationExecutionLogsApi();
            var id = id_example;  // string | AutomationExecutionLog Id,produces Bad request if Id is null or Id's don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new AutomationExecutionLog(); // AutomationExecutionLog | AutomationExecutionLog details to be updated (optional) 

            try
            {
                // Updates a AutomationExecutionLog
                IActionResult result = apiInstance.ApiVapiVersionAutomationExecutionLogsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| AutomationExecutionLog Id,produces Bad request if Id is null or Id&#x27;s don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**AutomationExecutionLog**](AutomationExecutionLog.md)| AutomationExecutionLog details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationexecutionlogspost"></a>
# **ApiVapiVersionAutomationExecutionLogsPost**
> AutomationExecutionLog ApiVapiVersionAutomationExecutionLogsPost (string apiVersion, AutomationExecutionLog body = null)

Adds a new AutomationExecutionLog to the existing AutomationExecutionLogs

Adds the AutomationExecutionLog with unique AutomationExecutionLog Id to the existing AutomationExecutionLogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsPostExample
    {
        public void main()
        {

            var apiInstance = new AutomationExecutionLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new AutomationExecutionLog(); // AutomationExecutionLog |  (optional) 

            try
            {
                // Adds a new AutomationExecutionLog to the existing AutomationExecutionLogs
                AutomationExecutionLog result = apiInstance.ApiVapiVersionAutomationExecutionLogsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**AutomationExecutionLog**](AutomationExecutionLog.md)|  | [optional] 

### Return type

[**AutomationExecutionLog**](AutomationExecutionLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationexecutionlogsstartautomationpost"></a>
# **ApiVapiVersionAutomationExecutionLogsStartAutomationPost**
> AutomationExecutionLog ApiVapiVersionAutomationExecutionLogsStartAutomationPost (string apiVersion, AutomationExecutionLog body = null)

Allows Agent to add a new AutomationExecutionLog to the existing AutomationExecutionLogs

Agent is able to Add the AutomationExecutionLog if the Agent is Connected

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsStartAutomationPostExample
    {
        public void main()
        {
            var apiInstance = new AutomationExecutionLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new AutomationExecutionLog(); // AutomationExecutionLog |  (optional) 

            try
            {
                // Allows Agent to add a new AutomationExecutionLog to the existing AutomationExecutionLogs
                AutomationExecutionLog result = apiInstance.ApiVapiVersionAutomationExecutionLogsStartAutomationPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsStartAutomationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**AutomationExecutionLog**](AutomationExecutionLog.md)|  | [optional] 

### Return type

[**AutomationExecutionLog**](AutomationExecutionLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationexecutionlogsviewget"></a>
# **ApiVapiVersionAutomationExecutionLogsViewGet**
> AutomationExecutionViewModelPaginatedList ApiVapiVersionAutomationExecutionLogsViewGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a viewmodel list of all AutomationExecutionLogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsViewGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationExecutionLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a viewmodel list of all AutomationExecutionLogs
                AutomationExecutionViewModelPaginatedList result = apiInstance.ApiVapiVersionAutomationExecutionLogsViewGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsViewGet: " + e.Message );
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

[**AutomationExecutionViewModelPaginatedList**](AutomationExecutionViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationexecutionlogsviewidget"></a>
# **ApiVapiVersionAutomationExecutionLogsViewIdGet**
> AutomationExecutionViewModel ApiVapiVersionAutomationExecutionLogsViewIdGet (string id, string apiVersion)

Provides a AutomationExecution's details for a particular AutomationExecution id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationExecutionLogsViewIdGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationExecutionLogsApi();
            var id = id_example;  // string | AutomationExecution id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a AutomationExecution's details for a particular AutomationExecution id
                AutomationExecutionViewModel result = apiInstance.ApiVapiVersionAutomationExecutionLogsViewIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.ApiVapiVersionAutomationExecutionLogsViewIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| AutomationExecution id | 
 **apiVersion** | **string**|  | 

### Return type

[**AutomationExecutionViewModel**](AutomationExecutionViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getautomationexecutionlog"></a>
# **GetAutomationExecutionLog**
> AutomationExecutionLog GetAutomationExecutionLog (string id, string apiVersion)

Provides a AutomationExecutionLog's details for a particular AutomationExecutionLog Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAutomationExecutionLogExample
    {
        public void main()
        {

            var apiInstance = new AutomationExecutionLogsApi();
            var id = id_example;  // string | AutomationExecutionLog id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a AutomationExecutionLog's details for a particular AutomationExecutionLog Id.
                AutomationExecutionLog result = apiInstance.GetAutomationExecutionLog(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationExecutionLogsApi.GetAutomationExecutionLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| AutomationExecutionLog id | 
 **apiVersion** | **string**|  | 

### Return type

[**AutomationExecutionLog**](AutomationExecutionLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
