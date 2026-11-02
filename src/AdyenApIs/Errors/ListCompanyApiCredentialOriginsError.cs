using System.Threading.Tasks;
using AdyenApIs.Core.ErrorResponse;
using AdyenApIs.Core.Models;
using AdyenApIs.Models;

namespace AdyenApIs.Errors;

public sealed class ListCompanyApiCredentialOriginsError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private ListCompanyApiCredentialOriginsError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static ListCompanyApiCredentialOriginsError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static ListCompanyApiCredentialOriginsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) => _restServiceErrorValue.TryGetValue(out value);

    private static Task<ListCompanyApiCredentialOriginsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => response.Json<RestServiceError>().As(AsRestServiceError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ListCompanyApiCredentialOriginsError> Response { get; } = new(Create);
}
