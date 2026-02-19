
# Split

## Structure

`Split`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Account` | `string` | Optional | The unique identifier of the account to which the split amount is booked. Required if `type` is **MarketPlace** or **BalanceAccount**.<br><br>* [Classic Platforms integration](https://docs.adyen.com/classic-platforms): The [`accountCode`](https://docs.adyen.com/api-explorer/Account/latest/post/updateAccount#request-accountCode) of the account to which the split amount is booked.<br>* [Balance Platform](https://docs.adyen.com/adyen-for-platforms-model): The [`balanceAccountId`](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/balanceAccounts/_id_#path-id) of the account to which the split amount is booked. |
| `Amount` | [`SplitAmount2`](../../doc/models/split-amount-2.md) | Optional | The amount of the split item.<br><br>* Required for all split types in the [Classic Platforms integration](https://docs.adyen.com/classic-platforms).<br>* Required if `type` is **BalanceAccount**, **Commission**, **Surcharge**, **Default**, or **VAT** in your [Balance Platform](https://docs.adyen.com/adyen-for-platforms-model) integration. |
| `Description` | `string` | Optional | Your description for the split item. |
| `Reference` | `string` | Optional | Your unique reference for the part of the payment booked to the specified `account`.<br><br>This is required if `type` is **MarketPlace** ([Classic Platforms integration](https://docs.adyen.com/classic-platforms)) or **BalanceAccount** ([Balance Platform](https://docs.adyen.com/adyen-for-platforms-model)).<br><br>For the other types, we also recommend providing a **unique** reference so you can reconcile the split and the associated payment in the transaction overview and in the reports. |
| `Type` | [`Type9`](../../doc/models/type-9.md) | Required | The part of the payment you want to book to the specified `account`.<br><br>Possible values for the [Balance Platform](https://docs.adyen.com/adyen-for-platforms-model):<br><br>* **BalanceAccount**: Books part of the payment (specified in `amount`) to the specified `account`.<br>* Transaction fees types that you can book to the specified `account`:<br>  * **AcquiringFees**: The aggregated amount of the interchange and scheme fees.<br>  * **PaymentFee**: The aggregated amount of all transaction fees.<br>  * **AdyenFees**: The aggregated amount of Adyen's commission and markup fees.<br>  * **AdyenCommission**: The transaction fees due to Adyen under [blended rates](https://www.adyen.com/knowledge-hub/interchange-fees-explained).<br>  * **AdyenMarkup**: The transaction fees due to Adyen under [Interchange ++ pricing](https://www.adyen.com/knowledge-hub/interchange-fees-explained).<br>  * **Interchange**: The fees paid to the issuer for each payment made with the card network.<br>  * **SchemeFee**: The fees paid to the card scheme for using their network.<br>* **Commission**: Your platform's commission on the payment (specified in `amount`), booked to your liable balance account.<br>* **Remainder**: The amount left over after a currency conversion, booked to the specified `account`.<br>* **Surcharge**: The payment acceptance fee imposed by the card scheme or debit network provider, paid by your user's customer.<br>* **TopUp**: Allows you and your users to top up balance accounts using direct debit, card payments, or other payment methods.<br>* **VAT**: The value-added tax charged on the payment, booked to your platforms liable balance account.<br>* **Default**: In very specific use cases, allows you to book the specified `amount` to the specified `account`. For more information, contact Adyen support.<br><br>Possible values for the [Classic Platforms integration](https://docs.adyen.com/classic-platforms): **Commission**, **Default**, **MarketPlace**, **PaymentFee**, **VAT**. |

## Example (as JSON)

```json
{
  "account": "account0",
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "description": "description0",
  "reference": "reference6",
  "type": "AdyenFees"
}
```

