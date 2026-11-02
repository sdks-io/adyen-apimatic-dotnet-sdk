using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>wechatpay_pos</b>.
/// </summary>
public record WeChatPayPosInfoPaymentMethodSetupInfo
{
    /// <summary>
    /// The name of the contact person from merchant support.
    /// </summary>
    [JsonPropertyName("contactPersonName")]
    public required string ContactPersonName { get; init; }

    /// <summary>
    /// The email address of merchant support.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }
}
