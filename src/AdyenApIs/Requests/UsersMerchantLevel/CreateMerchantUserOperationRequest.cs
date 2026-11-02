using AdyenApIs.Models;

namespace AdyenApIs.Requests.UsersMerchantLevel;

/// <summary>
/// The inputs of the CreateMerchantUser operation.
/// </summary>
public sealed record CreateMerchantUserOperationRequest
{
    /// <summary>
    /// Unique identifier of the merchant.
    /// </summary>
    public required string MerchantId { get; init; }

    public CreateMerchantUserRequest? Body { get; init; }
}
