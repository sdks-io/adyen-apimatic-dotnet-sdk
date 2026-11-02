<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersMerchantLevel — operations

Accessor: `client.UsersMerchantLevel` · Source: `src/AdyenApIs/Api/UsersMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateMerchantUser

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateMerchantUser(CreateMerchantUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `CreateUserResponse`
- **Error**: `ApiException<CreateMerchantUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMerchantUserOperationRequest` | `src/AdyenApIs/Requests/UsersMerchantLevel/CreateMerchantUserOperationRequest.cs` |
| `CreateMerchantUserRequest` | `src/AdyenApIs/Models/CreateMerchantUserRequest.cs` |
| `CreateUserResponse` | `src/AdyenApIs/Models/CreateUserResponse.cs` |
| `CreateMerchantUserError` | `src/AdyenApIs/Errors/CreateMerchantUserError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMerchantUser

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantUser(GetMerchantUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `UserId`
- **Returns**: `User`
- **Error**: `ApiException<GetMerchantUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantUserRequest` | `src/AdyenApIs/Requests/UsersMerchantLevel/GetMerchantUserRequest.cs` |
| `User` | `src/AdyenApIs/Models/User.cs` |
| `GetMerchantUserError` | `src/AdyenApIs/Errors/GetMerchantUserError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantUsers

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantUsers(ListMerchantUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `username` ← `Username`
- **Returns**: `ListMerchantUsersResponse`
- **Error**: `ApiException<ListMerchantUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantUsersRequest` | `src/AdyenApIs/Requests/UsersMerchantLevel/ListMerchantUsersRequest.cs` |
| `ListMerchantUsersResponse` | `src/AdyenApIs/Models/ListMerchantUsersResponse.cs` |
| `ListMerchantUsersError` | `src/AdyenApIs/Errors/ListMerchantUsersError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateMerchantUser

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateMerchantUser(UpdateMerchantUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `UserId`
- **Returns**: `User`
- **Error**: `ApiException<UpdateMerchantUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMerchantUserOperationRequest` | `src/AdyenApIs/Requests/UsersMerchantLevel/UpdateMerchantUserOperationRequest.cs` |
| `UpdateMerchantUserRequest` | `src/AdyenApIs/Models/UpdateMerchantUserRequest.cs` |
| `User` | `src/AdyenApIs/Models/User.cs` |
| `UpdateMerchantUserError` | `src/AdyenApIs/Errors/UpdateMerchantUserError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

