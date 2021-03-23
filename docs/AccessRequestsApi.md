# IO.Swagger.Api.AccessRequestsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionOrganizationsOrganizationIdAccessRequestsGet**](AccessRequestsApi.md#apivapiversionorganizationsorganizationidaccessrequestsget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/AccessRequests | Provides all the access requests for the given organization
[**ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdApprovePut**](AccessRequestsApi.md#apivapiversionorganizationsorganizationidaccessrequestsidapproveput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/AccessRequests/{id}/Approve | Approves the specified access request by an organization administrator
[**ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdDelete**](AccessRequestsApi.md#apivapiversionorganizationsorganizationidaccessrequestsiddelete) | **DELETE** /api/v{apiVersion}/Organizations/{organizationId}/AccessRequests/{id} | Deletes access request
[**ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPatch**](AccessRequestsApi.md#apivapiversionorganizationsorganizationidaccessrequestsidpatch) | **PATCH** /api/v{apiVersion}/Organizations/{organizationId}/AccessRequests/{id} | Updates partial details of an access request
[**ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPut**](AccessRequestsApi.md#apivapiversionorganizationsorganizationidaccessrequestsidput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/AccessRequests/{id} | Update the access request
[**ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdRejectPut**](AccessRequestsApi.md#apivapiversionorganizationsorganizationidaccessrequestsidrejectput) | **PUT** /api/v{apiVersion}/Organizations/{organizationId}/AccessRequests/{id}/Reject | Rejects the specified access request by an organization administrator
[**ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPendingGet**](AccessRequestsApi.md#apivapiversionorganizationsorganizationidaccessrequestspendingget) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/AccessRequests/Pending | Pending access requests
[**ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPost**](AccessRequestsApi.md#apivapiversionorganizationsorganizationidaccessrequestspost) | **POST** /api/v{apiVersion}/Organizations/{organizationId}/AccessRequests | Adds a new access request to the organization
[**GetAccessRequest**](AccessRequestsApi.md#getaccessrequest) | **GET** /api/v{apiVersion}/Organizations/{organizationId}/AccessRequests/{id} | Get the access request

<a name="apivapiversionorganizationsorganizationidaccessrequestsget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdAccessRequestsGet**
> AccessRequest ApiVapiVersionOrganizationsOrganizationIdAccessRequestsGet (string organizationId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides all the access requests for the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdAccessRequestsGetExample
    {
        public void main()
        {

            var apiInstance = new AccessRequestsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides all the access requests for the given organization
                AccessRequest result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsGet(organizationId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessRequestsApi.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**AccessRequest**](AccessRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidaccessrequestsidapproveput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdApprovePut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdApprovePut (string organizationId, string id, string apiVersion)

Approves the specified access request by an organization administrator

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdApprovePutExample
    {
        public void main()
        {

            var apiInstance = new AccessRequestsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var id = id_example;  // string | Access request identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Approves the specified access request by an organization administrator
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdApprovePut(organizationId, id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessRequestsApi.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdApprovePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **id** | **string**| Access request identifier | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidaccessrequestsiddelete"></a>
# **ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdDelete**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdDelete (string id, string apiVersion, string organizationId)

Deletes access request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new AccessRequestsApi();
            var id = id_example;  // string | Access request identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Deletes access request
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdDelete(id, apiVersion, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessRequestsApi.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Access request identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidaccessrequestsidpatch"></a>
# **ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPatch**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPatch (string id, string apiVersion, string organizationId, List<Operation> body = null)

Updates partial details of an access request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new AccessRequestsApi();
            var id = id_example;  // string | Access request identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Details of access request to be updated (optional) 

            try
            {
                // Updates partial details of an access request
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPatch(id, apiVersion, organizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessRequestsApi.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Access request identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Details of access request to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidaccessrequestsidput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPut (string organizationId, string id, string apiVersion, AccessRequest body = null)

Update the access request

Updates the access request with the particular id for the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPutExample
    {
        public void main()
        {

            var apiInstance = new AccessRequestsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var id = id_example;  // string | Access request id
            var apiVersion = apiVersion_example;  // string | 
            var body = new AccessRequest(); // AccessRequest | New value of the access request to be updated (optional) 

            try
            {
                // Update the access request
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPut(organizationId, id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessRequestsApi.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **id** | **string**| Access request id | 
 **apiVersion** | **string**|  | 
 **body** | [**AccessRequest**](AccessRequest.md)| New value of the access request to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidaccessrequestsidrejectput"></a>
# **ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdRejectPut**
> IActionResult ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdRejectPut (string organizationId, string id, string apiVersion)

Rejects the specified access request by an organization administrator

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdRejectPutExample
    {
        public void main()
        {

            var apiInstance = new AccessRequestsApi();
            var organizationId = organizationId_example;  // string | Organization identifier.
            var id = id_example;  // string | Access request identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Rejects the specified access request by an organization administrator
                IActionResult result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdRejectPut(organizationId, id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessRequestsApi.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsIdRejectPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier. | 
 **id** | **string**| Access request identifier | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidaccessrequestspendingget"></a>
# **ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPendingGet**
> PendingAccessRequestPaginatedList ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPendingGet (string organizationId, string apiVersion)

Pending access requests

Provides the paginated pending access requests for the organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPendingGetExample
    {
        public void main()
        {

            var apiInstance = new AccessRequestsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Pending access requests
                PendingAccessRequestPaginatedList result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPendingGet(organizationId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessRequestsApi.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPendingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **apiVersion** | **string**|  | 

### Return type

[**PendingAccessRequestPaginatedList**](PendingAccessRequestPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionorganizationsorganizationidaccessrequestspost"></a>
# **ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPost**
> AccessRequest ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPost (string organizationId, string apiVersion, AccessRequest body = null)

Adds a new access request to the organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPostExample
    {
        public void main()
        {

            var apiInstance = new AccessRequestsApi();
            var organizationId = organizationId_example;  // string | Organization identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new AccessRequest(); // AccessRequest | Access request details (optional) 

            try
            {
                // Adds a new access request to the organization
                AccessRequest result = apiInstance.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPost(organizationId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessRequestsApi.ApiVapiVersionOrganizationsOrganizationIdAccessRequestsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**AccessRequest**](AccessRequest.md)| Access request details | [optional] 

### Return type

[**AccessRequest**](AccessRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getaccessrequest"></a>
# **GetAccessRequest**
> AccessRequest GetAccessRequest (string id, string apiVersion, string organizationId)

Get the access request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccessRequestExample
    {
        public void main()
        {

            var apiInstance = new AccessRequestsApi();
            var id = id_example;  // string | Access request identifier
            var apiVersion = apiVersion_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Get the access request
                AccessRequest result = apiInstance.GetAccessRequest(id, apiVersion, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessRequestsApi.GetAccessRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Access request identifier | 
 **apiVersion** | **string**|  | 
 **organizationId** | **string**|  | 

### Return type

[**AccessRequest**](AccessRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
