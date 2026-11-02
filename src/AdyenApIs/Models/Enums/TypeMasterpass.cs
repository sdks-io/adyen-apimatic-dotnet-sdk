using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>masterpass</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeMasterpass>))]
public sealed record TypeMasterpass : OpenStringEnum<TypeMasterpass>
{
    private TypeMasterpass(string value) : base(value)
    {
    }

    public static readonly TypeMasterpass Masterpass = new("masterpass");

    public TResult Match<TResult>(Func<TResult> onMasterpass, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Masterpass => onMasterpass(),
            _ => otherwise(Value)
        };

    public void Match(Action onMasterpass, Action<string> otherwise)
    {
        if (this == Masterpass) onMasterpass();
        else otherwise(Value);
    }
}
