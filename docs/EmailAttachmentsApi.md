# IO.Swagger.Api.EmailAttachmentsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsCountGet**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentscountget) | **GET** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments/count | Gets count of email attachments related to an email in the database
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsDelete**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentsdelete) | **DELETE** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments | Delete all email attachments with a specified email id from list of email attachments
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsFilesPost**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentsfilespost) | **POST** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments/files | Adds email attachments using existing files to the existing email attachments
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsGet**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentsget) | **GET** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments | Provides all email attachments for an email
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsIdDelete**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentsiddelete) | **DELETE** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments/{id} | Delete specific email attachment from list of email attachments
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPatch**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentsidpatch) | **PATCH** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments/{id} | Updates partial details of email attachment
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPut**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentsidput) | **PUT** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments/{id} | Updates email attachment
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsIdUpdatePut**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentsidupdateput) | **PUT** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments/{id}/Update | Updates an email attachment with file
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsPost**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentspost) | **POST** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments | Attach files to an email
[**ApiVapiVersionEmailsEmailIdEmailAttachmentsViewGet**](EmailAttachmentsApi.md#apivapiversionemailsemailidemailattachmentsviewget) | **GET** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments/view | Provides all email attachments view for an email
[**ExportEmailAttachment**](EmailAttachmentsApi.md#exportemailattachment) | **GET** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments/{id}/Export | Export/download an email attachment file
[**GetEmailAttachments**](EmailAttachmentsApi.md#getemailattachments) | **GET** /api/v{apiVersion}/Emails/{emailId}/EmailAttachments/{id} | Get email attachment by id

<a name="apivapiversionemailsemailidemailattachmentscountget"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsCountGet**
> void ApiVapiVersionEmailsEmailIdEmailAttachmentsCountGet (string emailId, string apiVersion, string filter = null)

Gets count of email attachments related to an email in the database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsCountGetExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var emailId = emailId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of email attachments related to an email in the database
                apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsCountGet(emailId, apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsemailidemailattachmentsdelete"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsDelete**
> IActionResult ApiVapiVersionEmailsEmailIdEmailAttachmentsDelete (string emailId, string apiVersion, string driveName = null)

Delete all email attachments with a specified email id from list of email attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsDeleteExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var emailId = emailId_example;  // string | Email id to delete all email attachments from - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Delete all email attachments with a specified email id from list of email attachments
                IActionResult result = apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsDelete(emailId, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**| Email id to delete all email attachments from - throws bad request if null or empty Guid | 
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
<a name="apivapiversionemailsemailidemailattachmentsfilespost"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsFilesPost**
> IActionResult ApiVapiVersionEmailsEmailIdEmailAttachmentsFilesPost (string emailId, string apiVersion, List<string> body = null, string driveName = null)

Adds email attachments using existing files to the existing email attachments

Adds the email attachments with unique email attachment ids to the existing email attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsFilesPostExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var emailId = emailId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<string>(); // List<string> |  (optional) 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Adds email attachments using existing files to the existing email attachments
                IActionResult result = apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsFilesPost(emailId, apiVersion, body, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsFilesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **driveName** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsemailidemailattachmentsget"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsGet**
> IActionResult ApiVapiVersionEmailsEmailIdEmailAttachmentsGet (string emailId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides all email attachments for an email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsGetExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var emailId = emailId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides all email attachments for an email
                IActionResult result = apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsGet(emailId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsemailidemailattachmentsiddelete"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsIdDelete**
> IActionResult ApiVapiVersionEmailsEmailIdEmailAttachmentsIdDelete (string id, string apiVersion, string emailId, string driveName = null)

Delete specific email attachment from list of email attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var id = id_example;  // string | Email attachment id to be deleted - throws bad request if null or empty Guid/
            var apiVersion = apiVersion_example;  // string | 
            var emailId = emailId_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Delete specific email attachment from list of email attachments
                IActionResult result = apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsIdDelete(id, apiVersion, emailId, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email attachment id to be deleted - throws bad request if null or empty Guid/ | 
 **apiVersion** | **string**|  | 
 **emailId** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsemailidemailattachmentsidpatch"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPatch**
> EmailAttachment ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPatch (string id, string apiVersion, string emailId, List<Operation> body = null)

Updates partial details of email attachment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var emailId = emailId_example;  // string | 
            var body = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Updates partial details of email attachment
                EmailAttachment result = apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPatch(id, apiVersion, emailId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPatch: " + e.Message );
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
 **emailId** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)|  | [optional] 

### Return type

[**EmailAttachment**](EmailAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsemailidemailattachmentsidput"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPut**
> IActionResult ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPut (string id, string apiVersion, string emailId, EmailAttachment body = null, string driveName = null)

Updates email attachment

Provides an action to update email attachment, when email attachment id and the new details of email attachment are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPutExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var id = id_example;  // string | Email attachment id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var emailId = emailId_example;  // string | 
            var body = new EmailAttachment(); // EmailAttachment | Email attachment details to be updated (optional) 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Updates email attachment
                IActionResult result = apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPut(id, apiVersion, emailId, body, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email attachment id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **emailId** | **string**|  | 
 **body** | [**EmailAttachment**](EmailAttachment.md)| Email attachment details to be updated | [optional] 
 **driveName** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsemailidemailattachmentsidupdateput"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsIdUpdatePut**
> EmailAttachment ApiVapiVersionEmailsEmailIdEmailAttachmentsIdUpdatePut (string id, string apiVersion, string emailId)

Updates an email attachment with file

Provides an action to update an email attachment with file, when email attachment id and the new details of the email attachment are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsIdUpdatePutExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var id = id_example;  // string | Email attachment id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var emailId = emailId_example;  // string | 

            try
            {
                // Updates an email attachment with file
                EmailAttachment result = apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsIdUpdatePut(id, apiVersion, emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsIdUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Email attachment id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **emailId** | **string**|  | 

### Return type

[**EmailAttachment**](EmailAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsemailidemailattachmentspost"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsPost**
> EmailAttachment ApiVapiVersionEmailsEmailIdEmailAttachmentsPost (string emailId, string apiVersion, string driveName = null)

Attach files to an email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsPostExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var emailId = emailId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Attach files to an email
                EmailAttachment result = apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsPost(emailId, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**EmailAttachment**](EmailAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionemailsemailidemailattachmentsviewget"></a>
# **ApiVapiVersionEmailsEmailIdEmailAttachmentsViewGet**
> AllEmailAttachmentsViewModelPaginatedList ApiVapiVersionEmailsEmailIdEmailAttachmentsViewGet (string emailId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides all email attachments view for an email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionEmailsEmailIdEmailAttachmentsViewGetExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var emailId = emailId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides all email attachments view for an email
                AllEmailAttachmentsViewModelPaginatedList result = apiInstance.ApiVapiVersionEmailsEmailIdEmailAttachmentsViewGet(emailId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ApiVapiVersionEmailsEmailIdEmailAttachmentsViewGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**AllEmailAttachmentsViewModelPaginatedList**](AllEmailAttachmentsViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exportemailattachment"></a>
# **ExportEmailAttachment**
> MemoryStream ExportEmailAttachment (string id, string apiVersion, string emailId, string driveName = null)

Export/download an email attachment file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportEmailAttachmentExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var emailId = emailId_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Export/download an email attachment file
                MemoryStream result = apiInstance.ExportEmailAttachment(id, apiVersion, emailId, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.ExportEmailAttachment: " + e.Message );
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
 **emailId** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**MemoryStream**](MemoryStream.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemailattachments"></a>
# **GetEmailAttachments**
> EmailAttachmentPaginatedList GetEmailAttachments (string id, string apiVersion, string emailId)

Get email attachment by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailAttachmentsExample
    {
        public void main()
        {

            var apiInstance = new EmailAttachmentsApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var emailId = emailId_example;  // string | 

            try
            {
                // Get email attachment by id
                EmailAttachmentPaginatedList result = apiInstance.GetEmailAttachments(id, apiVersion, emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailAttachmentsApi.GetEmailAttachments: " + e.Message );
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
 **emailId** | **string**|  | 

### Return type

[**EmailAttachmentPaginatedList**](EmailAttachmentPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
