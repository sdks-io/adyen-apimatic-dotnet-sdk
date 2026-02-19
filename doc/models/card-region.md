
# Card Region

The card region condition that determines whether the [split logic](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId)/splitConfigurations#request-rules-splitLogic) applies to the transaction.

> This condition is in pilot phase, and not yet available for all platforms.

Possible values:

* **domestic**: The card issuer and the store where the transaction is processed are registered in the same country.
* **international**: The card issuer and the store where the transaction is processed are registered in different countries or regions. Includes all **interRegional** and **intraRegional** transactions.
* **interRegional**: The card issuer and the store where the transaction is processed are registered in different regions.
* **intraRegional**: The card issuer and the store where the transaction is processed are registered in different countries, but in the same region.
* **ANY**: Applies to all transactions, regardless of the processing and issuing country/region.

## Enumeration

`CardRegion`

## Fields

| Name |
|  --- |
| `International` |
| `IntraRegional` |
| `InterRegional` |
| `Domestic` |
| `Any` |

