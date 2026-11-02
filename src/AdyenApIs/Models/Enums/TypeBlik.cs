using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>blik</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeBlik>))]
public sealed record TypeBlik : OpenStringEnum<TypeBlik>
{
    private TypeBlik(string value) : base(value)
    {
    }

    public static readonly TypeBlik Blik = new("blik");

    public TResult Match<TResult>(Func<TResult> onBlik, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Blik => onBlik(),
            _ => otherwise(Value)
        };

    public void Match(Action onBlik, Action<string> otherwise)
    {
        if (this == Blik) onBlik();
        else otherwise(Value);
    }
}
