using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record UninstallAndroidCertificateDetails
{
    /// <summary>
    /// The unique identifier of the certificate to be uninstalled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("certificateId")]
    public string? CertificateId { get; init; }

    /// <summary>
    /// Type of terminal action: Uninstall an Android certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeUninstallAndroidCertificateDetails? Type { get; init; } = TypeUninstallAndroidCertificateDetails.UninstallAndroidCertificate;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
