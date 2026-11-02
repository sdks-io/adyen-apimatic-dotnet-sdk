using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>Cellulant</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeCellulant>))]
public sealed record TypeCellulant : OpenStringEnum<TypeCellulant>
{
    private TypeCellulant(string value) : base(value)
    {
    }

    public static readonly TypeCellulant Cellulant = new("cellulant");

    public TResult Match<TResult>(Func<TResult> onCellulant, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cellulant => onCellulant(),
            _ => otherwise(Value)
        };

    public void Match(Action onCellulant, Action<string> otherwise)
    {
        if (this == Cellulant) onCellulant();
        else otherwise(Value);
    }
}
