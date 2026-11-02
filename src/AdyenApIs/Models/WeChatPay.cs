using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record WeChatPay
{
    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

    /// <summary>
    /// Base64-encoded JSON object containing SDK related parameters required by the SDK
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    [MaxLength(50000)]
    public string? SdkData { get; init; }

    /// <summary>
    /// <b>wechatpay</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeWeChatPay? Type { get; init; } = TypeWeChatPay.Wechatpay;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
