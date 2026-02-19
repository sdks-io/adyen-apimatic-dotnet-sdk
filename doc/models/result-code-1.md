
# Result Code 1

The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).

Possible values:

* **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions.
* **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only).
* **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state.
* **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state.
* **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions.
* **Error** – There was an error when the payment was being processed. The reason is given in the `refusalReason` field. This is a final state.
* **IdentifyShopper** – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions.
* **PartiallyAuthorised** – The payment has been authorised for a partial amount.
  This happens for card payments when the merchant supports Partial Authorisations and the cardholder has insufficient funds.
* **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment.
* **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment.
* **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments.
* **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation.
* **Refused** – Indicates the payment was refused. The reason is given in the `refusalReason` field. This is a final state.

## Enumeration

`ResultCode1`

## Fields

| Name |
|  --- |
| `AuthenticationFinished` |
| `AuthenticationNotRequired` |
| `Authorised` |
| `Cancelled` |
| `ChallengeShopper` |
| `Error` |
| `IdentifyShopper` |
| `PartiallyAuthorised` |
| `Pending` |
| `PresentToShopper` |
| `Received` |
| `RedirectShopper` |
| `Refused` |
| `Success` |

