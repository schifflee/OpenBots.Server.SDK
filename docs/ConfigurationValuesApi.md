# IO.Swagger.Api.ConfigurationValuesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionConfigurationValuesCountGet**](ConfigurationValuesApi.md#apivapiversionconfigurationvaluescountget) | **GET** /api/v{apiVersion}/ConfigurationValues/count | Gets count of configuration values in database
[**ApiVapiVersionConfigurationValuesGet**](ConfigurationValuesApi.md#apivapiversionconfigurationvaluesget) | **GET** /api/v{apiVersion}/ConfigurationValues | Provides a list of all configuration values
[**ApiVapiVersionConfigurationValuesIdDelete**](ConfigurationValuesApi.md#apivapiversionconfigurationvaluesiddelete) | **DELETE** /api/v{apiVersion}/ConfigurationValues/{id} | Delete configuration value with a specified id from configuration value data table
[**ApiVapiVersionConfigurationValuesIdPatch**](ConfigurationValuesApi.md#apivapiversionconfigurationvaluesidpatch) | **PATCH** /api/v{apiVersion}/ConfigurationValues/{id} | Updates partial details of configuration value
[**ApiVapiVersionConfigurationValuesIdPut**](ConfigurationValuesApi.md#apivapiversionconfigurationvaluesidput) | **PUT** /api/v{apiVersion}/ConfigurationValues/{id} | Updates configuration value
[**ApiVapiVersionConfigurationValuesPost**](ConfigurationValuesApi.md#apivapiversionconfigurationvaluespost) | **POST** /api/v{apiVersion}/ConfigurationValues | Adds a new configuration value to the existing configuration values
[**GetConfigurationValue**](ConfigurationValuesApi.md#getconfigurationvalue) | **GET** /api/v{apiVersion}/ConfigurationValues/{id} | Get configuration value by id

<a name="apivapiversionconfigurationvaluescountget"></a>
# **ApiVapiVersionConfigurationValuesCountGet**
> void ApiVapiVersionConfigurationValuesCountGet (string apiVersion, string filter = null)

Gets count of configuration values in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionConfigurationValuesCountGetExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationValuesApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of configuration values in database
                apiInstance.ApiVapiVersionConfigurationValuesCountGet(apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationValuesApi.ApiVapiVersionConfigurationValuesCountGet: " + e.Message );
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
<a name="apivapiversionconfigurationvaluesget"></a>
# **ApiVapiVersionConfigurationValuesGet**
> ConfigurationValuePaginatedList ApiVapiVersionConfigurationValuesGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all configuration values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionConfigurationValuesGetExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationValuesApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all configuration values
                ConfigurationValuePaginatedList result = apiInstance.ApiVapiVersionConfigurationValuesGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationValuesApi.ApiVapiVersionConfigurationValuesGet: " + e.Message );
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

[**ConfigurationValuePaginatedList**](ConfigurationValuePaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionconfigurationvaluesiddelete"></a>
# **ApiVapiVersionConfigurationValuesIdDelete**
> IActionResult ApiVapiVersionConfigurationValuesIdDelete (string id, string apiVersion)

Delete configuration value with a specified id from configuration value data table

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionConfigurationValuesIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationValuesApi();
            var id = id_example;  // string | Configuration value id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Delete configuration value with a specified id from configuration value data table
                IActionResult result = apiInstance.ApiVapiVersionConfigurationValuesIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationValuesApi.ApiVapiVersionConfigurationValuesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Configuration value id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionconfigurationvaluesidpatch"></a>
# **ApiVapiVersionConfigurationValuesIdPatch**
> EmailSettings ApiVapiVersionConfigurationValuesIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of configuration value

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionConfigurationValuesIdPatchExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationValuesApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Updates partial details of configuration value
                EmailSettings result = apiInstance.ApiVapiVersionConfigurationValuesIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationValuesApi.ApiVapiVersionConfigurationValuesIdPatch: " + e.Message );
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
<a name="apivapiversionconfigurationvaluesidput"></a>
# **ApiVapiVersionConfigurationValuesIdPut**
> ConfigurationValue ApiVapiVersionConfigurationValuesIdPut (string id, string apiVersion, ConfigurationValue body = null)

Updates configuration value

Provides an action to update a configuration value, when configuration value id and the new details of configuration value are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionConfigurationValuesIdPutExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationValuesApi();
            var id = id_example;  // string | Configuration value id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new ConfigurationValue(); // ConfigurationValue | Configuration value details to be updated (optional) 

            try
            {
                // Updates configuration value
                ConfigurationValue result = apiInstance.ApiVapiVersionConfigurationValuesIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationValuesApi.ApiVapiVersionConfigurationValuesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Configuration value id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**ConfigurationValue**](ConfigurationValue.md)| Configuration value details to be updated | [optional] 

### Return type

[**ConfigurationValue**](ConfigurationValue.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionconfigurationvaluespost"></a>
# **ApiVapiVersionConfigurationValuesPost**
> ConfigurationValue ApiVapiVersionConfigurationValuesPost (string apiVersion, ConfigurationValue body = null)

Adds a new configuration value to the existing configuration values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionConfigurationValuesPostExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationValuesApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new ConfigurationValue(); // ConfigurationValue |  (optional) 

            try
            {
                // Adds a new configuration value to the existing configuration values
                ConfigurationValue result = apiInstance.ApiVapiVersionConfigurationValuesPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationValuesApi.ApiVapiVersionConfigurationValuesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**ConfigurationValue**](ConfigurationValue.md)|  | [optional] 

### Return type

[**ConfigurationValue**](ConfigurationValue.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getconfigurationvalue"></a>
# **GetConfigurationValue**
> ConfigurationValuePaginatedList GetConfigurationValue (string id, string apiVersion)

Get configuration value by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConfigurationValueExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationValuesApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Get configuration value by id
                ConfigurationValuePaginatedList result = apiInstance.GetConfigurationValue(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationValuesApi.GetConfigurationValue: " + e.Message );
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

[**ConfigurationValuePaginatedList**](ConfigurationValuePaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
