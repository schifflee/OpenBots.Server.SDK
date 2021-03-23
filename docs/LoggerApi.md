# IO.Swagger.Api.LoggerApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionLoggerLoggerPost**](LoggerApi.md#apivapiversionloggerloggerpost) | **POST** /api/v{apiVersion}/Logger/{logger} | Adds serilog logs from the agent to the automation logs table

<a name="apivapiversionloggerloggerpost"></a>
# **ApiVapiVersionLoggerLoggerPost**
> IActionResult ApiVapiVersionLoggerLoggerPost (string logger, string apiVersion,  body = null)

Adds serilog logs from the agent to the automation logs table

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionLoggerLoggerPostExample
    {
        public void main()
        {
            var apiInstance = new LoggerApi();
            var logger = logger_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 
            var body = new (); //  |  (optional) 

            try
            {
                // Adds serilog logs from the agent to the automation logs table
                IActionResult result = apiInstance.ApiVapiVersionLoggerLoggerPost(logger, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggerApi.ApiVapiVersionLoggerLoggerPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logger** | **string**|  | 
 **apiVersion** | **string**|  | 
 **body** | [****](.md)|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
