using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The funding source of the payment method.
/// <para>
/// Possible values:
/// * <b>credit</b>
/// * <b>debit</b>
/// * <b>prepaid</b>
/// * <b>deferred_debit</b>
/// * <b>charged</b>
/// * <b>ANY</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundingSourceManagementApi>))]
public sealed record FundingSourceManagementApi : OpenStringEnum<FundingSourceManagementApi>
{
    private FundingSourceManagementApi(string value) : base(value)
    {
    }

    public static readonly FundingSourceManagementApi Charged = new("charged");

    public static readonly FundingSourceManagementApi Credit = new("credit");

    public static readonly FundingSourceManagementApi Debit = new("debit");

    public static readonly FundingSourceManagementApi DeferredDebit = new("deferred_debit");

    public static readonly FundingSourceManagementApi Prepaid = new("prepaid");

    public static readonly FundingSourceManagementApi Any = new("ANY");

    public TResult Match<TResult>(Func<TResult> onCharged,
        Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<TResult> onDeferredDebit,
        Func<TResult> onPrepaid,
        Func<TResult> onAny,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Charged => onCharged(),
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ when this == DeferredDebit => onDeferredDebit(),
            _ when this == Prepaid => onPrepaid(),
            _ when this == Any => onAny(),
            _ => otherwise(Value)
        };

    public void Match(Action onCharged,
        Action onCredit,
        Action onDebit,
        Action onDeferredDebit,
        Action onPrepaid,
        Action onAny,
        Action<string> otherwise)
    {
        if (this == Charged) onCharged();
        else if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else if (this == DeferredDebit) onDeferredDebit();
        else if (this == Prepaid) onPrepaid();
        else if (this == Any) onAny();
        else otherwise(Value);
    }
}
