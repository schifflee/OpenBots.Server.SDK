# IO.Swagger.Api.MembershipApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionPeoplePersonIdOrganizationsGet**](MembershipApi.md#apivapiversionpeoplepersonidorganizationsget) | **GET** /api/v{apiVersion}/People/{personId}/Organizations | Get cards for organizations a person has access to
[**ApiVapiVersionPeoplePersonIdOrganizationsIdDelete**](MembershipApi.md#apivapiversionpeoplepersonidorganizationsiddelete) | **DELETE** /api/v{apiVersion}/People/{personId}/Organizations/{id} | Leave a particular organization
[**ApiVapiVersionPeoplePersonIdOrganizationsIdGrantAdminPut**](MembershipApi.md#apivapiversionpeoplepersonidorganizationsidgrantadminput) | **PUT** /api/v{apiVersion}/People/{personId}/Organizations/{id}/GrantAdmin | Grant admin permission to non-admin users of the organization
[**ApiVapiVersionPeoplePersonIdOrganizationsIdPost**](MembershipApi.md#apivapiversionpeoplepersonidorganizationsidpost) | **POST** /api/v{apiVersion}/People/{personId}/Organizations/{id} | Request for joining an organization
[**ApiVapiVersionPeoplePersonIdOrganizationsIdRevokeAdminPut**](MembershipApi.md#apivapiversionpeoplepersonidorganizationsidrevokeadminput) | **PUT** /api/v{apiVersion}/People/{personId}/Organizations/{id}/RevokeAdmin | Revoke admin permission
[**ApiVapiVersionPeoplePersonIdOrganizationsSearchGet**](MembershipApi.md#apivapiversionpeoplepersonidorganizationssearchget) | **GET** /api/v{apiVersion}/People/{personId}/Organizations/Search | Get organizations user has access to
[**ApiVapiVersionPeoplePersonIdOrganizationsSuggestionsGet**](MembershipApi.md#apivapiversionpeoplepersonidorganizationssuggestionsget) | **GET** /api/v{apiVersion}/People/{personId}/Organizations/Suggestions | Provides a list of organizations that can be presented to the user as suggestions to apply for access request

<a name="apivapiversionpeoplepersonidorganizationsget"></a>
# **ApiVapiVersionPeoplePersonIdOrganizationsGet**
> OrganizationCardPaginatedList ApiVapiVersionPeoplePersonIdOrganizationsGet (string personId, string apiVersion)

Get cards for organizations a person has access to

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdOrganizationsGetExample
    {
        public void main()
        {

            var apiInstance = new MembershipApi();
            var personId = personId_example;  // string | Person identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Get cards for organizations a person has access to
                OrganizationCardPaginatedList result = apiInstance.ApiVapiVersionPeoplePersonIdOrganizationsGet(personId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembershipApi.ApiVapiVersionPeoplePersonIdOrganizationsGet: " + e.Message );
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

### Return type

[**OrganizationCardPaginatedList**](OrganizationCardPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidorganizationsiddelete"></a>
# **ApiVapiVersionPeoplePersonIdOrganizationsIdDelete**
> IActionResult ApiVapiVersionPeoplePersonIdOrganizationsIdDelete (string personId, string id, string apiVersion)

Leave a particular organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdOrganizationsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new MembershipApi();
            var personId = personId_example;  // string | Id of the currently logged in user. If the user id is not the same, then the request will be rejected
            var id = id_example;  // string | Id of the organization that the user wants to delete the membership from
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Leave a particular organization
                IActionResult result = apiInstance.ApiVapiVersionPeoplePersonIdOrganizationsIdDelete(personId, id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembershipApi.ApiVapiVersionPeoplePersonIdOrganizationsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | **string**| Id of the currently logged in user. If the user id is not the same, then the request will be rejected | 
 **id** | **string**| Id of the organization that the user wants to delete the membership from | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidorganizationsidgrantadminput"></a>
# **ApiVapiVersionPeoplePersonIdOrganizationsIdGrantAdminPut**
> void ApiVapiVersionPeoplePersonIdOrganizationsIdGrantAdminPut (string personId, string id, string apiVersion)

Grant admin permission to non-admin users of the organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdOrganizationsIdGrantAdminPutExample
    {
        public void main()
        {

            var apiInstance = new MembershipApi();
            var personId = personId_example;  // string | User who's admin permission needs to be grant
            var id = id_example;  // string | Organization id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Grant admin permission to non-admin users of the organization
                apiInstance.ApiVapiVersionPeoplePersonIdOrganizationsIdGrantAdminPut(personId, id, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembershipApi.ApiVapiVersionPeoplePersonIdOrganizationsIdGrantAdminPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | **string**| User who&#x27;s admin permission needs to be grant | 
 **id** | **string**| Organization id | 
 **apiVersion** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidorganizationsidpost"></a>
# **ApiVapiVersionPeoplePersonIdOrganizationsIdPost**
> void ApiVapiVersionPeoplePersonIdOrganizationsIdPost (string personId, string id, string apiVersion)

Request for joining an organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdOrganizationsIdPostExample
    {
        public void main()
        {

            var apiInstance = new MembershipApi();
            var personId = personId_example;  // string | User id of the person logged in
            var id = id_example;  // string | Organization id that the user wants to be a member of
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Request for joining an organization
                apiInstance.ApiVapiVersionPeoplePersonIdOrganizationsIdPost(personId, id, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembershipApi.ApiVapiVersionPeoplePersonIdOrganizationsIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | **string**| User id of the person logged in | 
 **id** | **string**| Organization id that the user wants to be a member of | 
 **apiVersion** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidorganizationsidrevokeadminput"></a>
# **ApiVapiVersionPeoplePersonIdOrganizationsIdRevokeAdminPut**
> void ApiVapiVersionPeoplePersonIdOrganizationsIdRevokeAdminPut (string personId, string id, string apiVersion)

Revoke admin permission

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdOrganizationsIdRevokeAdminPutExample
    {
        public void main()
        {

            var apiInstance = new MembershipApi();
            var personId = personId_example;  // string | User who's admin permission needs to be revoked
            var id = id_example;  // string | Organization id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Revoke admin permission
                apiInstance.ApiVapiVersionPeoplePersonIdOrganizationsIdRevokeAdminPut(personId, id, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembershipApi.ApiVapiVersionPeoplePersonIdOrganizationsIdRevokeAdminPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | **string**| User who&#x27;s admin permission needs to be revoked | 
 **id** | **string**| Organization id | 
 **apiVersion** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidorganizationssearchget"></a>
# **ApiVapiVersionPeoplePersonIdOrganizationsSearchGet**
> OrganizationListingPaginatedList ApiVapiVersionPeoplePersonIdOrganizationsSearchGet (string apiVersion, string personId, string startsWith = null, int? skip = null, int? take = null)

Get organizations user has access to

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdOrganizationsSearchGetExample
    {
        public void main()
        {

            var apiInstance = new MembershipApi();
            var apiVersion = apiVersion_example;  // string | 
            var personId = personId_example;  // string | 
            var startsWith = startsWith_example;  // string | Search criteria (optional) 
            var skip = 56;  // int? |  (optional)  (default to 0)
            var take = 56;  // int? |  (optional)  (default to 10)

            try
            {
                // Get organizations user has access to
                OrganizationListingPaginatedList result = apiInstance.ApiVapiVersionPeoplePersonIdOrganizationsSearchGet(apiVersion, personId, startsWith, skip, take);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembershipApi.ApiVapiVersionPeoplePersonIdOrganizationsSearchGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **personId** | **string**|  | 
 **startsWith** | **string**| Search criteria | [optional] 
 **skip** | **int?**|  | [optional] [default to 0]
 **take** | **int?**|  | [optional] [default to 10]

### Return type

[**OrganizationListingPaginatedList**](OrganizationListingPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidorganizationssuggestionsget"></a>
# **ApiVapiVersionPeoplePersonIdOrganizationsSuggestionsGet**
> OrganizationListingPaginatedList ApiVapiVersionPeoplePersonIdOrganizationsSuggestionsGet (string personId, string apiVersion)

Provides a list of organizations that can be presented to the user as suggestions to apply for access request

This method will return all organizations that are visible to users with a certain email domain  All the emails of the user are matched to the allowed domains of organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdOrganizationsSuggestionsGetExample
    {
        public void main()
        {

            var apiInstance = new MembershipApi();
            var personId = personId_example;  // string | Id of the currently logged in user. If the user id is not the same, then the request will be rejected
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a list of organizations that can be presented to the user as suggestions to apply for access request
                OrganizationListingPaginatedList result = apiInstance.ApiVapiVersionPeoplePersonIdOrganizationsSuggestionsGet(personId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembershipApi.ApiVapiVersionPeoplePersonIdOrganizationsSuggestionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | **string**| Id of the currently logged in user. If the user id is not the same, then the request will be rejected | 
 **apiVersion** | **string**|  | 

### Return type

[**OrganizationListingPaginatedList**](OrganizationListingPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
