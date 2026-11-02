using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Default payment method details. Common for scheme payment methods, and for simple payment method details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeCheckoutForwardRequestCard>))]
public sealed record TypeCheckoutForwardRequestCard : OpenStringEnum<TypeCheckoutForwardRequestCard>
{
    private TypeCheckoutForwardRequestCard(string value) : base(value)
    {
    }

    public static readonly TypeCheckoutForwardRequestCard Scheme = new("scheme");

    public TResult Match<TResult>(Func<TResult> onScheme, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Scheme => onScheme(),
            _ => otherwise(Value)
        };

    public void Match(Action onScheme, Action<string> otherwise)
    {
        if (this == Scheme) onScheme();
        else otherwise(Value);
    }
}
