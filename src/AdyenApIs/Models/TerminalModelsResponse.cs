using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record TerminalModelsResponse
{
    /// <summary>
    /// The terminal models that the API credential has access to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<IdName>? Data { get; init; }
}
