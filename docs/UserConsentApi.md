# IO.Swagger.Api.UserConsentApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionUserConsentGet**](UserConsentApi.md#apivapiversionuserconsentget) | **GET** /api/v{apiVersion}/UserConsent | Provides a list of all user consents
[**ApiVapiVersionUserConsentIdDelete**](UserConsentApi.md#apivapiversionuserconsentiddelete) | **DELETE** /api/v{apiVersion}/UserConsent/{id} | Deletes user consent with a specified id from the database.
[**ApiVapiVersionUserConsentIdPatch**](UserConsentApi.md#apivapiversionuserconsentidpatch) | **PATCH** /api/v{apiVersion}/UserConsent/{id} | Updates partial details of user consent.
[**ApiVapiVersionUserConsentIdPut**](UserConsentApi.md#apivapiversionuserconsentidput) | **PUT** /api/v{apiVersion}/UserConsent/{id} | Updates user consent entity
[**ApiVapiVersionUserConsentPost**](UserConsentApi.md#apivapiversionuserconsentpost) | **POST** /api/v{apiVersion}/UserConsent | Save user constent
[**GetUserConsent**](UserConsentApi.md#getuserconsent) | **GET** /api/v{apiVersion}/UserConsent/{id} | Provides a user consent details for a particular organization id.

<a name="apivapiversionuserconsentget"></a>
# **ApiVapiVersionUserConsentGet**
> UserConsentPaginatedList ApiVapiVersionUserConsentGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all user consents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionUserConsentGetExample
    {
        public void main()
        {

            var apiInstance = new UserConsentApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all user consents
                UserConsentPaginatedList result = apiInstance.ApiVapiVersionUserConsentGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserConsentApi.ApiVapiVersionUserConsentGet: " + e.Message );
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

[**UserConsentPaginatedList**](UserConsentPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionuserconsentiddelete"></a>
# **ApiVapiVersionUserConsentIdDelete**
> IActionResult ApiVapiVersionUserConsentIdDelete (string id, string apiVersion)

Deletes user consent with a specified id from the database.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionUserConsentIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new UserConsentApi();
            var id = id_example;  // string | User consent id to be deleted - throws bad request if null or empty Guid/
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes user consent with a specified id from the database.
                IActionResult result = apiInstance.ApiVapiVersionUserConsentIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserConsentApi.ApiVapiVersionUserConsentIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User consent id to be deleted - throws bad request if null or empty Guid/ | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionuserconsentidpatch"></a>
# **ApiVapiVersionUserConsentIdPatch**
> IActionResult ApiVapiVersionUserConsentIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of user consent.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionUserConsentIdPatchExample
    {
        public void main()
        {

            var apiInstance = new UserConsentApi();
            var id = id_example;  // string | user consent identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | value of the user consent to be updated. (optional) 

            try
            {
                // Updates partial details of user consent.
                IActionResult result = apiInstance.ApiVapiVersionUserConsentIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserConsentApi.ApiVapiVersionUserConsentIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| user consent identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| value of the user consent to be updated. | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionuserconsentidput"></a>
# **ApiVapiVersionUserConsentIdPut**
> UserConsent ApiVapiVersionUserConsentIdPut (string id, string apiVersion, UserConsent body = null)

Updates user consent entity

Provides an action to update user consent, when user consent id and the new details of user consent are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionUserConsentIdPutExample
    {
        public void main()
        {

            var apiInstance = new UserConsentApi();
            var id = id_example;  // string | User consent id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new UserConsent(); // UserConsent | User consent details to be updated (optional) 

            try
            {
                // Updates user consent entity
                UserConsent result = apiInstance.ApiVapiVersionUserConsentIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserConsentApi.ApiVapiVersionUserConsentIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User consent id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**UserConsent**](UserConsent.md)| User consent details to be updated | [optional] 

### Return type

[**UserConsent**](UserConsent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionuserconsentpost"></a>
# **ApiVapiVersionUserConsentPost**
> UserConsent ApiVapiVersionUserConsentPost (string apiVersion, UserConsent body = null)

Save user constent

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionUserConsentPostExample
    {
        public void main()
        {

            var apiInstance = new UserConsentApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new UserConsent(); // UserConsent |  (optional) 

            try
            {
                // Save user constent
                UserConsent result = apiInstance.ApiVapiVersionUserConsentPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserConsentApi.ApiVapiVersionUserConsentPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**UserConsent**](UserConsent.md)|  | [optional] 

### Return type

[**UserConsent**](UserConsent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuserconsent"></a>
# **GetUserConsent**
> UserConsent GetUserConsent (string id, string apiVersion)

Provides a user consent details for a particular organization id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserConsentExample
    {
        public void main()
        {

            var apiInstance = new UserConsentApi();
            var id = id_example;  // string | User consent id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a user consent details for a particular organization id.
                UserConsent result = apiInstance.GetUserConsent(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserConsentApi.GetUserConsent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User consent id | 
 **apiVersion** | **string**|  | 

### Return type

[**UserConsent**](UserConsent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
