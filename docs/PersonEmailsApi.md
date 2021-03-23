# IO.Swagger.Api.PersonEmailsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionPeoplePersonIdPersonEmailsGet**](PersonEmailsApi.md#apivapiversionpeoplepersonidpersonemailsget) | **GET** /api/v{apiVersion}/People/{personId}/PersonEmails | Gets all the email address and verification id for a particular person
[**ApiVapiVersionPeoplePersonIdPersonEmailsIdDelete**](PersonEmailsApi.md#apivapiversionpeoplepersonidpersonemailsiddelete) | **DELETE** /api/v{apiVersion}/People/{personId}/PersonEmails/{id} | Deletes the email details
[**ApiVapiVersionPeoplePersonIdPersonEmailsIdPatch**](PersonEmailsApi.md#apivapiversionpeoplepersonidpersonemailsidpatch) | **PATCH** /api/v{apiVersion}/People/{personId}/PersonEmails/{id} | Updates partial details of email
[**ApiVapiVersionPeoplePersonIdPersonEmailsIdPut**](PersonEmailsApi.md#apivapiversionpeoplepersonidpersonemailsidput) | **PUT** /api/v{apiVersion}/People/{personId}/PersonEmails/{id} | Updates the email details for person
[**ApiVapiVersionPeoplePersonIdPersonEmailsPost**](PersonEmailsApi.md#apivapiversionpeoplepersonidpersonemailspost) | **POST** /api/v{apiVersion}/People/{personId}/PersonEmails | Adds a new email id and verification id for a person
[**GetPersonEmail**](PersonEmailsApi.md#getpersonemail) | **GET** /api/v{apiVersion}/People/{personId}/PersonEmails/{id} | Gets the email address and verfiication id for a particular email for person

<a name="apivapiversionpeoplepersonidpersonemailsget"></a>
# **ApiVapiVersionPeoplePersonIdPersonEmailsGet**
> PersonEmail ApiVapiVersionPeoplePersonIdPersonEmailsGet (string personId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Gets all the email address and verification id for a particular person

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdPersonEmailsGetExample
    {
        public void main()
        {

            var apiInstance = new PersonEmailsApi();
            var personId = personId_example;  // string | Person identifier
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? | returns the top 100 (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Gets all the email address and verification id for a particular person
                PersonEmail result = apiInstance.ApiVapiVersionPeoplePersonIdPersonEmailsGet(personId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEmailsApi.ApiVapiVersionPeoplePersonIdPersonEmailsGet: " + e.Message );
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
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**| returns the top 100 | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**PersonEmail**](PersonEmail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidpersonemailsiddelete"></a>
# **ApiVapiVersionPeoplePersonIdPersonEmailsIdDelete**
> IActionResult ApiVapiVersionPeoplePersonIdPersonEmailsIdDelete (string id, string apiVersion, string personId)

Deletes the email details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdPersonEmailsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new PersonEmailsApi();
            var id = id_example;  // string | Email identifier
            var apiVersion = apiVersion_example;  // string | 
            var personId = personId_example;  // string | 

            try
            {
                // Deletes the email details
                IActionResult result = apiInstance.ApiVapiVersionPeoplePersonIdPersonEmailsIdDelete(id, apiVersion, personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEmailsApi.ApiVapiVersionPeoplePersonIdPersonEmailsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email identifier | 
 **apiVersion** | **string**|  | 
 **personId** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidpersonemailsidpatch"></a>
# **ApiVapiVersionPeoplePersonIdPersonEmailsIdPatch**
> IActionResult ApiVapiVersionPeoplePersonIdPersonEmailsIdPatch (string id, string apiVersion, string personId, List<Operation> body = null)

Updates partial details of email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdPersonEmailsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new PersonEmailsApi();
            var id = id_example;  // string | Person email identifier
            var apiVersion = apiVersion_example;  // string | 
            var personId = personId_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value to be updated (optional) 

            try
            {
                // Updates partial details of email
                IActionResult result = apiInstance.ApiVapiVersionPeoplePersonIdPersonEmailsIdPatch(id, apiVersion, personId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEmailsApi.ApiVapiVersionPeoplePersonIdPersonEmailsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Person email identifier | 
 **apiVersion** | **string**|  | 
 **personId** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidpersonemailsidput"></a>
# **ApiVapiVersionPeoplePersonIdPersonEmailsIdPut**
> IActionResult ApiVapiVersionPeoplePersonIdPersonEmailsIdPut (string personId, string id, string apiVersion, PersonEmail body = null)

Updates the email details for person

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdPersonEmailsIdPutExample
    {
        public void main()
        {

            var apiInstance = new PersonEmailsApi();
            var personId = personId_example;  // string | Person identifier
            var id = id_example;  // string | Email identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new PersonEmail(); // PersonEmail | Value to be updated (optional) 

            try
            {
                // Updates the email details for person
                IActionResult result = apiInstance.ApiVapiVersionPeoplePersonIdPersonEmailsIdPut(personId, id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEmailsApi.ApiVapiVersionPeoplePersonIdPersonEmailsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | **string**| Person identifier | 
 **id** | **string**| Email identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**PersonEmail**](PersonEmail.md)| Value to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidpersonemailspost"></a>
# **ApiVapiVersionPeoplePersonIdPersonEmailsPost**
> PersonEmail ApiVapiVersionPeoplePersonIdPersonEmailsPost (string personId, string apiVersion, PersonEmail body = null)

Adds a new email id and verification id for a person

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdPersonEmailsPostExample
    {
        public void main()
        {

            var apiInstance = new PersonEmailsApi();
            var personId = personId_example;  // string | Person identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new PersonEmail(); // PersonEmail | Email details to be added (optional) 

            try
            {
                // Adds a new email id and verification id for a person
                PersonEmail result = apiInstance.ApiVapiVersionPeoplePersonIdPersonEmailsPost(personId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEmailsApi.ApiVapiVersionPeoplePersonIdPersonEmailsPost: " + e.Message );
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
 **body** | [**PersonEmail**](PersonEmail.md)| Email details to be added | [optional] 

### Return type

[**PersonEmail**](PersonEmail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpersonemail"></a>
# **GetPersonEmail**
> PersonEmail GetPersonEmail (string id, string apiVersion, string personId)

Gets the email address and verfiication id for a particular email for person

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPersonEmailExample
    {
        public void main()
        {

            var apiInstance = new PersonEmailsApi();
            var id = id_example;  // string | Email identifier
            var apiVersion = apiVersion_example;  // string | 
            var personId = personId_example;  // string | 

            try
            {
                // Gets the email address and verfiication id for a particular email for person
                PersonEmail result = apiInstance.GetPersonEmail(id, apiVersion, personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEmailsApi.GetPersonEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email identifier | 
 **apiVersion** | **string**|  | 
 **personId** | **string**|  | 

### Return type

[**PersonEmail**](PersonEmail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
