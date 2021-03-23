# IO.Swagger.Api.LookupValuesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionLookupValuesGet**](LookupValuesApi.md#apivapiversionlookupvaluesget) | **GET** /api/v{apiVersion}/LookupValues | Provides a list of all lookup values
[**ApiVapiVersionLookupValuesIdDelete**](LookupValuesApi.md#apivapiversionlookupvaluesiddelete) | **DELETE** /api/v{apiVersion}/LookupValues/{id} | Deletes a lookup value with a specified id
[**ApiVapiVersionLookupValuesIdPatch**](LookupValuesApi.md#apivapiversionlookupvaluesidpatch) | **PATCH** /api/v{apiVersion}/LookupValues/{id} | Updates partial details of a lookup value
[**ApiVapiVersionLookupValuesIdPut**](LookupValuesApi.md#apivapiversionlookupvaluesidput) | **PUT** /api/v{apiVersion}/LookupValues/{id} | Updates a lookup value
[**ApiVapiVersionLookupValuesPost**](LookupValuesApi.md#apivapiversionlookupvaluespost) | **POST** /api/v{apiVersion}/LookupValues | Adds a new lookup value to the existing lookup values
[**GetLookupValue**](LookupValuesApi.md#getlookupvalue) | **GET** /api/v{apiVersion}/LookupValues/{codeType} | Provides lookup value details for a particular id

<a name="apivapiversionlookupvaluesget"></a>
# **ApiVapiVersionLookupValuesGet**
> LookupValuePaginatedList ApiVapiVersionLookupValuesGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all lookup values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionLookupValuesGetExample
    {
        public void main()
        {

            var apiInstance = new LookupValuesApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all lookup values
                LookupValuePaginatedList result = apiInstance.ApiVapiVersionLookupValuesGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookupValuesApi.ApiVapiVersionLookupValuesGet: " + e.Message );
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

[**LookupValuePaginatedList**](LookupValuePaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionlookupvaluesiddelete"></a>
# **ApiVapiVersionLookupValuesIdDelete**
> IActionResult ApiVapiVersionLookupValuesIdDelete (string id, string apiVersion)

Deletes a lookup value with a specified id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionLookupValuesIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new LookupValuesApi();
            var id = id_example;  // string | Lookup value id to be soft deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes a lookup value with a specified id
                IActionResult result = apiInstance.ApiVapiVersionLookupValuesIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookupValuesApi.ApiVapiVersionLookupValuesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Lookup value id to be soft deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionlookupvaluesidpatch"></a>
# **ApiVapiVersionLookupValuesIdPatch**
> IActionResult ApiVapiVersionLookupValuesIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of a lookup value

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionLookupValuesIdPatchExample
    {
        public void main()
        {

            var apiInstance = new LookupValuesApi();
            var id = id_example;  // string | Lookup value identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the lookup value to be updated (optional) 

            try
            {
                // Updates partial details of a lookup value
                IActionResult result = apiInstance.ApiVapiVersionLookupValuesIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookupValuesApi.ApiVapiVersionLookupValuesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Lookup value identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the lookup value to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionlookupvaluesidput"></a>
# **ApiVapiVersionLookupValuesIdPut**
> IActionResult ApiVapiVersionLookupValuesIdPut (string id, string apiVersion, LookupValue body = null)

Updates a lookup value

Provides an action to update a lookup value, when lookup value id and the new details of lookup value are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionLookupValuesIdPutExample
    {
        public void main()
        {

            var apiInstance = new LookupValuesApi();
            var id = id_example;  // string | Lookup value id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new LookupValue(); // LookupValue | lookup value details to be updated (optional) 

            try
            {
                // Updates a lookup value
                IActionResult result = apiInstance.ApiVapiVersionLookupValuesIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookupValuesApi.ApiVapiVersionLookupValuesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Lookup value id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**LookupValue**](LookupValue.md)| lookup value details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionlookupvaluespost"></a>
# **ApiVapiVersionLookupValuesPost**
> LookupValue ApiVapiVersionLookupValuesPost (string apiVersion, LookupValue body = null)

Adds a new lookup value to the existing lookup values

Adds the lookup value with unique lookup value id to the existing lookup values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionLookupValuesPostExample
    {
        public void main()
        {

            var apiInstance = new LookupValuesApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new LookupValue(); // LookupValue |  (optional) 

            try
            {
                // Adds a new lookup value to the existing lookup values
                LookupValue result = apiInstance.ApiVapiVersionLookupValuesPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookupValuesApi.ApiVapiVersionLookupValuesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**LookupValue**](LookupValue.md)|  | [optional] 

### Return type

[**LookupValue**](LookupValue.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlookupvalue"></a>
# **GetLookupValue**
> LookupValuePaginatedList GetLookupValue (string codeType, string apiVersion)

Provides lookup value details for a particular id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLookupValueExample
    {
        public void main()
        {

            var apiInstance = new LookupValuesApi();
            var codeType = codeType_example;  // string | Lookup value id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides lookup value details for a particular id
                LookupValuePaginatedList result = apiInstance.GetLookupValue(codeType, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookupValuesApi.GetLookupValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codeType** | **string**| Lookup value id | 
 **apiVersion** | **string**|  | 

### Return type

[**LookupValuePaginatedList**](LookupValuePaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
