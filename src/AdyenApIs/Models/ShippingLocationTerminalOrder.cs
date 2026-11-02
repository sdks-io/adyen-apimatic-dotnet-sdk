using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// The details of the location where the order is shipped to.
/// </summary>
public record ShippingLocationTerminalOrder
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public AddressManagementApi? Address { get; init; }

    /// <summary>
    /// The contact details for the shipping location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contact")]
    public ContactShippingLocation? Contact { get; init; }

    /// <summary>
    /// The unique identifier of the shipping location, for use as <c>shippingLocationId</c> when creating an order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The unique name of the shipping location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
