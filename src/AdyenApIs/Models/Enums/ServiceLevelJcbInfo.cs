using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Specifies the service level (settlement type) of this payment method. Required for merchants operating in Japan.
/// Possible values:
/// * <b>noContract</b>: Adyen holds the contract with JCB for merchants operating in Japan or American Express for merchants operating in Canada, Australia and New Zealand.
/// * <b>gatewayContract</b>: JCB or American Express receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.
/// * <b>paymentDesignatorContract</b>: Available only for merchants operating in Canada, Australia and New Zealand. Adyen receives the settlement, and handles disputes and payouts.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceLevelJcbInfo>))]
public sealed record ServiceLevelJcbInfo : OpenStringEnum<ServiceLevelJcbInfo>
{
    private ServiceLevelJcbInfo(string value) : base(value)
    {
    }

    public static readonly ServiceLevelJcbInfo NoContract = new("noContract");

    public static readonly ServiceLevelJcbInfo GatewayContract = new("gatewayContract");

    public static readonly ServiceLevelJcbInfo PaymentDesignatorContract = new("paymentDesignatorContract");

    public TResult Match<TResult>(Func<TResult> onNoContract,
        Func<TResult> onGatewayContract,
        Func<TResult> onPaymentDesignatorContract,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoContract => onNoContract(),
            _ when this == GatewayContract => onGatewayContract(),
            _ when this == PaymentDesignatorContract => onPaymentDesignatorContract(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoContract,
        Action onGatewayContract,
        Action onPaymentDesignatorContract,
        Action<string> otherwise)
    {
        if (this == NoContract) onNoContract();
        else if (this == GatewayContract) onGatewayContract();
        else if (this == PaymentDesignatorContract) onPaymentDesignatorContract();
        else otherwise(Value);
    }
}
