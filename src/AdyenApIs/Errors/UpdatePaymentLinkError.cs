using System.Threading.Tasks;
using AdyenApIs.Core.ErrorResponse;
using AdyenApIs.Core.Models;
using AdyenApIs.Models;

namespace AdyenApIs.Errors;

public sealed class UpdatePaymentLinkError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private UpdatePaymentLinkError(Optional<ServiceError> serviceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static UpdatePaymentLinkError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static UpdatePaymentLinkError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    private static Task<UpdatePaymentLinkError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => response.Json<ServiceError>().As(AsServiceError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<UpdatePaymentLinkError> Response { get; } = new(Create);
}
