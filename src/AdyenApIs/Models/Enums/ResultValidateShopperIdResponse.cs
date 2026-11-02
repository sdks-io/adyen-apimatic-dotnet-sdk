using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Result of the validation. Ex: valid, invalid, unknown
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResultValidateShopperIdResponse>))]
public sealed record ResultValidateShopperIdResponse : OpenStringEnum<ResultValidateShopperIdResponse>
{
    private ResultValidateShopperIdResponse(string value) : base(value)
    {
    }

    public static readonly ResultValidateShopperIdResponse Valid = new("VALID");

    public static readonly ResultValidateShopperIdResponse Invalid = new("INVALID");

    public static readonly ResultValidateShopperIdResponse Unknown = new("UNKNOWN");

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
