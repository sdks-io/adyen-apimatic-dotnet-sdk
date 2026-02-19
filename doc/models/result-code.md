
# Result Code

The result of the cancellation request.

Possible values:

* **Success** – Indicates that the balance check was successful.
* **NotEnoughBalance** – Commonly indicates that the card did not have enough balance to pay the amount in the request, or that the currency of the balance on the card did not match the currency of the requested amount.
* **Failed** – Indicates that the balance check failed.

## Enumeration

`ResultCode`

## Fields

| Name |
|  --- |
| `Success` |
| `NotEnoughBalance` |
| `Failed` |

