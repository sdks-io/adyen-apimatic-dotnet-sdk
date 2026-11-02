using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// The user's full name.
/// </summary>
public record NameUser
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
