using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>ancv</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeAncv>))]
public sealed record TypeAncv : OpenStringEnum<TypeAncv>
{
    private TypeAncv(string value) : base(value)
    {
    }

    public static readonly TypeAncv Ancv = new("ancv");

    public TResult Match<TResult>(Func<TResult> onAncv, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ancv => onAncv(),
            _ => otherwise(Value)
        };

    public void Match(Action onAncv, Action<string> otherwise)
    {
        if (this == Ancv) onAncv();
        else otherwise(Value);
    }
}
