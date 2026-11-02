using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Type of terminal action: Install an Android certificate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeInstallAndroidCertificateDetails>))]
public sealed record TypeInstallAndroidCertificateDetails : OpenStringEnum<TypeInstallAndroidCertificateDetails>
{
    private TypeInstallAndroidCertificateDetails(string value) : base(value)
    {
    }

    public static readonly TypeInstallAndroidCertificateDetails InstallAndroidCertificate = new(
        "InstallAndroidCertificate");

    public TResult Match<TResult>(Func<TResult> onInstallAndroidCertificate, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InstallAndroidCertificate => onInstallAndroidCertificate(),
            _ => otherwise(Value)
        };

    public void Match(Action onInstallAndroidCertificate, Action<string> otherwise)
    {
        if (this == InstallAndroidCertificate) onInstallAndroidCertificate();
        else otherwise(Value);
    }
}
