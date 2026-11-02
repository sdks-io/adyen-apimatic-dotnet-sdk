using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Type of terminal action: Update Release.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeReleaseUpdateDetails>))]
public sealed record TypeReleaseUpdateDetails : OpenStringEnum<TypeReleaseUpdateDetails>
{
    private TypeReleaseUpdateDetails(string value) : base(value)
    {
    }

    public static readonly TypeReleaseUpdateDetails ReleaseUpdate = new("ReleaseUpdate");

    public TResult Match<TResult>(Func<TResult> onReleaseUpdate, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ReleaseUpdate => onReleaseUpdate(),
            _ => otherwise(Value)
        };

    public void Match(Action onReleaseUpdate, Action<string> otherwise)
    {
        if (this == ReleaseUpdate) onReleaseUpdate();
        else otherwise(Value);
    }
}
