using AdyenApIs.Models;

namespace AdyenApIs.Requests.UsersMerchantLevel;

/// <summary>
/// The inputs of the UpdateMerchantUser operation.
/// </summary>
public sealed record UpdateMerchantUserOperationRequest
{
    /// <summary>
    /// Unique identifier of the merchant.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the user.
    /// </summary>
    public required string UserId { get; init; }

    public UpdateMerchantUserRequest? Body { get; init; }
}
