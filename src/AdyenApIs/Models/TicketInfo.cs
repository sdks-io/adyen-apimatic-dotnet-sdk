using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record TicketInfo
{
    /// <summary>
    /// Ticket requestorId
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestorId")]
    public string? RequestorId { get; init; }
}
