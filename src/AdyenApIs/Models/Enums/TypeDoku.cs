using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>doku</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeDoku>))]
public sealed record TypeDoku : OpenStringEnum<TypeDoku>
{
    private TypeDoku(string value) : base(value)
    {
    }

    public static readonly TypeDoku DokuMandiriVa = new("doku_mandiri_va");

    public static readonly TypeDoku DokuCimbVa = new("doku_cimb_va");

    public static readonly TypeDoku DokuDanamonVa = new("doku_danamon_va");

    public static readonly TypeDoku DokuBniVa = new("doku_bni_va");

    public static readonly TypeDoku DokuPermataLiteAtm = new("doku_permata_lite_atm");

    public static readonly TypeDoku DokuBriVa = new("doku_bri_va");

    public static readonly TypeDoku DokuBcaVa = new("doku_bca_va");

    public static readonly TypeDoku DokuAlfamart = new("doku_alfamart");

    public static readonly TypeDoku DokuIndomaret = new("doku_indomaret");

    public static readonly TypeDoku DokuWallet = new("doku_wallet");

    public static readonly TypeDoku DokuOvo = new("doku_ovo");

    public TResult Match<TResult>(Func<TResult> onDokuMandiriVa,
        Func<TResult> onDokuCimbVa,
        Func<TResult> onDokuDanamonVa,
        Func<TResult> onDokuBniVa,
        Func<TResult> onDokuPermataLiteAtm,
        Func<TResult> onDokuBriVa,
        Func<TResult> onDokuBcaVa,
        Func<TResult> onDokuAlfamart,
        Func<TResult> onDokuIndomaret,
        Func<TResult> onDokuWallet,
        Func<TResult> onDokuOvo,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DokuMandiriVa => onDokuMandiriVa(),
            _ when this == DokuCimbVa => onDokuCimbVa(),
            _ when this == DokuDanamonVa => onDokuDanamonVa(),
            _ when this == DokuBniVa => onDokuBniVa(),
            _ when this == DokuPermataLiteAtm => onDokuPermataLiteAtm(),
            _ when this == DokuBriVa => onDokuBriVa(),
            _ when this == DokuBcaVa => onDokuBcaVa(),
            _ when this == DokuAlfamart => onDokuAlfamart(),
            _ when this == DokuIndomaret => onDokuIndomaret(),
            _ when this == DokuWallet => onDokuWallet(),
            _ when this == DokuOvo => onDokuOvo(),
            _ => otherwise(Value)
        };

    public void Match(Action onDokuMandiriVa,
        Action onDokuCimbVa,
        Action onDokuDanamonVa,
        Action onDokuBniVa,
        Action onDokuPermataLiteAtm,
        Action onDokuBriVa,
        Action onDokuBcaVa,
        Action onDokuAlfamart,
        Action onDokuIndomaret,
        Action onDokuWallet,
        Action onDokuOvo,
        Action<string> otherwise)
    {
        if (this == DokuMandiriVa) onDokuMandiriVa();
        else if (this == DokuCimbVa) onDokuCimbVa();
        else if (this == DokuDanamonVa) onDokuDanamonVa();
        else if (this == DokuBniVa) onDokuBniVa();
        else if (this == DokuPermataLiteAtm) onDokuPermataLiteAtm();
        else if (this == DokuBriVa) onDokuBriVa();
        else if (this == DokuBcaVa) onDokuBcaVa();
        else if (this == DokuAlfamart) onDokuAlfamart();
        else if (this == DokuIndomaret) onDokuIndomaret();
        else if (this == DokuWallet) onDokuWallet();
        else if (this == DokuOvo) onDokuOvo();
        else otherwise(Value);
    }
}
