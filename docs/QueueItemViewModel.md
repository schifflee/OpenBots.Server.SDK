# IO.Swagger.Model.QueueItemViewModel
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
**State** | **string** |  | [optional] 
**StateMessage** | **string** |  | [optional] 
**IsLocked** | **bool?** |  | [optional] 
**LockedBy** | **Guid?** |  | [optional] 
**LockedOnUTC** | **DateTime?** |  | [optional] 
**LockedUntilUTC** | **DateTime?** |  | [optional] 
**LockedEndTimeUTC** | **DateTime?** |  | [optional] 
**ExpireOnUTC** | **DateTime?** |  | [optional] 
**PostponeUntilUTC** | **DateTime?** |  | [optional] 
**ErrorCode** | **string** |  | [optional] 
**ErrorMessage** | **string** |  | [optional] 
**ErrorSerialized** | **string** |  | [optional] 
**Source** | **string** |  | [optional] 
**Event** | **string** |  | [optional] 
**ResultJSON** | **string** |  | [optional] 
**QueueId** | **Guid?** |  | [optional] 
**Type** | **string** |  | [optional] 
**JsonType** | **string** |  | [optional] 
**DataJson** | **string** |  | [optional] 
**LockTransactionKey** | **Guid?** |  | [optional] 
**RetryCount** | **int?** |  | [optional] 
**Priority** | **int?** |  | [optional] 
**PayloadSizeInBytes** | **long?** |  | [optional] 
**Attachments** | [**List&lt;QueueItemAttachment&gt;**](QueueItemAttachment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

