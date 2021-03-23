# IO.Swagger.Api.SchedulesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionSchedulesCountGet**](SchedulesApi.md#apivapiversionschedulescountget) | **GET** /api/v{apiVersion}/Schedules/count | Gets count of Schedules in database
[**ApiVapiVersionSchedulesGet**](SchedulesApi.md#apivapiversionschedulesget) | **GET** /api/v{apiVersion}/Schedules | Provides a list of all schedules
[**ApiVapiVersionSchedulesIdDelete**](SchedulesApi.md#apivapiversionschedulesiddelete) | **DELETE** /api/v{apiVersion}/Schedules/{id} | Deletes a schedule with a specified id from the schedules
[**ApiVapiVersionSchedulesIdPatch**](SchedulesApi.md#apivapiversionschedulesidpatch) | **PATCH** /api/v{apiVersion}/Schedules/{id} | Updates partial details of Schedule.
[**ApiVapiVersionSchedulesIdPut**](SchedulesApi.md#apivapiversionschedulesidput) | **PUT** /api/v{apiVersion}/Schedules/{id} | Updates a schedule
[**ApiVapiVersionSchedulesPost**](SchedulesApi.md#apivapiversionschedulespost) | **POST** /api/v{apiVersion}/Schedules | Adds a new schedule to the existing schedules
[**ApiVapiVersionSchedulesRunNowPost**](SchedulesApi.md#apivapiversionschedulesrunnowpost) | **POST** /api/v{apiVersion}/Schedules/RunNow | API to run a job now
[**ApiVapiVersionSchedulesViewIdGet**](SchedulesApi.md#apivapiversionschedulesviewidget) | **GET** /api/v{apiVersion}/Schedules/view/{id} | Provides schedule view model details for a particular schedule id
[**GetSchedule**](SchedulesApi.md#getschedule) | **GET** /api/v{apiVersion}/Schedules/{id} | Provides schedule details for a particular schedule id

<a name="apivapiversionschedulescountget"></a>
# **ApiVapiVersionSchedulesCountGet**
> void ApiVapiVersionSchedulesCountGet (string apiVersion, string filter = null)

Gets count of Schedules in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionSchedulesCountGetExample
    {
        public void main()
        {

            var apiInstance = new SchedulesApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of Schedules in database
                apiInstance.ApiVapiVersionSchedulesCountGet(apiVersion, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ApiVapiVersionSchedulesCountGet: " + e.Message );
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
<a name="apivapiversionschedulesget"></a>
# **ApiVapiVersionSchedulesGet**
> AllSchedulesViewModelPaginatedList ApiVapiVersionSchedulesGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all schedules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionSchedulesGetExample
    {
        public void main()
        {

            var apiInstance = new SchedulesApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all schedules
                AllSchedulesViewModelPaginatedList result = apiInstance.ApiVapiVersionSchedulesGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ApiVapiVersionSchedulesGet: " + e.Message );
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

[**AllSchedulesViewModelPaginatedList**](AllSchedulesViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionschedulesiddelete"></a>
# **ApiVapiVersionSchedulesIdDelete**
> IActionResult ApiVapiVersionSchedulesIdDelete (string id, string apiVersion)

Deletes a schedule with a specified id from the schedules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionSchedulesIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new SchedulesApi();
            var id = id_example;  // string | Schedule id to be deleted - throws bad request if null or empty Guid/
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes a schedule with a specified id from the schedules
                IActionResult result = apiInstance.ApiVapiVersionSchedulesIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ApiVapiVersionSchedulesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Schedule id to be deleted - throws bad request if null or empty Guid/ | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionschedulesidpatch"></a>
# **ApiVapiVersionSchedulesIdPatch**
> IActionResult ApiVapiVersionSchedulesIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of Schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionSchedulesIdPatchExample
    {
        public void main()
        {

            var apiInstance = new SchedulesApi();
            var id = id_example;  // string | Schedule identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the Schedule to be updated. (optional) 

            try
            {
                // Updates partial details of Schedule.
                IActionResult result = apiInstance.ApiVapiVersionSchedulesIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ApiVapiVersionSchedulesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Schedule identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the Schedule to be updated. | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionschedulesidput"></a>
# **ApiVapiVersionSchedulesIdPut**
> IActionResult ApiVapiVersionSchedulesIdPut (string id, string apiVersion, CreateScheduleViewModel body = null)

Updates a schedule

Provides an action to update a schedule, when schedule id and the new details of the schedule are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionSchedulesIdPutExample
    {
        public void main()
        {

            var apiInstance = new SchedulesApi();
            var id = id_example;  // string | Schedule id,produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new CreateScheduleViewModel(); // CreateScheduleViewModel | Schedule details to be updated (optional) 

            try
            {
                // Updates a schedule
                IActionResult result = apiInstance.ApiVapiVersionSchedulesIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ApiVapiVersionSchedulesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Schedule id,produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**CreateScheduleViewModel**](CreateScheduleViewModel.md)| Schedule details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionschedulespost"></a>
# **ApiVapiVersionSchedulesPost**
> Schedule ApiVapiVersionSchedulesPost (string apiVersion, CreateScheduleViewModel body = null)

Adds a new schedule to the existing schedules

Adds the schedule with unique schedule id to the existing schedules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionSchedulesPostExample
    {
        public void main()
        {

            var apiInstance = new SchedulesApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new CreateScheduleViewModel(); // CreateScheduleViewModel |  (optional) 

            try
            {
                // Adds a new schedule to the existing schedules
                Schedule result = apiInstance.ApiVapiVersionSchedulesPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ApiVapiVersionSchedulesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**CreateScheduleViewModel**](CreateScheduleViewModel.md)|  | [optional] 

### Return type

[**Schedule**](Schedule.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionschedulesrunnowpost"></a>
# **ApiVapiVersionSchedulesRunNowPost**
> IActionResult ApiVapiVersionSchedulesRunNowPost (string apiVersion, RunNowViewModel body = null)

API to run a job now

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionSchedulesRunNowPostExample
    {
        public void main()
        {

            var apiInstance = new SchedulesApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new RunNowViewModel(); // RunNowViewModel |  (optional) 

            try
            {
                // API to run a job now
                IActionResult result = apiInstance.ApiVapiVersionSchedulesRunNowPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ApiVapiVersionSchedulesRunNowPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**RunNowViewModel**](RunNowViewModel.md)|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionschedulesviewidget"></a>
# **ApiVapiVersionSchedulesViewIdGet**
> ScheduleViewModelPaginatedList ApiVapiVersionSchedulesViewIdGet (string id, string apiVersion)

Provides schedule view model details for a particular schedule id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionSchedulesViewIdGetExample
    {
        public void main()
        {

            var apiInstance = new SchedulesApi();
            var id = id_example;  // string | Schedule id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides schedule view model details for a particular schedule id
                ScheduleViewModelPaginatedList result = apiInstance.ApiVapiVersionSchedulesViewIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ApiVapiVersionSchedulesViewIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Schedule id | 
 **apiVersion** | **string**|  | 

### Return type

[**ScheduleViewModelPaginatedList**](ScheduleViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getschedule"></a>
# **GetSchedule**
> SchedulePaginatedList GetSchedule (string id, string apiVersion)

Provides schedule details for a particular schedule id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetScheduleExample
    {
        public void main()
        {

            var apiInstance = new SchedulesApi();
            var id = id_example;  // string | Schedule id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides schedule details for a particular schedule id
                SchedulePaginatedList result = apiInstance.GetSchedule(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.GetSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Schedule id | 
 **apiVersion** | **string**|  | 

### Return type

[**SchedulePaginatedList**](SchedulePaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
