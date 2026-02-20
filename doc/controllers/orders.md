# Orders

```csharp
OrdersApi ordersApi = client.OrdersApi;
```

## Class Name

`OrdersApi`

## Methods

* [Create Order](../../doc/controllers/orders.md#create-order)
* [Cancel Order](../../doc/controllers/orders.md#cancel-order)
* [Get Payment Method Balance](../../doc/controllers/orders.md#get-payment-method-balance)


# Create Order

Creates an order to be used for partial payments. Make a POST `/orders` call before making a `/payments` call when processing payments with different payment methods.

```csharp
CreateOrderAsync(
    string idempotencyKey = null,
    Models.CreateOrderRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`CreateOrderRequest`](../../doc/models/create-order-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CreateOrderResponse](../../doc/models/create-order-response.md).

## Example Usage

```csharp
CreateOrderRequest body = new CreateOrderRequest
{
    Amount = new Amount20
    {
        Currency = "EUR",
        MValue = 2500L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_ORDER_REFERENCE",
};

try
{
    ApiResponse<CreateOrderResponse> result = await ordersApi.CreateOrderAsync(
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
  "pspReference": "8616178914061985",
  "resultCode": "Success",
  "expiresAt": "2021-04-09T14:16:46Z",
  "orderData": "Ab02b4c0!BQABAgCxXvknCldOcRElkxY8Za7iyym4Wv8aDzyNwmj/3nh4G6YtwnUIJHaK62NlN4oIsACdkn1FEjBwKlheG40jvXcYGBk4KFV5WvOhTVCpv/KXnkrI7xQv/u2lE7U4wA+HPB6K4Zj2L8xO/ogZi+zGZqFs5m16jmkH7ku6FzXygXLNuUCuOlmlXSZhdkHHTNVQSq1MELDK9OL74y532ETRPTCNxx8WlEiZB+LDqYrPvH9GgigtD5kw8Do45jfFfG72kWBEgfYqp4mbUmBB9ebXFYZKfF0qvW1x7A2Y9+/MFlTIdXfKW484bJeDBCTTrmKGXIj+U4r5imr5fXTyNLcrxyUqwrb9jg+5B4qg1XB6Cgj5UPlSI4O62I7v0s5TTj69dzLwUQRxSQbwLrZVGYavXzeVKI54BVLRV3d/+BbPvTqnTo34UhfZbPlOx9F2eyaS0ZXdOKnHw89uGUgxUpLsMqnbRysi/pxpZaulel+0mExb68wVxb/7Teob5eRG4gp7cfZVZs6tLXOYWL+W0TqIlsa3hWsfM0LeaovzkoDtW/pK5JABXwMtLig9tsxoEh9ONYtIzkXC21LZ8ebiuSIMaPizjF8yca+QxrCZalQsu6uKnBz/mm8nnsflaGU2QS5zcoxk1RudL1Bl36LM9UZGPpFEYWiYA4sUsnNLw7peJjWCGhDepnwMv4TlgsEtoDtz1T54AEp7ImtleSI6IkFGMEFBQTEwM0NBNTM3RUFFRDg3QzI0REQ1MzkwOUI4MEE3OEE5MjNFMzgyM0Q2OERBQ0M5NEI5RkY4MzA1REMifRslOdmfgUHTXl66WPD9xoW2whIeRx/jR++2MqNE16x6zQy+KtDN8/h60crZwmqkjVTQYqQlsYSYDHSIyb4wnnay16/5il1yS7vN3UCLaTXjYBIAyyx6Wr9j4P3CI/etB+PpviHoESC4mV6ZN4whMDQyziQ8s230GtboXbh42qND7rk9phySBogowQlXrtF+l2n2F46nyif0owEgik5fGARfvjZtY2w23s30KMLNwU4gWSvX4H6RMVS8TfZH2fKfNrwB3tZUXwYkELs5ntaHysswq5Mn5aq2BKAMHu/Rh/wureMSI73Qi0avjrzWCwzt3JH4wnzErMnOZwSdgA==",
  "reference": "shopper-reference-ekvL83",
  "remainingAmount": {
    "currency": "EUR",
    "value": 2500
  },
  "amount": {
    "currency": "EUR",
    "value": 300
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


# Cancel Order

Cancels an order. Cancellation of an order results in an automatic rollback of all payments made in the order, either by canceling or refunding the payment, depending on the type of payment method.

```csharp
CancelOrderAsync(
    string idempotencyKey = null,
    Models.CancelOrderRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`CancelOrderRequest`](../../doc/models/cancel-order-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CancelOrderResponse](../../doc/models/cancel-order-response.md).

## Example Usage

```csharp
CancelOrderRequest body = new CancelOrderRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Order = new EncryptedOrderData4
    {
        OrderData = "823fh892f8f18f4...148f13f9f3f",
        PspReference = "8815517812932012",
    },
};

try
{
    ApiResponse<CancelOrderResponse> result = await ordersApi.CancelOrderAsync(
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
  "pspReference": "8816178914079738",
  "resultCode": "Received"
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


# Get Payment Method Balance

Retrieves the balance remaining on a shopper's gift card. To check a gift card's balance, make a POST `/paymentMethods/balance` call and include the gift card's details inside a `paymentMethod` object.

```csharp
GetPaymentMethodBalanceAsync(
    string idempotencyKey = null,
    Models.BalanceCheckRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`BalanceCheckRequest`](../../doc/models/balance-check-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.BalanceCheckResponse](../../doc/models/balance-check-response.md).

## Example Usage

```csharp
BalanceCheckRequest body = new BalanceCheckRequest
{
    Amount = new Amount2
    {
        Currency = "EUR",
        MValue = 1000L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    PaymentMethod = new Dictionary<string, string>
    {
        ["type"] = "givex",
        ["number"] = "4126491073027401",
        ["cvc"] = "737",
    },
};

try
{
    ApiResponse<BalanceCheckResponse> result = await ordersApi.GetPaymentMethodBalanceAsync(
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
  "pspReference": "KHQC5N7G84BLNK43",
  "resultCode": "Success",
  "balance": {
    "currency": "EUR",
    "value": 5000
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

