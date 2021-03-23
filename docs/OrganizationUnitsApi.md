# IO.Swagger.Api.OrganizationUnitsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsGet**](OrganizationUnitsApi.md#apivapiversionorganizationsorganizationidorganizationunitsget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnits | Gets allorganization units details (departments) that are part of an organization.
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdDelete**](OrganizationUnitsApi.md#apivapiversionorganizationsorganizationidorganizationunitsiddelete) | **DELETE** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnits/{id} | Deletes an organization unit
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPatch**](OrganizationUnitsApi.md#apivapiversionorganizationsorganizationidorganizationunitsidpatch) | **PATCH** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnits/{id} | Updates the partial details of an organization unit
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPut**](OrganizationUnitsApi.md#apivapiversionorganizationsorganizationidorganizationunitsidput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnits/{id} | Updates a member of an organization unit
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsPost**](OrganizationUnitsApi.md#apivapiversionorganizationsorganizationidorganizationunitspost) | **POST** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnits | Adds an organization unit to an organization
[**GetOrganizationUnit**](OrganizationUnitsApi.md#getorganizationunit) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationUnits/{id} | Provides the organization unit details for a particular id

<a name="apivapiversionorganizationsorganizationidorganizationunitsget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsGet**
> OrganizationUnitPaginatedList ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsGet (string organizationId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Gets allorganization units details (departments) that are part of an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsGetExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Gets allorganization units details (departments) that are part of an organization.
                OrganizationUnitPaginatedList result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsGet(organizationId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsGet: " + e.Message );
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

[**OrganizationUnitPaginatedList**](OrganizationUnitPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationunitsiddelete"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdDelete**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdDelete (string organizationId, string id, string apiVersion)

Deletes an organization unit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitsApi();
            var organizationId = organizationId_example;  // string | 
            var id = id_example;  // string | Organization unit identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes an organization unit
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdDelete(organizationId, id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **id** | **string**| Organization unit identifier | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationunitsidpatch"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPatch**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPatch (string organizationId, string id, string apiVersion, List<Operation> body = null)

Updates the partial details of an organization unit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitsApi();
            var organizationId = organizationId_example;  // string | 
            var id = id_example;  // string | Organization unit identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Details of the organization unit to be updated (optional) 

            try
            {
                // Updates the partial details of an organization unit
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPatch(organizationId, id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **id** | **string**| Organization unit identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Details of the organization unit to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationunitsidput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPut (string organizationId, string id, string apiVersion, OrganizationUnit body = null)

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
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPutExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var id = id_example;  // string | Organization unit identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new OrganizationUnit(); // OrganizationUnit | Value of the organization unit to be updated (optional) 

            try
            {
                // Updates a member of an organization unit
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPut(organizationId, id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **id** | **string**| Organization unit identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**OrganizationUnit**](OrganizationUnit.md)| Value of the organization unit to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationunitspost"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsPost**
> OrganizationUnit ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsPost (string organizationId, string apiVersion, OrganizationUnit body = null)

Adds an organization unit to an organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsPostExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new OrganizationUnit(); // OrganizationUnit | Value of organization unit to be added (optional) 

            try
            {
                // Adds an organization unit to an organization
                OrganizationUnit result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsPost(organizationId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationUnitsPost: " + e.Message );
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
 **body** | [**OrganizationUnit**](OrganizationUnit.md)| Value of organization unit to be added | [optional] 

### Return type

[**OrganizationUnit**](OrganizationUnit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorganizationunit"></a>
# **GetOrganizationUnit**
> OrganizationUnit GetOrganizationUnit (string id, string apiVersion, string organizationId)

Provides the organization unit details for a particular id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrganizationUnitExample
    {
        public void main()
        {

            var apiInstance = new OrganizationUnitsApi();
            var id = id_example;  // string | Organization unit identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Provides the organization unit details for a particular id
                OrganizationUnit result = apiInstance.GetOrganizationUnit(id, apiVersion, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUnitsApi.GetOrganizationUnit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization unit identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 

### Return type

[**OrganizationUnit**](OrganizationUnit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
