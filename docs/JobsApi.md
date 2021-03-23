# IO.Swagger.Api.JobsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionJobsCountByStatusGet**](JobsApi.md#apivapiversionjobscountbystatusget) | **GET** /api/v{apiVersion}/Jobs/CountByStatus | Provides a count of jobs by job status
[**ApiVapiVersionJobsCountGet**](JobsApi.md#apivapiversionjobscountget) | **GET** /api/v{apiVersion}/Jobs/Count | Provides a count of jobs
[**ApiVapiVersionJobsExportFileTypeGet**](JobsApi.md#apivapiversionjobsexportfiletypeget) | **GET** /api/v{apiVersion}/Jobs/export/{fileType} | Exports all jobs into a downloadable file
[**ApiVapiVersionJobsGet**](JobsApi.md#apivapiversionjobsget) | **GET** /api/v{apiVersion}/Jobs | Provides a list of all jobs
[**ApiVapiVersionJobsIdDelete**](JobsApi.md#apivapiversionjobsiddelete) | **DELETE** /api/v{apiVersion}/Jobs/{id} | Deletes a job with a specified id from the job
[**ApiVapiVersionJobsIdPatch**](JobsApi.md#apivapiversionjobsidpatch) | **PATCH** /api/v{apiVersion}/Jobs/{id} | Updates partial details of a job
[**ApiVapiVersionJobsIdPut**](JobsApi.md#apivapiversionjobsidput) | **PUT** /api/v{apiVersion}/Jobs/{id} | Updates a job
[**ApiVapiVersionJobsIdStatusStatusPut**](JobsApi.md#apivapiversionjobsidstatusstatusput) | **PUT** /api/v{apiVersion}/Jobs/{id}/Status/{status} | Updates a job with the specified status
[**ApiVapiVersionJobsJobAgentsLookupGet**](JobsApi.md#apivapiversionjobsjobagentslookupget) | **GET** /api/v{apiVersion}/Jobs/JobAgentsLookup | Provides a lookup list of all job agents and automations
[**ApiVapiVersionJobsJobIdAddCheckpointPost**](JobsApi.md#apivapiversionjobsjobidaddcheckpointpost) | **POST** /api/v{apiVersion}/Jobs/{jobId}/AddCheckpoint | Adds checkpoint to the existing JobCheckPoints
[**ApiVapiVersionJobsPost**](JobsApi.md#apivapiversionjobspost) | **POST** /api/v{apiVersion}/Jobs | Adds a new job to the existing jobs
[**ApiVapiVersionJobsViewGet**](JobsApi.md#apivapiversionjobsviewget) | **GET** /api/v{apiVersion}/Jobs/view | Provides a view model list of all jobs
[**ApiVapiVersionJobsViewIdGet**](JobsApi.md#apivapiversionjobsviewidget) | **GET** /api/v{apiVersion}/Jobs/view/{id} | Provides a job&#x27;s view model details for a particular job id
[**GetJob**](JobsApi.md#getjob) | **GET** /api/v{apiVersion}/Jobs/{id} | Provides a job&#x27;s details for a particular job id
[**GetJobCheckpoint**](JobsApi.md#getjobcheckpoint) | **GET** /api/v{apiVersion}/Jobs/{jobId}/JobCheckpoints | Provides a checkpoint&#x27;s view model details for a particular job id

<a name="apivapiversionjobscountbystatusget"></a>
# **ApiVapiVersionJobsCountByStatusGet**
> Dictionary<string, int?> ApiVapiVersionJobsCountByStatusGet (string apiVersion, string filter = null)

Provides a count of jobs by job status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsCountByStatusGetExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Provides a count of jobs by job status
                Dictionary&lt;string, int?&gt; result = apiInstance.ApiVapiVersionJobsCountByStatusGet(apiVersion, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsCountByStatusGet: " + e.Message );
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

**Dictionary<string, int?>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobscountget"></a>
# **ApiVapiVersionJobsCountGet**
> int? ApiVapiVersionJobsCountGet (string apiVersion, string filter = null)

Provides a count of jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsCountGetExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Provides a count of jobs
                int? result = apiInstance.ApiVapiVersionJobsCountGet(apiVersion, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsCountGet: " + e.Message );
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
<a name="apivapiversionjobsexportfiletypeget"></a>
# **ApiVapiVersionJobsExportFileTypeGet**
> void ApiVapiVersionJobsExportFileTypeGet (string fileType, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Exports all jobs into a downloadable file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsExportFileTypeGetExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var fileType = fileType_example;  // string | Specifies the file type to be downloaded: csv, zip, or json
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Exports all jobs into a downloadable file
                apiInstance.ApiVapiVersionJobsExportFileTypeGet(fileType, apiVersion, filter, orderby, top, skip);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsExportFileTypeGet: " + e.Message );
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
<a name="apivapiversionjobsget"></a>
# **ApiVapiVersionJobsGet**
> JobPaginatedList ApiVapiVersionJobsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsGetExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all jobs
                JobPaginatedList result = apiInstance.ApiVapiVersionJobsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsGet: " + e.Message );
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

[**JobPaginatedList**](JobPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobsiddelete"></a>
# **ApiVapiVersionJobsIdDelete**
> IActionResult ApiVapiVersionJobsIdDelete (string id, string apiVersion)

Deletes a job with a specified id from the job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var id = id_example;  // string | Job id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes a job with a specified id from the job
                IActionResult result = apiInstance.ApiVapiVersionJobsIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Job id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobsidpatch"></a>
# **ApiVapiVersionJobsIdPatch**
> IActionResult ApiVapiVersionJobsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of a job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var id = id_example;  // string | Job identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the job to be updated (optional) 

            try
            {
                // Updates partial details of a job
                IActionResult result = apiInstance.ApiVapiVersionJobsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Job identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the job to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobsidput"></a>
# **ApiVapiVersionJobsIdPut**
> IActionResult ApiVapiVersionJobsIdPut (string id, string apiVersion, CreateJobViewModel body = null)

Updates a job

Provides an action to update a job, when job id and the new details of a job are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsIdPutExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var id = id_example;  // string | Job id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new CreateJobViewModel(); // CreateJobViewModel | Job details to be updated (optional) 

            try
            {
                // Updates a job
                IActionResult result = apiInstance.ApiVapiVersionJobsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Job id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**CreateJobViewModel**](CreateJobViewModel.md)| Job details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobsidstatusstatusput"></a>
# **ApiVapiVersionJobsIdStatusStatusPut**
> Job ApiVapiVersionJobsIdStatusStatusPut (string agentId, string id, JobStatusType status, string apiVersion, JobErrorViewModel body = null)

Updates a job with the specified status

Provides an action to update a job status, when job id and the new details of job are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsIdStatusStatusPutExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var agentId = agentId_example;  // string | Id of agent that is updating job status
            var id = id_example;  // string | Job id, produces bad request if id is null or ids don't match
            var status = new JobStatusType(); // JobStatusType | Status value for the specified job id
            var apiVersion = apiVersion_example;  // string | 
            var body = new JobErrorViewModel(); // JobErrorViewModel | Job error details to be updated (optional) 

            try
            {
                // Updates a job with the specified status
                Job result = apiInstance.ApiVapiVersionJobsIdStatusStatusPut(agentId, id, status, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsIdStatusStatusPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Id of agent that is updating job status | 
 **id** | **string**| Job id, produces bad request if id is null or ids don&#x27;t match | 
 **status** | [**JobStatusType**](JobStatusType.md)| Status value for the specified job id | 
 **apiVersion** | **string**|  | 
 **body** | [**JobErrorViewModel**](JobErrorViewModel.md)| Job error details to be updated | [optional] 

### Return type

[**Job**](Job.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobsjobagentslookupget"></a>
# **ApiVapiVersionJobsJobAgentsLookupGet**
> JobsLookupViewModel ApiVapiVersionJobsJobAgentsLookupGet (string apiVersion)

Provides a lookup list of all job agents and automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsJobAgentsLookupGetExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a lookup list of all job agents and automations
                JobsLookupViewModel result = apiInstance.ApiVapiVersionJobsJobAgentsLookupGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsJobAgentsLookupGet: " + e.Message );
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

[**JobsLookupViewModel**](JobsLookupViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobsjobidaddcheckpointpost"></a>
# **ApiVapiVersionJobsJobIdAddCheckpointPost**
> JobCheckpoint ApiVapiVersionJobsJobIdAddCheckpointPost (string jobId, string apiVersion, JobCheckpoint body = null)

Adds checkpoint to the existing JobCheckPoints

Creates a new Job Checkpoint for the specified job id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsJobIdAddCheckpointPostExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new JobCheckpoint(); // JobCheckpoint |  (optional) 

            try
            {
                // Adds checkpoint to the existing JobCheckPoints
                JobCheckpoint result = apiInstance.ApiVapiVersionJobsJobIdAddCheckpointPost(jobId, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsJobIdAddCheckpointPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 
 **apiVersion** | **string**|  | 
 **body** | [**JobCheckpoint**](JobCheckpoint.md)|  | [optional] 

### Return type

[**JobCheckpoint**](JobCheckpoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobspost"></a>
# **ApiVapiVersionJobsPost**
> Job ApiVapiVersionJobsPost (string apiVersion, CreateJobViewModel body = null)

Adds a new job to the existing jobs

Adds the job with unique job id to the existing jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsPostExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new CreateJobViewModel(); // CreateJobViewModel |  (optional) 

            try
            {
                // Adds a new job to the existing jobs
                Job result = apiInstance.ApiVapiVersionJobsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**CreateJobViewModel**](CreateJobViewModel.md)|  | [optional] 

### Return type

[**Job**](Job.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobsviewget"></a>
# **ApiVapiVersionJobsViewGet**
> AllJobsViewModelPaginatedList ApiVapiVersionJobsViewGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a view model list of all jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsViewGetExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a view model list of all jobs
                AllJobsViewModelPaginatedList result = apiInstance.ApiVapiVersionJobsViewGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsViewGet: " + e.Message );
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

[**AllJobsViewModelPaginatedList**](AllJobsViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionjobsviewidget"></a>
# **ApiVapiVersionJobsViewIdGet**
> JobViewModel ApiVapiVersionJobsViewIdGet (string id, string apiVersion)

Provides a job's view model details for a particular job id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionJobsViewIdGetExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var id = id_example;  // string | Job id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a job's view model details for a particular job id
                JobViewModel result = apiInstance.ApiVapiVersionJobsViewIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ApiVapiVersionJobsViewIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Job id | 
 **apiVersion** | **string**|  | 

### Return type

[**JobViewModel**](JobViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getjob"></a>
# **GetJob**
> Job GetJob (string id, string apiVersion)

Provides a job's details for a particular job id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJobExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var id = id_example;  // string | Job id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a job's details for a particular job id
                Job result = apiInstance.GetJob(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Job id | 
 **apiVersion** | **string**|  | 

### Return type

[**Job**](Job.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getjobcheckpoint"></a>
# **GetJobCheckpoint**
> JobCheckpointPaginatedList GetJobCheckpoint (string jobId, string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a checkpoint's view model details for a particular job id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJobCheckpointExample
    {
        public void main()
        {

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | Job id
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a checkpoint's view model details for a particular job id
                JobCheckpointPaginatedList result = apiInstance.GetJobCheckpoint(jobId, apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetJobCheckpoint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| Job id | 
 **apiVersion** | **string**|  | 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**JobCheckpointPaginatedList**](JobCheckpointPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
