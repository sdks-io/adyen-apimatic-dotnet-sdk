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
[JsonConverter(typeof(StringEnumConverter<SurchargeUpdateSplitConfigurationLogicRequest>))]
public sealed record SurchargeUpdateSplitConfigurationLogicRequest : OpenStringEnum<SurchargeUpdateSplitConfigurationLogicRequest>
{
    private SurchargeUpdateSplitConfigurationLogicRequest(string value) : base(value)
    {
    }

    public static readonly SurchargeUpdateSplitConfigurationLogicRequest AddToLiableAccount = new("addToLiableAccount");

    public static readonly SurchargeUpdateSplitConfigurationLogicRequest AddToOneBalanceAccount = new(
        "addToOneBalanceAccount");

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
