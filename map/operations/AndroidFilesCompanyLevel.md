<!-- Generated file — do not edit; regenerated with the SDK. -->

# AndroidFilesCompanyLevel — operations

Accessor: `client.AndroidFilesCompanyLevel` · Source: `src/AdyenApIs/Api/AndroidFilesCompanyLevel.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAndroidApp

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateAndroidApp(CreateAndroidAppRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `UploadAndroidAppResponse`
- **Error**: `ApiException<CreateAndroidAppError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateAndroidAppRequest` | `src/AdyenApIs/Requests/AndroidFilesCompanyLevel/CreateAndroidAppRequest.cs` |
| `UploadAndroidAppResponse` | `src/AdyenApIs/Models/UploadAndroidAppResponse.cs` |
| `CreateAndroidAppError` | `src/AdyenApIs/Errors/CreateAndroidAppError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetAndroidApp

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetAndroidApp(GetAndroidAppRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Id`
- **Returns**: `AndroidApp`
- **Error**: `ApiException<GetAndroidAppError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAndroidAppRequest` | `src/AdyenApIs/Requests/AndroidFilesCompanyLevel/GetAndroidAppRequest.cs` |
| `AndroidApp` | `src/AdyenApIs/Models/AndroidApp.cs` |
| `GetAndroidAppError` | `src/AdyenApIs/Errors/GetAndroidAppError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListAndroidApps

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListAndroidApps(ListAndroidAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `packageName` ← `PackageName`, `versionCode` ← `VersionCode`
- **Returns**: `AndroidAppsResponse`
- **Error**: `ApiException<ListAndroidAppsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAndroidAppsRequest` | `src/AdyenApIs/Requests/AndroidFilesCompanyLevel/ListAndroidAppsRequest.cs` |
| `AndroidAppsResponse` | `src/AdyenApIs/Models/AndroidAppsResponse.cs` |
| `ListAndroidAppsError` | `src/AdyenApIs/Errors/ListAndroidAppsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListAndroidCertificates

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListAndroidCertificates(ListAndroidCertificatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `certificateName` ← `CertificateName`
- **Returns**: `AndroidCertificatesResponse`
- **Error**: `ApiException<ListAndroidCertificatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAndroidCertificatesRequest` | `src/AdyenApIs/Requests/AndroidFilesCompanyLevel/ListAndroidCertificatesRequest.cs` |
| `AndroidCertificatesResponse` | `src/AdyenApIs/Models/AndroidCertificatesResponse.cs` |
| `ListAndroidCertificatesError` | `src/AdyenApIs/Errors/ListAndroidCertificatesError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateAndroidApp

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateAndroidApp(UpdateAndroidAppRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Id`
- **Returns**: `ReprocessAndroidAppResponse`
- **Error**: `ApiException<UpdateAndroidAppError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateAndroidAppRequest` | `src/AdyenApIs/Requests/AndroidFilesCompanyLevel/UpdateAndroidAppRequest.cs` |
| `ReprocessAndroidAppResponse` | `src/AdyenApIs/Models/ReprocessAndroidAppResponse.cs` |
| `UpdateAndroidAppError` | `src/AdyenApIs/Errors/UpdateAndroidAppError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UploadAndroidCertificate

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UploadAndroidCertificate(UploadAndroidCertificateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `UploadAndroidCertificateResponse`
- **Error**: `ApiException<UploadAndroidCertificateError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UploadAndroidCertificateRequest` | `src/AdyenApIs/Requests/AndroidFilesCompanyLevel/UploadAndroidCertificateRequest.cs` |
| `UploadAndroidCertificateResponse` | `src/AdyenApIs/Models/UploadAndroidCertificateResponse.cs` |
| `UploadAndroidCertificateError` | `src/AdyenApIs/Errors/UploadAndroidCertificateError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

