using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>directdebit_GB</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeBacsDirectDebit>))]
public sealed record TypeBacsDirectDebit : OpenStringEnum<TypeBacsDirectDebit>
{
    private TypeBacsDirectDebit(string value) : base(value)
    {
    }

    public static readonly TypeBacsDirectDebit DirectdebitGb = new("directdebit_GB");

    public TResult Match<TResult>(Func<TResult> onDirectdebitGb, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DirectdebitGb => onDirectdebitGb(),
            _ => otherwise(Value)
        };

    public void Match(Action onDirectdebitGb, Action<string> otherwise)
    {
        if (this == DirectdebitGb) onDirectdebitGb();
        else otherwise(Value);
    }
}
