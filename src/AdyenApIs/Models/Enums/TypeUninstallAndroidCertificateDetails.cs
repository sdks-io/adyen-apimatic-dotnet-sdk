using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Type of terminal action: Uninstall an Android certificate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeUninstallAndroidCertificateDetails>))]
public sealed record TypeUninstallAndroidCertificateDetails : OpenStringEnum<TypeUninstallAndroidCertificateDetails>
{
    private TypeUninstallAndroidCertificateDetails(string value) : base(value)
    {
    }

    public static readonly TypeUninstallAndroidCertificateDetails UninstallAndroidCertificate = new(
        "UninstallAndroidCertificate");

    public TResult Match<TResult>(Func<TResult> onUninstallAndroidCertificate, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UninstallAndroidCertificate => onUninstallAndroidCertificate(),
            _ => otherwise(Value)
        };

    public void Match(Action onUninstallAndroidCertificate, Action<string> otherwise)
    {
        if (this == UninstallAndroidCertificate) onUninstallAndroidCertificate();
        else otherwise(Value);
    }
}
