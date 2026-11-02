using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record UpdatePaymentMethodInfo
{
    /// <summary>
    /// Details to provide if <c>type</c> is <b>accel</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accel")]
    public AccelInfoUpdatePaymentMethodInfo? Accel { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>bcmc</b> (Bancontact).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bcmc")]
    public BcmcInfoUpdatePaymentMethodInfo? Bcmc { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>cartebancaire</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cartesBancaires")]
    public CartesBancairesInfoUpdatePaymentMethodInfo? CartesBancaires { get; init; }

    /// <summary>
    /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public IReadOnlyList<string>? Countries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cup")]
    public GenericPmWithTdiInfo? Cup { get; init; }

    /// <summary>
    /// The list of currencies that a payment method supports. By default, all currencies supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencies")]
    public IReadOnlyList<string>? Currencies { get; init; }

    /// <summary>
    /// Custom routing flags for acquirer routing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customRoutingFlags")]
    public IReadOnlyList<string>? CustomRoutingFlags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("diners")]
    public GenericPmWithTdiInfo? Diners { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discover")]
    public GenericPmWithTdiInfo? Discover { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft_directdebit_CA")]
    public GenericPmWithTdiInfo? EftDirectdebitCa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eftpos_australia")]
    public GenericPmWithTdiInfo? EftposAustralia { get; init; }

    /// <summary>
    /// Indicates whether the payment method is enabled (<b>true</b>) or disabled (<b>false</b>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("girocard")]
    public GenericPmWithTdiInfo? Girocard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ideal")]
    public GenericPmWithTdiInfo? Ideal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interac_card")]
    public GenericPmWithTdiInfo? InteracCard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jcb")]
    public GenericPmWithTdiInfo? Jcb { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro")]
    public GenericPmWithTdiInfo? Maestro { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro_usa")]
    public GenericPmWithTdiInfo? MaestroUsa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mc")]
    public GenericPmWithTdiInfo? Mc { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>nyce</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nyce")]
    public NyceInfoUpdatePaymentMethodInfo? Nyce { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>paybybank_plaid</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paybybank_plaid")]
    public PayByBankPlaidInfoUpdatePaymentMethodInfo? PaybybankPlaid { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>pulse</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pulse")]
    public PulseInfoUpdatePaymentMethodInfo? Pulse { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>sepadirectdebit</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit")]
    public SepaDirectDebitInfoUpdatePaymentMethodInfo? Sepadirectdebit { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>star</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("star")]
    public StarInfoUpdatePaymentMethodInfo? Star { get; init; }

    /// <summary>
    /// The store for this payment method
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeId")]
    public string? StoreId { get; init; }

    /// <summary>
    /// The list of stores for this payment method
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeIds")]
    public IReadOnlyList<string>? StoreIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visa")]
    public GenericPmWithTdiInfo? Visa { get; init; }
}
