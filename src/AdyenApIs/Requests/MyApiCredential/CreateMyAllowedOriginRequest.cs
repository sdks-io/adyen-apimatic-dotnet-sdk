using AdyenApIs.Models;

namespace AdyenApIs.Requests.MyApiCredential;

/// <summary>
/// The inputs of the CreateMyAllowedOrigin operation.
/// </summary>
public sealed record CreateMyAllowedOriginRequest
{
    public CreateAllowedOriginRequest? Body { get; init; }
}
