using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The status of the donation transaction.
/// <para>
/// Possible values:
/// * <b>completed</b>
/// * <b>pending</b>
/// * <b>refused</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatusDonationPaymentResponse>))]
public sealed record StatusDonationPaymentResponse : OpenStringEnum<StatusDonationPaymentResponse>
{
    private StatusDonationPaymentResponse(string value) : base(value)
    {
    }

    public static readonly StatusDonationPaymentResponse Completed = new("completed");

    public static readonly StatusDonationPaymentResponse Pending = new("pending");

    public static readonly StatusDonationPaymentResponse Refused = new("refused");

    public TResult Match<TResult>(Func<TResult> onCompleted,
        Func<TResult> onPending,
        Func<TResult> onRefused,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Completed => onCompleted(),
            _ when this == Pending => onPending(),
            _ when this == Refused => onRefused(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompleted, Action onPending, Action onRefused, Action<string> otherwise)
    {
        if (this == Completed) onCompleted();
        else if (this == Pending) onPending();
        else if (this == Refused) onRefused();
        else otherwise(Value);
    }
}
