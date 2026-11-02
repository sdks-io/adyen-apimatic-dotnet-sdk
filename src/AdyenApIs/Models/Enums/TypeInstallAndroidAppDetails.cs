using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Type of terminal action: Install an Android app.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeInstallAndroidAppDetails>))]
public sealed record TypeInstallAndroidAppDetails : OpenStringEnum<TypeInstallAndroidAppDetails>
{
    private TypeInstallAndroidAppDetails(string value) : base(value)
    {
    }

    public static readonly TypeInstallAndroidAppDetails InstallAndroidApp = new("InstallAndroidApp");

    public TResult Match<TResult>(Func<TResult> onInstallAndroidApp, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InstallAndroidApp => onInstallAndroidApp(),
            _ => otherwise(Value)
        };

    public void Match(Action onInstallAndroidApp, Action<string> otherwise)
    {
        if (this == InstallAndroidApp) onInstallAndroidApp();
        else otherwise(Value);
    }
}
