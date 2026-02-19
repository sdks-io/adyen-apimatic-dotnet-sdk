
# Installments 2

Contains installment settings. For more information, refer to [Installments](https://docs.adyen.com/payment-methods/cards/credit-card-installments).

## Structure

`Installments2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Extra` | `int?` | Optional | Defines the bonus percentage, refund percentage or if the transaction is Buy now Pay later.<br>Used for [card installments in Mexico](https://docs.adyen.com/payment-methods/cards/credit-card-installments/#getting-paid-mexico) |
| `Plan` | [`Plan?`](../../doc/models/plan.md) | Optional | The installment plan, used for [card installments in Japan](https://docs.adyen.com/payment-methods/cards/credit-card-installments#make-a-payment-japan).<br>and [Mexico](https://docs.adyen.com/payment-methods/cards/credit-card-installments/#getting-paid-mexico).<br>By default, this is set to **regular**. |
| `MValue` | `int` | Required | Defines the number of installments.<br>Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary.<br>This value can be zero for Installments processed in Mexico. |

## Example (as JSON)

```json
{
  "extra": 62,
  "plan": "nointeres_refund_prctg",
  "value": 46
}
```

