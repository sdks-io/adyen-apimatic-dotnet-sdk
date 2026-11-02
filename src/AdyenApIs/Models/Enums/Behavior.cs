using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The method of handling the chargeback.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Behavior>))]
public sealed record Behavior : OpenStringEnum<Behavior>
{
    private Behavior(string value) : base(value)
    {
    }

    public static readonly Behavior DeductAccordingToSplitRatio = new("deductAccordingToSplitRatio");

    public static readonly Behavior DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly Behavior DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public TResult Match<TResult>(Func<TResult> onDeductAccordingToSplitRatio,
        Func<TResult> onDeductFromLiableAccount,
        Func<TResult> onDeductFromOneBalanceAccount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DeductAccordingToSplitRatio => onDeductAccordingToSplitRatio(),
            _ when this == DeductFromLiableAccount => onDeductFromLiableAccount(),
            _ when this == DeductFromOneBalanceAccount => onDeductFromOneBalanceAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onDeductAccordingToSplitRatio,
        Action onDeductFromLiableAccount,
        Action onDeductFromOneBalanceAccount,
        Action<string> otherwise)
    {
        if (this == DeductAccordingToSplitRatio) onDeductAccordingToSplitRatio();
        else if (this == DeductFromLiableAccount) onDeductFromLiableAccount();
        else if (this == DeductFromOneBalanceAccount) onDeductFromOneBalanceAccount();
        else otherwise(Value);
    }
}
