
# Additional Data Risk

## Structure

`AdditionalDataRisk`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RiskdataCustomFieldName` | `string` | Optional | The data for your custom risk field. For more information, refer to [Create custom risk fields](https://docs.adyen.com/risk-management/configure-custom-risk-rules#step-1-create-custom-risk-fields). |
| `RiskdataBasketItemItemNrAmountPerItem` | `string` | Optional | The price of item in the basket, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes). |
| `RiskdataBasketItemItemNrBrand` | `string` | Optional | Brand of the item. |
| `RiskdataBasketItemItemNrCategory` | `string` | Optional | Category of the item. |
| `RiskdataBasketItemItemNrColor` | `string` | Optional | Color of the item. |
| `RiskdataBasketItemItemNrCurrency` | `string` | Optional | The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217). |
| `RiskdataBasketItemItemNrItemId` | `string` | Optional | ID of the item. |
| `RiskdataBasketItemItemNrManufacturer` | `string` | Optional | Manufacturer of the item. |
| `RiskdataBasketItemItemNrProductTitle` | `string` | Optional | A text description of the product the invoice line refers to. |
| `RiskdataBasketItemItemNrQuantity` | `string` | Optional | Quantity of the item purchased. |
| `RiskdataBasketItemItemNrReceiverEmail` | `string` | Optional | Email associated with the given product in the basket (usually in electronic gift cards). |
| `RiskdataBasketItemItemNrSize` | `string` | Optional | Size of the item. |
| `RiskdataBasketItemItemNrSku` | `string` | Optional | [Stock keeping unit](https://en.wikipedia.org/wiki/Stock_keeping_unit). |
| `RiskdataBasketItemItemNrUpc` | `string` | Optional | [Universal Product Code](https://en.wikipedia.org/wiki/Universal_Product_Code). |
| `RiskdataPromotionsPromotionItemNrPromotionCode` | `string` | Optional | Code of the promotion. |
| `RiskdataPromotionsPromotionItemNrPromotionDiscountAmount` | `string` | Optional | The discount amount of the promotion, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes). |
| `RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency` | `string` | Optional | The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217). |
| `RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage` | `string` | Optional | Promotion's percentage discount. It is represented in percentage value and there is no need to include the '%' sign.<br><br>e.g. for a promotion discount of 30%, the value of the field should be 30. |
| `RiskdataPromotionsPromotionItemNrPromotionName` | `string` | Optional | Name of the promotion. |
| `RiskdataRiskProfileReference` | `string` | Optional | Reference number of the risk profile that you want to apply to the payment. If not provided or left blank, the merchant-level account's default risk profile will be applied to the payment. For more information, see [dynamically assign a risk profile to a payment](https://docs.adyen.com/risk-management/create-and-use-risk-profiles#dynamically-assign-a-risk-profile-to-a-payment). |
| `RiskdataSkipRisk` | `string` | Optional | If this parameter is provided with the value **true**, risk checks for the payment request are skipped and the transaction will not get a risk score. |

## Example (as JSON)

```json
{
  "riskdata.[customFieldName]": "riskdata.[customFieldName]8",
  "riskdata.basket.item[itemNr].amountPerItem": "riskdata.basket.item[itemNr].amountPerItem6",
  "riskdata.basket.item[itemNr].brand": "riskdata.basket.item[itemNr].brand0",
  "riskdata.basket.item[itemNr].category": "riskdata.basket.item[itemNr].category8",
  "riskdata.basket.item[itemNr].color": "riskdata.basket.item[itemNr].color6"
}
```

