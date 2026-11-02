using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record Name2
{
    /// <summary>
    /// The first name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(80)]
    public string? FirstName { get; init; }

    /// <summary>
    /// The last name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(80)]
    public string? LastName { get; init; }
}
