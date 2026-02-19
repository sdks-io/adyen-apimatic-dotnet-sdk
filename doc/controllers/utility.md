# Utility

```csharp
UtilityApi utilityApi = client.UtilityApi;
```

## Class Name

`UtilityApi`

## Methods

* [Post-Apple Pay-Sessions](../../doc/controllers/utility.md#post-apple-pay-sessions)
* [Post-Origin Keys](../../doc/controllers/utility.md#post-origin-keys)
* [Post-Paypal-Update Order](../../doc/controllers/utility.md#post-paypal-update-order)
* [Post-Validate Shopper Id](../../doc/controllers/utility.md#post-validate-shopper-id)


# Post-Apple Pay-Sessions

You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.

The endpoint returns the Apple Pay session data which you need to complete the [Apple Pay session validation](https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation).

```csharp
PostApplePaySessionsAsync(
    string idempotencyKey = null,
    Models.ApplePaySessionRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`ApplePaySessionRequest`](../../doc/models/apple-pay-session-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ApplePaySessionResponse](../../doc/models/apple-pay-session-response.md).

## Example Usage

```csharp
ApplePaySessionRequest body = new ApplePaySessionRequest
{
    DisplayName = "YOUR_MERCHANT_NAME",
    DomainName = "YOUR_DOMAIN_NAME",
    MerchantIdentifier = "YOUR_MERCHANT_ID",
};

try
{
    ApiResponse<ApplePaySessionResponse> result = await utilityApi.PostApplePaySessionsAsync(
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "data": "eyJ2Z..."
}
```


# Post-Origin Keys

**This endpoint is deprecated.**

This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains.

> If you're still using origin key for your Web Drop-in or Components integration, we recommend [switching to client key](https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key). This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form.

```csharp
PostOriginKeysAsync(
    string idempotencyKey = null,
    Models.UtilityRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`UtilityRequest`](../../doc/models/utility-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.UtilityResponse](../../doc/models/utility-response.md).

## Example Usage

```csharp
UtilityRequest body = new UtilityRequest
{
    OriginDomains = new List<string>
    {
        "https://www.your-domain1.com",
        "https://www.your-domain2.com",
        "https://www.your-domain3.com",
    },
};

try
{
    ApiResponse<UtilityResponse> result = await utilityApi.PostOriginKeysAsync(
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
  "originKeys": {
    "https://www.your-domain1.com": "pub.v2.8116178901076090.aHR0cHM6Ly93d3cueW91ci1kb21haW4xLmNvbQ.pvbYlrXz0ICP4kwMJXDGDLVMqALhwXr1MSRjT-fkhvw",
    "https://www.your-domain3.com": "pub.v2.8116178901076090.aHR0cHM6Ly93d3cueW91ci1kb21haW4zLmNvbQ.FrTpVz7_RzAywKasM0kXCRoMfoMkKIKaxjFymRGORIc",
    "https://www.your-domain2.com": "pub.v2.8116178901076090.aHR0cHM6Ly93d3cueW91ci1kb21haW4yLmNvbQ.LdN9kvJ35fYFFiBSJA4idMnwwxJ5_yXpeNS__Ap5wkg"
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


# Post-Paypal-Update Order

Updates the order for PayPal Express Checkout. This can be used to update the PayPal lightbox with an updated amount and delivery methods based on the delivery address.

```csharp
PostPaypalUpdateOrderAsync(
    string idempotencyKey = null,
    Models.PaypalUpdateOrderRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaypalUpdateOrderRequest`](../../doc/models/paypal-update-order-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaypalUpdateOrderResponse](../../doc/models/paypal-update-order-response.md).

## Example Usage

```csharp
PaypalUpdateOrderRequest body = new PaypalUpdateOrderRequest
{
    Amount = new Amount43
    {
        Currency = "EUR",
        MValue = 12000L,
    },
    DeliveryMethods = new List<DeliveryMethod>
    {
        new DeliveryMethod
        {
            Amount = new Amount23
            {
                Currency = "EUR",
                MValue = 1000L,
            },
            Description = "Express Shipping",
            Reference = "1",
            Selected = true,
            Type = Type18.Shipping,
        },
        new DeliveryMethod
        {
            Amount = new Amount23
            {
                Currency = "EUR",
                MValue = 500L,
            },
            Description = "Standard Ground",
            Reference = "2",
            Selected = false,
            Type = Type18.Shipping,
        },
    },
    PaymentData = "po7XZ...",
    PspReference = "DZ4DPSHB4WD2WN82",
};

try
{
    ApiResponse<PaypalUpdateOrderResponse> result = await utilityApi.PostPaypalUpdateOrderAsync(
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
  "paymentData": "po7XZ...",
  "status": "success"
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


# Post-Validate Shopper Id

Validates the shopperId.

:information_source: **Note** This endpoint does not require authentication.

```csharp
PostValidateShopperIdAsync(
    Models.ValidateShopperIdRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ValidateShopperIdRequest`](../../doc/models/validate-shopper-id-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ValidateShopperIdResponse](../../doc/models/validate-shopper-id-response.md).

## Example Usage

```csharp
ValidateShopperIdRequest body = new ValidateShopperIdRequest
{
    MerchantAccount = "merchantAccount2",
    PaymentMethod = new ShopperIdPaymentMethod1
    {
        Type = "ShopperIdPaymentMethod1",
    },
};

try
{
    ApiResponse<ValidateShopperIdResponse> result = await utilityApi.PostValidateShopperIdAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is DefaultErrorResponseEntityException)
    {
       // TODO: Handle DefaultErrorResponseEntityException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`DefaultErrorResponseEntityException`](../../doc/models/default-error-response-entity-exception.md) |
| 401 | Unauthorized - authentication required. | [`DefaultErrorResponseEntityException`](../../doc/models/default-error-response-entity-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`DefaultErrorResponseEntityException`](../../doc/models/default-error-response-entity-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`DefaultErrorResponseEntityException`](../../doc/models/default-error-response-entity-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`DefaultErrorResponseEntityException`](../../doc/models/default-error-response-entity-exception.md) |

