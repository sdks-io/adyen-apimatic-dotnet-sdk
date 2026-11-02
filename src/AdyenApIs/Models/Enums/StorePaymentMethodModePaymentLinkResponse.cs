using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Indicates if the details of the payment method will be stored for the shopper. Possible values:
/// * <b>disabled</b> – No details will be stored (default).
/// * <b>askForConsent</b> – If the <c>shopperReference</c> is provided, the Drop-in/Component shows a checkbox where the shopper can select to store their payment details for card payments.
/// * <b>enabled</b> – If the <c>shopperReference</c> is provided, the details will be stored without asking the shopper for consent.
///  When set to <b>askForConsent</b> or <b>enabled</b>, you must also include the <c>recurringProcessingModel</c> parameter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StorePaymentMethodModePaymentLinkResponse>))]
public sealed record StorePaymentMethodModePaymentLinkResponse : OpenStringEnum<StorePaymentMethodModePaymentLinkResponse>
{
    private StorePaymentMethodModePaymentLinkResponse(string value) : base(value)
    {
    }

    public static readonly StorePaymentMethodModePaymentLinkResponse AskForConsent = new("askForConsent");

    public static readonly StorePaymentMethodModePaymentLinkResponse Disabled = new("disabled");

    public static readonly StorePaymentMethodModePaymentLinkResponse Enabled = new("enabled");

    public TResult Match<TResult>(Func<TResult> onAskForConsent,
        Func<TResult> onDisabled,
        Func<TResult> onEnabled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AskForConsent => onAskForConsent(),
            _ when this == Disabled => onDisabled(),
            _ when this == Enabled => onEnabled(),
            _ => otherwise(Value)
        };

    public void Match(Action onAskForConsent, Action onDisabled, Action onEnabled, Action<string> otherwise)
    {
        if (this == AskForConsent) onAskForConsent();
        else if (this == Disabled) onDisabled();
        else if (this == Enabled) onEnabled();
        else otherwise(Value);
    }
}
