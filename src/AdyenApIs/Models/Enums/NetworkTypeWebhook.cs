using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Network type for Terminal API details webhooks.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkTypeWebhook>))]
public sealed record NetworkTypeWebhook : OpenStringEnum<NetworkTypeWebhook>
{
    private NetworkTypeWebhook(string value) : base(value)
    {
    }

    public static readonly NetworkTypeWebhook Local = new("local");

    public static readonly NetworkTypeWebhook Public = new("public");

    public TResult Match<TResult>(Func<TResult> onLocal, Func<TResult> onPublic, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Local => onLocal(),
            _ when this == Public => onPublic(),
            _ => otherwise(Value)
        };

    public void Match(Action onLocal, Action onPublic, Action<string> otherwise)
    {
        if (this == Local) onLocal();
        else if (this == Public) onPublic();
        else otherwise(Value);
    }
}
