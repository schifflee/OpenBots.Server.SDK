# IO.Swagger.Api.OrganizationSettingsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsGet**](OrganizationSettingsApi.md#apivapiversionorganizationsorganizationidorganizationsettingsget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationSettings | Gets all the organization settings for an organization
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdDelete**](OrganizationSettingsApi.md#apivapiversionorganizationsorganizationidorganizationsettingsiddelete) | **DELETE** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationSettings/{id} | Deletes setting with the specific id
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPatch**](OrganizationSettingsApi.md#apivapiversionorganizationsorganizationidorganizationsettingsidpatch) | **PATCH** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationSettings/{id} | Partially updates the organization setting
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPut**](OrganizationSettingsApi.md#apivapiversionorganizationsorganizationidorganizationsettingsidput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationSettings/{id} | Updates the organization setting for an organization
[**ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsPost**](OrganizationSettingsApi.md#apivapiversionorganizationsorganizationidorganizationsettingspost) | **POST** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationSettings | Adds an organization setting for an organization id
[**GetOrganizationSetting**](OrganizationSettingsApi.md#getorganizationsetting) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/OrganizationSettings/{id} | Gets a particular organization setting

<a name="apivapiversionorganizationsorganizationidorganizationsettingsget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsGet**
> OrganizationSetting ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsGet (string organizationId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Gets all the organization settings for an organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsGetExample
    {
        public void main()
        {

            var apiInstance = new OrganizationSettingsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Gets all the organization settings for an organization
                OrganizationSetting result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsGet(organizationId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationSettingsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsGet: " + e.Message );
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

[**OrganizationSetting**](OrganizationSetting.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationsettingsiddelete"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdDelete**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdDelete (string id, string apiVersion, string organizationId)

Deletes setting with the specific id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new OrganizationSettingsApi();
            var id = id_example;  // string | Organization setting identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Deletes setting with the specific id
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdDelete(id, apiVersion, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationSettingsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization setting identifier | 
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
<a name="apivapiversionorganizationsorganizationidorganizationsettingsidpatch"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPatch**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPatch (string id, string apiVersion, string organizationId, List<Operation> body = null)

Partially updates the organization setting

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new OrganizationSettingsApi();
            var id = id_example;  // string | Organization setting identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Values to be updated (optional) 

            try
            {
                // Partially updates the organization setting
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPatch(id, apiVersion, organizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationSettingsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization setting identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Values to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationsettingsidput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPut (string organizationId, string id, string apiVersion, OrganizationSetting body = null)

Updates the organization setting for an organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPutExample
    {
        public void main()
        {

            var apiInstance = new OrganizationSettingsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var id = id_example;  // string | Organization setting identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new OrganizationSetting(); // OrganizationSetting | Value to be updated (optional) 

            try
            {
                // Updates the organization setting for an organization
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPut(organizationId, id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationSettingsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **id** | **string**| Organization setting identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**OrganizationSetting**](OrganizationSetting.md)| Value to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidorganizationsettingspost"></a>
# **ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsPost**
> OrganizationSetting ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsPost (string organizationId, string apiVersion, OrganizationSetting body = null)

Adds an organization setting for an organization id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsPostExample
    {
        public void main()
        {

            var apiInstance = new OrganizationSettingsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new OrganizationSetting(); // OrganizationSetting | Details of the organization setting (optional) 

            try
            {
                // Adds an organization setting for an organization id
                OrganizationSetting result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsPost(organizationId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationSettingsApi.ApiVapiVersionOrganizationsOrganizationIdOrganizationSettingsPost: " + e.Message );
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
 **body** | [**OrganizationSetting**](OrganizationSetting.md)| Details of the organization setting | [optional] 

### Return type

[**OrganizationSetting**](OrganizationSetting.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorganizationsetting"></a>
# **GetOrganizationSetting**
> OrganizationSetting GetOrganizationSetting (string id, string apiVersion, string organizationId)

Gets a particular organization setting

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrganizationSettingExample
    {
        public void main()
        {

            var apiInstance = new OrganizationSettingsApi();
            var id = id_example;  // string | Organization setting identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Gets a particular organization setting
                OrganizationSetting result = apiInstance.GetOrganizationSetting(id, apiVersion, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationSettingsApi.GetOrganizationSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Organization setting identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 

### Return type

[**OrganizationSetting**](OrganizationSetting.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
