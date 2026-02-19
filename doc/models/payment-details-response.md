
# Payment Details Response

## Structure

`PaymentDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | [`CheckoutThreeDs2Action`](../../doc/models/checkout-three-ds-2-action.md) | Optional | Action to be taken for completing the payment. When returned, only the 3D Secure action is needed in most cases. |
| `AdditionalData` | `Dictionary<string, string>` | Optional | Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** > **Developers** > **Additional data**. |
| `Amount` | [`Amount25`](../../doc/models/amount-25.md) | Optional | Authorised amount in the transaction. |
| `DonationToken` | `string` | Optional | Donation Token containing payment details for Adyen Giving. |
| `FraudResult` | [`FraudResult1`](../../doc/models/fraud-result-1.md) | Optional | The fraud result properties of the payment. |
| `MerchantReference` | `string` | Optional | The reference used during the /payments request. |
| `Order` | [`CheckoutOrderResponse1`](../../doc/models/checkout-order-response-1.md) | Optional | Contains updated information regarding the order in case order information was provided in the request. |
| `PaymentMethod` | [`PaymentResponse1`](../../doc/models/payment-response-1.md) | Optional | Details about the payment method used in the transaction.<br>Only returned if `resultCode` is **Authorised**. |
| `PaymentValidations` | [`PaymentResponse2`](../../doc/models/payment-response-2.md) | Optional | The object that contains the validation outcomes.<br>Only returned if `resultCode` is **Authorised** and if you have requested a payment validation in the request. |
| `PspReference` | `string` | Optional | Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request. |
| `RefusalReason` | `string` | Optional | If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes `resultCode` and `refusalReason` values.<br><br>For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons). |
| `RefusalReasonCode` | `string` | Optional | Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons). |
| `ResultCode` | [`ResultCode1?`](../../doc/models/result-code-1.md) | Optional | The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).<br><br>Possible values:<br><br>* **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions.<br>* **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only).<br>* **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state.<br>* **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state.<br>* **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions.<br>* **Error** – There was an error when the payment was being processed. The reason is given in the `refusalReason` field. This is a final state.<br>* **IdentifyShopper** – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions.<br>* **PartiallyAuthorised** – The payment has been authorised for a partial amount.<br>  This happens for card payments when the merchant supports Partial Authorisations and the cardholder has insufficient funds.<br>* **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment.<br>* **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment.<br>* **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments.<br>* **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation.<br>* **Refused** – Indicates the payment was refused. The reason is given in the `refusalReason` field. This is a final state. |
| `ShopperLocale` | `string` | Optional | The shopperLocale. |
| `ThreeDs2ResponseData` | [`ThreeDs2ResponseData1`](../../doc/models/three-ds-2-response-data-1.md) | Optional | Response of the 3D Secure 2 authentication. |
| `ThreeDs2Result` | [`ThreeDs2Result1`](../../doc/models/three-ds-2-result-1.md) | Optional | Result of the 3D Secure 2 authentication. |
| `ThreeDsPaymentData` | `string` | Optional | When non-empty, contains a value that you must submit to the `/payments/details` endpoint as `paymentData`. |

## Example (as JSON)

```json
{
  "action": {
    "authorisationToken": "authorisationToken6",
    "paymentData": "paymentData4",
    "paymentMethodType": "paymentMethodType4",
    "subtype": "subtype4",
    "token": "token6",
    "type": "type2"
  },
  "additionalData": {
    "key0": "additionalData2",
    "key1": "additionalData3"
  },
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "donationToken": "donationToken4",
  "fraudResult": {
    "accountScore": 232,
    "results": [
      {
        "accountScore": 102,
        "checkId": 246,
        "name": "name6"
      },
      {
        "accountScore": 102,
        "checkId": 246,
        "name": "name6"
      }
    ]
  }
}
```

