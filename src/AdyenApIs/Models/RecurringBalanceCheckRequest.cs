using System;
using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

/// <summary>
/// The recurring settings for the payment. Use this property when you want to enable <see href="https://docs.adyen.com/classic-integration/recurring-payments">recurring payments</see>.
/// </summary>
public record RecurringBalanceCheckRequest
{
    /// <summary>
    /// The type of recurring contract to be used.
    /// Possible values:
    /// * <c>ONECLICK</c> – Payment details can be used to initiate a one-click payment, where the shopper enters the <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid">card security code (CVC/CVV)</see>.
    /// * <c>RECURRING</c> – Payment details can be used without the card security code to initiate <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp">card-not-present transactions</see>.
    /// * <c>ONECLICK,RECURRING</c> – Payment details can be used regardless of whether the shopper is on your site or not.
    /// * <c>PAYOUT</c> – Payment details can be used to <see href="https://docs.adyen.com/online-payments/online-payouts">make a payout</see>.
    /// * <c>EXTERNAL</c> - Use this when you store payment details and send the raw card number or network token directly in your API request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contract")]
    public Contract? Contract { get; init; }

    /// <summary>
    /// A descriptive name for this detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailName")]
    public string? RecurringDetailName { get; init; }

    /// <summary>
    /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringExpiry")]
    public DateTimeOffset? RecurringExpiry { get; init; }

    /// <summary>
    /// Minimum number of days between authorisations. Only for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringFrequency")]
    public string? RecurringFrequency { get; init; }

    /// <summary>
    /// The name of the token service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenService")]
    public TokenService? TokenService { get; init; }
}
