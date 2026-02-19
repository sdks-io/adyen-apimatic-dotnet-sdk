
# Response Additional Data Installments

## Structure

`ResponseAdditionalDataInstallments`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InstallmentPaymentDataInstallmentType` | `string` | Optional | Type of installment. The value of `installmentType` should be **IssuerFinanced**. |
| `InstallmentPaymentDataOptionItemNrAnnualPercentageRate` | `string` | Optional | Annual interest rate. |
| `InstallmentPaymentDataOptionItemNrFirstInstallmentAmount` | `string` | Optional | First Installment Amount in minor units. |
| `InstallmentPaymentDataOptionItemNrInstallmentFee` | `string` | Optional | Installment fee amount in minor units. |
| `InstallmentPaymentDataOptionItemNrInterestRate` | `string` | Optional | Interest rate for the installment period. |
| `InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments` | `string` | Optional | Maximum number of installments possible for this payment. |
| `InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments` | `string` | Optional | Minimum number of installments possible for this payment. |
| `InstallmentPaymentDataOptionItemNrNumberOfInstallments` | `string` | Optional | Total number of installments possible for this payment. |
| `InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount` | `string` | Optional | Subsequent Installment Amount in minor units. |
| `InstallmentPaymentDataOptionItemNrTotalAmountDue` | `string` | Optional | Total amount in minor units. |
| `InstallmentPaymentDataPaymentOptions` | `string` | Optional | Possible values:<br><br>* PayInInstallmentsOnly<br>* PayInFullOnly<br>* PayInFullOrInstallments |
| `InstallmentsValue` | `string` | Optional | The number of installments that the payment amount should be charged with.<br><br>Example: 5<br><br>> Only relevant for card payments in countries that support installments. |

## Example (as JSON)

```json
{
  "installmentPaymentData.installmentType": "installmentPaymentData.installmentType8",
  "installmentPaymentData.option[itemNr].annualPercentageRate": "installmentPaymentData.option[itemNr].annualPercentageRate2",
  "installmentPaymentData.option[itemNr].firstInstallmentAmount": "installmentPaymentData.option[itemNr].firstInstallmentAmount6",
  "installmentPaymentData.option[itemNr].installmentFee": "installmentPaymentData.option[itemNr].installmentFee8",
  "installmentPaymentData.option[itemNr].interestRate": "installmentPaymentData.option[itemNr].interestRate4"
}
```

