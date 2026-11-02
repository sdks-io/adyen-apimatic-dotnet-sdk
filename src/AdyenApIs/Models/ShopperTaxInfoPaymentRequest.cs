using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// The tax info of the shopper
/// </summary>
public record ShopperTaxInfoPaymentRequest
{
    /// <summary>
    /// The tax-id of the shopper doing the transaction.
    /// </summary>
    [JsonPropertyName("taxId")]
    [MaxLength(10)]
    public required string TaxId { get; init; }

    /// <summary>
    /// The country to which the tax-id belongs to.
    /// </summary>
    [JsonPropertyName("taxIdCountryCode")]
    [MaxLength(2)]
    public required string TaxIdCountryCode { get; init; }
}
