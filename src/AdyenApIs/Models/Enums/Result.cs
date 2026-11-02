using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Result>))]
public sealed record Result : OpenStringEnum<Result>
{
    private Result(string value) : base(value)
    {
    }

    public static readonly Result Valid = new("VALID");

    public static readonly Result Invalid = new("INVALID");

    public static readonly Result Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onValid,
        Func<TResult> onInvalid,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Valid => onValid(),
            _ when this == Invalid => onInvalid(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onValid, Action onInvalid, Action onUnknown, Action<string> otherwise)
    {
        if (this == Valid) onValid();
        else if (this == Invalid) onInvalid();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
