using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Specifies how and from which balance account(s) to deduct the refund amount.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Refund>))]
public sealed record Refund : OpenStringEnum<Refund>
{
    private Refund(string value) : base(value)
    {
    }

    public static readonly Refund DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly Refund DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static readonly Refund DeductAccordingToSplitRatio = new("deductAccordingToSplitRatio");

    public TResult Match<TResult>(Func<TResult> onDeductFromLiableAccount,
        Func<TResult> onDeductFromOneBalanceAccount,
        Func<TResult> onDeductAccordingToSplitRatio,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DeductFromLiableAccount => onDeductFromLiableAccount(),
            _ when this == DeductFromOneBalanceAccount => onDeductFromOneBalanceAccount(),
            _ when this == DeductAccordingToSplitRatio => onDeductAccordingToSplitRatio(),
            _ => otherwise(Value)
        };

    public void Match(Action onDeductFromLiableAccount,
        Action onDeductFromOneBalanceAccount,
        Action onDeductAccordingToSplitRatio,
        Action<string> otherwise)
    {
        if (this == DeductFromLiableAccount) onDeductFromLiableAccount();
        else if (this == DeductFromOneBalanceAccount) onDeductFromOneBalanceAccount();
        else if (this == DeductAccordingToSplitRatio) onDeductAccordingToSplitRatio();
        else otherwise(Value);
    }
}
