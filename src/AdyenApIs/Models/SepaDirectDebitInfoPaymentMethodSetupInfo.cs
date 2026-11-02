using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>sepadirectdebit</b>.
/// </summary>
public record SepaDirectDebitInfoPaymentMethodSetupInfo
{
    /// <summary>
    /// Creditor id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creditorId")]
    public string? CreditorId { get; init; }

    /// <summary>
    /// Information regarding the transaction description.
    /// &gt; You cannot configure the transaction description in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfoSepaDirectDebitInfo? TransactionDescription { get; init; }
}
