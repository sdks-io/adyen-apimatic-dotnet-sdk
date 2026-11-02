using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>eft</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEftDirectDebit>))]
public sealed record TypeEftDirectDebit : OpenStringEnum<TypeEftDirectDebit>
{
    private TypeEftDirectDebit(string value) : base(value)
    {
    }

    public static readonly TypeEftDirectDebit EftDirectdebitCa = new("eft_directdebit_CA");

    public TResult Match<TResult>(Func<TResult> onEftDirectdebitCa, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == EftDirectdebitCa => onEftDirectdebitCa(),
            _ => otherwise(Value)
        };

    public void Match(Action onEftDirectdebitCa, Action<string> otherwise)
    {
        if (this == EftDirectdebitCa) onEftDirectdebitCa();
        else otherwise(Value);
    }
}
