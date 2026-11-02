using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The type of the action.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeCheckoutSdkAction>))]
public sealed record TypeCheckoutSdkAction : OpenStringEnum<TypeCheckoutSdkAction>
{
    private TypeCheckoutSdkAction(string value) : base(value)
    {
    }

    public static readonly TypeCheckoutSdkAction Sdk = new("sdk");

    public static readonly TypeCheckoutSdkAction WechatpaySdk = new("wechatpaySDK");

    public TResult Match<TResult>(Func<TResult> onSdk, Func<TResult> onWechatpaySdk, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sdk => onSdk(),
            _ when this == WechatpaySdk => onWechatpaySdk(),
            _ => otherwise(Value)
        };

    public void Match(Action onSdk, Action onWechatpaySdk, Action<string> otherwise)
    {
        if (this == Sdk) onSdk();
        else if (this == WechatpaySdk) onWechatpaySdk();
        else otherwise(Value);
    }
}
