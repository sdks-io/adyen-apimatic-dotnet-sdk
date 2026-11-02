using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Length of time that the cardholder has had the account with the 3DS Requestor.
/// Allowed values:
/// * <b>01</b> — No account
/// * <b>02</b> — Created during this transaction
/// * <b>03</b> — Less than 30 days
/// * <b>04</b> — 30–60 days
/// * <b>05</b> — More than 60 days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChAccAgeInd>))]
public sealed record ChAccAgeInd : OpenStringEnum<ChAccAgeInd>
{
    private ChAccAgeInd(string value) : base(value)
    {
    }

    public static readonly ChAccAgeInd _01 = new("01");

    public static readonly ChAccAgeInd _02 = new("02");

    public static readonly ChAccAgeInd _03 = new("03");

    public static readonly ChAccAgeInd _04 = new("04");

    public static readonly ChAccAgeInd _05 = new("05");

    public TResult Match<TResult>(Func<TResult> on_01,
        Func<TResult> on_02,
        Func<TResult> on_03,
        Func<TResult> on_04,
        Func<TResult> on_05,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _01 => on_01(),
            _ when this == _02 => on_02(),
            _ when this == _03 => on_03(),
            _ when this == _04 => on_04(),
            _ when this == _05 => on_05(),
            _ => otherwise(Value)
        };

    public void Match(Action on_01, Action on_02, Action on_03, Action on_04, Action on_05, Action<string> otherwise)
    {
        if (this == _01) on_01();
        else if (this == _02) on_02();
        else if (this == _03) on_03();
        else if (this == _04) on_04();
        else if (this == _05) on_05();
        else otherwise(Value);
    }
}
