using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>mobilepay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeMobilePay>))]
public sealed record TypeMobilePay : OpenStringEnum<TypeMobilePay>
{
    private TypeMobilePay(string value) : base(value)
    {
    }

    public static readonly TypeMobilePay Mobilepay = new("mobilepay");

    public TResult Match<TResult>(Func<TResult> onMobilepay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mobilepay => onMobilepay(),
            _ => otherwise(Value)
        };

    public void Match(Action onMobilepay, Action<string> otherwise)
    {
        if (this == Mobilepay) onMobilepay();
        else otherwise(Value);
    }
}
