using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record WeChatPayMiniProgram
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appId")]
    public string? AppId { get; init; }

    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openid")]
    public string? Openid { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailReference")]
    public string? RecurringDetailReference { get; init; }

    /// <summary>
    /// Base64-encoded JSON object containing SDK related parameters required by the SDK
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    [MaxLength(50000)]
    public string? SdkData { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    [MaxLength(64)]
    public string? StoredPaymentMethodId { get; init; }

    /// <summary>
    /// <b>wechatpayMiniProgram</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeWeChatPayMiniProgram? Type { get; init; } = TypeWeChatPayMiniProgram.WechatpayMiniProgram;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
