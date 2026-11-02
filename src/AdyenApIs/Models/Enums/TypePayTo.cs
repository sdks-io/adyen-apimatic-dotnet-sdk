using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>payto</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypePayTo>))]
public sealed record TypePayTo : OpenStringEnum<TypePayTo>
{
    private TypePayTo(string value) : base(value)
    {
    }

    public static readonly TypePayTo Payto = new("payto");

    public TResult Match<TResult>(Func<TResult> onPayto, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Payto => onPayto(),
            _ => otherwise(Value)
        };

    public void Match(Action onPayto, Action<string> otherwise)
    {
        if (this == Payto) onPayto();
        else otherwise(Value);
    }
}
