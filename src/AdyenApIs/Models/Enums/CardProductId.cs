using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The Card Product ID represents the type of card following card scheme product definitions and can be returned for Adyen Acquiring service level payments.
/// <para>
/// Possible values Visa:
/// * <b>A</b> - Visa Traditional
/// * <b>B</b> - Visa Traditional Rewards
/// * <b>C</b> - Visa Signature
/// * <b>D</b> - Visa Signature Preferred
/// * <b>F</b> - Visa Classic
/// </para>
/// <para>
/// Possible values Mastercard:
/// * <b>MCC</b> - Mastercard Card
/// * <b>MCE</b> - Mastercard Electronic Card
/// * <b>MCF</b> - Mastercard Corporate Fleet Card
/// * <b>MCG</b> - Gold Mastercard Card
/// * <b>MCH</b> - Mastercard Premium Charge
/// * <b>MCI</b> - Mastercard Select Debit
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardProductId>))]
public sealed record CardProductId : OpenStringEnum<CardProductId>
{
    private CardProductId(string value) : base(value)
    {
    }

    public static readonly CardProductId A = new("A");

    public static readonly CardProductId B = new("B");

    public static readonly CardProductId C = new("C");

    public static readonly CardProductId D = new("D");

    public static readonly CardProductId F = new("F");

    public static readonly CardProductId Mcc = new("MCC");

    public static readonly CardProductId Mce = new("MCE");

    public static readonly CardProductId Mcf = new("MCF");

    public static readonly CardProductId Mcg = new("MCG");

    public static readonly CardProductId Mch = new("MCH");

    public static readonly CardProductId Mci = new("MCI");

    public TResult Match<TResult>(Func<TResult> onA,
        Func<TResult> onB,
        Func<TResult> onC,
        Func<TResult> onD,
        Func<TResult> onF,
        Func<TResult> onMcc,
        Func<TResult> onMce,
        Func<TResult> onMcf,
        Func<TResult> onMcg,
        Func<TResult> onMch,
        Func<TResult> onMci,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == A => onA(),
            _ when this == B => onB(),
            _ when this == C => onC(),
            _ when this == D => onD(),
            _ when this == F => onF(),
            _ when this == Mcc => onMcc(),
            _ when this == Mce => onMce(),
            _ when this == Mcf => onMcf(),
            _ when this == Mcg => onMcg(),
            _ when this == Mch => onMch(),
            _ when this == Mci => onMci(),
            _ => otherwise(Value)
        };

    public void Match(Action onA,
        Action onB,
        Action onC,
        Action onD,
        Action onF,
        Action onMcc,
        Action onMce,
        Action onMcf,
        Action onMcg,
        Action onMch,
        Action onMci,
        Action<string> otherwise)
    {
        if (this == A) onA();
        else if (this == B) onB();
        else if (this == C) onC();
        else if (this == D) onD();
        else if (this == F) onF();
        else if (this == Mcc) onMcc();
        else if (this == Mce) onMce();
        else if (this == Mcf) onMcf();
        else if (this == Mcg) onMcg();
        else if (this == Mch) onMch();
        else if (this == Mci) onMci();
        else otherwise(Value);
    }
}
