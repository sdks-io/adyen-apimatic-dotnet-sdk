using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Indicates whether the cardholder shipping Address and cardholder billing address are the same. Allowed values:
/// * <b>Y</b> — Shipping Address matches Billing Address.
/// * <b>N</b> — Shipping Address does not match Billing Address.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AddrMatchThreeDs2RequestFields>))]
public sealed record AddrMatchThreeDs2RequestFields : OpenStringEnum<AddrMatchThreeDs2RequestFields>
{
    private AddrMatchThreeDs2RequestFields(string value) : base(value)
    {
    }

    public static readonly AddrMatchThreeDs2RequestFields Y = new("Y");

    public static readonly AddrMatchThreeDs2RequestFields N = new("N");

    public TResult Match<TResult>(Func<TResult> onY, Func<TResult> onN, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Y => onY(),
            _ when this == N => onN(),
            _ => otherwise(Value)
        };

    public void Match(Action onY, Action onN, Action<string> otherwise)
    {
        if (this == Y) onY();
        else if (this == N) onN();
        else otherwise(Value);
    }
}
