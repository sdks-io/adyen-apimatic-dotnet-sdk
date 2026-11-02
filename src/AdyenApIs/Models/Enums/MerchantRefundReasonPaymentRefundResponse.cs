using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Your reason for the refund request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantRefundReasonPaymentRefundResponse>))]
public sealed record MerchantRefundReasonPaymentRefundResponse : OpenStringEnum<MerchantRefundReasonPaymentRefundResponse>
{
    private MerchantRefundReasonPaymentRefundResponse(string value) : base(value)
    {
    }

    public static readonly MerchantRefundReasonPaymentRefundResponse Fraud = new("FRAUD");

    public static readonly MerchantRefundReasonPaymentRefundResponse CustomerRequest = new("CUSTOMER REQUEST");

    public static readonly MerchantRefundReasonPaymentRefundResponse Return = new("RETURN");

    public static readonly MerchantRefundReasonPaymentRefundResponse Duplicate = new("DUPLICATE");

    public static readonly MerchantRefundReasonPaymentRefundResponse Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onFraud,
        Func<TResult> onCustomerRequest,
        Func<TResult> onReturn,
        Func<TResult> onDuplicate,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Fraud => onFraud(),
            _ when this == CustomerRequest => onCustomerRequest(),
            _ when this == Return => onReturn(),
            _ when this == Duplicate => onDuplicate(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onFraud,
        Action onCustomerRequest,
        Action onReturn,
        Action onDuplicate,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Fraud) onFraud();
        else if (this == CustomerRequest) onCustomerRequest();
        else if (this == Return) onReturn();
        else if (this == Duplicate) onDuplicate();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
