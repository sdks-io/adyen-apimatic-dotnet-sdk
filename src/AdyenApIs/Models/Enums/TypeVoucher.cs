using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>econtextvoucher</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeVoucher>))]
public sealed record TypeVoucher : OpenStringEnum<TypeVoucher>
{
    private TypeVoucher(string value) : base(value)
    {
    }

    public static readonly TypeVoucher EcontextSevenEleven = new("econtext_seven_eleven");

    public static readonly TypeVoucher EcontextOnline = new("econtext_online");

    public static readonly TypeVoucher Econtext = new("econtext");

    public static readonly TypeVoucher EcontextStores = new("econtext_stores");

    public static readonly TypeVoucher EcontextAtm = new("econtext_atm");

    public TResult Match<TResult>(Func<TResult> onEcontextSevenEleven,
        Func<TResult> onEcontextOnline,
        Func<TResult> onEcontext,
        Func<TResult> onEcontextStores,
        Func<TResult> onEcontextAtm,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == EcontextSevenEleven => onEcontextSevenEleven(),
            _ when this == EcontextOnline => onEcontextOnline(),
            _ when this == Econtext => onEcontext(),
            _ when this == EcontextStores => onEcontextStores(),
            _ when this == EcontextAtm => onEcontextAtm(),
            _ => otherwise(Value)
        };

    public void Match(Action onEcontextSevenEleven,
        Action onEcontextOnline,
        Action onEcontext,
        Action onEcontextStores,
        Action onEcontextAtm,
        Action<string> otherwise)
    {
        if (this == EcontextSevenEleven) onEcontextSevenEleven();
        else if (this == EcontextOnline) onEcontextOnline();
        else if (this == Econtext) onEcontext();
        else if (this == EcontextStores) onEcontextStores();
        else if (this == EcontextAtm) onEcontextAtm();
        else otherwise(Value);
    }
}
