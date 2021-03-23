# IO.Swagger.Api.EmailVerificationsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionPeoplePersonIdEmailVerificationsGet**](EmailVerificationsApi.md#apivapiversionpeoplepersonidemailverificationsget) | **GET** /api/v{apiVersion}/People/{personId}/EmailVerifications | Gets all the email verfication details for a particular person
[**ApiVapiVersionPeoplePersonIdEmailVerificationsIdDelete**](EmailVerificationsApi.md#apivapiversionpeoplepersonidemailverificationsiddelete) | **DELETE** /api/v{apiVersion}/People/{personId}/EmailVerifications/{id} | Deletes email verification details
[**ApiVapiVersionPeoplePersonIdEmailVerificationsIdPatch**](EmailVerificationsApi.md#apivapiversionpeoplepersonidemailverificationsidpatch) | **PATCH** /api/v{apiVersion}/People/{personId}/EmailVerifications/{id} | Updates a portion of email verification details
[**ApiVapiVersionPeoplePersonIdEmailVerificationsIdPut**](EmailVerificationsApi.md#apivapiversionpeoplepersonidemailverificationsidput) | **PUT** /api/v{apiVersion}/People/{personId}/EmailVerifications/{id} | Updates the email verfication details for a person
[**ApiVapiVersionPeoplePersonIdEmailVerificationsPost**](EmailVerificationsApi.md#apivapiversionpeoplepersonidemailverificationspost) | **POST** /api/v{apiVersion}/People/{personId}/EmailVerifications | Adds email verfication details for a person
[**GetEmailVerification**](EmailVerificationsApi.md#getemailverification) | **GET** /api/v{apiVersion}/People/{personId}/EmailVerifications/{id} | Provides the email verification details for a particular id

<a name="apivapiversionpeoplepersonidemailverificationsget"></a>
# **ApiVapiVersionPeoplePersonIdEmailVerificationsGet**
> EmailVerification ApiVapiVersionPeoplePersonIdEmailVerificationsGet (string personId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Gets all the email verfication details for a particular person

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdEmailVerificationsGetExample
    {
        public void main()
        {

            var apiInstance = new EmailVerificationsApi();
            var personId = personId_example;  // string | Person identifier
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Gets all the email verfication details for a particular person
                EmailVerification result = apiInstance.ApiVapiVersionPeoplePersonIdEmailVerificationsGet(personId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailVerificationsApi.ApiVapiVersionPeoplePersonIdEmailVerificationsGet: " + e.Message );
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
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**EmailVerification**](EmailVerification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidemailverificationsiddelete"></a>
# **ApiVapiVersionPeoplePersonIdEmailVerificationsIdDelete**
> IActionResult ApiVapiVersionPeoplePersonIdEmailVerificationsIdDelete (string id, string apiVersion, string personId)

Deletes email verification details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdEmailVerificationsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new EmailVerificationsApi();
            var id = id_example;  // string | Email verification identifier
            var apiVersion = apiVersion_example;  // string | 
            var personId = personId_example;  // string | 

            try
            {
                // Deletes email verification details
                IActionResult result = apiInstance.ApiVapiVersionPeoplePersonIdEmailVerificationsIdDelete(id, apiVersion, personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailVerificationsApi.ApiVapiVersionPeoplePersonIdEmailVerificationsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email verification identifier | 
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
<a name="apivapiversionpeoplepersonidemailverificationsidpatch"></a>
# **ApiVapiVersionPeoplePersonIdEmailVerificationsIdPatch**
> IActionResult ApiVapiVersionPeoplePersonIdEmailVerificationsIdPatch (string id, string apiVersion, string personId, List<Operation> body = null)

Updates a portion of email verification details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdEmailVerificationsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new EmailVerificationsApi();
            var id = id_example;  // string | Email verification identifier
            var apiVersion = apiVersion_example;  // string | 
            var personId = personId_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value to be updated (optional) 

            try
            {
                // Updates a portion of email verification details
                IActionResult result = apiInstance.ApiVapiVersionPeoplePersonIdEmailVerificationsIdPatch(id, apiVersion, personId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailVerificationsApi.ApiVapiVersionPeoplePersonIdEmailVerificationsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email verification identifier | 
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
<a name="apivapiversionpeoplepersonidemailverificationsidput"></a>
# **ApiVapiVersionPeoplePersonIdEmailVerificationsIdPut**
> IActionResult ApiVapiVersionPeoplePersonIdEmailVerificationsIdPut (string personId, string id, string apiVersion, EmailVerification body = null)

Updates the email verfication details for a person

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdEmailVerificationsIdPutExample
    {
        public void main()
        {

            var apiInstance = new EmailVerificationsApi();
            var personId = personId_example;  // string | Person identifier
            var id = id_example;  // string | Email verfication identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new EmailVerification(); // EmailVerification | Value to be updated (optional) 

            try
            {
                // Updates the email verfication details for a person
                IActionResult result = apiInstance.ApiVapiVersionPeoplePersonIdEmailVerificationsIdPut(personId, id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailVerificationsApi.ApiVapiVersionPeoplePersonIdEmailVerificationsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | **string**| Person identifier | 
 **id** | **string**| Email verfication identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**EmailVerification**](EmailVerification.md)| Value to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionpeoplepersonidemailverificationspost"></a>
# **ApiVapiVersionPeoplePersonIdEmailVerificationsPost**
> EmailVerification ApiVapiVersionPeoplePersonIdEmailVerificationsPost (string personId, string apiVersion, EmailVerification body = null)

Adds email verfication details for a person

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionPeoplePersonIdEmailVerificationsPostExample
    {
        public void main()
        {

            var apiInstance = new EmailVerificationsApi();
            var personId = personId_example;  // string | Person identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new EmailVerification(); // EmailVerification | Value of the email verfication details to be added (optional) 

            try
            {
                // Adds email verfication details for a person
                EmailVerification result = apiInstance.ApiVapiVersionPeoplePersonIdEmailVerificationsPost(personId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailVerificationsApi.ApiVapiVersionPeoplePersonIdEmailVerificationsPost: " + e.Message );
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
 **body** | [**EmailVerification**](EmailVerification.md)| Value of the email verfication details to be added | [optional] 

### Return type

[**EmailVerification**](EmailVerification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemailverification"></a>
# **GetEmailVerification**
> EmailVerification GetEmailVerification (string id, string apiVersion, string personId)

Provides the email verification details for a particular id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailVerificationExample
    {
        public void main()
        {

            var apiInstance = new EmailVerificationsApi();
            var id = id_example;  // string | Email verfication id
            var apiVersion = apiVersion_example;  // string | 
            var personId = personId_example;  // string | 

            try
            {
                // Provides the email verification details for a particular id
                EmailVerification result = apiInstance.GetEmailVerification(id, apiVersion, personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailVerificationsApi.GetEmailVerification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email verfication id | 
 **apiVersion** | **string**|  | 
 **personId** | **string**|  | 

### Return type

[**EmailVerification**](EmailVerification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
