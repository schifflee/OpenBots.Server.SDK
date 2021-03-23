# IO.Swagger.Api.OrganizationMembersApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersGet**](OrganizationMembersApi.md#apivapiversionorganizationsorganizationidorganizationmembersget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers | Gets all the members of the given organization
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersInviteUserPost**](OrganizationMembersApi.md#apivapiversionorganizationsorganizationidorganizationmembersinviteuserpost) | **POST** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers/InviteUser | Invite user to become an organization member
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdDelete**](OrganizationMembersApi.md#apivapiversionorganizationsorganizationidorganizationmembersorganizationmemberiddelete) | **DELETE** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers/{organizationMemberId} | Delete organization member
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPatch**](OrganizationMembersApi.md#apivapiversionorganizationsorganizationidorganizationmembersorganizationmemberidpatch) | **PATCH** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers/{organizationMemberId} | Updates the partial details of organization members
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPut**](OrganizationMembersApi.md#apivapiversionorganizationsorganizationidorganizationmembersorganizationmemberidput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers/{organizationMemberId} | Update the organization member details
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPeopleGet**](OrganizationMembersApi.md#apivapiversionorganizationsorganizationidorganizationmemberspeopleget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers/People | Gets the people in the organization
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdGet**](OrganizationMembersApi.md#apivapiversionorganizationsorganizationidorganizationmemberspersonpersonidget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers/Person/{personId} | Retrieves a user&#x27;s details for a particular organization member
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdUpdateUserPatch**](OrganizationMembersApi.md#apivapiversionorganizationsorganizationidorganizationmemberspersonpersonidupdateuserpatch) | **PATCH** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers/Person/{personId}/UpdateUser | Updates the partial details of an organization member
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPost**](OrganizationMembersApi.md#apivapiversionorganizationsorganizationidorganizationmemberspost) | **POST** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers | Adds a new member to the organization
[**GetOrganizationMember**](OrganizationMembersApi.md#getorganizationmember) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationMembers/{organizationMemberId} | Get the member for a particular organization

<a name="apivapiversionorganizationsorganizationidorganizationmembersget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersGet**
> OrganizationMember ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersGet (string organizationId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Gets all the members of the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersGetExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Gets all the members of the given organization
                OrganizationMember result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersGet(organizationId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersGet: " + e.Message );
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
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**OrganizationMember**](OrganizationMember.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationmembersinviteuserpost"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersInviteUserPost**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersInviteUserPost (string organizationId, string apiVersion, InviteUserViewModel body = null)

Invite user to become an organization member

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersInviteUserPostExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new InviteUserViewModel(); // InviteUserViewModel |  (optional) 

            try
            {
                // Invite user to become an organization member
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersInviteUserPost(organizationId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersInviteUserPost: " + e.Message );
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
 **body** | [**InviteUserViewModel**](InviteUserViewModel.md)|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationmembersorganizationmemberiddelete"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdDelete**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdDelete (string organizationId, string organizationMemberId, string apiVersion)

Delete organization member

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var organizationMemberId = organizationMemberId_example;  // string | Organization member identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Delete organization member
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdDelete(organizationId, organizationMemberId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **organizationMemberId** | **string**| Organization member identifier | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationmembersorganizationmemberidpatch"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPatch**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPatch (string organizationMemberId, string apiVersion, string organizationId, List<Operation> body = null)

Updates the partial details of organization members

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPatchExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var organizationMemberId = organizationMemberId_example;  // string | Organization member identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value to be updated (optional) 

            try
            {
                // Updates the partial details of organization members
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPatch(organizationMemberId, apiVersion, organizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationMemberId** | **string**| Organization member identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationmembersorganizationmemberidput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPut (string organizationId, string organizationMemberId, string apiVersion, OrganizationMember body = null)

Update the organization member details

Updates the organization member details with the particular id for the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPutExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var organizationMemberId = organizationMemberId_example;  // string | Organization member id
            var apiVersion = apiVersion_example;  // string | 
            var body = new OrganizationMember(); // OrganizationMember | New value of the organization member to be updated (optional) 

            try
            {
                // Update the organization member details
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPut(organizationId, organizationMemberId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersOrganizationMemberIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **organizationMemberId** | **string**| Organization member id | 
 **apiVersion** | **string**|  | 
 **body** | [**OrganizationMember**](OrganizationMember.md)| New value of the organization member to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationmemberspeopleget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPeopleGet**
> TeamMemberViewModelPaginatedList ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPeopleGet (string organizationId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Gets the people in the organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPeopleGetExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Gets the people in the organization
                TeamMemberViewModelPaginatedList result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPeopleGet(organizationId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPeopleGet: " + e.Message );
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
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**TeamMemberViewModelPaginatedList**](TeamMemberViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationmemberspersonpersonidget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdGet**
> AspNetUsers ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdGet (string personId, string apiVersion, string organizationId)

Retrieves a user's details for a particular organization member

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdGetExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var personId = personId_example;  // string | Person identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Retrieves a user's details for a particular organization member
                AspNetUsers result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdGet(personId, apiVersion, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | **string**| Person identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 

### Return type

[**AspNetUsers**](AspNetUsers.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationmemberspersonpersonidupdateuserpatch"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdUpdateUserPatch**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdUpdateUserPatch (string personId, string organizationId, string apiVersion, UpdateTeamMemberViewModel body = null)

Updates the partial details of an organization member

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdUpdateUserPatchExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var personId = personId_example;  // string | Organization member person id
            var organizationId = organizationId_example;  // string | Organization id
            var apiVersion = apiVersion_example;  // string | 
            var body = new UpdateTeamMemberViewModel(); // UpdateTeamMemberViewModel | Values to be updated (optional) 

            try
            {
                // Updates the partial details of an organization member
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdUpdateUserPatch(personId, organizationId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPersonPersonIdUpdateUserPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | **string**| Organization member person id | 
 **organizationId** | **string**| Organization id | 
 **apiVersion** | **string**|  | 
 **body** | [**UpdateTeamMemberViewModel**](UpdateTeamMemberViewModel.md)| Values to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationmemberspost"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPost**
> OrganizationMember ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPost (string organizationId, string apiVersion, OrganizationMember body = null)

Adds a new member to the organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPostExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new OrganizationMember(); // OrganizationMember | Organization member details (optional) 

            try
            {
                // Adds a new member to the organization
                OrganizationMember result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPost(organizationId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationMembersPost: " + e.Message );
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
 **body** | [**OrganizationMember**](OrganizationMember.md)| Organization member details | [optional] 

### Return type

[**OrganizationMember**](OrganizationMember.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorganizationmember"></a>
# **GetOrganizationMember**
> OrganizationMember GetOrganizationMember (string organizationMemberId, string apiVersion, string organizationId)

Get the member for a particular organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrganizationMemberExample
    {
        public void main()
        {

            var apiInstance = new OrganizationMembersApi();
            var organizationMemberId = organizationMemberId_example;  // string | Organization member identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Get the member for a particular organization
                OrganizationMember result = apiInstance.GetOrganizationMember(organizationMemberId, apiVersion, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationMembersApi.GetOrganizationMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationMemberId** | **string**| Organization member identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 

### Return type

[**OrganizationMember**](OrganizationMember.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
