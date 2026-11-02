using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>amazonpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeAmazonPay>))]
public sealed record TypeAmazonPay : OpenStringEnum<TypeAmazonPay>
{
    private TypeAmazonPay(string value) : base(value)
    {
    }

    public static readonly TypeAmazonPay Amazonpay = new("amazonpay");

    public TResult Match<TResult>(Func<TResult> onAmazonpay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Amazonpay => onAmazonpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onAmazonpay, Action<string> otherwise)
    {
        if (this == Amazonpay) onAmazonpay();
        else otherwise(Value);
    }
}
