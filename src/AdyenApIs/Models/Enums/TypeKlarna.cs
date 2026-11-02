using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>klarna</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeKlarna>))]
public sealed record TypeKlarna : OpenStringEnum<TypeKlarna>
{
    private TypeKlarna(string value) : base(value)
    {
    }

    public static readonly TypeKlarna Klarna = new("klarna");

    public static readonly TypeKlarna Klarnapayments = new("klarnapayments");

    public static readonly TypeKlarna KlarnapaymentsAccount = new("klarnapayments_account");

    public static readonly TypeKlarna KlarnapaymentsB2B = new("klarnapayments_b2b");

    public static readonly TypeKlarna KlarnaPaynow = new("klarna_paynow");

    public static readonly TypeKlarna KlarnaAccount = new("klarna_account");

    public static readonly TypeKlarna KlarnaB2B = new("klarna_b2b");

    public TResult Match<TResult>(Func<TResult> onKlarna,
        Func<TResult> onKlarnapayments,
        Func<TResult> onKlarnapaymentsAccount,
        Func<TResult> onKlarnapaymentsB2B,
        Func<TResult> onKlarnaPaynow,
        Func<TResult> onKlarnaAccount,
        Func<TResult> onKlarnaB2B,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Klarna => onKlarna(),
            _ when this == Klarnapayments => onKlarnapayments(),
            _ when this == KlarnapaymentsAccount => onKlarnapaymentsAccount(),
            _ when this == KlarnapaymentsB2B => onKlarnapaymentsB2B(),
            _ when this == KlarnaPaynow => onKlarnaPaynow(),
            _ when this == KlarnaAccount => onKlarnaAccount(),
            _ when this == KlarnaB2B => onKlarnaB2B(),
            _ => otherwise(Value)
        };

    public void Match(Action onKlarna,
        Action onKlarnapayments,
        Action onKlarnapaymentsAccount,
        Action onKlarnapaymentsB2B,
        Action onKlarnaPaynow,
        Action onKlarnaAccount,
        Action onKlarnaB2B,
        Action<string> otherwise)
    {
        if (this == Klarna) onKlarna();
        else if (this == Klarnapayments) onKlarnapayments();
        else if (this == KlarnapaymentsAccount) onKlarnapaymentsAccount();
        else if (this == KlarnapaymentsB2B) onKlarnapaymentsB2B();
        else if (this == KlarnaPaynow) onKlarnaPaynow();
        else if (this == KlarnaAccount) onKlarnaAccount();
        else if (this == KlarnaB2B) onKlarnaB2B();
        else otherwise(Value);
    }
}
