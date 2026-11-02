using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>affirm</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeAffirm>))]
public sealed record TypeAffirm : OpenStringEnum<TypeAffirm>
{
    private TypeAffirm(string value) : base(value)
    {
    }

    public static readonly TypeAffirm Affirm = new("affirm");

    public TResult Match<TResult>(Func<TResult> onAffirm, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Affirm => onAffirm(),
            _ => otherwise(Value)
        };

    public void Match(Action onAffirm, Action<string> otherwise)
    {
        if (this == Affirm) onAffirm();
        else otherwise(Value);
    }
}
