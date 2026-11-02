using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>bcmc</b> (Bancontact).
/// </summary>
public record BcmcInfoPaymentMethodSetupInfo
{
    /// <summary>
    /// Indicates if <see href="https://docs.adyen.com/payment-methods/bancontact/bancontact-mobile">Bancontact mobile</see> is enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableBcmcMobile")]
    public bool? EnableBcmcMobile { get; init; }
}
