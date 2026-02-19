
# Transaction Description Info 1

Information regarding the transaction description.

> You cannot configure the transaction description in the test environment.

## Structure

`TransactionDescriptionInfo1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DoingBusinessAsName` | `string` | Optional | The text to be shown on the shopper's bank statement.<br>We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.<br>Allowed characters: **a-z**, **A-Z**, **0-9**, spaces, and special characters **. , ' _ - ? + * /**.<br><br>**Constraints**: *Maximum Length*: `22` |
| `Type` | [`Type7?`](../../doc/models/type-7.md) | Optional | The type of transaction description you want to use:<br><br>- **fixed**: The transaction description set in this request is used for all payments with this payment method.<br>- **append**: The transaction description set in this request is used as a base for all payments with this payment method. The [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is appended to this base description. Note that if the combined length exceeds 22 characters, banks may truncate the string.<br>- **dynamic**: Only the [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is used for payments with this payment method.<br><br>**Default**: `Type7.dynamic` |

## Example (as JSON)

```json
{
  "type": "dynamic",
  "doingBusinessAsName": "doingBusinessAsName4"
}
```

