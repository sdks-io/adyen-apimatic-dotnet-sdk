using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// The user's full name.
/// <para>
/// Allowed length: 1—80 characters.
/// </para>
/// </summary>
public record NameCreateCompanyUserRequest
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
