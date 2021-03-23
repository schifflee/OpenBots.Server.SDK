# IO.Swagger.Api.AutomationsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionAutomationsAutomationIdUpdateParametersPost**](AutomationsApi.md#apivapiversionautomationsautomationidupdateparameterspost) | **POST** /api/v{apiVersion}/Automations/{automationId}/UpdateParameters | Update an Automation&#x27;s parameters
[**ApiVapiVersionAutomationsCountGet**](AutomationsApi.md#apivapiversionautomationscountget) | **GET** /api/v{apiVersion}/Automations/count | Gets count of Automations in database
[**ApiVapiVersionAutomationsGet**](AutomationsApi.md#apivapiversionautomationsget) | **GET** /api/v{apiVersion}/Automations | Provides a list of all Automations
[**ApiVapiVersionAutomationsGetLookupGet**](AutomationsApi.md#apivapiversionautomationsgetlookupget) | **GET** /api/v{apiVersion}/Automations/GetLookup | Lookup list of all Automations
[**ApiVapiVersionAutomationsIdDelete**](AutomationsApi.md#apivapiversionautomationsiddelete) | **DELETE** /api/v{apiVersion}/Automations/{id} | Delete Automation with a specified id from list of Automations
[**ApiVapiVersionAutomationsIdPatch**](AutomationsApi.md#apivapiversionautomationsidpatch) | **PATCH** /api/v{apiVersion}/Automations/{id} | Updates partial details of an Automation
[**ApiVapiVersionAutomationsIdPut**](AutomationsApi.md#apivapiversionautomationsidput) | **PUT** /api/v{apiVersion}/Automations/{id} | Update Automation entity
[**ApiVapiVersionAutomationsIdUpdatePost**](AutomationsApi.md#apivapiversionautomationsidupdatepost) | **POST** /api/v{apiVersion}/Automations/{id}/update | Update Automation with file
[**ApiVapiVersionAutomationsPost**](AutomationsApi.md#apivapiversionautomationspost) | **POST** /api/v{apiVersion}/Automations | Create a new Automation entity and file
[**ApiVapiVersionAutomationsViewGet**](AutomationsApi.md#apivapiversionautomationsviewget) | **GET** /api/v{apiVersion}/Automations/view | Provides a view model list of all Automations and corresponding Automation version information
[**ApiVapiVersionAutomationsViewIdGet**](AutomationsApi.md#apivapiversionautomationsviewidget) | **GET** /api/v{apiVersion}/Automations/view/{id} | Provides an Automation&#x27;s view model details for a particular Automation id
[**ExportAutomation**](AutomationsApi.md#exportautomation) | **GET** /api/v{apiVersion}/Automations/{id}/Export | Export/download an Automation
[**GetAutomation**](AutomationsApi.md#getautomation) | **GET** /api/v{apiVersion}/Automations/{id} | Get Automation by id

<a name="apivapiversionautomationsautomationidupdateparameterspost"></a>
# **ApiVapiVersionAutomationsAutomationIdUpdateParametersPost**
> List<AutomationParameter> ApiVapiVersionAutomationsAutomationIdUpdateParametersPost (string automationId, string apiVersion, List<AutomationParameter> body = null)

Update an Automation's parameters

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsAutomationIdUpdateParametersPostExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var automationId = automationId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<AutomationParameter>(); // List<AutomationParameter> |  (optional) 

            try
            {
                // Update an Automation's parameters
                List&lt;AutomationParameter&gt; result = apiInstance.ApiVapiVersionAutomationsAutomationIdUpdateParametersPost(automationId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsAutomationIdUpdateParametersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **automationId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;AutomationParameter&gt;**](AutomationParameter.md)|  | [optional] 

### Return type

[**List<AutomationParameter>**](AutomationParameter.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationscountget"></a>
# **ApiVapiVersionAutomationsCountGet**
> void ApiVapiVersionAutomationsCountGet (string apiVersion, string filter = null)

Gets count of Automations in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsCountGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of Automations in database
                apiInstance.ApiVapiVersionAutomationsCountGet(apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsCountGet: " + e.Message );
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
<a name="apivapiversionautomationsget"></a>
# **ApiVapiVersionAutomationsGet**
> AutomationPaginatedList ApiVapiVersionAutomationsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all Automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all Automations
                AutomationPaginatedList result = apiInstance.ApiVapiVersionAutomationsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsGet: " + e.Message );
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

[**AutomationPaginatedList**](AutomationPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationsgetlookupget"></a>
# **ApiVapiVersionAutomationsGetLookupGet**
> List<JobAutomationLookup> ApiVapiVersionAutomationsGetLookupGet (string apiVersion)

Lookup list of all Automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsGetLookupGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Lookup list of all Automations
                List&lt;JobAutomationLookup&gt; result = apiInstance.ApiVapiVersionAutomationsGetLookupGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsGetLookupGet: " + e.Message );
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

[**List<JobAutomationLookup>**](JobAutomationLookup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationsiddelete"></a>
# **ApiVapiVersionAutomationsIdDelete**
> IActionResult ApiVapiVersionAutomationsIdDelete (string id, string apiVersion, string driveName = null)

Delete Automation with a specified id from list of Automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var id = id_example;  // string | Automation id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Delete Automation with a specified id from list of Automations
                IActionResult result = apiInstance.ApiVapiVersionAutomationsIdDelete(id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Automation id to be deleted - throws bad request if null or empty Guid | 
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
<a name="apivapiversionautomationsidpatch"></a>
# **ApiVapiVersionAutomationsIdPatch**
> IActionResult ApiVapiVersionAutomationsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of an Automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var id = id_example;  // string | Automation identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the Automation to be updated (optional) 

            try
            {
                // Updates partial details of an Automation
                IActionResult result = apiInstance.ApiVapiVersionAutomationsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Automation identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the Automation to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationsidput"></a>
# **ApiVapiVersionAutomationsIdPut**
> IActionResult ApiVapiVersionAutomationsIdPut (string id, string apiVersion, AutomationViewModel body = null)

Update Automation entity

Provides an action to update an Automation, when Automation id and the new details of Automation are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsIdPutExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var id = id_example;  // string | Automation id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new AutomationViewModel(); // AutomationViewModel |  (optional) 

            try
            {
                // Update Automation entity
                IActionResult result = apiInstance.ApiVapiVersionAutomationsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Automation id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**AutomationViewModel**](AutomationViewModel.md)|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationsidupdatepost"></a>
# **ApiVapiVersionAutomationsIdUpdatePost**
> Automation ApiVapiVersionAutomationsIdUpdatePost (string id, string apiVersion)

Update Automation with file

Provides an action to update an Automation, when Automation id and the new details of Automation are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsIdUpdatePostExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var id = id_example;  // string | Automation id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Update Automation with file
                Automation result = apiInstance.ApiVapiVersionAutomationsIdUpdatePost(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsIdUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Automation id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 

### Return type

[**Automation**](Automation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationspost"></a>
# **ApiVapiVersionAutomationsPost**
> Automation ApiVapiVersionAutomationsPost (string apiVersion)

Create a new Automation entity and file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsPostExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Create a new Automation entity and file
                Automation result = apiInstance.ApiVapiVersionAutomationsPost(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsPost: " + e.Message );
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

[**Automation**](Automation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationsviewget"></a>
# **ApiVapiVersionAutomationsViewGet**
> AllAutomationsViewModelPaginatedList ApiVapiVersionAutomationsViewGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a view model list of all Automations and corresponding Automation version information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsViewGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a view model list of all Automations and corresponding Automation version information
                AllAutomationsViewModelPaginatedList result = apiInstance.ApiVapiVersionAutomationsViewGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsViewGet: " + e.Message );
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

[**AllAutomationsViewModelPaginatedList**](AllAutomationsViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationsviewidget"></a>
# **ApiVapiVersionAutomationsViewIdGet**
> AutomationViewModel ApiVapiVersionAutomationsViewIdGet (string id, string apiVersion)

Provides an Automation's view model details for a particular Automation id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationsViewIdGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var id = id_example;  // string | Automation id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides an Automation's view model details for a particular Automation id
                AutomationViewModel result = apiInstance.ApiVapiVersionAutomationsViewIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ApiVapiVersionAutomationsViewIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Automation id | 
 **apiVersion** | **string**|  | 

### Return type

[**AutomationViewModel**](AutomationViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportautomation"></a>
# **ExportAutomation**
> MemoryStream ExportAutomation (string id, string apiVersion, string driveName = null)

Export/download an Automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportAutomationExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Export/download an Automation
                MemoryStream result = apiInstance.ExportAutomation(id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.ExportAutomation: " + e.Message );
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
 **driveName** | **string**|  | [optional] 

### Return type

[**MemoryStream**](MemoryStream.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getautomation"></a>
# **GetAutomation**
> AutomationPaginatedList GetAutomation (string id, string apiVersion)

Get Automation by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAutomationExample
    {
        public void main()
        {

            var apiInstance = new AutomationsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Get Automation by id
                AutomationPaginatedList result = apiInstance.GetAutomation(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsApi.GetAutomation: " + e.Message );
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

[**AutomationPaginatedList**](AutomationPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
