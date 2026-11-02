using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalActionsTerminalLevel;

/// <summary>
/// The inputs of the ScheduleTerminalActions operation.
/// </summary>
public sealed record ScheduleTerminalActionsOperationRequest
{
    public ScheduleTerminalActionsRequest? Body { get; init; }
}
