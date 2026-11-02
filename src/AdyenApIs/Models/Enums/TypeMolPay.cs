using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>molpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeMolPay>))]
public sealed record TypeMolPay : OpenStringEnum<TypeMolPay>
{
    private TypeMolPay(string value) : base(value)
    {
    }

    public static readonly TypeMolPay MolpayEbankingFpxMy = new("molpay_ebanking_fpx_MY");

    public static readonly TypeMolPay MolpayEbankingTh = new("molpay_ebanking_TH");

    public TResult Match<TResult>(Func<TResult> onMolpayEbankingFpxMy,
        Func<TResult> onMolpayEbankingTh,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MolpayEbankingFpxMy => onMolpayEbankingFpxMy(),
            _ when this == MolpayEbankingTh => onMolpayEbankingTh(),
            _ => otherwise(Value)
        };

    public void Match(Action onMolpayEbankingFpxMy, Action onMolpayEbankingTh, Action<string> otherwise)
    {
        if (this == MolpayEbankingFpxMy) onMolpayEbankingFpxMy();
        else if (this == MolpayEbankingTh) onMolpayEbankingTh();
        else otherwise(Value);
    }
}
