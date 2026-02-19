
# Encrypted Order Data

## Structure

`EncryptedOrderData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OrderData` | `string` | Required | The encrypted order data.<br><br>**Constraints**: *Maximum Length*: `5000` |
| `PspReference` | `string` | Required | The `pspReference` that belongs to the order. |

## Example (as JSON)

```json
{
  "orderData": "orderData0",
  "pspReference": "pspReference0"
}
```

