using AdyenApIs.Models;

namespace AdyenApIs.Requests.Utility;

/// <summary>
/// The inputs of the ValidateShopperId operation.
/// </summary>
public sealed record ValidateShopperIdOperationRequest
{
    public required ValidateShopperIdRequest Body { get; init; }
}
