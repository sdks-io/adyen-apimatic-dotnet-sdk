
# Shopper Tax Info

## Structure

`ShopperTaxInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TaxId` | `string` | Required | The tax-id of the shopper doing the transaction.<br><br>**Constraints**: *Maximum Length*: `10` |
| `TaxIdCountryCode` | `string` | Required | The country to which the tax-id belongs to.<br><br>**Constraints**: *Maximum Length*: `2` |

## Example (as JSON)

```json
{
  "taxId": "taxId6",
  "taxIdCountryCode": "taxIdCountryCode2"
}
```

