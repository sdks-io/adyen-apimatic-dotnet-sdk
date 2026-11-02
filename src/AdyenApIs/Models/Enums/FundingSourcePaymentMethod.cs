using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The funding source of the payment method.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundingSourcePaymentMethod>))]
public sealed record FundingSourcePaymentMethod : OpenStringEnum<FundingSourcePaymentMethod>
{
    private FundingSourcePaymentMethod(string value) : base(value)
    {
    }

    public static readonly FundingSourcePaymentMethod Credit = new("credit");

    public static readonly FundingSourcePaymentMethod Debit = new("debit");

    public static readonly FundingSourcePaymentMethod Prepaid = new("prepaid");

    public TResult Match<TResult>(Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<TResult> onPrepaid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ when this == Prepaid => onPrepaid(),
            _ => otherwise(Value)
        };

    public void Match(Action onCredit, Action onDebit, Action onPrepaid, Action<string> otherwise)
    {
        if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else if (this == Prepaid) onPrepaid();
        else otherwise(Value);
    }
}
