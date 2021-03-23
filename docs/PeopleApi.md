# IO.Swagger.Api.PeopleApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionPeopleGet**](PeopleApi.md#apivapiversionpeopleget) | **GET** /api/v{apiVersion}/People | Gets all the users (people)
[**ApiVapiVersionPeopleIdDelete**](PeopleApi.md#apivapiversionpeopleiddelete) | **DELETE** /api/v{apiVersion}/People/{id} | Deletes the person details
[**ApiVapiVersionPeopleIdPatch**](PeopleApi.md#apivapiversionpeopleidpatch) | **PATCH** /api/v{apiVersion}/People/{id} | Updates person details
[**ApiVapiVersionPeopleIdPut**](PeopleApi.md#apivapiversionpeopleidput) | **PUT** /api/v{apiVersion}/People/{id} | Updates person details
[**ApiVapiVersionPeoplePost**](PeopleApi.md#apivapiversionpeoplepost) | **POST** /api/v{apiVersion}/People | Adds a person
[**GetPerson**](PeopleApi.md#getperson) | **GET** /api/v{apiVersion}/People/{id} | Retrieves the person details for a particular user

<a name="apivapiversionpeopleget"></a>
# **ApiVapiVersionPeopleGet**
> Person ApiVapiVersionPeopleGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Gets all the users (people)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeopleGetExample
    {
        public void main()
        {

            var apiInstance = new PeopleApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Gets all the users (people)
                Person result = apiInstance.ApiVapiVersionPeopleGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeopleApi.ApiVapiVersionPeopleGet: " + e.Message );
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

[**Person**](Person.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeopleiddelete"></a>
# **ApiVapiVersionPeopleIdDelete**
> IActionResult ApiVapiVersionPeopleIdDelete (string id, string apiVersion)

Deletes the person details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeopleIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new PeopleApi();
            var id = id_example;  // string | Person id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes the person details
                IActionResult result = apiInstance.ApiVapiVersionPeopleIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeopleApi.ApiVapiVersionPeopleIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Person id | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeopleidpatch"></a>
# **ApiVapiVersionPeopleIdPatch**
> IActionResult ApiVapiVersionPeopleIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates person details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeopleIdPatchExample
    {
        public void main()
        {

            var apiInstance = new PeopleApi();
            var id = id_example;  // string | People identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Values to be updated (optional) 

            try
            {
                // Updates person details
                IActionResult result = apiInstance.ApiVapiVersionPeopleIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeopleApi.ApiVapiVersionPeopleIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| People identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Values to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeopleidput"></a>
# **ApiVapiVersionPeopleIdPut**
> IActionResult ApiVapiVersionPeopleIdPut (string id, string apiVersion, Person body = null)

Updates person details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeopleIdPutExample
    {
        public void main()
        {

            var apiInstance = new PeopleApi();
            var id = id_example;  // string | Person id
            var apiVersion = apiVersion_example;  // string | 
            var body = new Person(); // Person | Details to be updated (optional) 

            try
            {
                // Updates person details
                IActionResult result = apiInstance.ApiVapiVersionPeopleIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeopleApi.ApiVapiVersionPeopleIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Person id | 
 **apiVersion** | **string**|  | 
 **body** | [**Person**](Person.md)| Details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepost"></a>
# **ApiVapiVersionPeoplePost**
> Person ApiVapiVersionPeoplePost (string apiVersion, Person body = null)

Adds a person

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePostExample
    {
        public void main()
        {

            var apiInstance = new PeopleApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new Person(); // Person |  (optional) 

            try
            {
                // Adds a person
                Person result = apiInstance.ApiVapiVersionPeoplePost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeopleApi.ApiVapiVersionPeoplePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**Person**](Person.md)|  | [optional] 

### Return type

[**Person**](Person.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getperson"></a>
# **GetPerson**
> Person GetPerson (string id, string apiVersion)

Retrieves the person details for a particular user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPersonExample
    {
        public void main()
        {

            var apiInstance = new PeopleApi();
            var id = id_example;  // string | People identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Retrieves the person details for a particular user
                Person result = apiInstance.GetPerson(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeopleApi.GetPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| People identifier | 
 **apiVersion** | **string**|  | 

### Return type

[**Person**](Person.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
