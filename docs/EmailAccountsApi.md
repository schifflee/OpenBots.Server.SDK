# IO.Swagger.Api.EmailAccountsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionEmailAccountsCountGet**](EmailAccountsApi.md#apivapiversionemailaccountscountget) | **GET** /api/v{apiVersion}/EmailAccounts/count | Gets count of email accounts in database
[**ApiVapiVersionEmailAccountsGet**](EmailAccountsApi.md#apivapiversionemailaccountsget) | **GET** /api/v{apiVersion}/EmailAccounts | Provides a list of all email accounts
[**ApiVapiVersionEmailAccountsGetLookupGet**](EmailAccountsApi.md#apivapiversionemailaccountsgetlookupget) | **GET** /api/v{apiVersion}/EmailAccounts/GetLookup | Lookup list of all email accounts
[**ApiVapiVersionEmailAccountsIdDelete**](EmailAccountsApi.md#apivapiversionemailaccountsiddelete) | **DELETE** /api/v{apiVersion}/EmailAccounts/{id} | Delete email account with a specified id from list of email accounts
[**ApiVapiVersionEmailAccountsIdPatch**](EmailAccountsApi.md#apivapiversionemailaccountsidpatch) | **PATCH** /api/v{apiVersion}/EmailAccounts/{id} | Updates partial details of an email account.
[**ApiVapiVersionEmailAccountsIdPut**](EmailAccountsApi.md#apivapiversionemailaccountsidput) | **PUT** /api/v{apiVersion}/EmailAccounts/{id} | Updates an email account
[**ApiVapiVersionEmailAccountsPost**](EmailAccountsApi.md#apivapiversionemailaccountspost) | **POST** /api/v{apiVersion}/EmailAccounts | Adds a new email account to the existing email accounts
[**GetEmailAccount**](EmailAccountsApi.md#getemailaccount) | **GET** /api/v{apiVersion}/EmailAccounts/{id} | Get email account by id

<a name="apivapiversionemailaccountscountget"></a>
# **ApiVapiVersionEmailAccountsCountGet**
> void ApiVapiVersionEmailAccountsCountGet (string apiVersion, string filter = null)

Gets count of email accounts in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailAccountsCountGetExample
    {
        public void main()
        {

            var apiInstance = new EmailAccountsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of email accounts in database
                apiInstance.ApiVapiVersionEmailAccountsCountGet(apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAccountsApi.ApiVapiVersionEmailAccountsCountGet: " + e.Message );
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
<a name="apivapiversionemailaccountsget"></a>
# **ApiVapiVersionEmailAccountsGet**
> EmailAccountViewModelPaginatedList ApiVapiVersionEmailAccountsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all email accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailAccountsGetExample
    {
        public void main()
        {

            var apiInstance = new EmailAccountsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all email accounts
                EmailAccountViewModelPaginatedList result = apiInstance.ApiVapiVersionEmailAccountsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAccountsApi.ApiVapiVersionEmailAccountsGet: " + e.Message );
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

[**EmailAccountViewModelPaginatedList**](EmailAccountViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailaccountsgetlookupget"></a>
# **ApiVapiVersionEmailAccountsGetLookupGet**
> List<EmailAccountLookup> ApiVapiVersionEmailAccountsGetLookupGet (string apiVersion)

Lookup list of all email accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailAccountsGetLookupGetExample
    {
        public void main()
        {

            var apiInstance = new EmailAccountsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Lookup list of all email accounts
                List&lt;EmailAccountLookup&gt; result = apiInstance.ApiVapiVersionEmailAccountsGetLookupGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAccountsApi.ApiVapiVersionEmailAccountsGetLookupGet: " + e.Message );
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

[**List<EmailAccountLookup>**](EmailAccountLookup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailaccountsiddelete"></a>
# **ApiVapiVersionEmailAccountsIdDelete**
> IActionResult ApiVapiVersionEmailAccountsIdDelete (string id, string apiVersion)

Delete email account with a specified id from list of email accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailAccountsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new EmailAccountsApi();
            var id = id_example;  // string | Email account id to be deleted - throws  bad request if null or empty Guid/
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Delete email account with a specified id from list of email accounts
                IActionResult result = apiInstance.ApiVapiVersionEmailAccountsIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAccountsApi.ApiVapiVersionEmailAccountsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email account id to be deleted - throws  bad request if null or empty Guid/ | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailaccountsidpatch"></a>
# **ApiVapiVersionEmailAccountsIdPatch**
> EmailAccount ApiVapiVersionEmailAccountsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of an email account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailAccountsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new EmailAccountsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Updates partial details of an email account.
                EmailAccount result = apiInstance.ApiVapiVersionEmailAccountsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAccountsApi.ApiVapiVersionEmailAccountsIdPatch: " + e.Message );
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

[**EmailAccount**](EmailAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailaccountsidput"></a>
# **ApiVapiVersionEmailAccountsIdPut**
> EmailAccount ApiVapiVersionEmailAccountsIdPut (string id, string apiVersion, EmailAccount body = null)

Updates an email account

Provides an action to update an email account, when email account id and the new details of email account are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailAccountsIdPutExample
    {
        public void main()
        {

            var apiInstance = new EmailAccountsApi();
            var id = id_example;  // string | Email account id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new EmailAccount(); // EmailAccount | Email account details to be updated (optional) 

            try
            {
                // Updates an email account
                EmailAccount result = apiInstance.ApiVapiVersionEmailAccountsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAccountsApi.ApiVapiVersionEmailAccountsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email account id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**EmailAccount**](EmailAccount.md)| Email account details to be updated | [optional] 

### Return type

[**EmailAccount**](EmailAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailaccountspost"></a>
# **ApiVapiVersionEmailAccountsPost**
> EmailAccount ApiVapiVersionEmailAccountsPost (string apiVersion, EmailAccount body = null)

Adds a new email account to the existing email accounts

Adds the email account with unique email account id to the existing email accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailAccountsPostExample
    {
        public void main()
        {

            var apiInstance = new EmailAccountsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new EmailAccount(); // EmailAccount |  (optional) 

            try
            {
                // Adds a new email account to the existing email accounts
                EmailAccount result = apiInstance.ApiVapiVersionEmailAccountsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAccountsApi.ApiVapiVersionEmailAccountsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**EmailAccount**](EmailAccount.md)|  | [optional] 

### Return type

[**EmailAccount**](EmailAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemailaccount"></a>
# **GetEmailAccount**
> EmailAccountPaginatedList GetEmailAccount (string id, string apiVersion)

Get email account by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailAccountExample
    {
        public void main()
        {

            var apiInstance = new EmailAccountsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Get email account by id
                EmailAccountPaginatedList result = apiInstance.GetEmailAccount(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAccountsApi.GetEmailAccount: " + e.Message );
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

[**EmailAccountPaginatedList**](EmailAccountPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
