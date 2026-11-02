using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>ratepay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeRatepay>))]
public sealed record TypeRatepay : OpenStringEnum<TypeRatepay>
{
    private TypeRatepay(string value) : base(value)
    {
    }

    public static readonly TypeRatepay Ratepay = new("ratepay");

    public static readonly TypeRatepay RatepayDirectdebit = new("ratepay_directdebit");

    public TResult Match<TResult>(Func<TResult> onRatepay,
        Func<TResult> onRatepayDirectdebit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ratepay => onRatepay(),
            _ when this == RatepayDirectdebit => onRatepayDirectdebit(),
            _ => otherwise(Value)
        };

    public void Match(Action onRatepay, Action onRatepayDirectdebit, Action<string> otherwise)
    {
        if (this == Ratepay) onRatepay();
        else if (this == RatepayDirectdebit) onRatepayDirectdebit();
        else otherwise(Value);
    }
}
