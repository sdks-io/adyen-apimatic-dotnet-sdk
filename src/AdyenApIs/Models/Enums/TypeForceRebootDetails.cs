using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The type of terminal action. The value <b>ForceReboot</b> triggers an immediate reboot of the specified terminal(s).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeForceRebootDetails>))]
public sealed record TypeForceRebootDetails : OpenStringEnum<TypeForceRebootDetails>
{
    private TypeForceRebootDetails(string value) : base(value)
    {
    }

    public static readonly TypeForceRebootDetails ForceReboot = new("ForceReboot");

    public TResult Match<TResult>(Func<TResult> onForceReboot, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ForceReboot => onForceReboot(),
            _ => otherwise(Value)
        };

    public void Match(Action onForceReboot, Action<string> otherwise)
    {
        if (this == ForceReboot) onForceReboot();
        else otherwise(Value);
    }
}
