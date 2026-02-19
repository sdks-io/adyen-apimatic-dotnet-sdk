
# Payment Method Response

## Structure

`PaymentMethodResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Links` | [`PaginationLinks1`](../../doc/models/pagination-links-1.md) | Optional | Pagination references. |
| `Data` | [`List<PaymentMethod1>`](../../doc/models/payment-method-1.md) | Optional | The list of supported payment methods and their details. |
| `ItemsTotal` | `int` | Required | Total number of items. |
| `PagesTotal` | `int` | Required | Total number of pages. |
| `TypesWithErrors` | [`List<TypesWithError>`](../../doc/models/types-with-error.md) | Optional | The payment method types that were not successfully requested and their corresponding errors. |

## Example (as JSON)

```json
{
  "_links": {
    "first": {
      "href": "href2"
    },
    "last": {
      "href": "href2"
    },
    "next": {
      "href": "href4"
    },
    "prev": {
      "href": "href8"
    },
    "self": {
      "href": "href0"
    }
  },
  "data": [
    {
      "accel": {
        "processingType": "billpay",
        "transactionDescription": {
          "doingBusinessAsName": "doingBusinessAsName0",
          "type": "fixed"
        }
      },
      "affirm": {
        "pricePlan": "BRONZE",
        "supportEmail": "supportEmail2"
      },
      "afterpayTouch": {
        "supportEmail": "supportEmail8",
        "supportUrl": "supportUrl4"
      },
      "alipayPlus": {
        "settlementCurrencyCode": "settlementCurrencyCode0"
      },
      "allowed": false,
      "id": "id0"
    },
    {
      "accel": {
        "processingType": "billpay",
        "transactionDescription": {
          "doingBusinessAsName": "doingBusinessAsName0",
          "type": "fixed"
        }
      },
      "affirm": {
        "pricePlan": "BRONZE",
        "supportEmail": "supportEmail2"
      },
      "afterpayTouch": {
        "supportEmail": "supportEmail8",
        "supportUrl": "supportUrl4"
      },
      "alipayPlus": {
        "settlementCurrencyCode": "settlementCurrencyCode0"
      },
      "allowed": false,
      "id": "id0"
    }
  ],
  "itemsTotal": 90,
  "pagesTotal": 52,
  "typesWithErrors": [
    "vpay",
    "wechatpay",
    "wechatpay_pos"
  ]
}
```

