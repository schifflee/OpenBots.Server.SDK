# IO.Swagger.Api.AppApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplicationApplicationVersionGet**](AppApi.md#applicationapplicationversionget) | **GET** /Application/{application}/Version | Application version
[**ApplicationApplicationVersionMinorReleasePut**](AppApi.md#applicationapplicationversionminorreleaseput) | **PUT** /Application/{application}/Version/Minor/Release | Minor version release
[**ApplicationApplicationVersionPatchReleasePut**](AppApi.md#applicationapplicationversionpatchreleaseput) | **PUT** /Application/{application}/Version/Patch/Release | Patch release

<a name="applicationapplicationversionget"></a>
# **ApplicationApplicationVersionGet**
> string ApplicationApplicationVersionGet (string application)

Application version

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationApplicationVersionGetExample
    {
        public void main()
        {
            var apiInstance = new AppApi();
            var application = application_example;  // string | 

            try
            {
                // Application version
                string result = apiInstance.ApplicationApplicationVersionGet(application);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppApi.ApplicationApplicationVersionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **application** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applicationapplicationversionminorreleaseput"></a>
# **ApplicationApplicationVersionMinorReleasePut**
> string ApplicationApplicationVersionMinorReleasePut (string application, string key = null)

Minor version release

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationApplicationVersionMinorReleasePutExample
    {
        public void main()
        {
            var apiInstance = new AppApi();
            var application = application_example;  // string | 
            var key = key_example;  // string |  (optional) 

            try
            {
                // Minor version release
                string result = apiInstance.ApplicationApplicationVersionMinorReleasePut(application, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppApi.ApplicationApplicationVersionMinorReleasePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **application** | **string**|  | 
 **key** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applicationapplicationversionpatchreleaseput"></a>
# **ApplicationApplicationVersionPatchReleasePut**
> string ApplicationApplicationVersionPatchReleasePut (string application, string key = null)

Patch release

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationApplicationVersionPatchReleasePutExample
    {
        public void main()
        {
            var apiInstance = new AppApi();
            var application = application_example;  // string | 
            var key = key_example;  // string |  (optional) 

            try
            {
                // Patch release
                string result = apiInstance.ApplicationApplicationVersionPatchReleasePut(application, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppApi.ApplicationApplicationVersionPatchReleasePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **application** | **string**|  | 
 **key** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
