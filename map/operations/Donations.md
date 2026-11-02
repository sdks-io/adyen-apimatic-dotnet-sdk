<!-- Generated file — do not edit; regenerated with the SDK. -->

# Donations — operations

Accessor: `client.Donations` · Source: `src/AdyenApIs/Api/Donations.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateDonation

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateDonation(CreateDonationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DonationPaymentResponse`
- **Error**: `ApiException<CreateDonationError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateDonationRequest` | `src/AdyenApIs/Requests/Donations/CreateDonationRequest.cs` |
| `DonationPaymentRequest` | `src/AdyenApIs/Models/DonationPaymentRequest.cs` |
| `DonationPaymentResponse` | `src/AdyenApIs/Models/DonationPaymentResponse.cs` |
| `CreateDonationError` | `src/AdyenApIs/Errors/CreateDonationError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### GetDonationCampaigns

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetDonationCampaigns(GetDonationCampaignsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DonationCampaignsResponse`
- **Error**: `ApiException<GetDonationCampaignsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDonationCampaignsRequest` | `src/AdyenApIs/Requests/Donations/GetDonationCampaignsRequest.cs` |
| `DonationCampaignsRequest` | `src/AdyenApIs/Models/DonationCampaignsRequest.cs` |
| `DonationCampaignsResponse` | `src/AdyenApIs/Models/DonationCampaignsResponse.cs` |
| `GetDonationCampaignsError` | `src/AdyenApIs/Errors/GetDonationCampaignsError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

