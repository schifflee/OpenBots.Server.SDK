# IO.Swagger.Model.Automation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** |  | [optional] 
**IsDeleted** | **bool?** |  | [optional] [default to false]
**CreatedBy** | **string** |  | [optional] 
**CreatedOn** | **DateTime?** |  | [optional] 
**DeletedBy** | **string** |  | [optional] 
**DeleteOn** | **DateTime?** |  | [optional] 
**Timestamp** | **byte[]** |  | [optional] 
**UpdatedOn** | **DateTime?** |  | [optional] 
**UpdatedBy** | **string** |  | [optional] 
**Name** | **string** |  | 
**FileId** | **Guid?** | Id linked to Files data table | [optional] 
**OriginalPackageName** | **string** | Original name of file | [optional] 
**AutomationEngine** | **string** | Type of automation that will be executed (i.e. OpenBots, Python, etc.) | [optional] 
**AverageSuccessfulExecutionInMinutes** | **double?** | Average execution time in minutes of successful jobs that execute this process | [optional] 
**AverageUnSuccessfulExecutionInMinutes** | **double?** | Average execution time in minutes of unsuccessful jobs that execute this process | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

