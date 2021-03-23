# IO.Swagger.Api.AgentGroupsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionAgentGroupsCountGet**](AgentGroupsApi.md#apivapiversionagentgroupscountget) | **GET** /api/v{apiVersion}/AgentGroups/Count | Provides a count of AgentGroups
[**ApiVapiVersionAgentGroupsGet**](AgentGroupsApi.md#apivapiversionagentgroupsget) | **GET** /api/v{apiVersion}/AgentGroups | Provides a list of all AgentGroups
[**ApiVapiVersionAgentGroupsIdDelete**](AgentGroupsApi.md#apivapiversionagentgroupsiddelete) | **DELETE** /api/v{apiVersion}/AgentGroups/{id} | Deletes an AgentGroup with a specified id
[**ApiVapiVersionAgentGroupsIdPatch**](AgentGroupsApi.md#apivapiversionagentgroupsidpatch) | **PATCH** /api/v{apiVersion}/AgentGroups/{id} | Updates partial details of an AgentGroup
[**ApiVapiVersionAgentGroupsIdPut**](AgentGroupsApi.md#apivapiversionagentgroupsidput) | **PUT** /api/v{apiVersion}/AgentGroups/{id} | Updates an AgentGroup
[**ApiVapiVersionAgentGroupsIdUpdateGroupMembersPut**](AgentGroupsApi.md#apivapiversionagentgroupsidupdategroupmembersput) | **PUT** /api/v{apiVersion}/AgentGroups/{id}/UpdateGroupMembers | Updates the AgentGroupMembers of the specified AgentGroup id
[**ApiVapiVersionAgentGroupsPost**](AgentGroupsApi.md#apivapiversionagentgroupspost) | **POST** /api/v{apiVersion}/AgentGroups | 
[**ApiVapiVersionAgentGroupsViewIdGet**](AgentGroupsApi.md#apivapiversionagentgroupsviewidget) | **GET** /api/v{apiVersion}/AgentGroups/view/{id} | Provides an AgentGroup&#x27;s view model details for a particular AgentGroup id
[**GetAgentGroup**](AgentGroupsApi.md#getagentgroup) | **GET** /api/v{apiVersion}/AgentGroups/{id} | 

<a name="apivapiversionagentgroupscountget"></a>
# **ApiVapiVersionAgentGroupsCountGet**
> int? ApiVapiVersionAgentGroupsCountGet (string apiVersion, string filter = null)

Provides a count of AgentGroups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentGroupsCountGetExample
    {
        public void main()
        {

            var apiInstance = new AgentGroupsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Provides a count of AgentGroups
                int? result = apiInstance.ApiVapiVersionAgentGroupsCountGet(apiVersion, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentGroupsApi.ApiVapiVersionAgentGroupsCountGet: " + e.Message );
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
<a name="apivapiversionagentgroupsget"></a>
# **ApiVapiVersionAgentGroupsGet**
> AgentGroupPaginatedList ApiVapiVersionAgentGroupsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all AgentGroups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentGroupsGetExample
    {
        public void main()
        {

            var apiInstance = new AgentGroupsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all AgentGroups
                AgentGroupPaginatedList result = apiInstance.ApiVapiVersionAgentGroupsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentGroupsApi.ApiVapiVersionAgentGroupsGet: " + e.Message );
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

[**AgentGroupPaginatedList**](AgentGroupPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentgroupsiddelete"></a>
# **ApiVapiVersionAgentGroupsIdDelete**
> IActionResult ApiVapiVersionAgentGroupsIdDelete (string id, string apiVersion)

Deletes an AgentGroup with a specified id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentGroupsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new AgentGroupsApi();
            var id = id_example;  // string | AgentGroup id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes an AgentGroup with a specified id
                IActionResult result = apiInstance.ApiVapiVersionAgentGroupsIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentGroupsApi.ApiVapiVersionAgentGroupsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| AgentGroup id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentgroupsidpatch"></a>
# **ApiVapiVersionAgentGroupsIdPatch**
> IActionResult ApiVapiVersionAgentGroupsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of an AgentGroup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentGroupsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new AgentGroupsApi();
            var id = id_example;  // string | AgentGroup identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the AgentGroup to be updated (optional) 

            try
            {
                // Updates partial details of an AgentGroup
                IActionResult result = apiInstance.ApiVapiVersionAgentGroupsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentGroupsApi.ApiVapiVersionAgentGroupsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| AgentGroup identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the AgentGroup to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentgroupsidput"></a>
# **ApiVapiVersionAgentGroupsIdPut**
> IActionResult ApiVapiVersionAgentGroupsIdPut (string id, string apiVersion, AgentGroup body = null)

Updates an AgentGroup

Provides an action to update an AgentGroup, when AgentGroup id and the new details of AgentGroup are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentGroupsIdPutExample
    {
        public void main()
        {

            var apiInstance = new AgentGroupsApi();
            var id = id_example;  // string | AgentGroup id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new AgentGroup(); // AgentGroup | AgentGroup details to be updated (optional) 

            try
            {
                // Updates an AgentGroup
                IActionResult result = apiInstance.ApiVapiVersionAgentGroupsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentGroupsApi.ApiVapiVersionAgentGroupsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| AgentGroup id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**AgentGroup**](AgentGroup.md)| AgentGroup details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentgroupsidupdategroupmembersput"></a>
# **ApiVapiVersionAgentGroupsIdUpdateGroupMembersPut**
> Agent ApiVapiVersionAgentGroupsIdUpdateGroupMembersPut (string id, string apiVersion, List<AgentGroupMember> body = null)

Updates the AgentGroupMembers of the specified AgentGroup id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentGroupsIdUpdateGroupMembersPutExample
    {
        public void main()
        {

            var apiInstance = new AgentGroupsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<AgentGroupMember>(); // List<AgentGroupMember> |  (optional) 

            try
            {
                // Updates the AgentGroupMembers of the specified AgentGroup id
                Agent result = apiInstance.ApiVapiVersionAgentGroupsIdUpdateGroupMembersPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentGroupsApi.ApiVapiVersionAgentGroupsIdUpdateGroupMembersPut: " + e.Message );
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
 **body** | [**List&lt;AgentGroupMember&gt;**](AgentGroupMember.md)|  | [optional] 

### Return type

[**Agent**](Agent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentgroupspost"></a>
# **ApiVapiVersionAgentGroupsPost**
> Agent ApiVapiVersionAgentGroupsPost (string apiVersion, AgentGroup body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentGroupsPostExample
    {
        public void main()
        {

            var apiInstance = new AgentGroupsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new AgentGroup(); // AgentGroup |  (optional) 

            try
            {
                Agent result = apiInstance.ApiVapiVersionAgentGroupsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentGroupsApi.ApiVapiVersionAgentGroupsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**AgentGroup**](AgentGroup.md)|  | [optional] 

### Return type

[**Agent**](Agent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentgroupsviewidget"></a>
# **ApiVapiVersionAgentGroupsViewIdGet**
> AgentGroupViewModelPaginatedList ApiVapiVersionAgentGroupsViewIdGet (string id, string apiVersion)

Provides an AgentGroup's view model details for a particular AgentGroup id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentGroupsViewIdGetExample
    {
        public void main()
        {

            var apiInstance = new AgentGroupsApi();
            var id = id_example;  // string | Specifies the id of the AgentGroup
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides an AgentGroup's view model details for a particular AgentGroup id
                AgentGroupViewModelPaginatedList result = apiInstance.ApiVapiVersionAgentGroupsViewIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentGroupsApi.ApiVapiVersionAgentGroupsViewIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Specifies the id of the AgentGroup | 
 **apiVersion** | **string**|  | 

### Return type

[**AgentGroupViewModelPaginatedList**](AgentGroupViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getagentgroup"></a>
# **GetAgentGroup**
> AgentGroup GetAgentGroup (string id, string apiVersion)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAgentGroupExample
    {
        public void main()
        {

            var apiInstance = new AgentGroupsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                AgentGroup result = apiInstance.GetAgentGroup(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentGroupsApi.GetAgentGroup: " + e.Message );
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

[**AgentGroup**](AgentGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
