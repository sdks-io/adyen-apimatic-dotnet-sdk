<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersCompanyLevel — operations

Accessor: `client.UsersCompanyLevel` · Source: `src/AdyenApIs/Api/UsersCompanyLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCompanyUser

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateCompanyUser(CreateCompanyUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `CreateCompanyUserResponse`
- **Error**: `ApiException<CreateCompanyUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCompanyUserOperationRequest` | `src/AdyenApIs/Requests/UsersCompanyLevel/CreateCompanyUserOperationRequest.cs` |
| `CreateCompanyUserRequest` | `src/AdyenApIs/Models/CreateCompanyUserRequest.cs` |
| `CreateCompanyUserResponse` | `src/AdyenApIs/Models/CreateCompanyUserResponse.cs` |
| `CreateCompanyUserError` | `src/AdyenApIs/Errors/CreateCompanyUserError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetCompanyUser

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompanyUser(GetCompanyUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `UserId`
- **Returns**: `CompanyUser`
- **Error**: `ApiException<GetCompanyUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompanyUserRequest` | `src/AdyenApIs/Requests/UsersCompanyLevel/GetCompanyUserRequest.cs` |
| `CompanyUser` | `src/AdyenApIs/Models/CompanyUser.cs` |
| `GetCompanyUserError` | `src/AdyenApIs/Errors/GetCompanyUserError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyUsers

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyUsers(ListCompanyUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `username` ← `Username`
- **Returns**: `ListCompanyUsersResponse`
- **Error**: `ApiException<ListCompanyUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyUsersRequest` | `src/AdyenApIs/Requests/UsersCompanyLevel/ListCompanyUsersRequest.cs` |
| `ListCompanyUsersResponse` | `src/AdyenApIs/Models/ListCompanyUsersResponse.cs` |
| `ListCompanyUsersError` | `src/AdyenApIs/Errors/ListCompanyUsersError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateCompanyUser

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateCompanyUser(UpdateCompanyUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `UserId`
- **Returns**: `CompanyUser`
- **Error**: `ApiException<UpdateCompanyUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCompanyUserOperationRequest` | `src/AdyenApIs/Requests/UsersCompanyLevel/UpdateCompanyUserOperationRequest.cs` |
| `UpdateCompanyUserRequest` | `src/AdyenApIs/Models/UpdateCompanyUserRequest.cs` |
| `CompanyUser` | `src/AdyenApIs/Models/CompanyUser.cs` |
| `UpdateCompanyUserError` | `src/AdyenApIs/Errors/UpdateCompanyUserError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

