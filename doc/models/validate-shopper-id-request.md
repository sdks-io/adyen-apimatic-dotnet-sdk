
# Validate Shopper Id Request

*This model accepts additional fields of type object.*

## Structure

`ValidateShopperIdRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the transaction.<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `1000` |
| `PaymentMethod` | [`ShopperIdPaymentMethod1`](../../doc/models/shopper-id-payment-method-1.md) | Required | paymentMethod |
| `ShopperEmail` | `string` | Optional | **Constraints**: *Minimum Length*: `0`, *Maximum Length*: `300` |
| `ShopperIp` | `string` | Optional | **Constraints**: *Minimum Length*: `0`, *Maximum Length*: `15` |
| `ShopperReference` | `string` | Optional | **Constraints**: *Minimum Length*: `0`, *Maximum Length*: `256` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "merchantAccount": "merchantAccount8",
  "paymentMethod": {
    "type": "ShopperIdPaymentMethod1",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "shopperEmail": "shopperEmail0",
  "shopperIP": "shopperIP4",
  "shopperReference": "shopperReference4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

