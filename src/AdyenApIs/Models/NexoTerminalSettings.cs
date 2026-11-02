using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Settings for a Terminal API integration.
/// </summary>
public record NexoTerminalSettings
{
    /// <summary>
    /// The list of local and public URLs to send display notifications to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayUrls")]
    public NotificationUrlNexo? DisplayUrls { get; init; }

    /// <summary>
    /// The key you share with Adyen to secure local communications when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionKey")]
    public KeyNexo? EncryptionKey { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventUrls")]
    public EventUrl? EventUrls { get; init; }

    /// <summary>
    /// One or more URLs to send event messages to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nexoEventUrls")]
    public IReadOnlyList<string>? NexoEventUrls { get; init; }

    /// <summary>
    /// Configures sending event notifications by pressing a button on a terminal, for example used for pay-at-table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notification")]
    public NotificationNexo? Notification { get; init; }
}
