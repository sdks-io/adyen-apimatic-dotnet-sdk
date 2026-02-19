
# Session Result Response

## Structure

`SessionResultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | Contains additional information about the payment. Some fields are included only if you enable them. To enable these fields in your Customer Area, go to **Developers** > **Additional data**. |
| `Id` | `string` | Optional | A unique identifier of the session. |
| `Payments` | [`List<Payment>`](../../doc/models/payment.md) | Optional | A list of all authorised payments done for this session. |
| `Reference` | `string` | Optional | The unique reference that you provided in the original `/sessions` request. This identifies the payment and is used in all communication with you about the payment status. |
| `Status` | [`Status4?`](../../doc/models/status-4.md) | Optional | The status of the session. The status included in the response doesn't get updated. Don't make the request again to check for payment status updates.<br><br>Possible values:<br><br>* **completed**: the shopper completed the payment, and the payment was authorized.<br>* **paymentPending**: the shopper is in the process of making the payment. This applies to payment methods with an asynchronous flow, like voucher payments where the shopper completes the payment in a physical shop.<br>* **refused**: the session has been refused, because of too many refused payment attempts. The shopper can no longer complete the payment with this session.<br>* **canceled**: the shopper canceled the payment.<br>* **expired**: the session expired. The shopper can no longer complete the payment with this session. By default, the session expires one hour after it is created. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData4"
  },
  "id": "id6",
  "payments": [
    {
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "paymentMethod": {
        "brand": "brand6",
        "type": "type8"
      },
      "pspReference": "pspReference6",
      "resultCode": "Pending"
    },
    {
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "paymentMethod": {
        "brand": "brand6",
        "type": "type8"
      },
      "pspReference": "pspReference6",
      "resultCode": "Pending"
    }
  ],
  "reference": "reference8",
  "status": "paymentPending"
}
```

