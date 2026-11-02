using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The status of the request. This indicates whether the order was successfully updated with PayPal.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatusPaypalUpdateOrderResponse>))]
public sealed record StatusPaypalUpdateOrderResponse : OpenStringEnum<StatusPaypalUpdateOrderResponse>
{
    private StatusPaypalUpdateOrderResponse(string value) : base(value)
    {
    }

    public static readonly StatusPaypalUpdateOrderResponse Error = new("error");

    public static readonly StatusPaypalUpdateOrderResponse Success = new("success");

    public TResult Match<TResult>(Func<TResult> onError, Func<TResult> onSuccess, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Error => onError(),
            _ when this == Success => onSuccess(),
            _ => otherwise(Value)
        };

    public void Match(Action onError, Action onSuccess, Action<string> otherwise)
    {
        if (this == Error) onError();
        else if (this == Success) onSuccess();
        else otherwise(Value);
    }
}
