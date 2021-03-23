# IO.Swagger.Api.EmailsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionEmailsCountGet**](EmailsApi.md#apivapiversionemailscountget) | **GET** /api/v{apiVersion}/Emails/count | Gets count of emails in database
[**ApiVapiVersionEmailsGet**](EmailsApi.md#apivapiversionemailsget) | **GET** /api/v{apiVersion}/Emails | Provides all emails
[**ApiVapiVersionEmailsIdDelete**](EmailsApi.md#apivapiversionemailsiddelete) | **DELETE** /api/v{apiVersion}/Emails/{id} | Delete email with a specified id from list of emails
[**ApiVapiVersionEmailsIdPatch**](EmailsApi.md#apivapiversionemailsidpatch) | **PATCH** /api/v{apiVersion}/Emails/{id} | Updates partial details of email
[**ApiVapiVersionEmailsIdPut**](EmailsApi.md#apivapiversionemailsidput) | **PUT** /api/v{apiVersion}/Emails/{id} | Updates email
[**ApiVapiVersionEmailsIdSendPut**](EmailsApi.md#apivapiversionemailsidsendput) | **PUT** /api/v{apiVersion}/Emails/{id}/send | Send email draft with file attachments
[**ApiVapiVersionEmailsIdUpdatePut**](EmailsApi.md#apivapiversionemailsidupdateput) | **PUT** /api/v{apiVersion}/Emails/{id}/Update | Update the email with file attachments
[**ApiVapiVersionEmailsIdViewGet**](EmailsApi.md#apivapiversionemailsidviewget) | **GET** /api/v{apiVersion}/Emails/{id}/view | Get email by id view
[**ApiVapiVersionEmailsPost**](EmailsApi.md#apivapiversionemailspost) | **POST** /api/v{apiVersion}/Emails | Adds a new draft email to the existing emails
[**ApiVapiVersionEmailsSendPost**](EmailsApi.md#apivapiversionemailssendpost) | **POST** /api/v{apiVersion}/Emails/send | Sends a new email
[**GetEmailModel**](EmailsApi.md#getemailmodel) | **GET** /api/v{apiVersion}/Emails/{id} | Get email by id

<a name="apivapiversionemailscountget"></a>
# **ApiVapiVersionEmailsCountGet**
> void ApiVapiVersionEmailsCountGet (string apiVersion, string filter = null)

Gets count of emails in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsCountGetExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of emails in database
                apiInstance.ApiVapiVersionEmailsCountGet(apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsCountGet: " + e.Message );
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
<a name="apivapiversionemailsget"></a>
# **ApiVapiVersionEmailsGet**
> GetEmailsViewModelPaginatedList ApiVapiVersionEmailsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides all emails

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsGetExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides all emails
                GetEmailsViewModelPaginatedList result = apiInstance.ApiVapiVersionEmailsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsGet: " + e.Message );
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

[**GetEmailsViewModelPaginatedList**](GetEmailsViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsiddelete"></a>
# **ApiVapiVersionEmailsIdDelete**
> IActionResult ApiVapiVersionEmailsIdDelete (string id, string apiVersion, string driveName = null)

Delete email with a specified id from list of emails

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var id = id_example;  // string | Email id to be deleted - throws bad request if null or empty Guid/
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Delete email with a specified id from list of emails
                IActionResult result = apiInstance.ApiVapiVersionEmailsIdDelete(id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email id to be deleted - throws bad request if null or empty Guid/ | 
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
<a name="apivapiversionemailsidpatch"></a>
# **ApiVapiVersionEmailsIdPatch**
> Email ApiVapiVersionEmailsIdPatch (string id, string apiVersion, List<Operation> body = null)

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
    public class ApiVapiVersionEmailsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Updates partial details of email
                Email result = apiInstance.ApiVapiVersionEmailsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsIdPatch: " + e.Message );
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

[**Email**](Email.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsidput"></a>
# **ApiVapiVersionEmailsIdPut**
> Email ApiVapiVersionEmailsIdPut (string id, string apiVersion, Email body = null)

Updates email

Provides an action to update email, when email id and the new details of email are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsIdPutExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var id = id_example;  // string | Email id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new Email(); // Email | Email details to be updated (optional) 

            try
            {
                // Updates email
                Email result = apiInstance.ApiVapiVersionEmailsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**Email**](Email.md)| Email details to be updated | [optional] 

### Return type

[**Email**](Email.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsidsendput"></a>
# **ApiVapiVersionEmailsIdSendPut**
> EmailViewModel ApiVapiVersionEmailsIdSendPut (string id, string apiVersion, string emailAccountName = null)

Send email draft with file attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsIdSendPutExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var emailAccountName = emailAccountName_example;  // string |  (optional) 

            try
            {
                // Send email draft with file attachments
                EmailViewModel result = apiInstance.ApiVapiVersionEmailsIdSendPut(id, apiVersion, emailAccountName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsIdSendPut: " + e.Message );
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
 **emailAccountName** | **string**|  | [optional] 

### Return type

[**EmailViewModel**](EmailViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsidupdateput"></a>
# **ApiVapiVersionEmailsIdUpdatePut**
> UpdateEmailViewModel ApiVapiVersionEmailsIdUpdatePut (string id, string apiVersion)

Update the email with file attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsIdUpdatePutExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Update the email with file attachments
                UpdateEmailViewModel result = apiInstance.ApiVapiVersionEmailsIdUpdatePut(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsIdUpdatePut: " + e.Message );
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

[**UpdateEmailViewModel**](UpdateEmailViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsidviewget"></a>
# **ApiVapiVersionEmailsIdViewGet**
> EmailViewModelPaginatedList ApiVapiVersionEmailsIdViewGet (string id, string apiVersion)

Get email by id view

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsIdViewGetExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Get email by id view
                EmailViewModelPaginatedList result = apiInstance.ApiVapiVersionEmailsIdViewGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsIdViewGet: " + e.Message );
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

[**EmailViewModelPaginatedList**](EmailViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailspost"></a>
# **ApiVapiVersionEmailsPost**
> EmailViewModel ApiVapiVersionEmailsPost (string apiVersion)

Adds a new draft email to the existing emails

Adds the email with unique email id to the existing emails

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsPostExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Adds a new draft email to the existing emails
                EmailViewModel result = apiInstance.ApiVapiVersionEmailsPost(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsPost: " + e.Message );
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

[**EmailViewModel**](EmailViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailssendpost"></a>
# **ApiVapiVersionEmailsSendPost**
> EmailViewModel ApiVapiVersionEmailsSendPost (string apiVersion, string accountName = null)

Sends a new email

Creates an EmailMessage with file attachments to send to an email address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsSendPostExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var apiVersion = apiVersion_example;  // string | 
            var accountName = accountName_example;  // string |  (optional) 

            try
            {
                // Sends a new email
                EmailViewModel result = apiInstance.ApiVapiVersionEmailsSendPost(apiVersion, accountName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.ApiVapiVersionEmailsSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **accountName** | **string**|  | [optional] 

### Return type

[**EmailViewModel**](EmailViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemailmodel"></a>
# **GetEmailModel**
> EmailPaginatedList GetEmailModel (string id, string apiVersion)

Get email by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailModelExample
    {
        public void main()
        {

            var apiInstance = new EmailsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Get email by id
                EmailPaginatedList result = apiInstance.GetEmailModel(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailsApi.GetEmailModel: " + e.Message );
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

[**EmailPaginatedList**](EmailPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
