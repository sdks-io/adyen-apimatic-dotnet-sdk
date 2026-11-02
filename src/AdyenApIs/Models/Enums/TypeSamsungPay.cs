using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>samsungpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeSamsungPay>))]
public sealed record TypeSamsungPay : OpenStringEnum<TypeSamsungPay>
{
    private TypeSamsungPay(string value) : base(value)
    {
    }

    public static readonly TypeSamsungPay Samsungpay = new("samsungpay");

    public TResult Match<TResult>(Func<TResult> onSamsungpay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Samsungpay => onSamsungpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onSamsungpay, Action<string> otherwise)
    {
        if (this == Samsungpay) onSamsungpay();
        else otherwise(Value);
    }
}
