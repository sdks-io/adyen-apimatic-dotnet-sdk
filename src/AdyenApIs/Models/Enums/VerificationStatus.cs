using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Payment method status. Possible values:
/// * <b>valid</b>
/// * <b>pending</b>
/// * <b>invalid</b>
/// * <b>rejected</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationStatus>))]
public sealed record VerificationStatus : OpenStringEnum<VerificationStatus>
{
    private VerificationStatus(string value) : base(value)
    {
    }

    public static readonly VerificationStatus Valid = new("valid");

    public static readonly VerificationStatus Pending = new("pending");

    public static readonly VerificationStatus Invalid = new("invalid");

    public static readonly VerificationStatus Rejected = new("rejected");

    public TResult Match<TResult>(Func<TResult> onValid,
        Func<TResult> onPending,
        Func<TResult> onInvalid,
        Func<TResult> onRejected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Valid => onValid(),
            _ when this == Pending => onPending(),
            _ when this == Invalid => onInvalid(),
            _ when this == Rejected => onRejected(),
            _ => otherwise(Value)
        };

    public void Match(Action onValid, Action onPending, Action onInvalid, Action onRejected, Action<string> otherwise)
    {
        if (this == Valid) onValid();
        else if (this == Pending) onPending();
        else if (this == Invalid) onInvalid();
        else if (this == Rejected) onRejected();
        else otherwise(Value);
    }
}
