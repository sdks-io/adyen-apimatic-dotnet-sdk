using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The processing model used for the recurring transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RecurringProcessingModelResponseAdditionalDataCommon>))]
public sealed record RecurringProcessingModelResponseAdditionalDataCommon : OpenStringEnum<RecurringProcessingModelResponseAdditionalDataCommon>
{
    private RecurringProcessingModelResponseAdditionalDataCommon(string value) : base(value)
    {
    }

    public static readonly RecurringProcessingModelResponseAdditionalDataCommon CardOnFile = new("CardOnFile");

    public static readonly RecurringProcessingModelResponseAdditionalDataCommon Subscription = new("Subscription");

    public static readonly RecurringProcessingModelResponseAdditionalDataCommon UnscheduledCardOnFile = new(
        "UnscheduledCardOnFile");

    public TResult Match<TResult>(Func<TResult> onCardOnFile,
        Func<TResult> onSubscription,
        Func<TResult> onUnscheduledCardOnFile,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CardOnFile => onCardOnFile(),
            _ when this == Subscription => onSubscription(),
            _ when this == UnscheduledCardOnFile => onUnscheduledCardOnFile(),
            _ => otherwise(Value)
        };

    public void Match(Action onCardOnFile,
        Action onSubscription,
        Action onUnscheduledCardOnFile,
        Action<string> otherwise)
    {
        if (this == CardOnFile) onCardOnFile();
        else if (this == Subscription) onSubscription();
        else if (this == UnscheduledCardOnFile) onUnscheduledCardOnFile();
        else otherwise(Value);
    }
}
