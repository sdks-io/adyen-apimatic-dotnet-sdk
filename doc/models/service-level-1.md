
# Service Level 1

Specifies the service level (settlement type) of this payment method. Required for merchants operating in Japan. Possible values:

* **noContract**: Adyen holds the contract with JCB.
* **gatewayContract**: JCB receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.

## Enumeration

`ServiceLevel1`

## Fields

| Name |
|  --- |
| `NoContract` |
| `GatewayContract` |

