# IO.Swagger.Model.QueueItem
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
**IsLocked** | **bool?** | Whether a QueueItem is locked by a job or not | [optional] 
**LockedOnUTC** | **DateTime?** | When the QueueItem was locked | [optional] 
**LockedUntilUTC** | **DateTime?** | When to lock QueueItem if still being executed | [optional] 
**LockedBy** | **Guid?** | Which Agent locked the QueueItem | [optional] 
**QueueId** | **Guid?** | Which Queue the QueueItem belongs to | [optional] 
**Type** | **string** | Format of Data | [optional] 
**JsonType** | **string** | Describes the type of item the queue is dealing with | [optional] 
**DataJson** | **string** | Data in JSON or Text format | [optional] 
**State** | **string** | Failed, Expired, Successful, New | [optional] 
**StateMessage** | **string** | Message given to user after state of QueueItem was changed | [optional] 
**LockTransactionKey** | **Guid?** | Guid generated when item is dequeued | [optional] 
**LockedEndTimeUTC** | **DateTime?** | Tells when QueueItem has been executed and when IsLocked has been turned back to false | [optional] 
**RetryCount** | **int?** | Number of time a QueueItem has been retried | [optional] 
**Priority** | **int?** | Priority of when queue item should be dequeued | [optional] 
**ExpireOnUTC** | **DateTime?** | DateTime the queue item will expire on | [optional] 
**PostponeUntilUTC** | **DateTime?** | DateTime to postpone the queue item from being processed until | [optional] 
**ErrorCode** | **string** | Error Code received when processing a queue item | [optional] 
**ErrorMessage** | **string** | Error message received when processing a queue item | [optional] 
**ErrorSerialized** | **string** | ErrorCode and ErrorMessage serialized into JSON string | [optional] 
**Source** | **string** | System of event that was raised (ex: \&quot;Employee.Onboarded\&quot;) | [optional] 
**Event** | **string** | Event raised from an application (ex: \&quot;New employee joins the company.\&quot;) | [optional] 
**ResultJSON** | **string** | Result of the processed queue item | [optional] 
**PayloadSizeInBytes** | **long?** | Total bytes of all attached files | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

