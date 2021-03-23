# IO.Swagger.Api.IntegrationEventSubscriptionsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionIntegrationEventSubscriptionsGet**](IntegrationEventSubscriptionsApi.md#apivapiversionintegrationeventsubscriptionsget) | **GET** /api/v{apiVersion}/IntegrationEventSubscriptions | Provides a list of all Integration Event Subscriptions
[**ApiVapiVersionIntegrationEventSubscriptionsIdDelete**](IntegrationEventSubscriptionsApi.md#apivapiversionintegrationeventsubscriptionsiddelete) | **DELETE** /api/v{apiVersion}/IntegrationEventSubscriptions/{id} | Deletes an IntegrationEventSubscription with a specified id
[**ApiVapiVersionIntegrationEventSubscriptionsIdPatch**](IntegrationEventSubscriptionsApi.md#apivapiversionintegrationeventsubscriptionsidpatch) | **PATCH** /api/v{apiVersion}/IntegrationEventSubscriptions/{id} | Updates partial details of IntegrationEventSubscription
[**ApiVapiVersionIntegrationEventSubscriptionsIdPut**](IntegrationEventSubscriptionsApi.md#apivapiversionintegrationeventsubscriptionsidput) | **PUT** /api/v{apiVersion}/IntegrationEventSubscriptions/{id} | Updates an IntegrationEventSubscription
[**ApiVapiVersionIntegrationEventSubscriptionsPost**](IntegrationEventSubscriptionsApi.md#apivapiversionintegrationeventsubscriptionspost) | **POST** /api/v{apiVersion}/IntegrationEventSubscriptions | Adds a new IntegrationEventSubscription to the existing IntegrationEventSubscriptions
[**GetIntegrationEventSubscription**](IntegrationEventSubscriptionsApi.md#getintegrationeventsubscription) | **GET** /api/v{apiVersion}/IntegrationEventSubscriptions/{id} | Provides an IntegrationEventSubscription&#x27;s details for a particular IntegrationEventSubscription id

<a name="apivapiversionintegrationeventsubscriptionsget"></a>
# **ApiVapiVersionIntegrationEventSubscriptionsGet**
> IntegrationEventSubscriptionPaginatedList ApiVapiVersionIntegrationEventSubscriptionsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all Integration Event Subscriptions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventSubscriptionsGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all Integration Event Subscriptions
                IntegrationEventSubscriptionPaginatedList result = apiInstance.ApiVapiVersionIntegrationEventSubscriptionsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionsApi.ApiVapiVersionIntegrationEventSubscriptionsGet: " + e.Message );
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

[**IntegrationEventSubscriptionPaginatedList**](IntegrationEventSubscriptionPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionintegrationeventsubscriptionsiddelete"></a>
# **ApiVapiVersionIntegrationEventSubscriptionsIdDelete**
> IActionResult ApiVapiVersionIntegrationEventSubscriptionsIdDelete (string id, string apiVersion)

Deletes an IntegrationEventSubscription with a specified id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventSubscriptionsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionsApi();
            var id = id_example;  // string | IntegrationEventSubscription id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes an IntegrationEventSubscription with a specified id
                IActionResult result = apiInstance.ApiVapiVersionIntegrationEventSubscriptionsIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionsApi.ApiVapiVersionIntegrationEventSubscriptionsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| IntegrationEventSubscription id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionintegrationeventsubscriptionsidpatch"></a>
# **ApiVapiVersionIntegrationEventSubscriptionsIdPatch**
> IActionResult ApiVapiVersionIntegrationEventSubscriptionsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of IntegrationEventSubscription

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventSubscriptionsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionsApi();
            var id = id_example;  // string | IntegrationEventSubscription identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the IntegrationEventSubscription to be updated (optional) 

            try
            {
                // Updates partial details of IntegrationEventSubscription
                IActionResult result = apiInstance.ApiVapiVersionIntegrationEventSubscriptionsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionsApi.ApiVapiVersionIntegrationEventSubscriptionsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| IntegrationEventSubscription identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the IntegrationEventSubscription to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionintegrationeventsubscriptionsidput"></a>
# **ApiVapiVersionIntegrationEventSubscriptionsIdPut**
> IActionResult ApiVapiVersionIntegrationEventSubscriptionsIdPut (string id, string apiVersion, IntegrationEventSubscription body = null)

Updates an IntegrationEventSubscription

Provides an action to update an IntegrationEventSubscription, when id and the new details of   IntegrationEventSubscription are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventSubscriptionsIdPutExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionsApi();
            var id = id_example;  // string | IntegrationEventSubscription Id,produces Bad request if Id is null or Id's don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new IntegrationEventSubscription(); // IntegrationEventSubscription | IntegrationEventSubscription details to be updated (optional) 

            try
            {
                // Updates an IntegrationEventSubscription
                IActionResult result = apiInstance.ApiVapiVersionIntegrationEventSubscriptionsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionsApi.ApiVapiVersionIntegrationEventSubscriptionsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| IntegrationEventSubscription Id,produces Bad request if Id is null or Id&#x27;s don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**IntegrationEventSubscription**](IntegrationEventSubscription.md)| IntegrationEventSubscription details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionintegrationeventsubscriptionspost"></a>
# **ApiVapiVersionIntegrationEventSubscriptionsPost**
> IntegrationEventSubscription ApiVapiVersionIntegrationEventSubscriptionsPost (string apiVersion, IntegrationEventSubscription body = null)

Adds a new IntegrationEventSubscription to the existing IntegrationEventSubscriptions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionIntegrationEventSubscriptionsPostExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new IntegrationEventSubscription(); // IntegrationEventSubscription |  (optional) 

            try
            {
                // Adds a new IntegrationEventSubscription to the existing IntegrationEventSubscriptions
                IntegrationEventSubscription result = apiInstance.ApiVapiVersionIntegrationEventSubscriptionsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionsApi.ApiVapiVersionIntegrationEventSubscriptionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**IntegrationEventSubscription**](IntegrationEventSubscription.md)|  | [optional] 

### Return type

[**IntegrationEventSubscription**](IntegrationEventSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getintegrationeventsubscription"></a>
# **GetIntegrationEventSubscription**
> IntegrationEventSubscription GetIntegrationEventSubscription (string id, string apiVersion)

Provides an IntegrationEventSubscription's details for a particular IntegrationEventSubscription id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIntegrationEventSubscriptionExample
    {
        public void main()
        {

            var apiInstance = new IntegrationEventSubscriptionsApi();
            var id = id_example;  // string | IntegrationEventSubscription id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides an IntegrationEventSubscription's details for a particular IntegrationEventSubscription id
                IntegrationEventSubscription result = apiInstance.GetIntegrationEventSubscription(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationEventSubscriptionsApi.GetIntegrationEventSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| IntegrationEventSubscription id | 
 **apiVersion** | **string**|  | 

### Return type

[**IntegrationEventSubscription**](IntegrationEventSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
