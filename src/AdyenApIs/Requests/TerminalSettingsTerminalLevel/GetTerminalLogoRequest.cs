namespace AdyenApIs.Requests.TerminalSettingsTerminalLevel;

/// <summary>
/// The inputs of the GetTerminalLogo operation.
/// </summary>
public sealed record GetTerminalLogoRequest
{
    /// <summary>
    /// The unique identifier of the payment terminal.
    /// </summary>
    public required string TerminalId { get; init; }
}
