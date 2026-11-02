using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>ticket</b> (Edenred Brazil).
/// </summary>
public record TicketInfoPaymentMethod
{
    /// <summary>
    /// Ticket requestorId
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestorId")]
    public string? RequestorId { get; init; }
}
