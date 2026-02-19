
# Amex Info 1

Details to provide if `type` is **amex**.

## Structure

`AmexInfo1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MidNumber` | `string` | Optional | Merchant ID (MID) number. Format: 10 numeric characters.<br>You must provide this field when you request `gatewayContract` or `paymentDesignatorContract` service levels.<br><br>**Constraints**: *Maximum Length*: `10` |
| `ReuseMidNumber` | `bool?` | Optional | Indicates whether the Amex Merchant ID is reused from a previously setup Amex payment method.<br>This is only applicable for `gatewayContract` and `paymentDesignatorContract` service levels.<br>The default value is **false**.<br><br>**Default**: `false` |
| `ServiceLevel` | [`ServiceLevel`](../../doc/models/service-level.md) | Required | Specifies the service level (settlement type) of this payment method. Possible values:<br><br>* **noContract**: Adyen holds the contract with American Express.<br>* **gatewayContract**: American Express receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.<br>* **paymentDesignatorContract**: Adyen receives the settlement, and handles disputes and payouts. |

## Example (as JSON)

```json
{
  "reuseMidNumber": false,
  "serviceLevel": "gatewayContract",
  "midNumber": "midNumber2"
}
```

