using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>ideal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeIDeal>))]
public sealed record TypeIDeal : OpenStringEnum<TypeIDeal>
{
    private TypeIDeal(string value) : base(value)
    {
    }

    public static readonly TypeIDeal Ideal = new("ideal");

    public TResult Match<TResult>(Func<TResult> onIdeal, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ideal => onIdeal(),
            _ => otherwise(Value)
        };

    public void Match(Action onIdeal, Action<string> otherwise)
    {
        if (this == Ideal) onIdeal();
        else otherwise(Value);
    }
}
