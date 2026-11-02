using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The card region condition that determines whether the <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">split logic</see>/splitConfigurations#request-rules-splitLogic) applies to the transaction.
/// <para>
/// &gt; This condition is in pilot phase, and not yet available for all platforms.
/// </para>
/// <para>
/// Possible values:
/// * <b>domestic</b>: The card issuer and the store where the transaction is processed are registered in the same country.
/// * <b>international</b>: The card issuer and the store where the transaction is processed are registered in different countries or regions. Includes all <b>interRegional</b> and <b>intraRegional</b> transactions.
/// * <b>interRegional</b>: The card issuer and the store where the transaction is processed are registered in different regions.
/// * <b>intraRegional</b>: The card issuer and the store where the transaction is processed are registered in different countries, but in the same region.
/// * <b>ANY</b>: Applies to all transactions, regardless of the processing and issuing country/region.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardRegion>))]
public sealed record CardRegion : OpenStringEnum<CardRegion>
{
    private CardRegion(string value) : base(value)
    {
    }

    public static readonly CardRegion International = new("international");

    public static readonly CardRegion IntraRegional = new("intraRegional");

    public static readonly CardRegion InterRegional = new("interRegional");

    public static readonly CardRegion Domestic = new("domestic");

    public static readonly CardRegion Any = new("ANY");

    public TResult Match<TResult>(Func<TResult> onInternational,
        Func<TResult> onIntraRegional,
        Func<TResult> onInterRegional,
        Func<TResult> onDomestic,
        Func<TResult> onAny,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == International => onInternational(),
            _ when this == IntraRegional => onIntraRegional(),
            _ when this == InterRegional => onInterRegional(),
            _ when this == Domestic => onDomestic(),
            _ when this == Any => onAny(),
            _ => otherwise(Value)
        };

    public void Match(Action onInternational,
        Action onIntraRegional,
        Action onInterRegional,
        Action onDomestic,
        Action onAny,
        Action<string> otherwise)
    {
        if (this == International) onInternational();
        else if (this == IntraRegional) onIntraRegional();
        else if (this == InterRegional) onInterRegional();
        else if (this == Domestic) onDomestic();
        else if (this == Any) onAny();
        else otherwise(Value);
    }
}
