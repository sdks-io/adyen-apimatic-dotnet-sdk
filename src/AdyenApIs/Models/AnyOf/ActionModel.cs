using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Extensions;
using AdyenApIs.Core.Models;

namespace AdyenApIs.Models.AnyOf;

/// <summary>
/// Action to be taken for completing the payment.
/// </summary>
[JsonConverter(typeof(ActionModelConverter))]
public record ActionModel
{
    private readonly Optional<CheckoutAwaitAction> _checkoutAwaitActionValue;

    private readonly Optional<CheckoutBankTransferAction> _checkoutBankTransferActionValue;

    private readonly Optional<CheckoutDelegatedAuthenticationAction> _checkoutDelegatedAuthenticationActionValue;

    private readonly Optional<CheckoutNativeRedirectAction> _checkoutNativeRedirectActionValue;

    private readonly Optional<CheckoutQrCodeAction> _checkoutQrCodeActionValue;

    private readonly Optional<CheckoutRedirectAction> _checkoutRedirectActionValue;

    private readonly Optional<CheckoutSdkAction> _checkoutSdkActionValue;

    private readonly Optional<CheckoutThreeDs2Action> _checkoutThreeDs2ActionValue;

    private readonly Optional<CheckoutVoucherAction> _checkoutVoucherActionValue;

    private ActionModel(Optional<CheckoutAwaitAction> checkoutAwaitActionValue,
        Optional<CheckoutBankTransferAction> checkoutBankTransferActionValue,
        Optional<CheckoutDelegatedAuthenticationAction> checkoutDelegatedAuthenticationActionValue,
        Optional<CheckoutNativeRedirectAction> checkoutNativeRedirectActionValue,
        Optional<CheckoutQrCodeAction> checkoutQrCodeActionValue,
        Optional<CheckoutRedirectAction> checkoutRedirectActionValue,
        Optional<CheckoutSdkAction> checkoutSdkActionValue,
        Optional<CheckoutThreeDs2Action> checkoutThreeDs2ActionValue,
        Optional<CheckoutVoucherAction> checkoutVoucherActionValue)
    {
        _checkoutAwaitActionValue = checkoutAwaitActionValue;
        _checkoutBankTransferActionValue = checkoutBankTransferActionValue;
        _checkoutDelegatedAuthenticationActionValue = checkoutDelegatedAuthenticationActionValue;
        _checkoutNativeRedirectActionValue = checkoutNativeRedirectActionValue;
        _checkoutQrCodeActionValue = checkoutQrCodeActionValue;
        _checkoutRedirectActionValue = checkoutRedirectActionValue;
        _checkoutSdkActionValue = checkoutSdkActionValue;
        _checkoutThreeDs2ActionValue = checkoutThreeDs2ActionValue;
        _checkoutVoucherActionValue = checkoutVoucherActionValue;
    }

    public static ActionModel CheckoutAwaitAction(CheckoutAwaitAction value) =>
        new(
            Optional<CheckoutAwaitAction>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static ActionModel CheckoutBankTransferAction(CheckoutBankTransferAction value) =>
        new(
            default,
            Optional<CheckoutBankTransferAction>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static ActionModel CheckoutDelegatedAuthenticationAction(CheckoutDelegatedAuthenticationAction value) =>
        new(
            default,
            default,
            Optional<CheckoutDelegatedAuthenticationAction>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static ActionModel CheckoutNativeRedirectAction(CheckoutNativeRedirectAction value) =>
        new(
            default,
            default,
            default,
            Optional<CheckoutNativeRedirectAction>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static ActionModel CheckoutQrCodeAction(CheckoutQrCodeAction value) =>
        new(
            default,
            default,
            default,
            default,
            Optional<CheckoutQrCodeAction>.Some(value),
            default,
            default,
            default,
            default);

    public static ActionModel CheckoutRedirectAction(CheckoutRedirectAction value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutRedirectAction>.Some(value),
            default,
            default,
            default);

    public static ActionModel CheckoutSdkAction(CheckoutSdkAction value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutSdkAction>.Some(value),
            default,
            default);

    public static ActionModel CheckoutThreeDs2Action(CheckoutThreeDs2Action value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutThreeDs2Action>.Some(value),
            default);

    public static ActionModel CheckoutVoucherAction(CheckoutVoucherAction value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutVoucherAction>.Some(value));

    public bool TryGetCheckoutAwaitAction(out CheckoutAwaitAction value) =>
        _checkoutAwaitActionValue.TryGetValue(out value);

    public bool TryGetCheckoutBankTransferAction(out CheckoutBankTransferAction value) =>
        _checkoutBankTransferActionValue.TryGetValue(out value);

    public bool TryGetCheckoutDelegatedAuthenticationAction(out CheckoutDelegatedAuthenticationAction value) =>
        _checkoutDelegatedAuthenticationActionValue.TryGetValue(out value);

    public bool TryGetCheckoutNativeRedirectAction(out CheckoutNativeRedirectAction value) =>
        _checkoutNativeRedirectActionValue.TryGetValue(out value);

    public bool TryGetCheckoutQrCodeAction(out CheckoutQrCodeAction value) =>
        _checkoutQrCodeActionValue.TryGetValue(out value);

    public bool TryGetCheckoutRedirectAction(out CheckoutRedirectAction value) =>
        _checkoutRedirectActionValue.TryGetValue(out value);

    public bool TryGetCheckoutSdkAction(out CheckoutSdkAction value) => _checkoutSdkActionValue.TryGetValue(out value);

    public bool TryGetCheckoutThreeDs2Action(out CheckoutThreeDs2Action value) =>
        _checkoutThreeDs2ActionValue.TryGetValue(out value);

    public bool TryGetCheckoutVoucherAction(out CheckoutVoucherAction value) =>
        _checkoutVoucherActionValue.TryGetValue(out value);

    public static implicit operator ActionModel(CheckoutAwaitAction value) => CheckoutAwaitAction(value);

    public static implicit operator ActionModel(CheckoutBankTransferAction value) => CheckoutBankTransferAction(value);

    public static implicit operator ActionModel(CheckoutDelegatedAuthenticationAction value) =>
        CheckoutDelegatedAuthenticationAction(value);

    public static implicit operator ActionModel(CheckoutNativeRedirectAction value) =>
        CheckoutNativeRedirectAction(value);

    public static implicit operator ActionModel(CheckoutQrCodeAction value) => CheckoutQrCodeAction(value);

    public static implicit operator ActionModel(CheckoutRedirectAction value) => CheckoutRedirectAction(value);

    public static implicit operator ActionModel(CheckoutSdkAction value) => CheckoutSdkAction(value);

    public static implicit operator ActionModel(CheckoutThreeDs2Action value) => CheckoutThreeDs2Action(value);

    public static implicit operator ActionModel(CheckoutVoucherAction value) => CheckoutVoucherAction(value);
}

file sealed class ActionModelConverter : JsonConverter<ActionModel>
{
    public override ActionModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<CheckoutAwaitAction>(root, options, out var checkoutAwaitActionValue))
        {
            return ActionModel.CheckoutAwaitAction(checkoutAwaitActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutBankTransferAction>(
            root,
            options,
            out var checkoutBankTransferActionValue))
        {
            return ActionModel.CheckoutBankTransferAction(checkoutBankTransferActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutDelegatedAuthenticationAction>(
            root,
            options,
            out var checkoutDelegatedAuthenticationActionValue))
        {
            return ActionModel.CheckoutDelegatedAuthenticationAction(checkoutDelegatedAuthenticationActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutNativeRedirectAction>(
            root,
            options,
            out var checkoutNativeRedirectActionValue))
        {
            return ActionModel.CheckoutNativeRedirectAction(checkoutNativeRedirectActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutQrCodeAction>(root, options, out var checkoutQrCodeActionValue))
        {
            return ActionModel.CheckoutQrCodeAction(checkoutQrCodeActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutRedirectAction>(root, options, out var checkoutRedirectActionValue))
        {
            return ActionModel.CheckoutRedirectAction(checkoutRedirectActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutSdkAction>(root, options, out var checkoutSdkActionValue))
        {
            return ActionModel.CheckoutSdkAction(checkoutSdkActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutThreeDs2Action>(root, options, out var checkoutThreeDs2ActionValue))
        {
            return ActionModel.CheckoutThreeDs2Action(checkoutThreeDs2ActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutVoucherAction>(root, options, out var checkoutVoucherActionValue))
        {
            return ActionModel.CheckoutVoucherAction(checkoutVoucherActionValue);
        }
        throw new JsonException(
            $"JSON does not match CheckoutAwaitAction or CheckoutBankTransferAction or CheckoutDelegatedAuthenticationAction or CheckoutNativeRedirectAction or CheckoutQrCodeAction or CheckoutRedirectAction or CheckoutSdkAction or CheckoutThreeDs2Action or CheckoutVoucherAction schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ActionModel value, JsonSerializerOptions options)
    {
        if (value.TryGetCheckoutAwaitAction(out var checkoutAwaitActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutAwaitActionValue, options);
        }
        else if (value.TryGetCheckoutBankTransferAction(out var checkoutBankTransferActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutBankTransferActionValue, options);
        }
        else if (value.TryGetCheckoutDelegatedAuthenticationAction(out var checkoutDelegatedAuthenticationActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutDelegatedAuthenticationActionValue, options);
        }
        else if (value.TryGetCheckoutNativeRedirectAction(out var checkoutNativeRedirectActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutNativeRedirectActionValue, options);
        }
        else if (value.TryGetCheckoutQrCodeAction(out var checkoutQrCodeActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutQrCodeActionValue, options);
        }
        else if (value.TryGetCheckoutRedirectAction(out var checkoutRedirectActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutRedirectActionValue, options);
        }
        else if (value.TryGetCheckoutSdkAction(out var checkoutSdkActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutSdkActionValue, options);
        }
        else if (value.TryGetCheckoutThreeDs2Action(out var checkoutThreeDs2ActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutThreeDs2ActionValue, options);
        }
        else if (value.TryGetCheckoutVoucherAction(out var checkoutVoucherActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutVoucherActionValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ActionModel)} contains no valid value to serialize.");
        }
    }
}
