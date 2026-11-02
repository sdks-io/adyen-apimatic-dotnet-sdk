using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>paypay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypePayPay>))]
public sealed record TypePayPay : OpenStringEnum<TypePayPay>
{
    private TypePayPay(string value) : base(value)
    {
    }

    public static readonly TypePayPay Paypay = new("paypay");

    public TResult Match<TResult>(Func<TResult> onPaypay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Paypay => onPaypay(),
            _ => otherwise(Value)
        };

    public void Match(Action onPaypay, Action<string> otherwise)
    {
        if (this == Paypay) onPaypay();
        else otherwise(Value);
    }
}
