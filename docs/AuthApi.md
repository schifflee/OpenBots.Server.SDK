# IO.Swagger.Api.AuthApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionAuthChangePasswordPut**](AuthApi.md#apivapiversionauthchangepasswordput) | **PUT** /api/v{apiVersion}/Auth/ChangePassword | Change / Reset with new password
[**ApiVapiVersionAuthConfirmEmailAddressGet**](AuthApi.md#apivapiversionauthconfirmemailaddressget) | **GET** /api/v{apiVersion}/Auth/ConfirmEmailAddress | Confirm email address
[**ApiVapiVersionAuthConfirmEmailGet**](AuthApi.md#apivapiversionauthconfirmemailget) | **GET** /api/v{apiVersion}/Auth/ConfirmEmail | Confirm new user
[**ApiVapiVersionAuthForgotPasswordPost**](AuthApi.md#apivapiversionauthforgotpasswordpost) | **POST** /api/v{apiVersion}/Auth/ForgotPassword | Forgot password using email address
[**ApiVapiVersionAuthGetUserInfoGet**](AuthApi.md#apivapiversionauthgetuserinfoget) | **GET** /api/v{apiVersion}/Auth/GetUserInfo | Get user info for logged in authenticated user
[**ApiVapiVersionAuthPingGet**](AuthApi.md#apivapiversionauthpingget) | **GET** /api/v{apiVersion}/Auth/Ping | Used to get current user&#x27;s IP Address
[**ApiVapiVersionAuthRefreshPost**](AuthApi.md#apivapiversionauthrefreshpost) | **POST** /api/v{apiVersion}/Auth/Refresh | Refresh expired access and old refresh token
[**ApiVapiVersionAuthRegisterPost**](AuthApi.md#apivapiversionauthregisterpost) | **POST** /api/v{apiVersion}/Auth/Register | Register new user
[**ApiVapiVersionAuthResendEmailConfirmationPut**](AuthApi.md#apivapiversionauthresendemailconfirmationput) | **PUT** /api/v{apiVersion}/Auth/ResendEmailConfirmation | Resend confirmation email to registered email address
[**ApiVapiVersionAuthSetPasswordPut**](AuthApi.md#apivapiversionauthsetpasswordput) | **PUT** /api/v{apiVersion}/Auth/SetPassword | Reset password
[**ApiVapiVersionAuthSetUserPasswordPut**](AuthApi.md#apivapiversionauthsetuserpasswordput) | **PUT** /api/v{apiVersion}/Auth/SetUserPassword | Set new password
[**ApiVapiVersionAuthTokenPost**](AuthApi.md#apivapiversionauthtokenpost) | **POST** /api/v{apiVersion}/Auth/token | Login with username and password
[**ApiVapiVersionAuthVerifyUserTokenGet**](AuthApi.md#apivapiversionauthverifyusertokenget) | **GET** /api/v{apiVersion}/Auth/VerifyUserToken | Verify user token before resetting the password

<a name="apivapiversionauthchangepasswordput"></a>
# **ApiVapiVersionAuthChangePasswordPut**
> void ApiVapiVersionAuthChangePasswordPut (string apiVersion, ChangePasswordBindingModel body = null)

Change / Reset with new password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthChangePasswordPutExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new ChangePasswordBindingModel(); // ChangePasswordBindingModel |  (optional) 

            try
            {
                // Change / Reset with new password
                apiInstance.ApiVapiVersionAuthChangePasswordPut(apiVersion, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthChangePasswordPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**ChangePasswordBindingModel**](ChangePasswordBindingModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthconfirmemailaddressget"></a>
# **ApiVapiVersionAuthConfirmEmailAddressGet**
> void ApiVapiVersionAuthConfirmEmailAddressGet (string apiVersion, string emailAddress = null, string token = null)

Confirm email address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthConfirmEmailAddressGetExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var emailAddress = emailAddress_example;  // string |  (optional) 
            var token = token_example;  // string |  (optional) 

            try
            {
                // Confirm email address
                apiInstance.ApiVapiVersionAuthConfirmEmailAddressGet(apiVersion, emailAddress, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthConfirmEmailAddressGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **emailAddress** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthconfirmemailget"></a>
# **ApiVapiVersionAuthConfirmEmailGet**
> void ApiVapiVersionAuthConfirmEmailGet (string apiVersion, string userId = null, string code = null)

Confirm new user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthConfirmEmailGetExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var userId = userId_example;  // string |  (optional) 
            var code = code_example;  // string |  (optional) 

            try
            {
                // Confirm new user
                apiInstance.ApiVapiVersionAuthConfirmEmailGet(apiVersion, userId, code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthConfirmEmailGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **userId** | **string**|  | [optional] 
 **code** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthforgotpasswordpost"></a>
# **ApiVapiVersionAuthForgotPasswordPost**
> void ApiVapiVersionAuthForgotPasswordPost (string apiVersion, ForgotPasswordBindingModel body = null)

Forgot password using email address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthForgotPasswordPostExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new ForgotPasswordBindingModel(); // ForgotPasswordBindingModel |  (optional) 

            try
            {
                // Forgot password using email address
                apiInstance.ApiVapiVersionAuthForgotPasswordPost(apiVersion, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthForgotPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**ForgotPasswordBindingModel**](ForgotPasswordBindingModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthgetuserinfoget"></a>
# **ApiVapiVersionAuthGetUserInfoGet**
> void ApiVapiVersionAuthGetUserInfoGet (string apiVersion)

Get user info for logged in authenticated user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthGetUserInfoGetExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Get user info for logged in authenticated user
                apiInstance.ApiVapiVersionAuthGetUserInfoGet(apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthGetUserInfoGet: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthpingget"></a>
# **ApiVapiVersionAuthPingGet**
> string ApiVapiVersionAuthPingGet (string apiVersion)

Used to get current user's IP Address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthPingGetExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Used to get current user's IP Address
                string result = apiInstance.ApiVapiVersionAuthPingGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthPingGet: " + e.Message );
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

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthrefreshpost"></a>
# **ApiVapiVersionAuthRefreshPost**
> void ApiVapiVersionAuthRefreshPost (string apiVersion, RefreshModel body = null)

Refresh expired access and old refresh token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthRefreshPostExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new RefreshModel(); // RefreshModel |  (optional) 

            try
            {
                // Refresh expired access and old refresh token
                apiInstance.ApiVapiVersionAuthRefreshPost(apiVersion, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthRefreshPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**RefreshModel**](RefreshModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthregisterpost"></a>
# **ApiVapiVersionAuthRegisterPost**
> void ApiVapiVersionAuthRegisterPost (string apiVersion, SignUpViewModel body = null)

Register new user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthRegisterPostExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new SignUpViewModel(); // SignUpViewModel | Signup model (optional) 

            try
            {
                // Register new user
                apiInstance.ApiVapiVersionAuthRegisterPost(apiVersion, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthRegisterPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**SignUpViewModel**](SignUpViewModel.md)| Signup model | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthresendemailconfirmationput"></a>
# **ApiVapiVersionAuthResendEmailConfirmationPut**
> void ApiVapiVersionAuthResendEmailConfirmationPut (string apiVersion, string emailAddress = null)

Resend confirmation email to registered email address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthResendEmailConfirmationPutExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var emailAddress = emailAddress_example;  // string | Email address needed for confirmation (optional) 

            try
            {
                // Resend confirmation email to registered email address
                apiInstance.ApiVapiVersionAuthResendEmailConfirmationPut(apiVersion, emailAddress);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthResendEmailConfirmationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **emailAddress** | **string**| Email address needed for confirmation | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthsetpasswordput"></a>
# **ApiVapiVersionAuthSetPasswordPut**
> void ApiVapiVersionAuthSetPasswordPut (string apiVersion, ResetPasswordBindingModel body = null)

Reset password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthSetPasswordPutExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new ResetPasswordBindingModel(); // ResetPasswordBindingModel |  (optional) 

            try
            {
                // Reset password
                apiInstance.ApiVapiVersionAuthSetPasswordPut(apiVersion, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthSetPasswordPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**ResetPasswordBindingModel**](ResetPasswordBindingModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthsetuserpasswordput"></a>
# **ApiVapiVersionAuthSetUserPasswordPut**
> void ApiVapiVersionAuthSetUserPasswordPut (string apiVersion, SetPasswordBindingModel body = null)

Set new password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthSetUserPasswordPutExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new SetPasswordBindingModel(); // SetPasswordBindingModel |  (optional) 

            try
            {
                // Set new password
                apiInstance.ApiVapiVersionAuthSetUserPasswordPut(apiVersion, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthSetUserPasswordPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**SetPasswordBindingModel**](SetPasswordBindingModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthtokenpost"></a>
# **ApiVapiVersionAuthTokenPost**
> void ApiVapiVersionAuthTokenPost (string apiVersion, Login body = null)

Login with username and password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthTokenPostExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var body = new Login(); // Login |  (optional) 

            try
            {
                // Login with username and password
                apiInstance.ApiVapiVersionAuthTokenPost(apiVersion, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthTokenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **body** | [**Login**](Login.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionauthverifyusertokenget"></a>
# **ApiVapiVersionAuthVerifyUserTokenGet**
> void ApiVapiVersionAuthVerifyUserTokenGet (string apiVersion, string userId = null, string code = null)

Verify user token before resetting the password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionAuthVerifyUserTokenGetExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var apiVersion = apiVersion_example;  // string | 
            var userId = userId_example;  // string |  (optional) 
            var code = code_example;  // string |  (optional) 

            try
            {
                // Verify user token before resetting the password
                apiInstance.ApiVapiVersionAuthVerifyUserTokenGet(apiVersion, userId, code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.ApiVapiVersionAuthVerifyUserTokenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | 
 **userId** | **string**|  | [optional] 
 **code** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
