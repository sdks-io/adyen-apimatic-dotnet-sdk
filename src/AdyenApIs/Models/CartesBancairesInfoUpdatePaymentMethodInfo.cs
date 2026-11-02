using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>cartebancaire</b>.
/// </summary>
public record CartesBancairesInfoUpdatePaymentMethodInfo
{
    /// <summary>
    /// Cartes Bancaires SIRET. Format: 14 digits.
    /// </summary>
    [JsonPropertyName("siret")]
    public required string Siret { get; init; }

    /// <summary>
    /// Information regarding the transaction description.
    /// &gt; You cannot configure the transaction description in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfoCartesBancairesInfo? TransactionDescription { get; init; }
}
