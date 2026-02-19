
# Payment

## Structure

`Payment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount25`](../../doc/models/amount-25.md) | Optional | Authorised amount in the transaction. |
| `PaymentMethod` | [`PaymentResponse3`](../../doc/models/payment-response-3.md) | Optional | Only returned for `resultCode`: **Authorised**.<br>Details about the payment method used in the transaction. |
| `PspReference` | `string` | Optional | Adyen's 16-character reference associated with the transaction/request. This value is globally unique. Use this reference when you communicate with us about this request. |
| `ResultCode` | [`ResultCode2?`](../../doc/models/result-code-2.md) | Optional | The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).<br><br>Possible values:<br><br>* **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state.<br>* **Received** – Indicates the payment request was successfully received by Adyen, and will be processed. This is the initial state for all payments.<br>* **Pending** – The payment order was successfully received but the final status of the payment is not available yet. This is common for payment methods with an asynchronous flow. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "paymentMethod": {
    "brand": "brand6",
    "type": "type8"
  },
  "pspReference": "pspReference0",
  "resultCode": "Received"
}
```

