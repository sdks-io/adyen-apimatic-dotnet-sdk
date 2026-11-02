using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>wechatpayMiniProgram</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeWeChatPayMiniProgram>))]
public sealed record TypeWeChatPayMiniProgram : OpenStringEnum<TypeWeChatPayMiniProgram>
{
    private TypeWeChatPayMiniProgram(string value) : base(value)
    {
    }

    public static readonly TypeWeChatPayMiniProgram WechatpayMiniProgram = new("wechatpayMiniProgram");

    public TResult Match<TResult>(Func<TResult> onWechatpayMiniProgram, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == WechatpayMiniProgram => onWechatpayMiniProgram(),
            _ => otherwise(Value)
        };

    public void Match(Action onWechatpayMiniProgram, Action<string> otherwise)
    {
        if (this == WechatpayMiniProgram) onWechatpayMiniProgram();
        else otherwise(Value);
    }
}
