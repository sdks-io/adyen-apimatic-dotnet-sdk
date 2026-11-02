using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Books the surcharge amount to the specified balance account.
/// <para>
/// Possible values: <b>addToLiableAccount</b>, <b>addToOneBalanceAccount</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SurchargeSplitConfigurationLogic>))]
public sealed record SurchargeSplitConfigurationLogic : OpenStringEnum<SurchargeSplitConfigurationLogic>
{
    private SurchargeSplitConfigurationLogic(string value) : base(value)
    {
    }

    public static readonly SurchargeSplitConfigurationLogic AddToLiableAccount = new("addToLiableAccount");

    public static readonly SurchargeSplitConfigurationLogic AddToOneBalanceAccount = new("addToOneBalanceAccount");

    public TResult Match<TResult>(Func<TResult> onAddToLiableAccount,
        Func<TResult> onAddToOneBalanceAccount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AddToLiableAccount => onAddToLiableAccount(),
            _ when this == AddToOneBalanceAccount => onAddToOneBalanceAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onAddToLiableAccount, Action onAddToOneBalanceAccount, Action<string> otherwise)
    {
        if (this == AddToLiableAccount) onAddToLiableAccount();
        else if (this == AddToOneBalanceAccount) onAddToOneBalanceAccount();
        else otherwise(Value);
    }
}
