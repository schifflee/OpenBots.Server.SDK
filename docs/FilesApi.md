# IO.Swagger.Api.FilesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionFilesCountFolderGet**](FilesApi.md#apivapiversionfilescountfolderget) | **GET** /api/v{apiVersion}/Files/count/folder | Gets count of server folders in database
[**ApiVapiVersionFilesCountGet**](FilesApi.md#apivapiversionfilescountget) | **GET** /api/v{apiVersion}/Files/count | Gets count of server files in database
[**ApiVapiVersionFilesDrivePost**](FilesApi.md#apivapiversionfilesdrivepost) | **POST** /api/v{apiVersion}/Files/drive | Creates new server drive
[**ApiVapiVersionFilesGet**](FilesApi.md#apivapiversionfilesget) | **GET** /api/v{apiVersion}/Files | Provides a list of all files/folders
[**ApiVapiVersionFilesIdCopyParentIdPost**](FilesApi.md#apivapiversionfilesidcopyparentidpost) | **POST** /api/v{apiVersion}/Files/{id}/copy/{parentId} | Copies a folder or file
[**ApiVapiVersionFilesIdDelete**](FilesApi.md#apivapiversionfilesiddelete) | **DELETE** /api/v{apiVersion}/Files/{id} | Deletes a file or empty folder with a specified id from the database
[**ApiVapiVersionFilesIdDownloadGet**](FilesApi.md#apivapiversionfilesiddownloadget) | **GET** /api/v{apiVersion}/Files/{id}/download | Export/Download a file
[**ApiVapiVersionFilesIdMoveParentIdPut**](FilesApi.md#apivapiversionfilesidmoveparentidput) | **PUT** /api/v{apiVersion}/Files/{id}/move/{parentId} | Moves a folder or file
[**ApiVapiVersionFilesIdRenamePut**](FilesApi.md#apivapiversionfilesidrenameput) | **PUT** /api/v{apiVersion}/Files/{id}/rename | Renames a folder or file
[**ApiVapiVersionFilesPost**](FilesApi.md#apivapiversionfilespost) | **POST** /api/v{apiVersion}/Files | Uploads new file/folder in server drive
[**GetDrive**](FilesApi.md#getdrive) | **GET** /api/v{apiVersion}/Files/drive | Provides server drive details for local storage
[**GetDriveNames**](FilesApi.md#getdrivenames) | **GET** /api/v{apiVersion}/Files/driveNames | Provides server drive names
[**GetFileFolder**](FilesApi.md#getfilefolder) | **GET** /api/v{apiVersion}/Files/{id} | Provides file/folder details for a particular file/folder

<a name="apivapiversionfilescountfolderget"></a>
# **ApiVapiVersionFilesCountFolderGet**
> void ApiVapiVersionFilesCountFolderGet (string apiVersion, string driveName = null, string filter = null)

Gets count of server folders in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesCountFolderGetExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of server folders in database
                apiInstance.ApiVapiVersionFilesCountFolderGet(apiVersion, driveName, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesCountFolderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 
 **filter** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionfilescountget"></a>
# **ApiVapiVersionFilesCountGet**
> void ApiVapiVersionFilesCountGet (string apiVersion, string driveName = null, string filter = null)

Gets count of server files in database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesCountGetExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Gets count of server files in database
                apiInstance.ApiVapiVersionFilesCountGet(apiVersion, driveName, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 
 **filter** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionfilesdrivepost"></a>
# **ApiVapiVersionFilesDrivePost**
> ServerDrive ApiVapiVersionFilesDrivePost (string apiVersion, string driveName = null)

Creates new server drive

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesDrivePostExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Creates new server drive
                ServerDrive result = apiInstance.ApiVapiVersionFilesDrivePost(apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesDrivePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**ServerDrive**](ServerDrive.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionfilesget"></a>
# **ApiVapiVersionFilesGet**
> FileFolderViewModelPaginatedList ApiVapiVersionFilesGet (string apiVersion, string driveName = null, string _file = null, string filter = null, string orderby = null, int? top = null, int? skip = null)

Provides a list of all files/folders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesGetExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 
            var _file = _file_example;  // string | Determines whether to retrieve all files (true), folders (false), or both (null/empty) (optional) 
            var filter = filter_example;  // string |  (optional) 
            var orderby = orderby_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional)  (default to 100)
            var skip = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Provides a list of all files/folders
                FileFolderViewModelPaginatedList result = apiInstance.ApiVapiVersionFilesGet(apiVersion, driveName, _file, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 
 **_file** | **string**| Determines whether to retrieve all files (true), folders (false), or both (null/empty) | [optional] 
 **filter** | **string**|  | [optional] 
 **orderby** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] [default to 100]
 **skip** | **int?**|  | [optional] [default to 0]

### Return type

[**FileFolderViewModelPaginatedList**](FileFolderViewModelPaginatedList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionfilesidcopyparentidpost"></a>
# **ApiVapiVersionFilesIdCopyParentIdPost**
> IActionResult ApiVapiVersionFilesIdCopyParentIdPost (string id, string parentId, string apiVersion, string driveName = null)

Copies a folder or file

Provides an action to copy a folder or file, when the id and the parent folder id are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesIdCopyParentIdPostExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var id = id_example;  // string | Folder or file id, produces bad request if id is null or ids don't match
            var parentId = parentId_example;  // string | Parent folder id to be copied to
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Copies a folder or file
                IActionResult result = apiInstance.ApiVapiVersionFilesIdCopyParentIdPost(id, parentId, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesIdCopyParentIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Folder or file id, produces bad request if id is null or ids don&#x27;t match | 
 **parentId** | **string**| Parent folder id to be copied to | 
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
<a name="apivapiversionfilesiddelete"></a>
# **ApiVapiVersionFilesIdDelete**
> IActionResult ApiVapiVersionFilesIdDelete (string id, string apiVersion, string driveName = null)

Deletes a file or empty folder with a specified id from the database

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var id = id_example;  // string | File or empty folder id to be deleted - throws bad request if null or empty Guid
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Deletes a file or empty folder with a specified id from the database
                IActionResult result = apiInstance.ApiVapiVersionFilesIdDelete(id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| File or empty folder id to be deleted - throws bad request if null or empty Guid | 
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
<a name="apivapiversionfilesiddownloadget"></a>
# **ApiVapiVersionFilesIdDownloadGet**
> MemoryStream ApiVapiVersionFilesIdDownloadGet (string id, string apiVersion, string driveName = null)

Export/Download a file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesIdDownloadGetExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var id = id_example;  // string | File id
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Export/Download a file
                MemoryStream result = apiInstance.ApiVapiVersionFilesIdDownloadGet(id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesIdDownloadGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| File id | 
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**MemoryStream**](MemoryStream.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionfilesidmoveparentidput"></a>
# **ApiVapiVersionFilesIdMoveParentIdPut**
> IActionResult ApiVapiVersionFilesIdMoveParentIdPut (string id, string parentId, string apiVersion, string driveName = null)

Moves a folder or file

Provides an action to move a folder or file, when the id and the parent folder id are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesIdMoveParentIdPutExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var id = id_example;  // string | Folder or file id, produces bad request if id is null or ids don't match
            var parentId = parentId_example;  // string | Parent folder id to be moved to
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Moves a folder or file
                IActionResult result = apiInstance.ApiVapiVersionFilesIdMoveParentIdPut(id, parentId, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesIdMoveParentIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Folder or file id, produces bad request if id is null or ids don&#x27;t match | 
 **parentId** | **string**| Parent folder id to be moved to | 
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
<a name="apivapiversionfilesidrenameput"></a>
# **ApiVapiVersionFilesIdRenamePut**
> IActionResult ApiVapiVersionFilesIdRenamePut (string id, string apiVersion, FileFolderViewModel body = null, string driveName = null)

Renames a folder or file

Provides an action to rename a folder or file, when the id and the new name are given

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesIdRenamePutExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var id = id_example;  // string | Folder or file id, produces bad request if id is null or ids don't match
            var apiVersion = apiVersion_example;  // string | 
            var body = new FileFolderViewModel(); // FileFolderViewModel | Name to be updated (optional) 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Renames a folder or file
                IActionResult result = apiInstance.ApiVapiVersionFilesIdRenamePut(id, apiVersion, body, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesIdRenamePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Folder or file id, produces bad request if id is null or ids don&#x27;t match | 
 **apiVersion** | **string**|  | 
 **body** | [**FileFolderViewModel**](FileFolderViewModel.md)| Name to be updated | [optional] 
 **driveName** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionfilespost"></a>
# **ApiVapiVersionFilesPost**
> FileFolderViewModel ApiVapiVersionFilesPost (string apiVersion, string driveName = null)

Uploads new file/folder in server drive

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionFilesPostExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Uploads new file/folder in server drive
                FileFolderViewModel result = apiInstance.ApiVapiVersionFilesPost(apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.ApiVapiVersionFilesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**FileFolderViewModel**](FileFolderViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdrive"></a>
# **GetDrive**
> ServerDrive GetDrive (string apiVersion, string driveName = null)

Provides server drive details for local storage

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDriveExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Provides server drive details for local storage
                ServerDrive result = apiInstance.GetDrive(apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.GetDrive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**ServerDrive**](ServerDrive.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdrivenames"></a>
# **GetDriveNames**
> IActionResult GetDriveNames (string apiVersion, string adapterType = null)

Provides server drive names

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDriveNamesExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var apiVersion = apiVersion_example;  // string | 
            var adapterType = adapterType_example;  // string |  (optional) 

            try
            {
                // Provides server drive names
                IActionResult result = apiInstance.GetDriveNames(apiVersion, adapterType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.GetDriveNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **adapterType** | **string**|  | [optional] 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfilefolder"></a>
# **GetFileFolder**
> FileFolderViewModel GetFileFolder (string id, string apiVersion, string driveName = null)

Provides file/folder details for a particular file/folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFileFolderExample
    {
        public void main()
        {

            var apiInstance = new FilesApi();
            var id = id_example;  // string | File or folder id
            var apiVersion = apiVersion_example;  // string | 
            var driveName = driveName_example;  // string |  (optional) 

            try
            {
                // Provides file/folder details for a particular file/folder
                FileFolderViewModel result = apiInstance.GetFileFolder(id, apiVersion, driveName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.GetFileFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| File or folder id | 
 **apiVersion** | **string**|  | 
 **driveName** | **string**|  | [optional] 

### Return type

[**FileFolderViewModel**](FileFolderViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
