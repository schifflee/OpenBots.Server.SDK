# IO.Swagger.Api.OrganizationUnitMembersApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersGet**](OrganizationUnitMembersApi.md#apivapiversionorganizationsorganizationidorganizationunitmembersget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnitMembers | Gets all the members of an organization unit (department)
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdDelete**](OrganizationUnitMembersApi.md#apivapiversionorganizationsorganizationidorganizationunitmembersiddelete) | **DELETE** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnitMembers/{id} | Delete member from an organization unit
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPatch**](OrganizationUnitMembersApi.md#apivapiversionorganizationsorganizationidorganizationunitmembersidpatch) | **PATCH** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnitMembers/{id} | Updates the partial details of the organization unit member
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPut**](OrganizationUnitMembersApi.md#apivapiversionorganizationsorganizationidorganizationunitmembersidput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnitMembers/{id} | Updates a member of an organization unit
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersPost**](OrganizationUnitMembersApi.md#apivapiversionorganizationsorganizationidorganizationunitmemberspost) | **POST** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnitMembers | Adds a organization unit member to an organization unit
[**GetOrganizationUnitMember**](OrganizationUnitMembersApi.md#getorganizationunitmember) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnitMembers/{id} | Gets the organization unit member for a particular organization.

<a name="apivapiversionorganizationsorganizationidorganizationunitmembersget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersGet**
> OrganizationUnitMember ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersGet (string organizationId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Gets all the members of an organization unit (department)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersGetExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitMembersApi();
            var organizationId = organizationId_example;  // string | organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Gets all the members of an organization unit (department)
                OrganizationUnitMember result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersGet(organizationId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| organization identifier | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**OrganizationUnitMember**](OrganizationUnitMember.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationunitmembersiddelete"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdDelete**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdDelete (string id, string apiVersion, string organizationId)

Delete member from an organization unit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitMembersApi();
            var id = id_example;  // string | Organization member identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Delete member from an organization unit
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdDelete(id, apiVersion, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization member identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationunitmembersidpatch"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPatch**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPatch (string id, string apiVersion, string organizationId, List<Operation> body = null)

Updates the partial details of the organization unit member

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPatchExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitMembersApi();
            var id = id_example;  // string | Organization unit member identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the organization unit member to be updated (optional) 

            try
            {
                // Updates the partial details of the organization unit member
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPatch(id, apiVersion, organizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization unit member identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the organization unit member to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationunitmembersidput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPut (string organizationId, string id, string apiVersion, OrganizationUnitMember body = null)

Updates a member of an organization unit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPutExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitMembersApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var id = id_example;  // string | Member identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new OrganizationUnitMember(); // OrganizationUnitMember | Member value to be updated (optional) 

            try
            {
                // Updates a member of an organization unit
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPut(organizationId, id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **id** | **string**| Member identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**OrganizationUnitMember**](OrganizationUnitMember.md)| Member value to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationunitmemberspost"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersPost**
> OrganizationUnitMember ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersPost (string organizationId, string apiVersion, OrganizationUnitMember body = null)

Adds a organization unit member to an organization unit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersPostExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitMembersApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new OrganizationUnitMember(); // OrganizationUnitMember | Details of the organization unit member (optional) 

            try
            {
                // Adds a organization unit member to an organization unit
                OrganizationUnitMember result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersPost(organizationId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**OrganizationUnitMember**](OrganizationUnitMember.md)| Details of the organization unit member | [optional] 

### Return type

[**OrganizationUnitMember**](OrganizationUnitMember.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorganizationunitmember"></a>
# **GetOrganizationUnitMember**
> OrganizationUnitMember GetOrganizationUnitMember (string id, string apiVersion, string organizationId)

Gets the organization unit member for a particular organization.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrganizationUnitMemberExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitMembersApi();
            var id = id_example;  // string | Organization unit member id
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Gets the organization unit member for a particular organization.
                OrganizationUnitMember result = apiInstance.GetOrganizationUnitMember(id, apiVersion, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitMembersApi.GetOrganizationUnitMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization unit member id | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 

### Return type

[**OrganizationUnitMember**](OrganizationUnitMember.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
