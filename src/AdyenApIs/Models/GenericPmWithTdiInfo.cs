using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record GenericPmWithTdiInfo
{
    /// <summary>
    /// Information regarding the transaction description.
    /// &gt; You cannot configure the transaction description in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfoGenericPmWithTdiInfo? TransactionDescription { get; init; }
}
