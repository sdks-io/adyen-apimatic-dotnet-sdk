using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>sepadirectdebit</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeSepaDirectDebit>))]
public sealed record TypeSepaDirectDebit : OpenStringEnum<TypeSepaDirectDebit>
{
    private TypeSepaDirectDebit(string value) : base(value)
    {
    }

    public static readonly TypeSepaDirectDebit Sepadirectdebit = new("sepadirectdebit");

    public static readonly TypeSepaDirectDebit SepadirectdebitAmazonpay = new("sepadirectdebit_amazonpay");

    public TResult Match<TResult>(Func<TResult> onSepadirectdebit,
        Func<TResult> onSepadirectdebitAmazonpay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sepadirectdebit => onSepadirectdebit(),
            _ when this == SepadirectdebitAmazonpay => onSepadirectdebitAmazonpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onSepadirectdebit, Action onSepadirectdebitAmazonpay, Action<string> otherwise)
    {
        if (this == Sepadirectdebit) onSepadirectdebit();
        else if (this == SepadirectdebitAmazonpay) onSepadirectdebitAmazonpay();
        else otherwise(Value);
    }
}
