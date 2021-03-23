# IO.Swagger.Model.AuditLog
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
**ObjectId** | **Guid?** | Id of object being changed | [optional] 
**ServiceName** | **string** | Name of Service used | [optional] 
**MethodName** | **string** | Name of Methos used | [optional] 
**ParametersJson** | **string** | Parameters needed to make the change | [optional] 
**ExceptionJson** | **string** | Any exceptions that occurred while making changes to the entity | [optional] 
**ChangedFromJson** | **string** | Information about entity before it was changed | [optional] 
**ChangedToJson** | **string** | Information about entity after it was changed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

