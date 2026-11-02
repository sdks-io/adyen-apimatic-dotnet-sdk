using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>afterpay_default</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeAfterpay>))]
public sealed record TypeAfterpay : OpenStringEnum<TypeAfterpay>
{
    private TypeAfterpay(string value) : base(value)
    {
    }

    public static readonly TypeAfterpay AfterpayDefault = new("afterpay_default");

    public static readonly TypeAfterpay Afterpaytouch = new("afterpaytouch");

    public static readonly TypeAfterpay AfterpayB2B = new("afterpay_b2b");

    public static readonly TypeAfterpay Clearpay = new("clearpay");

    public TResult Match<TResult>(Func<TResult> onAfterpayDefault,
        Func<TResult> onAfterpaytouch,
        Func<TResult> onAfterpayB2B,
        Func<TResult> onClearpay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AfterpayDefault => onAfterpayDefault(),
            _ when this == Afterpaytouch => onAfterpaytouch(),
            _ when this == AfterpayB2B => onAfterpayB2B(),
            _ when this == Clearpay => onClearpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onAfterpayDefault,
        Action onAfterpaytouch,
        Action onAfterpayB2B,
        Action onClearpay,
        Action<string> otherwise)
    {
        if (this == AfterpayDefault) onAfterpayDefault();
        else if (this == Afterpaytouch) onAfterpaytouch();
        else if (this == AfterpayB2B) onAfterpayB2B();
        else if (this == Clearpay) onClearpay();
        else otherwise(Value);
    }
}
