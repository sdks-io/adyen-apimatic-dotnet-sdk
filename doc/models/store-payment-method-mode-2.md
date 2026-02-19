
# Store Payment Method Mode 2

Indicates if the details of the payment method will be stored for the shopper. Possible values:

* **disabled** – No details will be stored (default).
* **askForConsent** – If the `shopperReference` is provided, the Drop-in/Component shows a checkbox where the shopper can select to store their payment details for card payments.
* **enabled** – If the `shopperReference` is provided, the details will be stored without asking the shopper for consent.
  When set to **askForConsent** or **enabled**, you must also include the `recurringProcessingModel` parameter.

## Enumeration

`StorePaymentMethodMode2`

## Fields

| Name |
|  --- |
| `AskForConsent` |
| `Disabled` |
| `Enabled` |

