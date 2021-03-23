# IO.Swagger.Api.OrganizationsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionOrganizationsGet**](OrganizationsApi.md#apivapiversionorganizationsget) | **GET** /api/v{apiVersion}/Organizations | Provides a list of all organizations
[**ApiVapiVersionOrganizationsIdDelete**](OrganizationsApi.md#apivapiversionorganizationsiddelete) | **DELETE** /api/v{apiVersion}/Organizations/{id} | Deletes an organization with a specified id from the organizations.
[**ApiVapiVersionOrganizationsIdPatch**](OrganizationsApi.md#apivapiversionorganizationsidpatch) | **PATCH** /api/v{apiVersion}/Organizations/{id} | Updates partial details of an organization
[**ApiVapiVersionOrganizationsIdPut**](OrganizationsApi.md#apivapiversionorganizationsidput) | **PUT** /api/v{apiVersion}/Organizations/{id} | Updates an organization
[**ApiVapiVersionOrganizationsPost**](OrganizationsApi.md#apivapiversionorganizationspost) | **POST** /api/v{apiVersion}/Organizations | Adds a new organization to the existing organizations
[**ApiVapiVersionOrganizationsTotalOrganizationCountGet**](OrganizationsApi.md#apivapiversionorganizationstotalorganizationcountget) | **GET** /api/v{apiVersion}/Organizations/TotalOrganizationCount | Provides count of organizations
[**GetOrganization**](OrganizationsApi.md#getorganization) | **GET** /api/v{apiVersion}/Organizations/{id} | Provides organization details for a particular organization id

<a name="apivapiversionorganizationsget"></a>
# **ApiVapiVersionOrganizationsGet**
> OrganizationPaginatedList ApiVapiVersionOrganizationsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all organizations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsGetExample
    {
        public void main()
        {

            var apiInstance = new OrganizationsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all organizations
                OrganizationPaginatedList result = apiInstance.ApiVapiVersionOrganizationsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ApiVapiVersionOrganizationsGet: " + e.Message );
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

[**OrganizationPaginatedList**](OrganizationPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsiddelete"></a>
# **ApiVapiVersionOrganizationsIdDelete**
> IActionResult ApiVapiVersionOrganizationsIdDelete (string id, string apiVersion)

Deletes an organization with a specified id from the organizations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new OrganizationsApi();
            var id = id_example;  // string | Organization id to be deleted - throws bad request if null or empty Guid/
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes an organization with a specified id from the organizations.
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ApiVapiVersionOrganizationsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization id to be deleted - throws bad request if null or empty Guid/ | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsidpatch"></a>
# **ApiVapiVersionOrganizationsIdPatch**
> IActionResult ApiVapiVersionOrganizationsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of an organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new OrganizationsApi();
            var id = id_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the organization to be updated (optional) 

            try
            {
                // Updates partial details of an organization
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ApiVapiVersionOrganizationsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the organization to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsidput"></a>
# **ApiVapiVersionOrganizationsIdPut**
> IActionResult ApiVapiVersionOrganizationsIdPut (string id, string apiVersion, Organization body = null)

Updates an organization

Provides an action to update an organization, when organization id and the new details of organization are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsIdPutExample
    {
        public void main()
        {

            var apiInstance = new OrganizationsApi();
            var id = id_example;  // string | organization id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new Organization(); // Organization | Organization details to be updated (optional) 

            try
            {
                // Updates an organization
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ApiVapiVersionOrganizationsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| organization id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**Organization**](Organization.md)| Organization details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationspost"></a>
# **ApiVapiVersionOrganizationsPost**
> Organization ApiVapiVersionOrganizationsPost (string apiVersion, Organization body = null)

Adds a new organization to the existing organizations

Adds the organization with unique organization id to the existing organizations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsPostExample
    {
        public void main()
        {

            var apiInstance = new OrganizationsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new Organization(); // Organization |  (optional) 

            try
            {
                // Adds a new organization to the existing organizations
                Organization result = apiInstance.ApiVapiVersionOrganizationsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ApiVapiVersionOrganizationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**Organization**](Organization.md)|  | [optional] 

### Return type

[**Organization**](Organization.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationstotalorganizationcountget"></a>
# **ApiVapiVersionOrganizationsTotalOrganizationCountGet**
> int? ApiVapiVersionOrganizationsTotalOrganizationCountGet (string apiVersion)

Provides count of organizations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsTotalOrganizationCountGetExample
    {
        public void main()
        {
            var apiInstance = new OrganizationsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides count of organizations
                int? result = apiInstance.ApiVapiVersionOrganizationsTotalOrganizationCountGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ApiVapiVersionOrganizationsTotalOrganizationCountGet: " + e.Message );
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

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorganization"></a>
# **GetOrganization**
> Organization GetOrganization (string id, string apiVersion)

Provides organization details for a particular organization id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrganizationExample
    {
        public void main()
        {

            var apiInstance = new OrganizationsApi();
            var id = id_example;  // string | Organization id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides organization details for a particular organization id
                Organization result = apiInstance.GetOrganization(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization id | 
 **apiVersion** | **string**|  | 

### Return type

[**Organization**](Organization.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
