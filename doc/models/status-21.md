
# Status 21

The status of the reassignment. Possible values:

* `reassignmentInProgress`: the terminal was boarded and is now scheduled to remove the configuration. Wait for the terminal to synchronize with the Adyen platform.
* `deployed`: the terminal is deployed and reassigned.
* `inventory`: the terminal is in inventory and cannot process transactions.
* `boarded`: the terminal is boarded to a store, or a merchant account representing a store, and can process transactions.

## Enumeration

`Status21`

## Fields

| Name |
|  --- |
| `Boarded` |
| `Deployed` |
| `Inventory` |
| `ReassignmentInProgress` |

