using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The type of transaction description you want to use:
/// - <b>fixed</b>: The transaction description set in this request is used for all payments with this payment method.
/// - <b>append</b>: The transaction description set in this request is used as a base for all payments with this payment method. The <see href="https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement">transaction description set in the request to process the payment</see> is appended to this base description. Note that if the combined length exceeds 22 characters, banks may truncate the string.
/// - <b>dynamic</b>: Only the <see href="https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement">transaction description set in the request to process the payment</see> is used for payments with this payment method.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeManagementApi>))]
public sealed record TypeManagementApi : OpenStringEnum<TypeManagementApi>
{
    private TypeManagementApi(string value) : base(value)
    {
    }

    public static readonly TypeManagementApi Append = new("append");

    public static readonly TypeManagementApi Dynamic = new("dynamic");

    public static readonly TypeManagementApi Fixed = new("fixed");

    public TResult Match<TResult>(Func<TResult> onAppend,
        Func<TResult> onDynamic,
        Func<TResult> onFixed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Append => onAppend(),
            _ when this == Dynamic => onDynamic(),
            _ when this == Fixed => onFixed(),
            _ => otherwise(Value)
        };

    public void Match(Action onAppend, Action onDynamic, Action onFixed, Action<string> otherwise)
    {
        if (this == Append) onAppend();
        else if (this == Dynamic) onDynamic();
        else if (this == Fixed) onFixed();
        else otherwise(Value);
    }
}
