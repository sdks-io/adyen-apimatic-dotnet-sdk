using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>paywithgoogle</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeGooglePay1>))]
public sealed record TypeGooglePay1 : OpenStringEnum<TypeGooglePay1>
{
    private TypeGooglePay1(string value) : base(value)
    {
    }

    public static readonly TypeGooglePay1 Paywithgoogle = new("paywithgoogle");

    public TResult Match<TResult>(Func<TResult> onPaywithgoogle, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Paywithgoogle => onPaywithgoogle(),
            _ => otherwise(Value)
        };

    public void Match(Action onPaywithgoogle, Action<string> otherwise)
    {
        if (this == Paywithgoogle) onPaywithgoogle();
        else otherwise(Value);
    }
}
