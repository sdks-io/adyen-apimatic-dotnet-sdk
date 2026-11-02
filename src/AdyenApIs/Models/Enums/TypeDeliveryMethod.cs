using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The type of the delivery method.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeDeliveryMethod>))]
public sealed record TypeDeliveryMethod : OpenStringEnum<TypeDeliveryMethod>
{
    private TypeDeliveryMethod(string value) : base(value)
    {
    }

    public static readonly TypeDeliveryMethod Shipping = new("Shipping");

    public TResult Match<TResult>(Func<TResult> onShipping, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Shipping => onShipping(),
            _ => otherwise(Value)
        };

    public void Match(Action onShipping, Action<string> otherwise)
    {
        if (this == Shipping) onShipping();
        else otherwise(Value);
    }
}
