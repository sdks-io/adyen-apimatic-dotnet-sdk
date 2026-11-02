using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>applepay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeApplePay>))]
public sealed record TypeApplePay : OpenStringEnum<TypeApplePay>
{
    private TypeApplePay(string value) : base(value)
    {
    }

    public static readonly TypeApplePay Applepay = new("applepay");

    public TResult Match<TResult>(Func<TResult> onApplepay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Applepay => onApplepay(),
            _ => otherwise(Value)
        };

    public void Match(Action onApplepay, Action<string> otherwise)
    {
        if (this == Applepay) onApplepay();
        else otherwise(Value);
    }
}
