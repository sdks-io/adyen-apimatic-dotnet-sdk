using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Default payment method details. Common for scheme payment methods, and for simple payment method details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeCard>))]
public sealed record TypeCard : OpenStringEnum<TypeCard>
{
    private TypeCard(string value) : base(value)
    {
    }

    public static readonly TypeCard Bcmc = new("bcmc");

    public static readonly TypeCard Scheme = new("scheme");

    public static readonly TypeCard NetworkToken = new("networkToken");

    public static readonly TypeCard Giftcard = new("giftcard");

    public static readonly TypeCard Card = new("card");

    public static readonly TypeCard Clicktopay = new("clicktopay");

    public TResult Match<TResult>(Func<TResult> onBcmc,
        Func<TResult> onScheme,
        Func<TResult> onNetworkToken,
        Func<TResult> onGiftcard,
        Func<TResult> onCard,
        Func<TResult> onClicktopay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bcmc => onBcmc(),
            _ when this == Scheme => onScheme(),
            _ when this == NetworkToken => onNetworkToken(),
            _ when this == Giftcard => onGiftcard(),
            _ when this == Card => onCard(),
            _ when this == Clicktopay => onClicktopay(),
            _ => otherwise(Value)
        };

    public void Match(Action onBcmc,
        Action onScheme,
        Action onNetworkToken,
        Action onGiftcard,
        Action onCard,
        Action onClicktopay,
        Action<string> otherwise)
    {
        if (this == Bcmc) onBcmc();
        else if (this == Scheme) onScheme();
        else if (this == NetworkToken) onNetworkToken();
        else if (this == Giftcard) onGiftcard();
        else if (this == Card) onCard();
        else if (this == Clicktopay) onClicktopay();
        else otherwise(Value);
    }
}
