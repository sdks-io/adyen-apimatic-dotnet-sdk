using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// cashapp
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeStoredPaymentMethod>))]
public sealed record TypeStoredPaymentMethod : OpenStringEnum<TypeStoredPaymentMethod>
{
    private TypeStoredPaymentMethod(string value) : base(value)
    {
    }

    public static readonly TypeStoredPaymentMethod Cashapp = new("cashapp");

    public TResult Match<TResult>(Func<TResult> onCashapp, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cashapp => onCashapp(),
            _ => otherwise(Value)
        };

    public void Match(Action onCashapp, Action<string> otherwise)
    {
        if (this == Cashapp) onCashapp();
        else otherwise(Value);
    }
}
