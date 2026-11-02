using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>genericissuer</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeStoredPaymentMethod1>))]
public sealed record TypeStoredPaymentMethod1 : OpenStringEnum<TypeStoredPaymentMethod1>
{
    private TypeStoredPaymentMethod1(string value) : base(value)
    {
    }

    public static readonly TypeStoredPaymentMethod1 OnlineBankingPl = new("onlineBanking_PL");

    public static readonly TypeStoredPaymentMethod1 Eps = new("eps");

    public static readonly TypeStoredPaymentMethod1 OnlineBankingSk = new("onlineBanking_SK");

    public static readonly TypeStoredPaymentMethod1 OnlineBankingCz = new("onlineBanking_CZ");

    public static readonly TypeStoredPaymentMethod1 OnlinebankingIn = new("onlinebanking_IN");

    public TResult Match<TResult>(Func<TResult> onOnlineBankingPl,
        Func<TResult> onEps,
        Func<TResult> onOnlineBankingSk,
        Func<TResult> onOnlineBankingCz,
        Func<TResult> onOnlinebankingIn,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OnlineBankingPl => onOnlineBankingPl(),
            _ when this == Eps => onEps(),
            _ when this == OnlineBankingSk => onOnlineBankingSk(),
            _ when this == OnlineBankingCz => onOnlineBankingCz(),
            _ when this == OnlinebankingIn => onOnlinebankingIn(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnlineBankingPl,
        Action onEps,
        Action onOnlineBankingSk,
        Action onOnlineBankingCz,
        Action onOnlinebankingIn,
        Action<string> otherwise)
    {
        if (this == OnlineBankingPl) onOnlineBankingPl();
        else if (this == Eps) onEps();
        else if (this == OnlineBankingSk) onOnlineBankingSk();
        else if (this == OnlineBankingCz) onOnlineBankingCz();
        else if (this == OnlinebankingIn) onOnlinebankingIn();
        else otherwise(Value);
    }
}
