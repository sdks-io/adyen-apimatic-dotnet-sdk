using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The sales channel. Required if the merchant account does not have a sales channel. When you provide this field, it overrides the default sales channel set on the merchant account.
/// <para>
/// Possible values: <b>eCommerce</b>, <b>pos</b>, <b>contAuth</b>, and <b>moto</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShopperInteractionManagementApi>))]
public sealed record ShopperInteractionManagementApi : OpenStringEnum<ShopperInteractionManagementApi>
{
    private ShopperInteractionManagementApi(string value) : base(value)
    {
    }

    public static readonly ShopperInteractionManagementApi ECommerce = new("eCommerce");

    public static readonly ShopperInteractionManagementApi Pos = new("pos");

    public static readonly ShopperInteractionManagementApi Moto = new("moto");

    public static readonly ShopperInteractionManagementApi ContAuth = new("contAuth");

    public TResult Match<TResult>(Func<TResult> onECommerce,
        Func<TResult> onPos,
        Func<TResult> onMoto,
        Func<TResult> onContAuth,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ECommerce => onECommerce(),
            _ when this == Pos => onPos(),
            _ when this == Moto => onMoto(),
            _ when this == ContAuth => onContAuth(),
            _ => otherwise(Value)
        };

    public void Match(Action onECommerce, Action onPos, Action onMoto, Action onContAuth, Action<string> otherwise)
    {
        if (this == ECommerce) onECommerce();
        else if (this == Pos) onPos();
        else if (this == Moto) onMoto();
        else if (this == ContAuth) onContAuth();
        else otherwise(Value);
    }
}
