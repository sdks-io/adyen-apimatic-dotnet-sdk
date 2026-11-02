using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>wechatpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeWeChatPay>))]
public sealed record TypeWeChatPay : OpenStringEnum<TypeWeChatPay>
{
    private TypeWeChatPay(string value) : base(value)
    {
    }

    public static readonly TypeWeChatPay Wechatpay = new("wechatpay");

    public static readonly TypeWeChatPay WechatpayPos = new("wechatpay_pos");

    public TResult Match<TResult>(Func<TResult> onWechatpay,
        Func<TResult> onWechatpayPos,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Wechatpay => onWechatpay(),
            _ when this == WechatpayPos => onWechatpayPos(),
            _ => otherwise(Value)
        };

    public void Match(Action onWechatpay, Action onWechatpayPos, Action<string> otherwise)
    {
        if (this == Wechatpay) onWechatpay();
        else if (this == WechatpayPos) onWechatpayPos();
        else otherwise(Value);
    }
}
