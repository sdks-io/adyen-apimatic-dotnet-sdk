using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>paybybank_plaid</b>.
/// </summary>
public record PayByBankPlaidInfoPaymentMethod
{
    /// <summary>
    /// Merchant logo (max. size 150kB). Format: Base64-encoded string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }

    /// <summary>
    /// Information regarding the transaction description.
    /// &gt; You cannot configure the transaction description in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfoPayByBankPlaidInfo? TransactionDescription { get; init; }
}
