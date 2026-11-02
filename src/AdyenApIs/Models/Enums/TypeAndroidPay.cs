using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>androidpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeAndroidPay>))]
public sealed record TypeAndroidPay : OpenStringEnum<TypeAndroidPay>
{
    private TypeAndroidPay(string value) : base(value)
    {
    }

    public static readonly TypeAndroidPay Androidpay = new("androidpay");

    public TResult Match<TResult>(Func<TResult> onAndroidpay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Androidpay => onAndroidpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onAndroidpay, Action<string> otherwise)
    {
        if (this == Androidpay) onAndroidpay();
        else otherwise(Value);
    }
}
