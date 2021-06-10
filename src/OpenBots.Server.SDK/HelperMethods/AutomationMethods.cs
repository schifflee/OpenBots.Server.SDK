﻿using Newtonsoft.Json;
using OpenBots.Server.SDK.Api;
using OpenBots.Server.SDK.Model;
using System;
using System.Collections.Generic;
using SystemFile = System.IO;
using AutomationModel = OpenBots.Server.SDK.Model.Automation;
using SDKAutomationParameter = OpenBots.Server.SDK.Model.AutomationParameter;
using OpenBots.Server.SDK.Client;
using System.Linq;

namespace OpenBots.Server.SDK.HelperMethods
{
    public class AutomationMethods
    {
        public static AutomationModel UploadAutomation(string name, string filePath, string automationEngine, AuthMethods authMethods)
        {
            UserInfo userInfo = authMethods.GetUserInfo();
            var apiInstance = GetApiInstance(userInfo.Token, userInfo.ServerUrl);

            try
            {
                using (SystemFile.FileStream _file = new SystemFile.FileStream(filePath, SystemFile.FileMode.Open, SystemFile.FileAccess.Read))
                {
                    var automation = apiInstance.ApiVapiVersionAutomationsPostAsyncWithHttpInfo(authMethods.ApiVersion, userInfo.OrganizationId, name, _file, automationEngine).Result.Data;
                    return automation;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "One or more errors occurred.")
                    throw new InvalidOperationException("Exception when calling AutomationsApi.UploadAutomation: " + ex.Message);
                else
                    throw new InvalidOperationException(ex.InnerException.Message);
            }
        }

        public static void UpdateParameters(Guid? automationId, IEnumerable<AutomationParameter> automationParameters, AuthMethods authMethods)
        {
            UserInfo userInfo = authMethods.GetUserInfo();
            var apiInstance = GetApiInstance(userInfo.Token, userInfo.ServerUrl);

            try
            {
                var automationParametersList = new List<SDKAutomationParameter>();
                foreach (var parameter in automationParameters)
                {
                    automationParametersList.Add(parameter);
                }
                apiInstance.ApiVapiVersionAutomationsAutomationIdUpdateParametersPostAsyncWithHttpInfo(automationId.ToString(), userInfo.OrganizationId, authMethods.ApiVersion, automationParametersList);
            }
            catch (Exception ex)
            {
                if (ex.Message != "One or more errors occurred.")
                    throw new InvalidOperationException("Exception when calling AutomationsApi.UpdateParameters: " + ex.Message);
                else
                    throw new InvalidOperationException(ex.InnerException.Message);
            }
        }

        public static SystemFile.MemoryStream ExportAutomation(UserInfo userInfo, string automationID)
        {
            var automationsApi = GetApiInstance(userInfo.Token, userInfo.ServerUrl);

            try
            {
                return automationsApi.ExportAutomationWithHttpInfo(automationID, userInfo.ApiVersion, userInfo.OrganizationId).Data;
            }
            catch (Exception ex)
            {
                if (ex.Message != "One or more errors occurred.")
                    throw new InvalidOperationException("Exception when calling AutomationsApi.ExportAutomation: " + ex.Message);
                else
                    throw new InvalidOperationException(ex.InnerException.Message);
            }
        }

        public static Automation GetAutomation(UserInfo userInfo, string automationID)
        {
            var automationsApi = GetApiInstance(userInfo.Token, userInfo.ServerUrl);

            try
            {
                return automationsApi.GetAutomationWithHttpInfo(automationID, userInfo.ApiVersion, userInfo.OrganizationId).Data.Items.FirstOrDefault();
            }
            catch (Exception ex)
            {
                if (ex.Message != "One or more errors occurred.")
                    throw new InvalidOperationException("Exception when calling AutomationsApi.GetAutomation: " + ex.Message);
                else
                    throw new InvalidOperationException(ex.InnerException.Message);
            }
        }

        public static AutomationPaginatedList GetAutomations(UserInfo userInfo, string filter = null)
        {
            var automationsApi = GetApiInstance(userInfo.Token, userInfo.ServerUrl);

            try
            {
                return automationsApi.ApiVapiVersionAutomationsGetWithHttpInfo(userInfo.ApiVersion, userInfo.OrganizationId, filter).Data;
            }
            catch (Exception ex)
            {
                if (ex.Message != "One or more errors occurred.")
                    throw new InvalidOperationException("Exception when calling AutomationsApi.GetAutomations: " + ex.Message);
                else
                    throw new InvalidOperationException(ex.InnerException.Message);
            }
        }


        private static AutomationsApi GetApiInstance(string token, string serverUrl)
        {
            var apiInstance = new AutomationsApi(serverUrl);
            apiInstance.Configuration.AccessToken = token;

            return apiInstance;
        }
    }
}
