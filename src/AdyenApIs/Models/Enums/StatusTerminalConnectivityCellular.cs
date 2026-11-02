using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// On a terminal that supports 3G or 4G connectivity, indicates the status of the primary SIM card in the terminal.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatusTerminalConnectivityCellular>))]
public sealed record StatusTerminalConnectivityCellular : OpenStringEnum<StatusTerminalConnectivityCellular>
{
    private StatusTerminalConnectivityCellular(string value) : base(value)
    {
    }

    public static readonly StatusTerminalConnectivityCellular Activated = new("activated");

    public static readonly StatusTerminalConnectivityCellular Deactivated = new("deactivated");

    public static readonly StatusTerminalConnectivityCellular Deprecated = new("deprecated");

    public static readonly StatusTerminalConnectivityCellular Inventory = new("inventory");

    public static readonly StatusTerminalConnectivityCellular ReadyForActivation = new("readyForActivation");

    public TResult Match<TResult>(Func<TResult> onActivated,
        Func<TResult> onDeactivated,
        Func<TResult> onDeprecated,
        Func<TResult> onInventory,
        Func<TResult> onReadyForActivation,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Activated => onActivated(),
            _ when this == Deactivated => onDeactivated(),
            _ when this == Deprecated => onDeprecated(),
            _ when this == Inventory => onInventory(),
            _ when this == ReadyForActivation => onReadyForActivation(),
            _ => otherwise(Value)
        };

    public void Match(Action onActivated,
        Action onDeactivated,
        Action onDeprecated,
        Action onInventory,
        Action onReadyForActivation,
        Action<string> otherwise)
    {
        if (this == Activated) onActivated();
        else if (this == Deactivated) onDeactivated();
        else if (this == Deprecated) onDeprecated();
        else if (this == Inventory) onInventory();
        else if (this == ReadyForActivation) onReadyForActivation();
        else otherwise(Value);
    }
}
