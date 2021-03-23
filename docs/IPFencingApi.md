# IO.Swagger.Api.IPFencingApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionOrganizationsOrganizationIdIPFencingGet**](IPFencingApi.md#apivapiversionorganizationsorganizationidipfencingget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/IPFencing | Provides a list of all IPFencings
[**ApiVapiVersionOrganizationsOrganizationIdIPFencingIdDelete**](IPFencingApi.md#apivapiversionorganizationsorganizationidipfencingiddelete) | **DELETE** /api/v{apiVersion}/Organizations/{organizationId}/IPFencing/{id} | Deletes an IPFencing rule with a specified id from the organization.
[**ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPatch**](IPFencingApi.md#apivapiversionorganizationsorganizationidipfencingidpatch) | **PATCH** /api/v{apiVersion}/Organizations/{organizationId}/IPFencing/{id} | Updates partial details of an IPFencing entity.
[**ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPut**](IPFencingApi.md#apivapiversionorganizationsorganizationidipfencingidput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/IPFencing/{id} | Update the IPFencing rule
[**ApiVapiVersionOrganizationsOrganizationIdIPFencingModeAllowAllPut**](IPFencingApi.md#apivapiversionorganizationsorganizationidipfencingmodeallowallput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/IPFencing/Mode/AllowAll | Updates the IPFencing Mode to AllowMode
[**ApiVapiVersionOrganizationsOrganizationIdIPFencingModeDenyAllPut**](IPFencingApi.md#apivapiversionorganizationsorganizationidipfencingmodedenyallput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/IPFencing/Mode/DenyAll | Updates the IPFencing Mode to DenyAll
[**ApiVapiVersionOrganizationsOrganizationIdIPFencingModeGet**](IPFencingApi.md#apivapiversionorganizationsorganizationidipfencingmodeget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/IPFencing/Mode | 
[**ApiVapiVersionOrganizationsOrganizationIdIPFencingPost**](IPFencingApi.md#apivapiversionorganizationsorganizationidipfencingpost) | **POST** /api/v{apiVersion}/Organizations/{organizationId}/IPFencing | Adds a new IPFencing rule with the specified organization ID
[**GetIPFencing**](IPFencingApi.md#getipfencing) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/IPFencing/{id} | Provides an IPFencing&#x27;s details for a particular IPFencing ID

<a name="apivapiversionorganizationsorganizationidipfencingget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdIPFencingGet**
> IPFencingPaginatedList ApiVapiVersionOrganizationsOrganizationIdIPFencingGet (string organizationId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all IPFencings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdIPFencingGetExample
    {
        public void main()
        {

            var apiInstance = new IPFencingApi();
            var organizationId = organizationId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all IPFencings
                IPFencingPaginatedList result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdIPFencingGet(organizationId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFencingApi.ApiVapiVersionOrganizationsOrganizationIdIPFencingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**IPFencingPaginatedList**](IPFencingPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidipfencingiddelete"></a>
# **ApiVapiVersionOrganizationsOrganizationIdIPFencingIdDelete**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdIPFencingIdDelete (string organizationId, string id, string apiVersion)

Deletes an IPFencing rule with a specified id from the organization.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdIPFencingIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new IPFencingApi();
            var organizationId = organizationId_example;  // string | 
            var id = id_example;  // string | IPFencing id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes an IPFencing rule with a specified id from the organization.
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdIPFencingIdDelete(organizationId, id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFencingApi.ApiVapiVersionOrganizationsOrganizationIdIPFencingIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **id** | **string**| IPFencing id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidipfencingidpatch"></a>
# **ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPatch**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPatch (string organizationId, string id, string apiVersion, List<Operation> body = null)

Updates partial details of an IPFencing entity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPatchExample
    {
        public void main()
        {

            var apiInstance = new IPFencingApi();
            var organizationId = organizationId_example;  // string | 
            var id = id_example;  // string | IPFencing identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Details of IPFencing patch (optional) 

            try
            {
                // Updates partial details of an IPFencing entity.
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPatch(organizationId, id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFencingApi.ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **id** | **string**| IPFencing identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Details of IPFencing patch | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidipfencingidput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPut (string organizationId, string id, string apiVersion, IPFencing body = null)

Update the IPFencing rule

Updates the IPFencing with the particular id for the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPutExample
    {
        public void main()
        {

            var apiInstance = new IPFencingApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var id = id_example;  // string | IPFencing id
            var apiVersion = apiVersion_example;  // string | 
            var body = new IPFencing(); // IPFencing | New value of the IPFencing to be updated (optional) 

            try
            {
                // Update the IPFencing rule
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPut(organizationId, id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFencingApi.ApiVapiVersionOrganizationsOrganizationIdIPFencingIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **id** | **string**| IPFencing id | 
 **apiVersion** | **string**|  | 
 **body** | [**IPFencing**](IPFencing.md)| New value of the IPFencing to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidipfencingmodeallowallput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdIPFencingModeAllowAllPut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdIPFencingModeAllowAllPut (string organizationId, string apiVersion)

Updates the IPFencing Mode to AllowMode

Updates the IPFencingMode of the specified organizationID to AllowMode

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdIPFencingModeAllowAllPutExample
    {
        public void main()
        {

            var apiInstance = new IPFencingApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Updates the IPFencing Mode to AllowMode
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdIPFencingModeAllowAllPut(organizationId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFencingApi.ApiVapiVersionOrganizationsOrganizationIdIPFencingModeAllowAllPut: " + e.Message );
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

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidipfencingmodedenyallput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdIPFencingModeDenyAllPut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdIPFencingModeDenyAllPut (string organizationId, string apiVersion)

Updates the IPFencing Mode to DenyAll

Updates the IPFencingMode of the specified organizationID to DenyMode

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdIPFencingModeDenyAllPutExample
    {
        public void main()
        {

            var apiInstance = new IPFencingApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Updates the IPFencing Mode to DenyAll
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdIPFencingModeDenyAllPut(organizationId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFencingApi.ApiVapiVersionOrganizationsOrganizationIdIPFencingModeDenyAllPut: " + e.Message );
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

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidipfencingmodeget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdIPFencingModeGet**
> IPFencingPaginatedList ApiVapiVersionOrganizationsOrganizationIdIPFencingModeGet (string organizationId, string apiVersion)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdIPFencingModeGetExample
    {
        public void main()
        {

            var apiInstance = new IPFencingApi();
            var organizationId = organizationId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                IPFencingPaginatedList result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdIPFencingModeGet(organizationId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFencingApi.ApiVapiVersionOrganizationsOrganizationIdIPFencingModeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **apiVersion** | **string**|  | 

### Return type

[**IPFencingPaginatedList**](IPFencingPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidipfencingpost"></a>
# **ApiVapiVersionOrganizationsOrganizationIdIPFencingPost**
> CreateIPFencingViewModel ApiVapiVersionOrganizationsOrganizationIdIPFencingPost (string organizationId, string apiVersion, CreateIPFencingViewModel body = null)

Adds a new IPFencing rule with the specified organization ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdIPFencingPostExample
    {
        public void main()
        {

            var apiInstance = new IPFencingApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new CreateIPFencingViewModel(); // CreateIPFencingViewModel | Json containing IPFencing model (optional) 

            try
            {
                // Adds a new IPFencing rule with the specified organization ID
                CreateIPFencingViewModel result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdIPFencingPost(organizationId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFencingApi.ApiVapiVersionOrganizationsOrganizationIdIPFencingPost: " + e.Message );
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
 **body** | [**CreateIPFencingViewModel**](CreateIPFencingViewModel.md)| Json containing IPFencing model | [optional] 

### Return type

[**CreateIPFencingViewModel**](CreateIPFencingViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getipfencing"></a>
# **GetIPFencing**
> IPFencing GetIPFencing (string organizationId, string id, string apiVersion)

Provides an IPFencing's details for a particular IPFencing ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIPFencingExample
    {
        public void main()
        {

            var apiInstance = new IPFencingApi();
            var organizationId = organizationId_example;  // string | 
            var id = id_example;  // string | IPFencing id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides an IPFencing's details for a particular IPFencing ID
                IPFencing result = apiInstance.GetIPFencing(organizationId, id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFencingApi.GetIPFencing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **id** | **string**| IPFencing id | 
 **apiVersion** | **string**|  | 

### Return type

[**IPFencing**](IPFencing.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
