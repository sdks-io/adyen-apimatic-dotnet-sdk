using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The reason for the amount update. Possible values:
/// * <b>delayedCharge</b>
/// * <b>noShow</b>
/// * <b>installment</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IndustryUsagePaymentAmountUpdateRequest>))]
public sealed record IndustryUsagePaymentAmountUpdateRequest : OpenStringEnum<IndustryUsagePaymentAmountUpdateRequest>
{
    private IndustryUsagePaymentAmountUpdateRequest(string value) : base(value)
    {
    }

    public static readonly IndustryUsagePaymentAmountUpdateRequest DelayedCharge = new("delayedCharge");

    public static readonly IndustryUsagePaymentAmountUpdateRequest Installment = new("installment");

    public static readonly IndustryUsagePaymentAmountUpdateRequest NoShow = new("noShow");

    public TResult Match<TResult>(Func<TResult> onDelayedCharge,
        Func<TResult> onInstallment,
        Func<TResult> onNoShow,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DelayedCharge => onDelayedCharge(),
            _ when this == Installment => onInstallment(),
            _ when this == NoShow => onNoShow(),
            _ => otherwise(Value)
        };

    public void Match(Action onDelayedCharge, Action onInstallment, Action onNoShow, Action<string> otherwise)
    {
        if (this == DelayedCharge) onDelayedCharge();
        else if (this == Installment) onInstallment();
        else if (this == NoShow) onNoShow();
        else otherwise(Value);
    }
}
