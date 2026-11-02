using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypePseLatam>))]
public sealed record TypePseLatam : OpenStringEnum<TypePseLatam>
{
    private TypePseLatam(string value) : base(value)
    {
    }

    public static readonly TypePseLatam PsePayulatam = new("pse_payulatam");

    public TResult Match<TResult>(Func<TResult> onPsePayulatam, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PsePayulatam => onPsePayulatam(),
            _ => otherwise(Value)
        };

    public void Match(Action onPsePayulatam, Action<string> otherwise)
    {
        if (this == PsePayulatam) onPsePayulatam();
        else otherwise(Value);
    }
}
