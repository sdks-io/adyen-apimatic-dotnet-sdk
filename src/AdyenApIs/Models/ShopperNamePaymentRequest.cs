using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// The shopper's full name.
/// </summary>
public record ShopperNamePaymentRequest
{
    /// <summary>
    /// The first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    [MaxLength(80)]
    public required string FirstName { get; init; }

    /// <summary>
    /// The last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    [MaxLength(80)]
    public required string LastName { get; init; }
}
