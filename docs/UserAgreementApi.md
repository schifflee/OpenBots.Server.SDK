# IO.Swagger.Api.UserAgreementApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVapiVersionUserAgreementGet**](UserAgreementApi.md#apivapiversionuseragreementget) | **GET** /api/v{apiVersion}/UserAgreement | Get latest terms and conditions for user consent
[**ApiVapiVersionUserAgreementIdHasAcceptedAndNotExpiredGet**](UserAgreementApi.md#apivapiversionuseragreementidhasacceptedandnotexpiredget) | **GET** /api/v{apiVersion}/UserAgreement/{id}/HasAcceptedAndNotExpired | Check that the user consent has been recorded for logged user on the latest user agreement and IsAccepted property is True and has not expired  If there is no record of acceptance for the latest version of the Terms and Conditions, then response will be false, which will force user consent before proceeding

<a name="apivapiversionuseragreementget"></a>
# **ApiVapiVersionUserAgreementGet**
> UserAgreement ApiVapiVersionUserAgreementGet (string apiVersion)

Get latest terms and conditions for user consent

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionUserAgreementGetExample
    {
        public void main()
        {

            var apiInstance = new UserAgreementApi();
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Get latest terms and conditions for user consent
                UserAgreement result = apiInstance.ApiVapiVersionUserAgreementGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAgreementApi.ApiVapiVersionUserAgreementGet: " + e.Message );
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

[**UserAgreement**](UserAgreement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivapiversionuseragreementidhasacceptedandnotexpiredget"></a>
# **ApiVapiVersionUserAgreementIdHasAcceptedAndNotExpiredGet**
> UserAgreement ApiVapiVersionUserAgreementIdHasAcceptedAndNotExpiredGet (string id, string apiVersion)

Check that the user consent has been recorded for logged user on the latest user agreement and IsAccepted property is True and has not expired  If there is no record of acceptance for the latest version of the Terms and Conditions, then response will be false, which will force user consent before proceeding

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVapiVersionUserAgreementIdHasAcceptedAndNotExpiredGetExample
    {
        public void main()
        {

            var apiInstance = new UserAgreementApi();
            var id = id_example;  // string | 
            var apiVersion = apiVersion_example;  // string | 

            try
            {
                // Check that the user consent has been recorded for logged user on the latest user agreement and IsAccepted property is True and has not expired  If there is no record of acceptance for the latest version of the Terms and Conditions, then response will be false, which will force user consent before proceeding
                UserAgreement result = apiInstance.ApiVapiVersionUserAgreementIdHasAcceptedAndNotExpiredGet(id, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAgreementApi.ApiVapiVersionUserAgreementIdHasAcceptedAndNotExpiredGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **apiVersion** | **string**|  | 

### Return type

[**UserAgreement**](UserAgreement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
