using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values:
/// * iOS
/// * Android
/// * Web
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChannelPaymentMethodsRequest>))]
public sealed record ChannelPaymentMethodsRequest : OpenStringEnum<ChannelPaymentMethodsRequest>
{
    private ChannelPaymentMethodsRequest(string value) : base(value)
    {
    }

    public static readonly ChannelPaymentMethodsRequest IOs = new("iOS");

    public static readonly ChannelPaymentMethodsRequest Android = new("Android");

    public static readonly ChannelPaymentMethodsRequest Web = new("Web");

    public TResult Match<TResult>(Func<TResult> onIOs,
        Func<TResult> onAndroid,
        Func<TResult> onWeb,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IOs => onIOs(),
            _ when this == Android => onAndroid(),
            _ when this == Web => onWeb(),
            _ => otherwise(Value)
        };

    public void Match(Action onIOs, Action onAndroid, Action onWeb, Action<string> otherwise)
    {
        if (this == IOs) onIOs();
        else if (this == Android) onAndroid();
        else if (this == Web) onWeb();
        else otherwise(Value);
    }
}
