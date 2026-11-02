using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Specifies the service level (settlement type) of this payment method. Required for merchants operating in Japan. Possible values:
///  * <b>noContract</b>: Adyen holds the contract with JCB.
///  * <b>gatewayContract</b>: JCB receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceLevelDinersInfo>))]
public sealed record ServiceLevelDinersInfo : OpenStringEnum<ServiceLevelDinersInfo>
{
    private ServiceLevelDinersInfo(string value) : base(value)
    {
    }

    public static readonly ServiceLevelDinersInfo NoContract = new("noContract");

    public static readonly ServiceLevelDinersInfo GatewayContract = new("gatewayContract");

    public TResult Match<TResult>(Func<TResult> onNoContract,
        Func<TResult> onGatewayContract,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoContract => onNoContract(),
            _ when this == GatewayContract => onGatewayContract(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoContract, Action onGatewayContract, Action<string> otherwise)
    {
        if (this == NoContract) onNoContract();
        else if (this == GatewayContract) onGatewayContract();
        else otherwise(Value);
    }
}
