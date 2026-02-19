
# Payment Method 1

## Structure

`PaymentMethod1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accel` | [`AccelInfo1`](../../doc/models/accel-info-1.md) | Optional | Details to provide if `type` is **accel**. |
| `Affirm` | [`AffirmInfo1`](../../doc/models/affirm-info-1.md) | Optional | Details to provide if `type` is **affirm**. |
| `AfterpayTouch` | [`AfterpayTouchInfo1`](../../doc/models/afterpay-touch-info-1.md) | Optional | Details to provide if `type` is **afterpaytouch**. |
| `AlipayPlus` | [`AlipayPlusInfo1`](../../doc/models/alipay-plus-info-1.md) | Optional | Details to provide if `type` is **alipay_plus**. |
| `Allowed` | `bool?` | Optional | Indicates whether receiving payments is allowed. This value is set to **true** by Adyen after screening your merchant account. |
| `Amex` | [`AmexInfo1`](../../doc/models/amex-info-1.md) | Optional | Details to provide if `type` is **amex**. |
| `ApplePay` | [`ApplePayInfo1`](../../doc/models/apple-pay-info-1.md) | Optional | Details to provide if `type` is **applepay**. |
| `Bcmc` | [`BcmcInfo1`](../../doc/models/bcmc-info-1.md) | Optional | Details to provide if `type` is **bcmc** (Bancontact). |
| `BusinessLineId` | `string` | Optional | The unique identifier of the business line. Required if you are a [platform model](https://docs.adyen.com/platforms). |
| `CartesBancaires` | [`CartesBancairesInfo1`](../../doc/models/cartes-bancaires-info-1.md) | Optional | Details to provide if `type` is **cartebancaire**. |
| `Clearpay` | [`ClearpayInfo1`](../../doc/models/clearpay-info-1.md) | Optional | Details to provide if `type` is **clearpay**. |
| `Countries` | `List<string>` | Optional | The list of countries where a payment method is available. By default, all countries supported by the payment method. |
| `Cup` | [`GenericPmWithTdiInfo1`](../../doc/models/generic-pm-with-tdi-info-1.md) | Optional | Details to provide if `type` is **cup** (China Union Pay). |
| `Currencies` | `List<string>` | Optional | The list of currencies that a payment method supports. By default, all currencies supported by the payment method. |
| `CustomRoutingFlags` | `List<string>` | Optional | The list of custom routing flags to route payment to the intended acquirer. |
| `Diners` | [`DinersInfo1`](../../doc/models/diners-info-1.md) | Optional | Details to provide if `type` is **diners**.<br>For merchants operating in Japan, Diners payments are processed through the JCB network. This means that you must include [JCB-specific fields](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId)/paymentMethodSettings/(paymentMethodId)#request-jcb) in this object. |
| `Discover` | [`GenericPmWithTdiInfo2`](../../doc/models/generic-pm-with-tdi-info-2.md) | Optional | Details to provide if `type` is **discover**.<br>For merchants operating in Japan, request [Diners](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId)/paymentMethodSettings/(paymentMethodId)#request-diners) payment method instead. Discover is automatically requested, together with Diners. |
| `EftDirectdebitCa` | [`GenericPmWithTdiInfo3`](../../doc/models/generic-pm-with-tdi-info-3.md) | Optional | Details to provide if `type` is **eft_directdebit_CA** (EFT PAD). |
| `EftposAustralia` | [`GenericPmWithTdiInfo4`](../../doc/models/generic-pm-with-tdi-info-4.md) | Optional | Details to provide if `type` is **eftpos_australia**. |
| `Enabled` | `bool?` | Optional | Indicates whether the payment method is enabled (**true**) or disabled (**false**). |
| `Girocard` | [`GenericPmWithTdiInfo5`](../../doc/models/generic-pm-with-tdi-info-5.md) | Optional | Details to provide if `type` is **girocard**. |
| `Givex` | [`GivexInfo1`](../../doc/models/givex-info-1.md) | Optional | Details to provide if `type` is **givex**. |
| `GooglePay` | [`GooglePayInfo1`](../../doc/models/google-pay-info-1.md) | Optional | Details to provide if `type` is **googlepay**. |
| `Id` | `string` | Required | The identifier of the resource. |
| `Ideal` | [`GenericPmWithTdiInfo6`](../../doc/models/generic-pm-with-tdi-info-6.md) | Optional | Details to provide if `type` is **ideal**. |
| `InteracCard` | [`GenericPmWithTdiInfo7`](../../doc/models/generic-pm-with-tdi-info-7.md) | Optional | Details to provide if `type` is **interac_card**. |
| `Jcb` | [`JcbInfo1`](../../doc/models/jcb-info-1.md) | Optional | Details to provide if `type` is **jcb**.<br>For merchants operating in Japan, `midNumber`, `reuseMidNumber`, and `serviceLevel` fields are required.<br>For merchants operating outside of Japan, these fields are not required. |
| `Klarna` | [`KlarnaInfo1`](../../doc/models/klarna-info-1.md) | Optional | Details to provide if `type` is **klarna** or its variant.<br><br>You can use the following payment method `type` values for Klarna:<br><br>* **klarna**: Klarna Pay Later<br>* **klarna_account**: Klarna Pay over time<br>* **klarna_paynow**: Klarna Pay now<br>* **klarna_b2b**: [Billie via Klarna](https://docs.adyen.com/payment-methods/klarna/billie) |
| `Maestro` | [`GenericPmWithTdiInfo8`](../../doc/models/generic-pm-with-tdi-info-8.md) | Optional | Details to provide if `type` is **maestro**.<br>In the US, `maestro` is not supported; use `maestro_usa` instead. |
| `MaestroUsa` | [`GenericPmWithTdiInfo9`](../../doc/models/generic-pm-with-tdi-info-9.md) | Optional | Details to provide if `type` is **maestro_usa**.<br>Only for Maestro USA, otherwise use `maestro`. |
| `Mc` | [`GenericPmWithTdiInfo10`](../../doc/models/generic-pm-with-tdi-info-10.md) | Optional | Details to provide if `type` is **mc**. |
| `MealVoucherFr` | [`MealVoucherFrInfo1`](../../doc/models/meal-voucher-fr-info-1.md) | Optional | Details to provide if `type` is **mealVoucher_FR**. |
| `Nyce` | [`NyceInfo1`](../../doc/models/nyce-info-1.md) | Optional | Details to provide if `type` is **nyce**. |
| `PaybybankPlaid` | [`PayByBankPlaidInfo1`](../../doc/models/pay-by-bank-plaid-info-1.md) | Optional | Details to provide if `type` is **paybybank_plaid**. |
| `Payme` | [`PayMeInfo1`](../../doc/models/pay-me-info-1.md) | Optional | Details to provide if `type` is **payme**. |
| `Paypal` | [`PayPalInfo1`](../../doc/models/pay-pal-info-1.md) | Optional | Details to provide if `type` is **paypal**. |
| `Payto` | [`PayToInfo1`](../../doc/models/pay-to-info-1.md) | Optional | Details to provide if `type` is **payto**. |
| `Pulse` | [`PulseInfo1`](../../doc/models/pulse-info-1.md) | Optional | Details to provide if `type` is **pulse**. |
| `Reference` | `string` | Optional | Your reference for the payment method. Supported characters a-z, A-Z, 0-9.<br><br>**Constraints**: *Maximum Length*: `150` |
| `Sepadirectdebit` | [`SepaDirectDebitInfo1`](../../doc/models/sepa-direct-debit-info-1.md) | Optional | Details to provide if `type` is **sepadirectdebit**. |
| `ShopperInteraction` | `string` | Optional | The sales channel. |
| `Sodexo` | [`SodexoInfo1`](../../doc/models/sodexo-info-1.md) | Optional | Details to provide if `type` is **sodexo**. |
| `Sofort` | [`SofortInfo1`](../../doc/models/sofort-info-1.md) | Optional | Sofort details. |
| `Star` | [`StarInfo1`](../../doc/models/star-info-1.md) | Optional | Details to provide if `type` is **star**. |
| `StoreIds` | `List<string>` | Optional | The unique identifier of the store for which to configure the payment method, if any. |
| `Svs` | [`SvsInfo1`](../../doc/models/svs-info-1.md) | Optional | Details to provide if `type` is **svs**. |
| `Swish` | [`SwishInfo1`](../../doc/models/swish-info-1.md) | Optional | Details to provide if `type` is **swish**.<br><br>- This field is required only if you have a contract with Swish. Swish handles settlement directly with you (not through Adyen).<br>- If not specified then it's assumed that you are using Adyen's contract with Swish.You don't have a direct relationship with Swish. |
| `Ticket` | [`TicketInfo1`](../../doc/models/ticket-info-1.md) | Optional | Details to provide if `type` is **ticket** (Edenred Brazil). |
| `Twint` | [`TwintInfo1`](../../doc/models/twint-info-1.md) | Optional | Details to provide if `type` is **twint**. |
| `Type` | `string` | Optional | Payment method [variant](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api). |
| `Valuelink` | [`ValuelinkInfo1`](../../doc/models/valuelink-info-1.md) | Optional | Details to provide if `type` is **valuelink**. |
| `VerificationStatus` | [`VerificationStatus?`](../../doc/models/verification-status.md) | Optional | Payment method status. Possible values:<br><br>* **valid**<br>* **pending**<br>* **invalid**<br>* **rejected** |
| `Vipps` | [`VippsInfo1`](../../doc/models/vipps-info-1.md) | Optional | Details to provide if `type` is **vipps**. |
| `Visa` | [`GenericPmWithTdiInfo11`](../../doc/models/generic-pm-with-tdi-info-11.md) | Optional | Details to provide if `type` is **visa**. |
| `Wechatpay` | [`WeChatPayInfo1`](../../doc/models/we-chat-pay-info-1.md) | Optional | Details to provide if `type` is **wechatpay**. |
| `WechatpayPos` | [`WeChatPayPosInfo1`](../../doc/models/we-chat-pay-pos-info-1.md) | Optional | Details to provide if `type` is **wechatpay_pos**. |

## Example (as JSON)

```json
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
  "id": "id2"
}
```

