namespace AdyenApIs.Requests.TerminalSettingsTerminalLevel;

/// <summary>
/// The inputs of the GetTerminalSettings operation.
/// </summary>
public sealed record GetTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }
}
