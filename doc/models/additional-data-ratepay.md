
# Additional Data Ratepay

## Structure

`AdditionalDataRatepay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RatepayInstallmentAmount` | `string` | Optional | Amount the customer has to pay each month. |
| `RatepayInterestRate` | `string` | Optional | Interest rate of this installment. |
| `RatepayLastInstallmentAmount` | `string` | Optional | Amount of the last installment. |
| `RatepayPaymentFirstday` | `string` | Optional | Calendar day of the first payment. |
| `RatepaydataDeliveryDate` | `string` | Optional | Date the merchant delivered the goods to the customer. |
| `RatepaydataDueDate` | `string` | Optional | Date by which the customer must settle the payment. |
| `RatepaydataInvoiceDate` | `string` | Optional | Invoice date, defined by the merchant. If not included, the invoice date is set to the delivery date. |
| `RatepaydataInvoiceId` | `string` | Optional | Identification name or number for the invoice, defined by the merchant. |

## Example (as JSON)

```json
{
  "ratepay.installmentAmount": "ratepay.installmentAmount4",
  "ratepay.interestRate": "ratepay.interestRate8",
  "ratepay.lastInstallmentAmount": "ratepay.lastInstallmentAmount0",
  "ratepay.paymentFirstday": "ratepay.paymentFirstday2",
  "ratepaydata.deliveryDate": "ratepaydata.deliveryDate2"
}
```

