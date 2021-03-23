# IO.Swagger.Api.EmailSettingsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionEmailSettingsCountGet**](EmailSettingsApi.md#apivapiversionemailsettingscountget) | **GET** /api/v{apiVersion}/EmailSettings/count | Gets count of email settings in database
[**ApiVapiVersionEmailSettingsGet**](EmailSettingsApi.md#apivapiversionemailsettingsget) | **GET** /api/v{apiVersion}/EmailSettings | Provides all email settings
[**ApiVapiVersionEmailSettingsIdDelete**](EmailSettingsApi.md#apivapiversionemailsettingsiddelete) | **DELETE** /api/v{apiVersion}/EmailSettings/{id} | Delete email settings with a specified id from email settings data table.
[**ApiVapiVersionEmailSettingsIdPatch**](EmailSettingsApi.md#apivapiversionemailsettingsidpatch) | **PATCH** /api/v{apiVersion}/EmailSettings/{id} | Updates partial details of email settings
[**ApiVapiVersionEmailSettingsIdPut**](EmailSettingsApi.md#apivapiversionemailsettingsidput) | **PUT** /api/v{apiVersion}/EmailSettings/{id} | Updates email settings
[**ApiVapiVersionEmailSettingsPost**](EmailSettingsApi.md#apivapiversionemailsettingspost) | **POST** /api/v{apiVersion}/EmailSettings | Adds a new email setting to the existing email settings
[**GetEmailSettings**](EmailSettingsApi.md#getemailsettings) | **GET** /api/v{apiVersion}/EmailSettings/{id} | Get email setting by id

<a name="apivapiversionemailsettingscountget"></a>
# **ApiVapiVersionEmailSettingsCountGet**
> void ApiVapiVersionEmailSettingsCountGet (string apiVersion, string filter = null)

Gets count of email settings in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailSettingsCountGetExample
    {
        public void main()
        {

            var apiInstance = new EmailSettingsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of email settings in database
                apiInstance.ApiVapiVersionEmailSettingsCountGet(apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailSettingsApi.ApiVapiVersionEmailSettingsCountGet: " + e.Message );
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
<a name="apivapiversionemailsettingsget"></a>
# **ApiVapiVersionEmailSettingsGet**
> EmailSettingsPaginatedList ApiVapiVersionEmailSettingsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides all email settings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailSettingsGetExample
    {
        public void main()
        {

            var apiInstance = new EmailSettingsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides all email settings
                EmailSettingsPaginatedList result = apiInstance.ApiVapiVersionEmailSettingsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailSettingsApi.ApiVapiVersionEmailSettingsGet: " + e.Message );
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

[**EmailSettingsPaginatedList**](EmailSettingsPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsettingsiddelete"></a>
# **ApiVapiVersionEmailSettingsIdDelete**
> IActionResult ApiVapiVersionEmailSettingsIdDelete (string id, string apiVersion)

Delete email settings with a specified id from email settings data table.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailSettingsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new EmailSettingsApi();
            var id = id_example;  // string | Email setting id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Delete email settings with a specified id from email settings data table.
                IActionResult result = apiInstance.ApiVapiVersionEmailSettingsIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailSettingsApi.ApiVapiVersionEmailSettingsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email setting id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsettingsidpatch"></a>
# **ApiVapiVersionEmailSettingsIdPatch**
> EmailSettings ApiVapiVersionEmailSettingsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of email settings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailSettingsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new EmailSettingsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Updates partial details of email settings
                EmailSettings result = apiInstance.ApiVapiVersionEmailSettingsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailSettingsApi.ApiVapiVersionEmailSettingsIdPatch: " + e.Message );
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
 **body** | [**List&lt;Operation&gt;**](Operation.md)|  | [optional] 

### Return type

[**EmailSettings**](EmailSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsettingsidput"></a>
# **ApiVapiVersionEmailSettingsIdPut**
> EmailSettings ApiVapiVersionEmailSettingsIdPut (string id, string apiVersion, EmailSettings body = null)

Updates email settings

Provides an action to update email settings, when email setting id and the new details of email setting are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailSettingsIdPutExample
    {
        public void main()
        {

            var apiInstance = new EmailSettingsApi();
            var id = id_example;  // string | Email setting id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new EmailSettings(); // EmailSettings | Email setting details to be updated (optional) 

            try
            {
                // Updates email settings
                EmailSettings result = apiInstance.ApiVapiVersionEmailSettingsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailSettingsApi.ApiVapiVersionEmailSettingsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email setting id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**EmailSettings**](EmailSettings.md)| Email setting details to be updated | [optional] 

### Return type

[**EmailSettings**](EmailSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsettingspost"></a>
# **ApiVapiVersionEmailSettingsPost**
> EmailSettings ApiVapiVersionEmailSettingsPost (string apiVersion, EmailSettings body = null)

Adds a new email setting to the existing email settings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailSettingsPostExample
    {
        public void main()
        {

            var apiInstance = new EmailSettingsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new EmailSettings(); // EmailSettings |  (optional) 

            try
            {
                // Adds a new email setting to the existing email settings
                EmailSettings result = apiInstance.ApiVapiVersionEmailSettingsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailSettingsApi.ApiVapiVersionEmailSettingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**EmailSettings**](EmailSettings.md)|  | [optional] 

### Return type

[**EmailSettings**](EmailSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemailsettings"></a>
# **GetEmailSettings**
> EmailSettingsPaginatedList GetEmailSettings (string id, string apiVersion)

Get email setting by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailSettingsExample
    {
        public void main()
        {

            var apiInstance = new EmailSettingsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Get email setting by id
                EmailSettingsPaginatedList result = apiInstance.GetEmailSettings(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailSettingsApi.GetEmailSettings: " + e.Message );
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

[**EmailSettingsPaginatedList**](EmailSettingsPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
