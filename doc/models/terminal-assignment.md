
# Terminal Assignment

## Structure

`TerminalAssignment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CompanyId` | `string` | Required | The unique identifier of the company account to which terminal is assigned. |
| `MerchantId` | `string` | Optional | The unique identifier of the merchant account to which terminal is assigned. |
| `ReassignmentTarget` | [`TerminalReassignmentTarget2`](../../doc/models/terminal-reassignment-target-2.md) | Optional | Indicates where the terminal is in the process of being reassigned to. |
| `Status` | [`Status21`](../../doc/models/status-21.md) | Required | The status of the reassignment. Possible values:<br><br>* `reassignmentInProgress`: the terminal was boarded and is now scheduled to remove the configuration. Wait for the terminal to synchronize with the Adyen platform.<br>* `deployed`: the terminal is deployed and reassigned.<br>* `inventory`: the terminal is in inventory and cannot process transactions.<br>* `boarded`: the terminal is boarded to a store, or a merchant account representing a store, and can process transactions. |
| `StoreId` | `string` | Optional | The unique identifier of the store to which terminal is assigned. |

## Example (as JSON)

```json
{
  "companyId": "companyId8",
  "merchantId": "merchantId4",
  "reassignmentTarget": {
    "companyId": "companyId4",
    "inventory": false,
    "merchantId": "merchantId0",
    "storeId": "storeId8"
  },
  "status": "boarded",
  "storeId": "storeId8"
}
```

