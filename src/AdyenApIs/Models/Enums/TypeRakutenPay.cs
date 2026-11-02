using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>rakutenpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeRakutenPay>))]
public sealed record TypeRakutenPay : OpenStringEnum<TypeRakutenPay>
{
    private TypeRakutenPay(string value) : base(value)
    {
    }

    public static readonly TypeRakutenPay Rakutenpay = new("rakutenpay");

    public TResult Match<TResult>(Func<TResult> onRakutenpay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Rakutenpay => onRakutenpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onRakutenpay, Action<string> otherwise)
    {
        if (this == Rakutenpay) onRakutenpay();
        else otherwise(Value);
    }
}
