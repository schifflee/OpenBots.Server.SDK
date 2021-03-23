# IO.Swagger.Api.AuditLogsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionAuditLogsAuditLogsLookupGet**](AuditLogsApi.md#apivapiversionauditlogsauditlogslookupget) | **GET** /api/v{apiVersion}/AuditLogs/AuditLogsLookup | Provides a list of all audit logs by name
[**ApiVapiVersionAuditLogsCountGet**](AuditLogsApi.md#apivapiversionauditlogscountget) | **GET** /api/v{apiVersion}/AuditLogs/count | Gets count of AuditLogs in database
[**ApiVapiVersionAuditLogsExportFileTypeGet**](AuditLogsApi.md#apivapiversionauditlogsexportfiletypeget) | **GET** /api/v{apiVersion}/AuditLogs/export/{fileType} | Exports audit logs into a downloadable file
[**ApiVapiVersionAuditLogsGet**](AuditLogsApi.md#apivapiversionauditlogsget) | **GET** /api/v{apiVersion}/AuditLogs | Provides a list of all audit logs
[**ApiVapiVersionAuditLogsIdGet**](AuditLogsApi.md#apivapiversionauditlogsidget) | **GET** /api/v{apiVersion}/AuditLogs/{id} | Provides additional details on a specific audit Log
[**ApiVapiVersionAuditLogsIdViewGet**](AuditLogsApi.md#apivapiversionauditlogsidviewget) | **GET** /api/v{apiVersion}/AuditLogs/{id}/view | Provides additional ViewModel details on a specific audit Log
[**ApiVapiVersionAuditLogsViewGet**](AuditLogsApi.md#apivapiversionauditlogsviewget) | **GET** /api/v{apiVersion}/AuditLogs/view | Provides a ViewModel list of all audit logs

<a name="apivapiversionauditlogsauditlogslookupget"></a>
# **ApiVapiVersionAuditLogsAuditLogsLookupGet**
> List<AuditLogsLookupViewModel> ApiVapiVersionAuditLogsAuditLogsLookupGet (string apiVersion)

Provides a list of all audit logs by name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuditLogsAuditLogsLookupGetExample
    {
        public void main()
        {

            var apiInstance = new AuditLogsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a list of all audit logs by name
                List&lt;AuditLogsLookupViewModel&gt; result = apiInstance.ApiVapiVersionAuditLogsAuditLogsLookupGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogsApi.ApiVapiVersionAuditLogsAuditLogsLookupGet: " + e.Message );
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

[**List<AuditLogsLookupViewModel>**](AuditLogsLookupViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauditlogscountget"></a>
# **ApiVapiVersionAuditLogsCountGet**
> void ApiVapiVersionAuditLogsCountGet (string apiVersion, string filter = null)

Gets count of AuditLogs in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuditLogsCountGetExample
    {
        public void main()
        {

            var apiInstance = new AuditLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of AuditLogs in database
                apiInstance.ApiVapiVersionAuditLogsCountGet(apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogsApi.ApiVapiVersionAuditLogsCountGet: " + e.Message );
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
<a name="apivapiversionauditlogsexportfiletypeget"></a>
# **ApiVapiVersionAuditLogsExportFileTypeGet**
> void ApiVapiVersionAuditLogsExportFileTypeGet (string fileType, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Exports audit logs into a downloadable file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuditLogsExportFileTypeGetExample
    {
        public void main()
        {

            var apiInstance = new AuditLogsApi();
            var fileType = fileType_example;  // string | Specifies the file type to be downloaded: csv, zip or, json
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 0)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Exports audit logs into a downloadable file
                apiInstance.ApiVapiVersionAuditLogsExportFileTypeGet(fileType, apiVersion, filter, orderby, top, skip);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogsApi.ApiVapiVersionAuditLogsExportFileTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileType** | **string**| Specifies the file type to be downloaded: csv, zip or, json | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 0]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, application/zip, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauditlogsget"></a>
# **ApiVapiVersionAuditLogsGet**
> AuditLogViewModelPaginatedList ApiVapiVersionAuditLogsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all audit logs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuditLogsGetExample
    {
        public void main()
        {

            var apiInstance = new AuditLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all audit logs
                AuditLogViewModelPaginatedList result = apiInstance.ApiVapiVersionAuditLogsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogsApi.ApiVapiVersionAuditLogsGet: " + e.Message );
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

[**AuditLogViewModelPaginatedList**](AuditLogViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauditlogsidget"></a>
# **ApiVapiVersionAuditLogsIdGet**
> AuditLogPaginatedList ApiVapiVersionAuditLogsIdGet (Guid? id, string apiVersion)

Provides additional details on a specific audit Log

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuditLogsIdGetExample
    {
        public void main()
        {

            var apiInstance = new AuditLogsApi();
            var id = new Guid?(); // Guid? | Audit log id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides additional details on a specific audit Log
                AuditLogPaginatedList result = apiInstance.ApiVapiVersionAuditLogsIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogsApi.ApiVapiVersionAuditLogsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| Audit log id | 
 **apiVersion** | **string**|  | 

### Return type

[**AuditLogPaginatedList**](AuditLogPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauditlogsidviewget"></a>
# **ApiVapiVersionAuditLogsIdViewGet**
> AuditLogPaginatedList ApiVapiVersionAuditLogsIdViewGet (Guid? id, string apiVersion)

Provides additional ViewModel details on a specific audit Log

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuditLogsIdViewGetExample
    {
        public void main()
        {

            var apiInstance = new AuditLogsApi();
            var id = new Guid?(); // Guid? | Audit log id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides additional ViewModel details on a specific audit Log
                AuditLogPaginatedList result = apiInstance.ApiVapiVersionAuditLogsIdViewGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogsApi.ApiVapiVersionAuditLogsIdViewGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| Audit log id | 
 **apiVersion** | **string**|  | 

### Return type

[**AuditLogPaginatedList**](AuditLogPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauditlogsviewget"></a>
# **ApiVapiVersionAuditLogsViewGet**
> AuditLogViewModelPaginatedList ApiVapiVersionAuditLogsViewGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a ViewModel list of all audit logs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuditLogsViewGetExample
    {
        public void main()
        {

            var apiInstance = new AuditLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a ViewModel list of all audit logs
                AuditLogViewModelPaginatedList result = apiInstance.ApiVapiVersionAuditLogsViewGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogsApi.ApiVapiVersionAuditLogsViewGet: " + e.Message );
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

[**AuditLogViewModelPaginatedList**](AuditLogViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
