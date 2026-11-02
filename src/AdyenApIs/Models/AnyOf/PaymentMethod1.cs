using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Extensions;
using AdyenApIs.Core.Models;

namespace AdyenApIs.Models.AnyOf;

/// <summary>
/// The type and required details of a payment method to use.
/// <para>
/// When <c>donationToken</c> is provided, the payment method is derived from the token and this field becomes optional.
/// </para>
/// <para>
/// If you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">PCI compliant</see>, and make donations using raw card details, you must explicitly provide the payment method details.
/// </para>
/// </summary>
[JsonConverter(typeof(PaymentMethod1Converter))]
public record PaymentMethod1
{
    private readonly Optional<ApplePay> _applePayValue;

    private readonly Optional<Card> _cardValue;

    private readonly Optional<object> _anonymousObjectValue;

    private PaymentMethod1(Optional<ApplePay> applePayValue,
        Optional<Card> cardValue,
        Optional<object> anonymousObjectValue)
    {
        _applePayValue = applePayValue;
        _cardValue = cardValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static PaymentMethod1 ApplePay(ApplePay value) => new(Optional<ApplePay>.Some(value), default, default);

    public static PaymentMethod1 Card(Card value) => new(default, Optional<Card>.Some(value), default);

    public static PaymentMethod1 AnonymousObject(object value) => new(default, default, Optional<object>.Some(value));

    public bool TryGetApplePay(out ApplePay value) => _applePayValue.TryGetValue(out value);

    public bool TryGetCard(out Card value) => _cardValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator PaymentMethod1(ApplePay value) => ApplePay(value);

    public static implicit operator PaymentMethod1(Card value) => Card(value);
}

file sealed class PaymentMethod1Converter : JsonConverter<PaymentMethod1>
{
    public override PaymentMethod1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ApplePay>(root, options, out var applePayValue))
        {
            return PaymentMethod1.ApplePay(applePayValue);
        }
        if (JsonSerializer.TryDeserialize<Card>(root, options, out var cardValue))
        {
            return PaymentMethod1.Card(cardValue);
        }
        if (JsonSerializer.TryDeserialize<object>(root, options, out var anonymousObjectValue))
        {
            return PaymentMethod1.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match ApplePay or Card or object schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PaymentMethod1 value, JsonSerializerOptions options)
    {
        if (value.TryGetApplePay(out var applePayValue))
        {
            JsonSerializer.Serialize(writer, applePayValue, options);
        }
        else if (value.TryGetCard(out var cardValue))
        {
            JsonSerializer.Serialize(writer, cardValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PaymentMethod1)} contains no valid value to serialize.");
        }
    }
}
