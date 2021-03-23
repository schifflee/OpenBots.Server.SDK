# IO.Swagger.Api.AutomationLogsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionAutomationLogsCountGet**](AutomationLogsApi.md#apivapiversionautomationlogscountget) | **GET** /api/v{apiVersion}/AutomationLogs/Count | Provides a count of automation logs
[**ApiVapiVersionAutomationLogsExportFileTypeGet**](AutomationLogsApi.md#apivapiversionautomationlogsexportfiletypeget) | **GET** /api/v{apiVersion}/AutomationLogs/export/{fileType} | Exports automation logs into a downloadable file
[**ApiVapiVersionAutomationLogsGet**](AutomationLogsApi.md#apivapiversionautomationlogsget) | **GET** /api/v{apiVersion}/AutomationLogs | Provides a list of all automation logs
[**ApiVapiVersionAutomationLogsPost**](AutomationLogsApi.md#apivapiversionautomationlogspost) | **POST** /api/v{apiVersion}/AutomationLogs | Adds a new automation log to the existing automation logs
[**GetAutomationLog**](AutomationLogsApi.md#getautomationlog) | **GET** /api/v{apiVersion}/AutomationLogs/{id} | Provides a automation log&#x27;s details for a particular automation log id

<a name="apivapiversionautomationlogscountget"></a>
# **ApiVapiVersionAutomationLogsCountGet**
> int? ApiVapiVersionAutomationLogsCountGet (string apiVersion, string filter = null)

Provides a count of automation logs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationLogsCountGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Provides a count of automation logs
                int? result = apiInstance.ApiVapiVersionAutomationLogsCountGet(apiVersion, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationLogsApi.ApiVapiVersionAutomationLogsCountGet: " + e.Message );
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

**int?**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationlogsexportfiletypeget"></a>
# **ApiVapiVersionAutomationLogsExportFileTypeGet**
> void ApiVapiVersionAutomationLogsExportFileTypeGet (string fileType, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Exports automation logs into a downloadable file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationLogsExportFileTypeGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationLogsApi();
            var fileType = fileType_example;  // string | Specifies the file type to be downloaded: csv, zip, or json
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Exports automation logs into a downloadable file
                apiInstance.ApiVapiVersionAutomationLogsExportFileTypeGet(fileType, apiVersion, filter, orderby, top, skip);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationLogsApi.ApiVapiVersionAutomationLogsExportFileTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileType** | **string**| Specifies the file type to be downloaded: csv, zip, or json | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, application/zip, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationlogsget"></a>
# **ApiVapiVersionAutomationLogsGet**
> AutomationLogPaginatedList ApiVapiVersionAutomationLogsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all automation logs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationLogsGetExample
    {
        public void main()
        {

            var apiInstance = new AutomationLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all automation logs
                AutomationLogPaginatedList result = apiInstance.ApiVapiVersionAutomationLogsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationLogsApi.ApiVapiVersionAutomationLogsGet: " + e.Message );
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

[**AutomationLogPaginatedList**](AutomationLogPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionautomationlogspost"></a>
# **ApiVapiVersionAutomationLogsPost**
> AutomationLog ApiVapiVersionAutomationLogsPost (string apiVersion, AutomationLog body = null)

Adds a new automation log to the existing automation logs

Adds the automation log with unique automation log id to the existing automation logs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAutomationLogsPostExample
    {
        public void main()
        {

            var apiInstance = new AutomationLogsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new AutomationLog(); // AutomationLog |  (optional) 

            try
            {
                // Adds a new automation log to the existing automation logs
                AutomationLog result = apiInstance.ApiVapiVersionAutomationLogsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationLogsApi.ApiVapiVersionAutomationLogsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**AutomationLog**](AutomationLog.md)|  | [optional] 

### Return type

[**AutomationLog**](AutomationLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getautomationlog"></a>
# **GetAutomationLog**
> AutomationLog GetAutomationLog (string id, string apiVersion)

Provides a automation log's details for a particular automation log id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAutomationLogExample
    {
        public void main()
        {

            var apiInstance = new AutomationLogsApi();
            var id = id_example;  // string | automation log id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a automation log's details for a particular automation log id
                AutomationLog result = apiInstance.GetAutomationLog(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationLogsApi.GetAutomationLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| automation log id | 
 **apiVersion** | **string**|  | 

### Return type

[**AutomationLog**](AutomationLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
