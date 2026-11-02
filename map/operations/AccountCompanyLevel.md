<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountCompanyLevel — operations

Accessor: `client.AccountCompanyLevel` · Source: `src/AdyenApIs/Api/AccountCompanyLevel.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompany

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompany(GetCompanyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `CompanyManagementApi`
- **Error**: `ApiException<GetCompanyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompanyRequest` | `src/AdyenApIs/Requests/AccountCompanyLevel/GetCompanyRequest.cs` |
| `CompanyManagementApi` | `src/AdyenApIs/Models/CompanyManagementApi.cs` |
| `GetCompanyError` | `src/AdyenApIs/Errors/GetCompanyError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanies

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanies(ListCompaniesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListCompanyResponse`
- **Error**: `ApiException<ListCompaniesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompaniesRequest` | `src/AdyenApIs/Requests/AccountCompanyLevel/ListCompaniesRequest.cs` |
| `ListCompanyResponse` | `src/AdyenApIs/Models/ListCompanyResponse.cs` |
| `ListCompaniesError` | `src/AdyenApIs/Errors/ListCompaniesError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyMerchants

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyMerchants(ListCompanyMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListMerchantResponse`
- **Error**: `ApiException<ListCompanyMerchantsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyMerchantsRequest` | `src/AdyenApIs/Requests/AccountCompanyLevel/ListCompanyMerchantsRequest.cs` |
| `ListMerchantResponse` | `src/AdyenApIs/Models/ListMerchantResponse.cs` |
| `ListCompanyMerchantsError` | `src/AdyenApIs/Errors/ListCompanyMerchantsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

