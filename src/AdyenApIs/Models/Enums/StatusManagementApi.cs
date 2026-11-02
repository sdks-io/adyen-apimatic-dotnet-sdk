using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The status of the app. Possible values:
/// * <c>processing</c>: the app is being signed and converted to a format that the terminal can handle.
/// * <c>error</c>: something went wrong. Check that the app matches the <see href="https://docs.adyen.com/point-of-sale/android-terminals/app-requirements">requirements</see>.
/// * <c>invalid</c>: there is something wrong with the APK file of the app.
/// * <c>ready</c>: the app has been signed and converted.
/// * <c>archived</c>: the app is no longer available.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatusManagementApi>))]
public sealed record StatusManagementApi : OpenStringEnum<StatusManagementApi>
{
    private StatusManagementApi(string value) : base(value)
    {
    }

    public static readonly StatusManagementApi Archived = new("archived");

    public static readonly StatusManagementApi Error = new("error");

    public static readonly StatusManagementApi Invalid = new("invalid");

    public static readonly StatusManagementApi Processing = new("processing");

    public static readonly StatusManagementApi Ready = new("ready");

    public TResult Match<TResult>(Func<TResult> onArchived,
        Func<TResult> onError,
        Func<TResult> onInvalid,
        Func<TResult> onProcessing,
        Func<TResult> onReady,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Archived => onArchived(),
            _ when this == Error => onError(),
            _ when this == Invalid => onInvalid(),
            _ when this == Processing => onProcessing(),
            _ when this == Ready => onReady(),
            _ => otherwise(Value)
        };

    public void Match(Action onArchived,
        Action onError,
        Action onInvalid,
        Action onProcessing,
        Action onReady,
        Action<string> otherwise)
    {
        if (this == Archived) onArchived();
        else if (this == Error) onError();
        else if (this == Invalid) onInvalid();
        else if (this == Processing) onProcessing();
        else if (this == Ready) onReady();
        else otherwise(Value);
    }
}
