using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalSettingsTerminalLevel;

/// <summary>
/// The inputs of the UpdateTerminalLogo operation.
/// </summary>
public sealed record UpdateTerminalLogoRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }

    public Logo? Body { get; init; }
}
