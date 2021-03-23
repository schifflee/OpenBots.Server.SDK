# IO.Swagger.Api.AgentsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionAgentsAgentIDConnectPatch**](AgentsApi.md#apivapiversionagentsagentidconnectpatch) | **PATCH** /api/v{apiVersion}/Agents/{agentID}/Connect | Provides an agent id and name if the provided machine matches an agent and updates the isConnected field
[**ApiVapiVersionAgentsAgentIDDisconnectPatch**](AgentsApi.md#apivapiversionagentsagentiddisconnectpatch) | **PATCH** /api/v{apiVersion}/Agents/{agentID}/Disconnect | Updates the isConnected field if the disconnect details are correct
[**ApiVapiVersionAgentsAgentIdAddHeartbeatPost**](AgentsApi.md#apivapiversionagentsagentidaddheartbeatpost) | **POST** /api/v{apiVersion}/Agents/{agentId}/AddHeartbeat | Creates a new heartbeat for the specified AgentId
[**ApiVapiVersionAgentsAgentIdGetAllGroupMembersGet**](AgentsApi.md#apivapiversionagentsagentidgetallgroupmembersget) | **GET** /api/v{apiVersion}/Agents/{agentId}/GetAllGroupMembers | Provides a list of all AgentGroupMembers for the specified Agent
[**ApiVapiVersionAgentsCountGet**](AgentsApi.md#apivapiversionagentscountget) | **GET** /api/v{apiVersion}/Agents/Count | Provides a count of agents
[**ApiVapiVersionAgentsGet**](AgentsApi.md#apivapiversionagentsget) | **GET** /api/v{apiVersion}/Agents | Provides a list of all Agents
[**ApiVapiVersionAgentsGetLookupGet**](AgentsApi.md#apivapiversionagentsgetlookupget) | **GET** /api/v{apiVersion}/Agents/GetLookup | Lookup list of all agents
[**ApiVapiVersionAgentsIdDelete**](AgentsApi.md#apivapiversionagentsiddelete) | **DELETE** /api/v{apiVersion}/Agents/{id} | Deletes an agent with a specified id from the agents
[**ApiVapiVersionAgentsIdPatch**](AgentsApi.md#apivapiversionagentsidpatch) | **PATCH** /api/v{apiVersion}/Agents/{id} | Updates partial details of agent
[**ApiVapiVersionAgentsIdPut**](AgentsApi.md#apivapiversionagentsidput) | **PUT** /api/v{apiVersion}/Agents/{id} | Updates an Agent
[**ApiVapiVersionAgentsPost**](AgentsApi.md#apivapiversionagentspost) | **POST** /api/v{apiVersion}/Agents | Adds a new agent to the existing agents and create a new agent application user
[**ApiVapiVersionAgentsViewGet**](AgentsApi.md#apivapiversionagentsviewget) | **GET** /api/v{apiVersion}/Agents/view | Provides a view model list of all Agents and their most recent heartbeat information
[**GetAgent**](AgentsApi.md#getagent) | **GET** /api/v{apiVersion}/Agents/{id} | 
[**GetAgentHeartbeat**](AgentsApi.md#getagentheartbeat) | **GET** /api/v{apiVersion}/Agents/{agentId}/AgentHeartbeats | Provides a list of heartbeat details for a particular agent id

<a name="apivapiversionagentsagentidconnectpatch"></a>
# **ApiVapiVersionAgentsAgentIDConnectPatch**
> ConnectedViewModel ApiVapiVersionAgentsAgentIDConnectPatch (string agentID, string machineName, string apiVersion, string macAddresses = null)

Provides an agent id and name if the provided machine matches an agent and updates the isConnected field

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsAgentIDConnectPatchExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var agentID = agentID_example;  // string | 
            var machineName = machineName_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var macAddresses = macAddresses_example;  // string |  (optional) 

            try
            {
                // Provides an agent id and name if the provided machine matches an agent and updates the isConnected field
                ConnectedViewModel result = apiInstance.ApiVapiVersionAgentsAgentIDConnectPatch(agentID, machineName, apiVersion, macAddresses);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsAgentIDConnectPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentID** | **string**|  | 
 **machineName** | **string**|  | 
 **apiVersion** | **string**|  | 
 **macAddresses** | **string**|  | [optional] 

### Return type

[**ConnectedViewModel**](ConnectedViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentsagentiddisconnectpatch"></a>
# **ApiVapiVersionAgentsAgentIDDisconnectPatch**
> IActionResult ApiVapiVersionAgentsAgentIDDisconnectPatch (string agentID, string machineName, string apiVersion, string macAddresses = null)

Updates the isConnected field if the disconnect details are correct

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsAgentIDDisconnectPatchExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var agentID = agentID_example;  // string | 
            var machineName = machineName_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var macAddresses = macAddresses_example;  // string |  (optional) 

            try
            {
                // Updates the isConnected field if the disconnect details are correct
                IActionResult result = apiInstance.ApiVapiVersionAgentsAgentIDDisconnectPatch(agentID, machineName, apiVersion, macAddresses);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsAgentIDDisconnectPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentID** | **string**|  | 
 **machineName** | **string**|  | 
 **apiVersion** | **string**|  | 
 **macAddresses** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentsagentidaddheartbeatpost"></a>
# **ApiVapiVersionAgentsAgentIdAddHeartbeatPost**
> AgentHeartbeat ApiVapiVersionAgentsAgentIdAddHeartbeatPost (string agentId, string apiVersion, HeartbeatViewModel body = null)

Creates a new heartbeat for the specified AgentId

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsAgentIdAddHeartbeatPostExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var agentId = agentId_example;  // string | Agent identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new HeartbeatViewModel(); // HeartbeatViewModel | Heartbeat values to be updated (optional) 

            try
            {
                // Creates a new heartbeat for the specified AgentId
                AgentHeartbeat result = apiInstance.ApiVapiVersionAgentsAgentIdAddHeartbeatPost(agentId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsAgentIdAddHeartbeatPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Agent identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**HeartbeatViewModel**](HeartbeatViewModel.md)| Heartbeat values to be updated | [optional] 

### Return type

[**AgentHeartbeat**](AgentHeartbeat.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentsagentidgetallgroupmembersget"></a>
# **ApiVapiVersionAgentsAgentIdGetAllGroupMembersGet**
> AgentGroupMemberPaginatedList ApiVapiVersionAgentsAgentIdGetAllGroupMembersGet (string agentId, string apiVersion)

Provides a list of all AgentGroupMembers for the specified Agent

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsAgentIdGetAllGroupMembersGetExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var agentId = agentId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a list of all AgentGroupMembers for the specified Agent
                AgentGroupMemberPaginatedList result = apiInstance.ApiVapiVersionAgentsAgentIdGetAllGroupMembersGet(agentId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsAgentIdGetAllGroupMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**|  | 
 **apiVersion** | **string**|  | 

### Return type

[**AgentGroupMemberPaginatedList**](AgentGroupMemberPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentscountget"></a>
# **ApiVapiVersionAgentsCountGet**
> int? ApiVapiVersionAgentsCountGet (string apiVersion, string filter = null)

Provides a count of agents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsCountGetExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Provides a count of agents
                int? result = apiInstance.ApiVapiVersionAgentsCountGet(apiVersion, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsCountGet: " + e.Message );
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
<a name="apivapiversionagentsget"></a>
# **ApiVapiVersionAgentsGet**
> AgentPaginatedList ApiVapiVersionAgentsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all Agents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsGetExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all Agents
                AgentPaginatedList result = apiInstance.ApiVapiVersionAgentsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsGet: " + e.Message );
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

[**AgentPaginatedList**](AgentPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentsgetlookupget"></a>
# **ApiVapiVersionAgentsGetLookupGet**
> List<JobAgentsLookup> ApiVapiVersionAgentsGetLookupGet (string apiVersion)

Lookup list of all agents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsGetLookupGetExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Lookup list of all agents
                List&lt;JobAgentsLookup&gt; result = apiInstance.ApiVapiVersionAgentsGetLookupGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsGetLookupGet: " + e.Message );
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

[**List<JobAgentsLookup>**](JobAgentsLookup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentsiddelete"></a>
# **ApiVapiVersionAgentsIdDelete**
> IActionResult ApiVapiVersionAgentsIdDelete (string id, string apiVersion)

Deletes an agent with a specified id from the agents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var id = id_example;  // string | Agent id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes an agent with a specified id from the agents
                IActionResult result = apiInstance.ApiVapiVersionAgentsIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Agent id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentsidpatch"></a>
# **ApiVapiVersionAgentsIdPatch**
> IActionResult ApiVapiVersionAgentsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of agent

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var id = id_example;  // string | Agent identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the agent to be updated (optional) 

            try
            {
                // Updates partial details of agent
                IActionResult result = apiInstance.ApiVapiVersionAgentsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Agent identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the agent to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentsidput"></a>
# **ApiVapiVersionAgentsIdPut**
> IActionResult ApiVapiVersionAgentsIdPut (string id, string apiVersion, Agent body = null)

Updates an Agent

Provides an action to update an agent, when agent id and the new details of agent are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsIdPutExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var id = id_example;  // string | Agent id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new Agent(); // Agent | Agent details to be updated (optional) 

            try
            {
                // Updates an Agent
                IActionResult result = apiInstance.ApiVapiVersionAgentsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Agent id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**Agent**](Agent.md)| Agent details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentspost"></a>
# **ApiVapiVersionAgentsPost**
> Agent ApiVapiVersionAgentsPost (string apiVersion, CreateAgentViewModel body = null)

Adds a new agent to the existing agents and create a new agent application user

Adds the agent with unique agent id to the existing agents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsPostExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new CreateAgentViewModel(); // CreateAgentViewModel |  (optional) 

            try
            {
                // Adds a new agent to the existing agents and create a new agent application user
                Agent result = apiInstance.ApiVapiVersionAgentsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**CreateAgentViewModel**](CreateAgentViewModel.md)|  | [optional] 

### Return type

[**Agent**](Agent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionagentsviewget"></a>
# **ApiVapiVersionAgentsViewGet**
> AllAgentsViewModelPaginatedList ApiVapiVersionAgentsViewGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a view model list of all Agents and their most recent heartbeat information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAgentsViewGetExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a view model list of all Agents and their most recent heartbeat information
                AllAgentsViewModelPaginatedList result = apiInstance.ApiVapiVersionAgentsViewGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.ApiVapiVersionAgentsViewGet: " + e.Message );
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

[**AllAgentsViewModelPaginatedList**](AllAgentsViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getagent"></a>
# **GetAgent**
> AgentViewModel GetAgent (string id, string apiVersion)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAgentExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                AgentViewModel result = apiInstance.GetAgent(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.GetAgent: " + e.Message );
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

[**AgentViewModel**](AgentViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getagentheartbeat"></a>
# **GetAgentHeartbeat**
> AgentHeartbeatPaginatedList GetAgentHeartbeat (string agentId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of heartbeat details for a particular agent id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAgentHeartbeatExample
    {
        public void main()
        {

            var apiInstance = new AgentsApi();
            var agentId = agentId_example;  // string | Agent id
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of heartbeat details for a particular agent id
                AgentHeartbeatPaginatedList result = apiInstance.GetAgentHeartbeat(agentId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentsApi.GetAgentHeartbeat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Agent id | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**AgentHeartbeatPaginatedList**](AgentHeartbeatPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
