using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Information about bluetooth, cellular, ethernet and wifi connectivity for the terminal.
/// </summary>
public record TerminalConnectivityTerminal
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bluetooth")]
    public TerminalConnectivityBluetooth? Bluetooth { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cellular")]
    public TerminalConnectivityCellular? Cellular { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ethernet")]
    public TerminalConnectivityEthernet? Ethernet { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wifi")]
    public TerminalConnectivityWifi? Wifi { get; init; }
}
