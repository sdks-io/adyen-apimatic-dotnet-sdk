namespace AdyenApIs.Requests.MyApiCredential;

/// <summary>
/// The inputs of the GetMyAllowedOrigin operation.
/// </summary>
public sealed record GetMyAllowedOriginRequest
{
    /// <summary>
    /// Unique identifier of the allowed origin.
    /// </summary>
    public required string OriginId { get; init; }
}
