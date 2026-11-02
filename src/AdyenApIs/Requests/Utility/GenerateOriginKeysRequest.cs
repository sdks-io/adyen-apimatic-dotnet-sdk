using AdyenApIs.Models;

namespace AdyenApIs.Requests.Utility;

/// <summary>
/// The inputs of the GenerateOriginKeys operation.
/// </summary>
public sealed record GenerateOriginKeysRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public UtilityRequest? Body { get; init; }
}
