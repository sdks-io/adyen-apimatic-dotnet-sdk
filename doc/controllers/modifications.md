# Modifications

```csharp
ModificationsApi modificationsApi = client.ModificationsApi;
```

## Class Name

`ModificationsApi`

## Methods

* [Post-Cancels](../../doc/controllers/modifications.md#post-cancels)
* [Post-Payments-Payment Psp Reference-Amount Updates](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-amount-updates)
* [Post-Payments-Payment Psp Reference-Cancels](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-cancels)
* [Post-Payments-Payment Psp Reference-Captures](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-captures)
* [Post-Payments-Payment Psp Reference-Refunds](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-refunds)
* [Post-Payments-Payment Psp Reference-Reversals](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-reversals)


# Post-Cancels

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**TECHNICAL_CANCEL** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment using the [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

```csharp
PostCancelsAsync(
    string idempotencyKey = null,
    Models.StandalonePaymentCancelRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`StandalonePaymentCancelRequest`](../../doc/models/standalone-payment-cancel-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.StandalonePaymentCancelResponse](../../doc/models/standalone-payment-cancel-response.md).

## Example Usage

```csharp
StandalonePaymentCancelRequest body = new StandalonePaymentCancelRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    PaymentReference = "YOUR_UNIQUE_REFERENCE_FOR_THE_PAYMENT",
    Reference = "YOUR_UNIQUE_REFERENCE_FOR_THE_CANCELLATION",
};

try
{
    ApiResponse<StandalonePaymentCancelResponse> result = await modificationsApi.PostCancelsAsync(
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ServiceErrorException)
    {
       // TODO: Handle ServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentReference": "YOUR_UNIQUE_REFERENCE_FOR_THE_PAYMENT",
  "reference": "YOUR_UNIQUE_REFERENCE_FOR_THE_CANCELLATION",
  "pspReference": "993617894906488A",
  "status": "received"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Payments-Payment Psp Reference-Amount Updates

Increases or decreases the authorised payment amount and returns a unique reference for this request. You get the outcome of the request asynchronously, in an [**AUTHORISATION_ADJUSTMENT** webhook](https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes).

You can only update authorised amounts that have not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures).

The amount you specify in the request is the updated amount, which is larger or smaller than the initial authorised amount.

For more information, refer to [Authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#use-cases).

```csharp
PostPaymentsPaymentPspReferenceAmountUpdatesAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentAmountUpdateRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentAmountUpdateRequest`](../../doc/models/payment-amount-update-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentAmountUpdateResponse](../../doc/models/payment-amount-update-response.md).

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentAmountUpdateRequest body = new PaymentAmountUpdateRequest
{
    Amount = new Amount28
    {
        Currency = "EUR",
        MValue = 2500L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    ApiResponse<PaymentAmountUpdateResponse> result = await modificationsApi.PostPaymentsPaymentPspReferenceAmountUpdatesAsync(
        paymentPspReference,
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ServiceErrorException)
    {
       // TODO: Handle ServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received",
  "amount": {
    "currency": "EUR",
    "value": 2500
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Payments-Payment Psp Reference-Cancels

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCELLATION** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment but don't have the [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

```csharp
PostPaymentsPaymentPspReferenceCancelsAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentCancelRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to cancel. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentCancelRequest`](../../doc/models/payment-cancel-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentCancelResponse](../../doc/models/payment-cancel-response.md).

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentCancelRequest body = new PaymentCancelRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    ApiResponse<PaymentCancelResponse> result = await modificationsApi.PostPaymentsPaymentPspReferenceCancelsAsync(
        paymentPspReference,
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ServiceErrorException)
    {
       // TODO: Handle ServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Payments-Payment Psp Reference-Captures

Captures an authorised payment and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CAPTURE** webhook](https://docs.adyen.com/online-payments/capture#capture-notification).

You can capture either the full authorised amount or a part of the authorised amount. By default, any unclaimed amount after a partial capture gets cancelled. This does not apply if you enabled multiple partial captures on your account and the payment method supports multiple partial captures.

[Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture) is the default setting for most payment methods. In these cases, you don't need to make capture requests. However, making capture requests for payments that are captured automatically does not result in double charges.

For more information, refer to [Capture](https://docs.adyen.com/online-payments/capture).

```csharp
PostPaymentsPaymentPspReferenceCapturesAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentCaptureRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to capture. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentCaptureRequest`](../../doc/models/payment-capture-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentCaptureResponse](../../doc/models/payment-capture-response.md).

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentCaptureRequest body = new PaymentCaptureRequest
{
    Amount = new Amount30
    {
        Currency = "EUR",
        MValue = 2000L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    ApiResponse<PaymentCaptureResponse> result = await modificationsApi.PostPaymentsPaymentPspReferenceCapturesAsync(
        paymentPspReference,
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ServiceErrorException)
    {
       // TODO: Handle ServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received",
  "amount": {
    "value": 2000,
    "currency": "EUR"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Payments-Payment Psp Reference-Refunds

Refunds a payment that has been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**REFUND** webhook](https://docs.adyen.com/online-payments/refund#refund-webhook).

You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.

> Some payment methods do not support partial refunds. To learn if a payment method supports partial refunds, refer to the payment method page such as [cards](https://docs.adyen.com/payment-methods/cards#supported-cards), [iDEAL](https://docs.adyen.com/payment-methods/ideal), or [Klarna](https://docs.adyen.com/payment-methods/klarna).

If you want to refund a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Refund](https://docs.adyen.com/online-payments/refund).

```csharp
PostPaymentsPaymentPspReferenceRefundsAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentRefundRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to refund. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentRefundRequest`](../../doc/models/payment-refund-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentRefundResponse](../../doc/models/payment-refund-response.md).

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentRefundRequest body = new PaymentRefundRequest
{
    Amount = new Amount37
    {
        Currency = "EUR",
        MValue = 2500L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    ApiResponse<PaymentRefundResponse> result = await modificationsApi.PostPaymentsPaymentPspReferenceRefundsAsync(
        paymentPspReference,
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ServiceErrorException)
    {
       // TODO: Handle ServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received",
  "amount": {
    "currency": "EUR",
    "value": 2500
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Payments-Payment Psp Reference-Reversals

[Refunds](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/refunds) a payment if it has already been captured, and [cancels](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) a payment if it has not yet been captured. Returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCEL_OR_REFUND** webhook](https://docs.adyen.com/online-payments/reversal/#cancel-or-refund-webhook).

The reversed amount is always the full payment amount.

> Do not use this request for payments that involve multiple partial captures.

For more information, refer to [Reversal](https://docs.adyen.com/online-payments/reversal).

```csharp
PostPaymentsPaymentPspReferenceReversalsAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentReversalRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to reverse. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentReversalRequest`](../../doc/models/payment-reversal-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentReversalResponse](../../doc/models/payment-reversal-response.md).

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentReversalRequest body = new PaymentReversalRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    ApiResponse<PaymentReversalResponse> result = await modificationsApi.PostPaymentsPaymentPspReferenceReversalsAsync(
        paymentPspReference,
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ServiceErrorException)
    {
       // TODO: Handle ServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |

