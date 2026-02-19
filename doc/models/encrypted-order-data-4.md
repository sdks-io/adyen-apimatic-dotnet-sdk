
# Encrypted Order Data 4

The order request object that contains a pspReference that represents the order and the matching encrypted order data.

## Structure

`EncryptedOrderData4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OrderData` | `string` | Required | The encrypted order data.<br><br>**Constraints**: *Maximum Length*: `5000` |
| `PspReference` | `string` | Required | The `pspReference` that belongs to the order. |

## Example (as JSON)

```json
{
  "orderData": "orderData6",
  "pspReference": "pspReference6"
}
```

