namespace AdyenApIs.Requests.MyApiCredential;

/// <summary>
/// The inputs of the DeleteMyAllowedOrigin operation.
/// </summary>
public sealed record DeleteMyAllowedOriginRequest
{
    /// <summary>
    /// Unique identifier of the allowed origin.
    /// </summary>
    public required string OriginId { get; init; }
}
