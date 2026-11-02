using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Type of terminal action: Uninstall an Android app.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeUninstallAndroidAppDetails>))]
public sealed record TypeUninstallAndroidAppDetails : OpenStringEnum<TypeUninstallAndroidAppDetails>
{
    private TypeUninstallAndroidAppDetails(string value) : base(value)
    {
    }

    public static readonly TypeUninstallAndroidAppDetails UninstallAndroidApp = new("UninstallAndroidApp");

    public TResult Match<TResult>(Func<TResult> onUninstallAndroidApp, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UninstallAndroidApp => onUninstallAndroidApp(),
            _ => otherwise(Value)
        };

    public void Match(Action onUninstallAndroidApp, Action<string> otherwise)
    {
        if (this == UninstallAndroidApp) onUninstallAndroidApp();
        else otherwise(Value);
    }
}
