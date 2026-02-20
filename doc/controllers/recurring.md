# Recurring

```csharp
RecurringApi recurringApi = client.RecurringApi;
```

## Class Name

`RecurringApi`

## Methods

* [Forward Request](../../doc/controllers/recurring.md#forward-request)
* [List Stored Payment Methods](../../doc/controllers/recurring.md#list-stored-payment-methods)
* [Create Stored Payment Method](../../doc/controllers/recurring.md#create-stored-payment-method)
* [Delete Stored Payment Method](../../doc/controllers/recurring.md#delete-stored-payment-method)


# Forward Request

Forwards the payment details you stored with Adyen to a third-party that you specify and returns the response from the third-party. Supports forwarding stored card details or [network tokens](https://docs.adyen.com/online-payments/network-tokenization). For more information, see [Forward stored payment details](https://docs.adyen.com/online-payments/tokenization/forward-payment-details).

```csharp
ForwardRequestAsync(
    string idempotencyKey = null,
    Models.CheckoutForwardRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`CheckoutForwardRequest`](../../doc/models/checkout-forward-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CheckoutForwardResponse](../../doc/models/checkout-forward-response.md).

## Example Usage

```csharp
CheckoutForwardRequest body = new CheckoutForwardRequest
{
    BaseUrl = "http://thirdparty.example.com",
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Request = new CheckoutOutgoingForwardRequest2
    {
        Body = "{\"amount\":{\"value\":100,\"currency\":\"USD\"},\"paymentMethod\":{\"creditCard\":{\"holderName\":\"{{holderName}}\",\"number\":\"{{number}}\",\"expiryMonth\":\"{{expiryMonth}}\",\"expiryYear\":\"{{expiryYear}}\"}}}",
        HttpMethod = HttpMethod.Post,
        Credentials = "YOUR_CREDENTIALS_FOR_THE_THIRD_PARTY",
        Headers = new Dictionary<string, string>
        {
            ["Authorization"] = "Basic {{credentials}}",
        },
        UrlSuffix = "/payments",
    },
    ShopperReference = "YOUR_SHOPPER_REFERENCE",
    StoredPaymentMethodId = "M5N7TQ4TG5PFWR50",
};

try
{
    ApiResponse<CheckoutForwardResponse> result = await recurringApi.ForwardRequestAsync(
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
  "storedPaymentMethodId": "M5N7TQ4TG5PFWR50",
  "pspReference": "XB7XNCQ8HXSKGK82",
  "response": {
    "status": 200,
    "headers": {
      "thirdparty-version": "2023-10-16"
    },
    "body": "{\"success\": \"ok\",\"data\": {\"tokenizeCreditCard\": {\"paymentMethod\": {\"id\": \"PAYMENT_METHOD_ID\"}}}}"
  }
}
```


# List Stored Payment Methods

Lists the tokens for stored payment details for the shopper identified in the path, if there are any available. The token ID can be used with payment requests for the shopper's payment. A summary of the stored details is included.

```csharp
ListStoredPaymentMethodsAsync(
    string shopperReference = null,
    string merchantAccount = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shopperReference` | `string` | Query, Optional | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address. |
| `merchantAccount` | `string` | Query, Optional | Your merchant account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListStoredPaymentMethodsResponse](../../doc/models/list-stored-payment-methods-response.md).

## Example Usage

```csharp
try
{
    ApiResponse<ListStoredPaymentMethodsResponse> result = await recurringApi.ListStoredPaymentMethodsAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "shopperReference": "YOUR_SHOPPER_REFERENCE",
  "storedPaymentMethods": [
    {
      "brand": "visa",
      "expiryMonth": "10",
      "expiryYear": "30",
      "holderName": "John Smith",
      "id": "7219687191761347",
      "issuerName": "ISSUER_NAME",
      "lastFour": "1111",
      "name": "VISA",
      "shopperEmail": "john.smith@example.com",
      "shopperReference": "YOUR_SHOPPER_REFERENCE",
      "supportedRecurringProcessingModels": [
        "CardOnFile",
        "Subscription",
        "UnscheduledCardOnFile"
      ],
      "type": "scheme"
    }
  ]
}
```


# Create Stored Payment Method

Creates a token to store the shopper's payment details. This token can be used for the shopper's future payments.

```csharp
CreateStoredPaymentMethodAsync(
    string idempotencyKey = null,
    Models.StoredPaymentMethodRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`StoredPaymentMethodRequest`](../../doc/models/stored-payment-method-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.StoredPaymentMethodResource](../../doc/models/stored-payment-method-resource.md).

## Example Usage

```csharp
StoredPaymentMethodRequest body = new StoredPaymentMethodRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    PaymentMethod = new PaymentMethodToStore1
    {
        EncryptedCardNumber = "test_4111111111111111",
        EncryptedExpiryMonth = "test_03",
        EncryptedExpiryYear = "test_2030",
        EncryptedSecurityCode = "test_737",
        HolderName = "John Smith",
        Type = "scheme",
    },
    RecurringProcessingModel = RecurringProcessingModel1.Subscription,
    ShopperReference = "YOUR_SHOPPER_REFERENCE",
    ShopperEmail = "s.hopper@test.com",
    ShopperIp = "192.0.2.1",
};

try
{
    ApiResponse<StoredPaymentMethodResource> result = await recurringApi.CreateStoredPaymentMethodAsync(
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
  "expiryMonth": "03",
  "expiryYear": "2030",
  "holderName": "John Smith",
  "id": "KHQC5N7G84BLNK43",
  "lastFour": "1111",
  "shopperReference": "YOUR_SHOPPER_REFERENCE",
  "type": "scheme"
}
```


# Delete Stored Payment Method

Deletes the token identified in the path. The token can no longer be used with payment requests.

```csharp
DeleteStoredPaymentMethodAsync(
    string storedPaymentMethodId,
    string shopperReference,
    string merchantAccount)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storedPaymentMethodId` | `string` | Template, Required | The unique identifier of the token. |
| `shopperReference` | `string` | Query, Required | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address. |
| `merchantAccount` | `string` | Query, Required | Your merchant account. |

## Response Type

`Task`

## Example Usage

```csharp
string storedPaymentMethodId = "storedPaymentMethodId4";
string shopperReference = "shopperReference8";
string merchantAccount = "merchantAccount8";
try
{
    await recurringApi.DeleteStoredPaymentMethodAsync(
        storedPaymentMethodId,
        shopperReference,
        merchantAccount
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

