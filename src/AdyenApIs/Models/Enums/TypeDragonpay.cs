using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>dragonpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeDragonpay>))]
public sealed record TypeDragonpay : OpenStringEnum<TypeDragonpay>
{
    private TypeDragonpay(string value) : base(value)
    {
    }

    public static readonly TypeDragonpay DragonpayEbanking = new("dragonpay_ebanking");

    public static readonly TypeDragonpay DragonpayOtcBanking = new("dragonpay_otc_banking");

    public static readonly TypeDragonpay DragonpayOtcNonBanking = new("dragonpay_otc_non_banking");

    public static readonly TypeDragonpay DragonpayOtcPhilippines = new("dragonpay_otc_philippines");

    public TResult Match<TResult>(Func<TResult> onDragonpayEbanking,
        Func<TResult> onDragonpayOtcBanking,
        Func<TResult> onDragonpayOtcNonBanking,
        Func<TResult> onDragonpayOtcPhilippines,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DragonpayEbanking => onDragonpayEbanking(),
            _ when this == DragonpayOtcBanking => onDragonpayOtcBanking(),
            _ when this == DragonpayOtcNonBanking => onDragonpayOtcNonBanking(),
            _ when this == DragonpayOtcPhilippines => onDragonpayOtcPhilippines(),
            _ => otherwise(Value)
        };

    public void Match(Action onDragonpayEbanking,
        Action onDragonpayOtcBanking,
        Action onDragonpayOtcNonBanking,
        Action onDragonpayOtcPhilippines,
        Action<string> otherwise)
    {
        if (this == DragonpayEbanking) onDragonpayEbanking();
        else if (this == DragonpayOtcBanking) onDragonpayOtcBanking();
        else if (this == DragonpayOtcNonBanking) onDragonpayOtcNonBanking();
        else if (this == DragonpayOtcPhilippines) onDragonpayOtcPhilippines();
        else otherwise(Value);
    }
}
