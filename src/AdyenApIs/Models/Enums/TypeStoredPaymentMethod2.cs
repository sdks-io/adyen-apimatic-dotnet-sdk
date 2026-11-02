using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeStoredPaymentMethod2>))]
public sealed record TypeStoredPaymentMethod2 : OpenStringEnum<TypeStoredPaymentMethod2>
{
    private TypeStoredPaymentMethod2(string value) : base(value)
    {
    }

    public static readonly TypeStoredPaymentMethod2 Pix = new("pix");

    public TResult Match<TResult>(Func<TResult> onPix, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pix => onPix(),
            _ => otherwise(Value)
        };

    public void Match(Action onPix, Action<string> otherwise)
    {
        if (this == Pix) onPix();
        else otherwise(Value);
    }
}
