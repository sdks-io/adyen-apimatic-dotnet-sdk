using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Information about your application. For more details, see <see href="https://docs.adyen.com/development-resources/building-adyen-solutions">Building Adyen solutions</see>.
/// </summary>
public record ApplicationInfoDonationPaymentRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenLibrary")]
    public CommonField? AdyenLibrary { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenPaymentSource")]
    public CommonField? AdyenPaymentSource { get; init; }

    /// <summary>
    /// Third-party developed platform used to initiate payment requests. For example, Magento, Zuora, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalPlatform")]
    public ExternalPlatformApplicationInfo? ExternalPlatform { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantApplication")]
    public CommonField? MerchantApplication { get; init; }

    /// <summary>
    /// Merchant device information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDevice")]
    public MerchantDeviceApplicationInfo? MerchantDevice { get; init; }

    /// <summary>
    /// Shopper interaction device, such as terminal, mobile device or web browser, to initiate payment requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteractionDevice")]
    public ShopperInteractionDeviceApplicationInfo? ShopperInteractionDevice { get; init; }
}
