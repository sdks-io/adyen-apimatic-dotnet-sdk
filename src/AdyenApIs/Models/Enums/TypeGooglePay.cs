using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>googlepay</b>, <b>paywithgoogle</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeGooglePay>))]
public sealed record TypeGooglePay : OpenStringEnum<TypeGooglePay>
{
    private TypeGooglePay(string value) : base(value)
    {
    }

    public static readonly TypeGooglePay Googlepay = new("googlepay");

    public TResult Match<TResult>(Func<TResult> onGooglepay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Googlepay => onGooglepay(),
            _ => otherwise(Value)
        };

    public void Match(Action onGooglepay, Action<string> otherwise)
    {
        if (this == Googlepay) onGooglepay();
        else otherwise(Value);
    }
}
