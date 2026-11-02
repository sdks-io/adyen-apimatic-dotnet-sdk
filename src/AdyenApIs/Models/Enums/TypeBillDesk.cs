using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>billdesk</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeBillDesk>))]
public sealed record TypeBillDesk : OpenStringEnum<TypeBillDesk>
{
    private TypeBillDesk(string value) : base(value)
    {
    }

    public static readonly TypeBillDesk BilldeskOnline = new("billdesk_online");

    public static readonly TypeBillDesk BilldeskWallet = new("billdesk_wallet");

    public TResult Match<TResult>(Func<TResult> onBilldeskOnline,
        Func<TResult> onBilldeskWallet,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BilldeskOnline => onBilldeskOnline(),
            _ when this == BilldeskWallet => onBilldeskWallet(),
            _ => otherwise(Value)
        };

    public void Match(Action onBilldeskOnline, Action onBilldeskWallet, Action<string> otherwise)
    {
        if (this == BilldeskOnline) onBilldeskOnline();
        else if (this == BilldeskWallet) onBilldeskWallet();
        else otherwise(Value);
    }
}
