# IO.Swagger.Api.CredentialsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionCredentialsCountGet**](CredentialsApi.md#apivapiversioncredentialscountget) | **GET** /api/v{apiVersion}/Credentials/Count | Provides a count of credentials
[**ApiVapiVersionCredentialsGet**](CredentialsApi.md#apivapiversioncredentialsget) | **GET** /api/v{apiVersion}/Credentials | Provides a list of all credentials
[**ApiVapiVersionCredentialsGetLookupGet**](CredentialsApi.md#apivapiversioncredentialsgetlookupget) | **GET** /api/v{apiVersion}/Credentials/GetLookup | Lookup list of all active directory credentials
[**ApiVapiVersionCredentialsIdDelete**](CredentialsApi.md#apivapiversioncredentialsiddelete) | **DELETE** /api/v{apiVersion}/Credentials/{id} | Deletes a credential with a specified id
[**ApiVapiVersionCredentialsIdPatch**](CredentialsApi.md#apivapiversioncredentialsidpatch) | **PATCH** /api/v{apiVersion}/Credentials/{id} | Updates partial details of credential
[**ApiVapiVersionCredentialsIdPut**](CredentialsApi.md#apivapiversioncredentialsidput) | **PUT** /api/v{apiVersion}/Credentials/{id} | Updates a credential
[**ApiVapiVersionCredentialsPasswordIdGet**](CredentialsApi.md#apivapiversioncredentialspasswordidget) | **GET** /api/v{apiVersion}/Credentials/password/{id} | Provides a credential&#x27;s password string for a particular credential id
[**ApiVapiVersionCredentialsPost**](CredentialsApi.md#apivapiversioncredentialspost) | **POST** /api/v{apiVersion}/Credentials | Adds a new credential to the existing credentials
[**ApiVapiVersionCredentialsViewIdGet**](CredentialsApi.md#apivapiversioncredentialsviewidget) | **GET** /api/v{apiVersion}/Credentials/view/{id} | Provides a credential&#x27;s view details for a particular credential id
[**GetCredential**](CredentialsApi.md#getcredential) | **GET** /api/v{apiVersion}/Credentials/{id} | Provides a credential&#x27;s details for a particular credential id

<a name="apivapiversioncredentialscountget"></a>
# **ApiVapiVersionCredentialsCountGet**
> int? ApiVapiVersionCredentialsCountGet (string apiVersion, string filter = null)

Provides a count of credentials

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionCredentialsCountGetExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Provides a count of credentials
                int? result = apiInstance.ApiVapiVersionCredentialsCountGet(apiVersion, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ApiVapiVersionCredentialsCountGet: " + e.Message );
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
<a name="apivapiversioncredentialsget"></a>
# **ApiVapiVersionCredentialsGet**
> CredentialPaginatedList ApiVapiVersionCredentialsGet (string apiVersion, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all credentials

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionCredentialsGetExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var apiVersion = apiVersion_example;  // string | 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all credentials
                CredentialPaginatedList result = apiInstance.ApiVapiVersionCredentialsGet(apiVersion, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ApiVapiVersionCredentialsGet: " + e.Message );
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

[**CredentialPaginatedList**](CredentialPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversioncredentialsgetlookupget"></a>
# **ApiVapiVersionCredentialsGetLookupGet**
> List<CredentialsLookup> ApiVapiVersionCredentialsGetLookupGet (string apiVersion)

Lookup list of all active directory credentials

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionCredentialsGetLookupGetExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Lookup list of all active directory credentials
                List&lt;CredentialsLookup&gt; result = apiInstance.ApiVapiVersionCredentialsGetLookupGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ApiVapiVersionCredentialsGetLookupGet: " + e.Message );
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

[**List<CredentialsLookup>**](CredentialsLookup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversioncredentialsiddelete"></a>
# **ApiVapiVersionCredentialsIdDelete**
> IActionResult ApiVapiVersionCredentialsIdDelete (string id, string apiVersion)

Deletes a credential with a specified id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionCredentialsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var id = id_example;  // string | Credential id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Deletes a credential with a specified id
                IActionResult result = apiInstance.ApiVapiVersionCredentialsIdDelete(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ApiVapiVersionCredentialsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Credential id to be deleted - throws bad request if null or empty Guid | 
 **apiVersion** | **string**|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversioncredentialsidpatch"></a>
# **ApiVapiVersionCredentialsIdPatch**
> IActionResult ApiVapiVersionCredentialsIdPatch (string id, string apiVersion, List<Operation> body = null)

Updates partial details of credential

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionCredentialsIdPatchExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var id = id_example;  // string | Credential identifier
            var apiVersion = apiVersion_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | Value of the credential to be updated (optional) 

            try
            {
                // Updates partial details of credential
                IActionResult result = apiInstance.ApiVapiVersionCredentialsIdPatch(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ApiVapiVersionCredentialsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Credential identifier | 
 **apiVersion** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| Value of the credential to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversioncredentialsidput"></a>
# **ApiVapiVersionCredentialsIdPut**
> IActionResult ApiVapiVersionCredentialsIdPut (string id, string apiVersion, Credential body = null)

Updates a credential

Provides an action to update a credential, when id and the new details of credential are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionCredentialsIdPutExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var id = id_example;  // string | Credential Id,produces Bad request if Id is null or Id's don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new Credential(); // Credential | Credential details to be updated (optional) 

            try
            {
                // Updates a credential
                IActionResult result = apiInstance.ApiVapiVersionCredentialsIdPut(id, apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ApiVapiVersionCredentialsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Credential Id,produces Bad request if Id is null or Id&#x27;s don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**Credential**](Credential.md)| Credential details to be updated | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversioncredentialspasswordidget"></a>
# **ApiVapiVersionCredentialsPasswordIdGet**
> string ApiVapiVersionCredentialsPasswordIdGet (string id, string apiVersion)

Provides a credential's password string for a particular credential id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionCredentialsPasswordIdGetExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var id = id_example;  // string | Credential id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a credential's password string for a particular credential id
                string result = apiInstance.ApiVapiVersionCredentialsPasswordIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ApiVapiVersionCredentialsPasswordIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Credential id | 
 **apiVersion** | **string**|  | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversioncredentialspost"></a>
# **ApiVapiVersionCredentialsPost**
> Credential ApiVapiVersionCredentialsPost (string apiVersion, Credential body = null)

Adds a new credential to the existing credentials

Adds the Credential with unique id to the existing credentials

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionCredentialsPostExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new Credential(); // Credential |  (optional) 

            try
            {
                // Adds a new credential to the existing credentials
                Credential result = apiInstance.ApiVapiVersionCredentialsPost(apiVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ApiVapiVersionCredentialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**Credential**](Credential.md)|  | [optional] 

### Return type

[**Credential**](Credential.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversioncredentialsviewidget"></a>
# **ApiVapiVersionCredentialsViewIdGet**
> CredentialViewModel ApiVapiVersionCredentialsViewIdGet (string id, string apiVersion)

Provides a credential's view details for a particular credential id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionCredentialsViewIdGetExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var id = id_example;  // string | Credential id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a credential's view details for a particular credential id
                CredentialViewModel result = apiInstance.ApiVapiVersionCredentialsViewIdGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ApiVapiVersionCredentialsViewIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Credential id | 
 **apiVersion** | **string**|  | 

### Return type

[**CredentialViewModel**](CredentialViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcredential"></a>
# **GetCredential**
> Credential GetCredential (string id, string apiVersion)

Provides a credential's details for a particular credential id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCredentialExample
    {
        public void main()
        {

            var apiInstance = new CredentialsApi();
            var id = id_example;  // string | Credential id
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Provides a credential's details for a particular credential id
                Credential result = apiInstance.GetCredential(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Credential id | 
 **apiVersion** | **string**|  | 

### Return type

[**Credential**](Credential.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
