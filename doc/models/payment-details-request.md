
# Payment Details Request

## Structure

`PaymentDetailsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthenticationData` | [`DetailsRequestAuthenticationData1`](../../doc/models/details-request-authentication-data-1.md) | Optional | Data for 3DS authentication. |
| `Details` | [`PaymentCompletionDetails1`](../../doc/models/payment-completion-details-1.md) | Required | Use this collection to submit the details that were returned as a result of the `/payments` call. |
| `PaymentData` | `string` | Optional | Encoded payment data. For [authorizing a payment after using 3D Secure 2 Authentication-only](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only/#authorise-the-payment-with-adyen):<br><br>If you received `resultCode`: **AuthenticationNotRequired** in the `/payments` response, use the `threeDSPaymentData` from the same response.<br><br>If you received `resultCode`: **AuthenticationFinished** in the `/payments` response, use the `action.paymentData` from the same response.<br><br>**Constraints**: *Maximum Length*: `200000` |
| `ThreeDsAuthenticationOnly` | `bool?` | Optional | Change the `authenticationOnly` indicator originally set in the `/payments` request. Only needs to be set if you want to modify the value set previously. |

## Example (as JSON)

```json
{
  "authenticationData": {
    "authenticationOnly": false
  },
  "details": {
    "MD": "MD4",
    "PaReq": "PaReq0",
    "PaRes": "PaRes0",
    "authorization_token": "authorization_token4",
    "billingToken": "billingToken2"
  },
  "paymentData": "paymentData8",
  "threeDSAuthenticationOnly": false
}
```

