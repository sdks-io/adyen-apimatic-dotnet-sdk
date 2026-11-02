using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>visacheckout</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeVisaCheckout>))]
public sealed record TypeVisaCheckout : OpenStringEnum<TypeVisaCheckout>
{
    private TypeVisaCheckout(string value) : base(value)
    {
    }

    public static readonly TypeVisaCheckout Visacheckout = new("visacheckout");

    public TResult Match<TResult>(Func<TResult> onVisacheckout, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Visacheckout => onVisacheckout(),
            _ => otherwise(Value)
        };

    public void Match(Action onVisacheckout, Action<string> otherwise)
    {
        if (this == Visacheckout) onVisacheckout();
        else otherwise(Value);
    }
}
