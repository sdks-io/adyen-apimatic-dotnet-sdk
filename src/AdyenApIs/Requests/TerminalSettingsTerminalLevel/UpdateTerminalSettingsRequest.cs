using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalSettingsTerminalLevel;

/// <summary>
/// The inputs of the UpdateTerminalSettings operation.
/// </summary>
public sealed record UpdateTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }

    public TerminalSettings? Body { get; init; }
}
