
# Terminal Reassignment Target 2

Indicates where the terminal is in the process of being reassigned to.

## Structure

`TerminalReassignmentTarget2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CompanyId` | `string` | Optional | The unique identifier of the company account to which the terminal is reassigned. |
| `Inventory` | `bool` | Required | Indicates if the terminal is reassigned to the inventory of the merchant account.<br><br>- If **true**, the terminal is in the inventory of the merchant account and cannot process transactions.<br>- If **false**, the terminal is reassigned directly to the merchant account and can process transactions. |
| `MerchantId` | `string` | Optional | The unique identifier of the merchant account to which the terminal is reassigned. |
| `StoreId` | `string` | Optional | The unique identifier of the store to which the terminal is reassigned. |

## Example (as JSON)

```json
{
  "companyId": "companyId8",
  "inventory": false,
  "merchantId": "merchantId4",
  "storeId": "storeId8"
}
```

