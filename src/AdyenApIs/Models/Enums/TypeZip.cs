using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>zip</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeZip>))]
public sealed record TypeZip : OpenStringEnum<TypeZip>
{
    private TypeZip(string value) : base(value)
    {
    }

    public static readonly TypeZip Zip = new("zip");

    public static readonly TypeZip ZipPos = new("zip_pos");

    public TResult Match<TResult>(Func<TResult> onZip, Func<TResult> onZipPos, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Zip => onZip(),
            _ when this == ZipPos => onZipPos(),
            _ => otherwise(Value)
        };

    public void Match(Action onZip, Action onZipPos, Action<string> otherwise)
    {
        if (this == Zip) onZip();
        else if (this == ZipPos) onZipPos();
        else otherwise(Value);
    }
}
