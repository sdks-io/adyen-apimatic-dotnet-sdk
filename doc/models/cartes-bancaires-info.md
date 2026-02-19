
# Cartes Bancaires Info

## Structure

`CartesBancairesInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Siret` | `string` | Required | Cartes Bancaires SIRET. Format: 14 digits. |
| `TransactionDescription` | [`TransactionDescriptionInfo1`](../../doc/models/transaction-description-info-1.md) | Optional | Information regarding the transaction description.<br><br>> You cannot configure the transaction description in the test environment. |

## Example (as JSON)

```json
{
  "siret": "siret6",
  "transactionDescription": {
    "doingBusinessAsName": "doingBusinessAsName0",
    "type": "fixed"
  }
}
```

