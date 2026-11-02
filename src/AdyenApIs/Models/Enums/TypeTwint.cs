using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeTwint>))]
public sealed record TypeTwint : OpenStringEnum<TypeTwint>
{
    private TypeTwint(string value) : base(value)
    {
    }

    public static readonly TypeTwint Twint = new("twint");

    public TResult Match<TResult>(Func<TResult> onTwint, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Twint => onTwint(),
            _ => otherwise(Value)
        };

    public void Match(Action onTwint, Action<string> otherwise)
    {
        if (this == Twint) onTwint();
        else otherwise(Value);
    }
}
