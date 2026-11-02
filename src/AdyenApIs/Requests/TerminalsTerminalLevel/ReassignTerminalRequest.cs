using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalsTerminalLevel;

/// <summary>
/// The inputs of the ReassignTerminal operation.
/// </summary>
public sealed record ReassignTerminalRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }

    public TerminalReassignmentRequest? Body { get; init; }
}
