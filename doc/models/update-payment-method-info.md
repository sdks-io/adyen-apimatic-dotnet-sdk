
# Update Payment Method Info

## Structure

`UpdatePaymentMethodInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accel` | [`AccelInfo1`](../../doc/models/accel-info-1.md) | Optional | Details to provide if `type` is **accel**. |
| `Bcmc` | [`BcmcInfo1`](../../doc/models/bcmc-info-1.md) | Optional | Details to provide if `type` is **bcmc** (Bancontact). |
| `CartesBancaires` | [`CartesBancairesInfo1`](../../doc/models/cartes-bancaires-info-1.md) | Optional | Details to provide if `type` is **cartebancaire**. |
| `Countries` | `List<string>` | Optional | The list of countries where a payment method is available. By default, all countries supported by the payment method. |
| `Cup` | [`GenericPmWithTdiInfo1`](../../doc/models/generic-pm-with-tdi-info-1.md) | Optional | Details to provide if `type` is **cup** (China Union Pay). |
| `Currencies` | `List<string>` | Optional | The list of currencies that a payment method supports. By default, all currencies supported by the payment method. |
| `CustomRoutingFlags` | `List<string>` | Optional | Custom routing flags for acquirer routing. |
| `Diners` | [`GenericPmWithTdiInfo24`](../../doc/models/generic-pm-with-tdi-info-24.md) | Optional | Details to provide if `type` is **diners**.<br>For merchants operating in Japan, Diners payments are processed through the JCB network. This means that you must include [JCB-specific fields](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId)/paymentMethodSettings/(paymentMethodId)#request-jcb) in this object. |
| `Discover` | [`GenericPmWithTdiInfo2`](../../doc/models/generic-pm-with-tdi-info-2.md) | Optional | Details to provide if `type` is **discover**.<br>For merchants operating in Japan, request [Diners](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId)/paymentMethodSettings/(paymentMethodId)#request-diners) payment method instead. Discover is automatically requested, together with Diners. |
| `EftDirectdebitCa` | [`GenericPmWithTdiInfo3`](../../doc/models/generic-pm-with-tdi-info-3.md) | Optional | Details to provide if `type` is **eft_directdebit_CA** (EFT PAD). |
| `EftposAustralia` | [`GenericPmWithTdiInfo4`](../../doc/models/generic-pm-with-tdi-info-4.md) | Optional | Details to provide if `type` is **eftpos_australia**. |
| `Enabled` | `bool?` | Optional | Indicates whether the payment method is enabled (**true**) or disabled (**false**). |
| `Girocard` | [`GenericPmWithTdiInfo5`](../../doc/models/generic-pm-with-tdi-info-5.md) | Optional | Details to provide if `type` is **girocard**. |
| `Ideal` | [`GenericPmWithTdiInfo6`](../../doc/models/generic-pm-with-tdi-info-6.md) | Optional | Details to provide if `type` is **ideal**. |
| `InteracCard` | [`GenericPmWithTdiInfo7`](../../doc/models/generic-pm-with-tdi-info-7.md) | Optional | Details to provide if `type` is **interac_card**. |
| `Jcb` | [`GenericPmWithTdiInfo31`](../../doc/models/generic-pm-with-tdi-info-31.md) | Optional | Details to provide if `type` is **jcb**.<br>For merchants operating in Japan, `midNumber`, `reuseMidNumber`, and `serviceLevel` fields are required.<br>For merchants operating outside of Japan, these fields are not required. |
| `Maestro` | [`GenericPmWithTdiInfo8`](../../doc/models/generic-pm-with-tdi-info-8.md) | Optional | Details to provide if `type` is **maestro**.<br>In the US, `maestro` is not supported; use `maestro_usa` instead. |
| `MaestroUsa` | [`GenericPmWithTdiInfo9`](../../doc/models/generic-pm-with-tdi-info-9.md) | Optional | Details to provide if `type` is **maestro_usa**.<br>Only for Maestro USA, otherwise use `maestro`. |
| `Mc` | [`GenericPmWithTdiInfo10`](../../doc/models/generic-pm-with-tdi-info-10.md) | Optional | Details to provide if `type` is **mc**. |
| `Nyce` | [`NyceInfo1`](../../doc/models/nyce-info-1.md) | Optional | Details to provide if `type` is **nyce**. |
| `PaybybankPlaid` | [`PayByBankPlaidInfo1`](../../doc/models/pay-by-bank-plaid-info-1.md) | Optional | Details to provide if `type` is **paybybank_plaid**. |
| `Pulse` | [`PulseInfo1`](../../doc/models/pulse-info-1.md) | Optional | Details to provide if `type` is **pulse**. |
| `Sepadirectdebit` | [`SepaDirectDebitInfo1`](../../doc/models/sepa-direct-debit-info-1.md) | Optional | Details to provide if `type` is **sepadirectdebit**. |
| `Star` | [`StarInfo1`](../../doc/models/star-info-1.md) | Optional | Details to provide if `type` is **star**. |
| `StoreId` | `string` | Optional | The store for this payment method |
| `StoreIds` | `List<string>` | Optional | The list of stores for this payment method |
| `Visa` | [`GenericPmWithTdiInfo11`](../../doc/models/generic-pm-with-tdi-info-11.md) | Optional | Details to provide if `type` is **visa**. |

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
  "bcmc": {
    "enableBcmcMobile": false
  },
  "cartesBancaires": {
    "siret": "siret8",
    "transactionDescription": {
      "doingBusinessAsName": "doingBusinessAsName0",
      "type": "fixed"
    }
  },
  "countries": [
    "countries3",
    "countries2",
    "countries1"
  ],
  "cup": {
    "transactionDescription": {
      "doingBusinessAsName": "doingBusinessAsName0",
      "type": "fixed"
    }
  }
}
```

