
# Recurring Processing Model 4

Defines a recurring payment type. Required when `storePaymentMethodMode` is set to **askForConsent** or **enabled**.
Possible values:

* **Subscription** – A transaction for a fixed or variable amount, which follows a fixed schedule.
* **CardOnFile** – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
* **UnscheduledCardOnFile** – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.

## Enumeration

`RecurringProcessingModel4`

## Fields

| Name |
|  --- |
| `CardOnFile` |
| `Subscription` |
| `UnscheduledCardOnFile` |

