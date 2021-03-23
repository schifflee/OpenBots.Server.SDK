# IO.Swagger.Api.AssetsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionAssetsAddAgentAssetPost**](AssetsApi.md#apivapiversionassetsaddagentassetpost) | **POST** /api/v{apiVersion}/Assets/AddAgentAsset | Adds a new agent Asset if a global Asset exists for the given name
[**ApiVapiVersionAssetsCountGet**](AssetsApi.md#apivapiversionassetscountget) | **GET** /api/v{apiVersion}/Assets/Count | Provides a count of Assets
[**ApiVapiVersionAssetsGet**](AssetsApi.md#apivapiversionassetsget) | **GET** /api/v{apiVersion}/Assets | Provides a list of all Assets
[**ApiVapiVersionAssetsGetAssetByNameAssetNameGet**](AssetsApi.md#apivapiversionassetsgetassetbynameassetnameget) | **GET** /api/v{apiVersion}/Assets/GetAssetByName/{assetName} | Provides an Asset&#x27;s details for a particular Asset name
[**ApiVapiVersionAssetsIdAddPut**](AssetsApi.md#apivapiversionassetsidaddput) | **PUT** /api/v{apiVersion}/Assets/{id}/Add | Add the number value of Asset
[**ApiVapiVersionAssetsIdAppendPut**](AssetsApi.md#apivapiversionassetsidappendput) | **PUT** /api/v{apiVersion}/Assets/{id}/Append | Append the text value of Asset
[**ApiVapiVersionAssetsIdDecrementPut**](AssetsApi.md#apivapiversionassetsiddecrementput) | **PUT** /api/v{apiVersion}/Assets/{id}/Decrement | Decrement the number value of Asset
[**ApiVapiVersionAssetsIdDelete**](AssetsApi.md#apivapiversionassetsiddelete) | **DELETE** /api/v{apiVersion}/Assets/{id} | Deletes an Asset with a specified id
[**ApiVapiVersionAssetsIdIncrementPut**](AssetsApi.md#apivapiversionassetsidincrementput) | **PUT** /api/v{apiVersion}/Assets/{id}/Increment | Increment the number value of an Asset
[**ApiVapiVersionAssetsIdPatch**](AssetsApi.md#apivapiversionassetsidpatch) | **PATCH** /api/v{apiVersion}/Assets/{id} | Updates partial details of Asset
[**ApiVapiVersionAssetsIdPut**](AssetsApi.md#apivapiversionassetsidput) | **PUT** /api/v{apiVersion}/Assets/{id} | Updates an Asset
[**ApiVapiVersionAssetsIdSubtractPut**](AssetsApi.md#apivapiversionassetsidsubtractput) | **PUT** /api/v{apiVersion}/Assets/{id}/Subtract | Subtract the number value of Asset
[**ApiVapiVersionAssetsIdUpdatePut**](AssetsApi.md#apivapiversionassetsidupdateput) | **PUT** /api/v{apiVersion}/Assets/{id}/Update | Updates an Asset with file
[**ApiVapiVersionAssetsPost**](AssetsApi.md#apivapiversionassetspost) | **POST** /api/v{apiVersion}/Assets | Create a new Asset entity
[**ApiVapiVersionAssetsViewAssetIdGet**](AssetsApi.md#apivapiversionassetsviewassetidget) | **GET** /api/v{apiVersion}/Assets/view/{assetId} | 
[**ApiVapiVersionAssetsViewGet**](AssetsApi.md#apivapiversionassetsviewget) | **GET** /api/v{apiVersion}/Assets/view | Provides a view model list of all Assets and corresponding Agents and Files
[**ExportAsset**](AssetsApi.md#exportasset) | **GET** /api/v{apiVersion}/Assets/{id}/Export | Export/download an Asset file
[**GetAsset**](AssetsApi.md#getasset) | **GET** /api/v{apiVersion}/Assets/{id} | Provides an Asset&#x27;s details for a particular Asset id

<a name="apivapiversionassetsaddagentassetpost"></a>
# **ApiVapiVersionAssetsAddAgentAssetPost**
> Asset ApiVapiVersionAssetsAddAgentAssetPost (string apiVersion)

Adds a new agent Asset if a global Asset exists for the given name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsAddAgentAssetPostExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Adds a new agent Asset if a global Asset exists for the given name
                Asset result = apiInstance.ApiVapiVersionAssetsAddAgentAssetPost(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsAddAgentAssetPost: " + e.Message );
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

[**Asset**](Asset.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetscountget"></a>
# **ApiVapiVersionAssetsCountGet**
> int? ApiVapiVersionAssetsCountGet (string apiVersion, string filter = null)

Provides a count of Assets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsCountGetExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Provides a count of Assets
                int? result = apiInstance.ApiVapiVersionAssetsCountGet(apiVersion, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsCountGet: " + e.Message );
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

**int?**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsget"></a>
# **ApiVapiVersionAssetsGet**
> AssetPaginatedList ApiVapiVersionAssetsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all Assets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsGetExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all Assets
                AssetPaginatedList result = apiInstance.ApiVapiVersionAssetsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsGet: " + e.Message );
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

[**AssetPaginatedList**](AssetPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsgetassetbynameassetnameget"></a>
# **ApiVapiVersionAssetsGetAssetByNameAssetNameGet**
> Asset ApiVapiVersionAssetsGetAssetByNameAssetNameGet (string assetName, string apiVersion, string assetType = null)

Provides an Asset's details for a particular Asset name

If the requesting user is an Agent with an existing Asset, then that value will be returned

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsGetAssetByNameAssetNameGetExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var assetName = assetName_example;  // string | Asset name
            var apiVersion = apiVersion_example;  // string | 
            var assetType = assetType_example;  // string | Asset type (optional) 

            try
            {
                // Provides an Asset's details for a particular Asset name
                Asset result = apiInstance.ApiVapiVersionAssetsGetAssetByNameAssetNameGet(assetName, apiVersion, assetType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsGetAssetByNameAssetNameGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetName** | **string**| Asset name | 
 **apiVersion** | **string**|  | 
 **assetType** | **string**| Asset type | [optional] 

### Return type

[**Asset**](Asset.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsidaddput"></a>
# **ApiVapiVersionAssetsIdAddPut**
> IActionResult ApiVapiVersionAssetsIdAddPut (string id, string apiVersion, int? value = null)

Add the number value of Asset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsIdAddPutExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset identifier
            var apiVersion = apiVersion_example;  // string | 
            var value = 56;  // int? | Value of the Asset to be updated (optional) 

            try
            {
                // Add the number value of Asset
                IActionResult result = apiInstance.ApiVapiVersionAssetsIdAddPut(id, apiVersion, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsIdAddPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset identifier | 
 **apiVersion** | **string**|  | 
 **value** | **int?**| Value of the Asset to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsidappendput"></a>
# **ApiVapiVersionAssetsIdAppendPut**
> IActionResult ApiVapiVersionAssetsIdAppendPut (string id, string apiVersion, string value = null)

Append the text value of Asset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsIdAppendPutExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset identifier
            var apiVersion = apiVersion_example;  // string | 
            var value = value_example;  // string | Value of the Asset to be updated (optional) 

            try
            {
                // Append the text value of Asset
                IActionResult result = apiInstance.ApiVapiVersionAssetsIdAppendPut(id, apiVersion, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsIdAppendPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset identifier | 
 **apiVersion** | **string**|  | 
 **value** | **string**| Value of the Asset to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsiddecrementput"></a>
# **ApiVapiVersionAssetsIdDecrementPut**
> IActionResult ApiVapiVersionAssetsIdDecrementPut (string id, string apiVersion)

Decrement the number value of Asset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsIdDecrementPutExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Decrement the number value of Asset
                IActionResult result = apiInstance.ApiVapiVersionAssetsIdDecrementPut(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsIdDecrementPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset identifier | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsiddelete"></a>
# **ApiVapiVersionAssetsIdDelete**
> IActionResult ApiVapiVersionAssetsIdDelete (string id, string apiVersion, string driveName = null)

Deletes an Asset with a specified id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Deletes an Asset with a specified id
                IActionResult result = apiInstance.ApiVapiVersionAssetsIdDelete(id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsidincrementput"></a>
# **ApiVapiVersionAssetsIdIncrementPut**
> IActionResult ApiVapiVersionAssetsIdIncrementPut (string id, string apiVersion)

Increment the number value of an Asset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsIdIncrementPutExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Increment the number value of an Asset
                IActionResult result = apiInstance.ApiVapiVersionAssetsIdIncrementPut(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsIdIncrementPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset identifier | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsidpatch"></a>
# **ApiVapiVersionAssetsIdPatch**
> IActionResult ApiVapiVersionAssetsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of Asset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the Asset to be updated (optional) 

            try
            {
                // Updates partial details of Asset
                IActionResult result = apiInstance.ApiVapiVersionAssetsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the Asset to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsidput"></a>
# **ApiVapiVersionAssetsIdPut**
> IActionResult ApiVapiVersionAssetsIdPut (string id, string apiVersion, Asset body = null)

Updates an Asset

Provides an action to update an Asset, when Asset id and the new details of Asset are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsIdPutExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new Asset(); // Asset | Asset details to be updated (optional) 

            try
            {
                // Updates an Asset
                IActionResult result = apiInstance.ApiVapiVersionAssetsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**Asset**](Asset.md)| Asset details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsidsubtractput"></a>
# **ApiVapiVersionAssetsIdSubtractPut**
> IActionResult ApiVapiVersionAssetsIdSubtractPut (string id, string apiVersion, int? value = null)

Subtract the number value of Asset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsIdSubtractPutExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset identifier
            var apiVersion = apiVersion_example;  // string | 
            var value = 56;  // int? | Value of the Asset to be updated (optional) 

            try
            {
                // Subtract the number value of Asset
                IActionResult result = apiInstance.ApiVapiVersionAssetsIdSubtractPut(id, apiVersion, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsIdSubtractPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset identifier | 
 **apiVersion** | **string**|  | 
 **value** | **int?**| Value of the Asset to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsidupdateput"></a>
# **ApiVapiVersionAssetsIdUpdatePut**
> Asset ApiVapiVersionAssetsIdUpdatePut (string id, string apiVersion)

Updates an Asset with file

Provides an action to update an Asset with file, when Asset id and the new details of Asset are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsIdUpdatePutExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Updates an Asset with file
                Asset result = apiInstance.ApiVapiVersionAssetsIdUpdatePut(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsIdUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 

### Return type

[**Asset**](Asset.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetspost"></a>
# **ApiVapiVersionAssetsPost**
> GlobalAssetViewModel ApiVapiVersionAssetsPost (string apiVersion)

Create a new Asset entity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsPostExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Create a new Asset entity
                GlobalAssetViewModel result = apiInstance.ApiVapiVersionAssetsPost(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsPost: " + e.Message );
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

[**GlobalAssetViewModel**](GlobalAssetViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsviewassetidget"></a>
# **ApiVapiVersionAssetsViewAssetIdGet**
> AssetViewModelPaginatedList ApiVapiVersionAssetsViewAssetIdGet (string assetId, string apiVersion)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsViewAssetIdGetExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var assetId = assetId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                AssetViewModelPaginatedList result = apiInstance.ApiVapiVersionAssetsViewAssetIdGet(assetId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsViewAssetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **apiVersion** | **string**|  | 

### Return type

[**AssetViewModelPaginatedList**](AssetViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionassetsviewget"></a>
# **ApiVapiVersionAssetsViewGet**
> AssetViewModelPaginatedList ApiVapiVersionAssetsViewGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a view model list of all Assets and corresponding Agents and Files

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAssetsViewGetExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a view model list of all Assets and corresponding Agents and Files
                AssetViewModelPaginatedList result = apiInstance.ApiVapiVersionAssetsViewGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiVapiVersionAssetsViewGet: " + e.Message );
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

[**AssetViewModelPaginatedList**](AssetViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportasset"></a>
# **ExportAsset**
> MemoryStream ExportAsset (string id, string apiVersion, string driveName = null)

Export/download an Asset file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportAssetExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Export/download an Asset file
                MemoryStream result = apiInstance.ExportAsset(id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.ExportAsset: " + e.Message );
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
 **driveName** | **string**|  | [optional] 

### Return type

[**MemoryStream**](MemoryStream.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getasset"></a>
# **GetAsset**
> Asset GetAsset (string id, string apiVersion)

Provides an Asset's details for a particular Asset id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetExample
    {
        public void main()
        {

            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Asset id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides an Asset's details for a particular Asset id
                Asset result = apiInstance.GetAsset(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Asset id | 
 **apiVersion** | **string**|  | 

### Return type

[**Asset**](Asset.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
