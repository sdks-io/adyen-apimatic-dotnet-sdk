
# Filter Merchant Account Type

Shows how merchant accounts are filtered when configuring the webhook.

Possible values:

* **allAccounts** : Includes all merchant accounts, and does not require specifying `filterMerchantAccounts`.
* **includeAccounts** : The webhook is configured for the merchant accounts listed in `filterMerchantAccounts`.
* **excludeAccounts** : The webhook is not configured for the merchant accounts listed in `filterMerchantAccounts`.

## Enumeration

`FilterMerchantAccountType`

## Fields

| Name |
|  --- |
| `AllAccounts` |
| `ExcludeAccounts` |
| `IncludeAccounts` |

