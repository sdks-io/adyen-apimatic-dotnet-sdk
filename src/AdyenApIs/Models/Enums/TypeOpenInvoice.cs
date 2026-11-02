using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>openinvoice</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeOpenInvoice>))]
public sealed record TypeOpenInvoice : OpenStringEnum<TypeOpenInvoice>
{
    private TypeOpenInvoice(string value) : base(value)
    {
    }

    public static readonly TypeOpenInvoice Openinvoice = new("openinvoice");

    public static readonly TypeOpenInvoice AfterpayDirectdebit = new("afterpay_directdebit");

    public static readonly TypeOpenInvoice AtomePos = new("atome_pos");

    public TResult Match<TResult>(Func<TResult> onOpeninvoice,
        Func<TResult> onAfterpayDirectdebit,
        Func<TResult> onAtomePos,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Openinvoice => onOpeninvoice(),
            _ when this == AfterpayDirectdebit => onAfterpayDirectdebit(),
            _ when this == AtomePos => onAtomePos(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpeninvoice, Action onAfterpayDirectdebit, Action onAtomePos, Action<string> otherwise)
    {
        if (this == Openinvoice) onOpeninvoice();
        else if (this == AfterpayDirectdebit) onAfterpayDirectdebit();
        else if (this == AtomePos) onAtomePos();
        else otherwise(Value);
    }
}
