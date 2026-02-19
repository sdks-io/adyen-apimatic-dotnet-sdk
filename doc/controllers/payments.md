# Payments

```csharp
PaymentsApi paymentsApi = client.PaymentsApi;
```

## Class Name

`PaymentsApi`

## Methods

* [Post-Card Details](../../doc/controllers/payments.md#post-card-details)
* [Post-Payment Methods](../../doc/controllers/payments.md#post-payment-methods)
* [Post-Payments](../../doc/controllers/payments.md#post-payments)
* [Post-Payments-Details](../../doc/controllers/payments.md#post-payments-details)
* [Post-Sessions](../../doc/controllers/payments.md#post-sessions)
* [Get-Sessions-Session Id](../../doc/controllers/payments.md#get-sessions-session-id)


# Post-Card Details

Use this endpoint to get information about the card or network token that enables you to decide on the routing of the transaction and the eligibility of the card for the type of transaction.

If you include [your supported brands](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cardDetails__reqParam_supportedBrands) in the request, the response also tells you if you support each [brand that was identified on the card](https://docs.adyen.com/api-explorer/Checkout/latest/post/cardDetails#responses-200-brands).

If you have an API-only integration and collect card data, use this endpoint to find out if the shopper's card is co-bad. For co-badged cards, you must let the shopper choose the brand to pay with  if you support both brands.

## Server-side API libraries

We provide open-source [server-side API libraries](https://docs.adyen.com/development-resources/libraries/) in several languages:

- PHP
- Java
- Node.js
- .NET
- Go
- Python
- Ruby
- Apex (beta)

See our [integration examples](https://github.com/adyen-examples#%EF%B8%8F-official-integration-examples) for example uses of the libraries.

## Developer resources

BIN Lookup API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at **Environments**&nbsp;>&nbsp;**Adyen&nbsp;APIs**.

[![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/25716737-677c7679-a695-4ebb-91da-68b4e7c9228a?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D25716737-677c7679-a695-4ebb-91da-68b4e7c9228a%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)

```csharp
PostCardDetailsAsync(
    string idempotencyKey = null,
    Models.CardDetailsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`CardDetailsRequest`](../../doc/models/card-details-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CardDetailsResponse](../../doc/models/card-details-response.md).

## Example Usage

```csharp
CardDetailsRequest body = new CardDetailsRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    CardNumber = "411111",
};

try
{
    ApiResponse<CardDetailsResponse> result = await paymentsApi.PostCardDetailsAsync(
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "brands": [
    {
      "type": "visa",
      "supported": true
    },
    {
      "type": "cartebancaire",
      "supported": true
    }
  ],
  "fundingSource": "CREDIT",
  "isCardCommercial": false,
  "issuingCountryCode": "FR"
}
```


# Post-Payment Methods

Retrieves the list of available payment methods for the transaction, based on the transaction information like amount, country, and currency.

```csharp
PostPaymentMethodsAsync(
    string idempotencyKey = null,
    Models.PaymentMethodsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentMethodsRequest`](../../doc/models/payment-methods-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentMethodsResponse](../../doc/models/payment-methods-response.md).

## Example Usage

```csharp
PaymentMethodsRequest body = new PaymentMethodsRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
};

try
{
    ApiResponse<PaymentMethodsResponse> result = await paymentsApi.PostPaymentMethodsAsync(
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ServiceErrorException)
    {
       // TODO: Handle ServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "paymentMethods": [
    {
      "name": "ACH Direct Debit",
      "type": "ach"
    },
    {
      "name": "Adyen Voucher",
      "type": "adyen_test_voucher"
    },
    {
      "name": "AfterPay Invoice",
      "type": "afterpay_default"
    },
    {
      "name": "AfterPay DirectDebit",
      "type": "afterpay_directdebit"
    },
    {
      "name": "Afterpay",
      "type": "afterpaytouch"
    },
    {
      "name": "Cards",
      "type": "scheme"
    },
    {
      "name": "AliPay",
      "type": "alipay"
    },
    {
      "name": "AliPay HK",
      "type": "alipay_hk"
    },
    {
      "name": "AliPay",
      "type": "alipay_wap"
    },
    {
      "name": "Android Pay",
      "type": "androidpay"
    },
    {
      "name": "Apple Pay",
      "type": "applepay"
    },
    {
      "name": "Credit Card via AsiaPay",
      "type": "asiapay"
    },
    {
      "name": "China UnionPay",
      "type": "asiapay_unionpay"
    },
    {
      "name": "Baby Gift Card",
      "type": "babygiftcard"
    },
    {
      "name": "Baloto",
      "type": "baloto"
    },
    {
      "name": "BancNet",
      "type": "bancnet"
    },
    {
      "name": "Bank Transfer (BG)",
      "type": "bankTransfer_BG"
    },
    {
      "name": "Bank Transfer (CH)",
      "type": "bankTransfer_CH"
    },
    {
      "name": "Bank Transfer (DE)",
      "type": "bankTransfer_DE"
    },
    {
      "name": "Bank Transfer (FI)",
      "type": "bankTransfer_FI"
    },
    {
      "name": "Bank Transfer (GB)",
      "type": "bankTransfer_GB"
    },
    {
      "name": "Bank Transfer (HU)",
      "type": "bankTransfer_HU"
    },
    {
      "name": "SEPA Bank Transfer",
      "type": "bankTransfer_IBAN"
    },
    {
      "name": "Bank Transfer (IE)",
      "type": "bankTransfer_IE"
    },
    {
      "name": "Electronic Bank Transfer (MX)",
      "type": "bankTransfer_MX_linked"
    },
    {
      "name": "Bank Transfer (MX)",
      "type": "bankTransfer_MX_offline"
    },
    {
      "name": "Bank Transfer (NL)",
      "type": "bankTransfer_NL"
    },
    {
      "name": "Bank Transfer (PL)",
      "type": "bankTransfer_PL"
    },
    {
      "name": "Bank Transfer (SE)",
      "type": "bankTransfer_SE"
    },
    {
      "name": "Bank Transfer (US)",
      "type": "bankTransfer_US"
    },
    {
      "name": "Payconiq by Bancontact",
      "type": "bcmc_mobile"
    },
    {
      "name": "Bijenkorf Cadeaucard",
      "type": "bijcadeaucard"
    },
    {
      "name": "99Bill",
      "type": "bill99"
    },
    {
      "name": "Online Banking India",
      "type": "billdesk_online"
    },
    {
      "name": "UPI",
      "type": "billdesk_upi"
    },
    {
      "name": "Wallets India",
      "type": "billdesk_wallet"
    },
    {
      "name": "Blik",
      "type": "blik"
    },
    {
      "name": "Bloemen Giftcard",
      "type": "bloemengiftcard"
    },
    {
      "name": "Boekenbon Giftcard",
      "type": "boekenbon"
    },
    {
      "name": "Boleto",
      "type": "boleto"
    },
    {
      "name": "Boleto Bancario",
      "type": "boletobancario_santander"
    },
    {
      "name": "Bradesco",
      "type": "bradesco"
    },
    {
      "name": "Cash-Ticket",
      "type": "cashticket"
    },
    {
      "name": "CashU",
      "type": "cashu"
    },
    {
      "name": "CCAvenue",
      "type": "ccavenue"
    },
    {
      "name": "Mula Checkout",
      "type": "cellulant"
    },
    {
      "name": "Chasin Giftcard",
      "type": "chasingiftcard"
    },
    {
      "name": "Clearpay",
      "type": "clearpay"
    },
    {
      "name": "ClickandBuy",
      "type": "clickandbuy"
    },
    {
      "name": "Paiement en 3 fois par Cartes Bancaires",
      "type": "cofinoga_3xcb"
    },
    {
      "name": "Costes Giftcard",
      "type": "costesgiftcard"
    },
    {
      "name": "custom_settlement",
      "type": "custom_settlement"
    },
    {
      "name": "DANA",
      "type": "dana"
    },
    {
      "name": "DineroMail",
      "type": "dineromail"
    },
    {
      "name": "Online bank transfer.",
      "type": "directEbanking"
    },
    {
      "name": "Direct Debit Brazil - Banco do Brazil",
      "type": "directdebit_BR_bancodobrasil"
    },
    {
      "name": "Direct Debit Brazil - Bradesco",
      "type": "directdebit_BR_bradesco"
    },
    {
      "name": "Direct Debit Brazil - Caixa Economica Federal",
      "type": "directdebit_BR_caixa"
    },
    {
      "name": "Direct Debit Brazil - HSBC",
      "type": "directdebit_BR_hsbc"
    },
    {
      "name": "Direct Debit Brazil - Itau",
      "type": "directdebit_BR_itau"
    },
    {
      "name": "Direct Debit Brazil - Santander",
      "type": "directdebit_BR_santander"
    },
    {
      "name": "BACS Direct Debit",
      "type": "directdebit_GB"
    },
    {
      "name": "Alfamart",
      "type": "doku_alfamart"
    },
    {
      "name": "BCA Bank Transfer",
      "type": "doku_bca_va"
    },
    {
      "name": "BNI VA",
      "type": "doku_bni_va"
    },
    {
      "name": "BRI VA",
      "type": "doku_bri_va"
    },
    {
      "name": "CIMB VA",
      "type": "doku_cimb_va"
    },
    {
      "name": "Danamon VA",
      "type": "doku_danamon_va"
    },
    {
      "name": "Indomaret",
      "type": "doku_indomaret"
    },
    {
      "name": "Mandiri VA",
      "type": "doku_mandiri_va"
    },
    {
      "name": "OVO",
      "type": "doku_ovo"
    },
    {
      "name": "Bank Transfer",
      "type": "doku_permata_lite_atm"
    },
    {
      "name": "DOKU wallet",
      "type": "doku_wallet"
    },
    {
      "name": "Dragonpay Prepaid Credits",
      "type": "dragonpay_credits"
    },
    {
      "name": "Online Banking",
      "type": "dragonpay_ebanking"
    },
    {
      "name": "GCash",
      "type": "dragonpay_gcash"
    },
    {
      "name": "Over The Counter Banks",
      "type": "dragonpay_otc_banking"
    },
    {
      "name": "OTC non-Bank via Dragonpay",
      "type": "dragonpay_otc_non_banking"
    },
    {
      "name": "Convenience Stores",
      "type": "dragonpay_otc_philippines"
    },
    {
      "name": "7/11",
      "type": "dragonpay_seveneleven"
    },
    {
      "name": "eagleeye_voucher",
      "type": "eagleeye_voucher"
    },
    {
      "name": "Finnish E-Banking",
      "type": "ebanking_FI"
    },
    {
      "name": "Pay-easy ATM",
      "type": "econtext_atm"
    },
    {
      "name": "Online Banking",
      "type": "econtext_online"
    },
    {
      "name": "7-Eleven",
      "type": "econtext_seven_eleven"
    },
    {
      "name": "Convenience Stores",
      "type": "econtext_stores"
    },
    {
      "name": "eft_directdebit_CA",
      "type": "eft_directdebit_CA"
    },
    {
      "name": "Lastschrift (ELV)",
      "type": "elv"
    },
    {
      "name": "Bank Payment",
      "type": "entercash"
    },
    {
      "name": "Nationale Entertainment Card",
      "type": "entertainmentcard"
    },
    {
      "name": "EPS",
      "type": "eps"
    },
    {
      "name": "Expert Cadeaukaart",
      "type": "expertgiftcard"
    },
    {
      "name": "3x Oney",
      "type": "facilypay_3x"
    },
    {
      "name": "4x Oney",
      "type": "facilypay_4x"
    },
    {
      "name": "Fashioncheque",
      "type": "fashioncheque"
    },
    {
      "name": "Fawry",
      "type": "fawry"
    },
    {
      "name": "FijnCadeau",
      "type": "fijncadeau"
    },
    {
      "name": "Fleurop Bloemenbon",
      "type": "fleuropbloemenbon"
    },
    {
      "name": "Fonq Giftcard",
      "type": "fonqgiftcard"
    },
    {
      "name": "Gall & Gall",
      "type": "gallgall"
    },
    {
      "name": "GCash",
      "type": "gcash"
    },
    {
      "name": "Generic GiftCard",
      "type": "genericgiftcard"
    },
    {
      "name": "GiftFor2",
      "type": "giftfor2card"
    },
    {
      "name": "Givex",
      "type": "givex"
    },
    {
      "name": "Globe GCash",
      "type": "globegcash"
    },
    {
      "name": "Goldsmiths Card",
      "type": "goldsmithscard"
    },
    {
      "name": "GoPay Wallet",
      "type": "gopay_wallet"
    },
    {
      "name": "OVO",
      "type": "grabpay_ID"
    },
    {
      "name": "GrabPay",
      "type": "grabpay_PH"
    },
    {
      "name": "GrabPay",
      "type": "grabpay_SG"
    },
    {
      "name": "Hallmark Card",
      "type": "hallmarkcard"
    },
    {
      "name": "HDFC",
      "type": "hdfc"
    },
    {
      "name": "Hunkemoller Member Card",
      "type": "hmclub"
    },
    {
      "name": "Hunkemoller Lingerie Card",
      "type": "hmlingerie"
    },
    {
      "name": "iDEAL",
      "type": "ideal"
    },
    {
      "name": "igive",
      "type": "igive"
    },
    {
      "name": "Korean Account Transfer (IniPay)",
      "type": "inicisIniPay_accounttransfer"
    },
    {
      "name": "Korean Credit Cards (IniPay)",
      "type": "inicisIniPay_creditcard"
    },
    {
      "name": "Korean Mobile Phone (IniPay)",
      "type": "inicisIniPay_mobilephone"
    },
    {
      "name": "Korean Virtual Account (IniPay)",
      "type": "inicisIniPay_virtualaccount"
    },
    {
      "name": "Korean Account Transfer (Mobile)",
      "type": "inicisMobile_accounttransfer"
    },
    {
      "name": "Korean Credit Cards (Mobile)",
      "type": "inicisMobile_creditcard"
    },
    {
      "name": "Korean Mobile Phone (Mobile)",
      "type": "inicisMobile_mobilephone"
    },
    {
      "name": "Korean Virtual Account (Mobile)",
      "type": "inicisMobile_virtualaccount"
    },
    {
      "name": "Korean Credit Cards",
      "type": "inicis_creditcard"
    },
    {
      "name": "Interac® Online",
      "type": "interac"
    },
    {
      "name": "Instant EFT",
      "type": "ipay"
    },
    {
      "name": "iPay88",
      "type": "ipay88"
    },
    {
      "name": "isracard",
      "type": "isracard"
    },
    {
      "name": "Phone Payment",
      "type": "ivr"
    },
    {
      "name": "Landline phone",
      "type": "ivrLandline"
    },
    {
      "name": "Mobile phone",
      "type": "ivrMobile"
    },
    {
      "name": "Kado Wereld",
      "type": "kadowereld"
    },
    {
      "name": "KakaoPay",
      "type": "kakaopay"
    },
    {
      "name": "Karen Millen Card",
      "type": "karenmillen"
    },
    {
      "name": "Karen Millen GiftCard",
      "type": "karenmillengiftcard"
    },
    {
      "name": "Bank Transfer",
      "type": "kcp_banktransfer"
    },
    {
      "name": "Korea–issued cards",
      "type": "kcp_creditcard"
    },
    {
      "name": "PayCo",
      "type": "kcp_payco"
    },
    {
      "name": "Naver Pay",
      "type": "kcp_naverpay"
    },
    {
      "name": "Virtual Account via KCP",
      "type": "kcp_va"
    },
    {
      "name": "Pay later with Klarna.",
      "type": "klarna"
    },
    {
      "name": "Pay over time with Klarna.",
      "type": "klarna_account"
    },
    {
      "name": "Buy Now, Pay Later with Billie",
      "type": "klarna_b2b"
    },
    {
      "name": "Pay now with Klarna.",
      "type": "klarna_paynow"
    },
    {
      "name": "Leisure Card",
      "type": "leisurecard"
    },
    {
      "name": "China Credit Card",
      "type": "lianlianpay_creditcard"
    },
    {
      "name": "China Debit Card",
      "type": "lianlianpay_debitcard"
    },
    {
      "name": "China Online Banking - Credit Card",
      "type": "lianlianpay_ebanking_credit"
    },
    {
      "name": "China Online Banking - Debit Card",
      "type": "lianlianpay_ebanking_debit"
    },
    {
      "name": "China Online Banking - Enterprise",
      "type": "lianlianpay_ebanking_enterprise"
    },
    {
      "name": "Loods5 Cadeaukaart",
      "type": "loods5giftcard"
    },
    {
      "name": "Loods5 Tegoedbon",
      "type": "loods5prepaidcard"
    },
    {
      "name": "Love2Shop GiftCard",
      "type": "love2shop"
    },
    {
      "name": "mada",
      "type": "mada"
    },
    {
      "name": "Mappin & Webb Card",
      "type": "mappinwebbcard"
    },
    {
      "name": "MB WAY",
      "type": "mbway"
    },
    {
      "name": "Amazon Pay",
      "type": "amazonpay"
    },
    {
      "name": "Mercado Pago",
      "type": "mercadopago"
    },
    {
      "name": "MobilePay",
      "type": "mobilepay"
    },
    {
      "name": "AliPay via Razer Merchant Services",
      "type": "molpay_alipay"
    },
    {
      "name": "7-Eleven",
      "type": "molpay_cash"
    },
    {
      "name": "CIMB Virtual Account",
      "type": "molpay_cimb_va"
    },
    {
      "name": "Malaysia E-Banking via Razer Merchant Services",
      "type": "molpay_ebanking_MY"
    },
    {
      "name": "Vietnam E-Banking",
      "type": "molpay_ebanking_VN"
    },
    {
      "name": "Malaysia E-Banking",
      "type": "molpay_ebanking_fpx_MY"
    },
    {
      "name": "eNETS Debit",
      "type": "molpay_enetsd"
    },
    {
      "name": "epay",
      "type": "molpay_epay"
    },
    {
      "name": "Esapay",
      "type": "molpay_esapay"
    },
    {
      "name": "MyClear FPX",
      "type": "molpay_fpx"
    },
    {
      "name": "Maybank2u",
      "type": "molpay_maybank2u"
    },
    {
      "name": "Nganluong",
      "type": "molpay_nganluong"
    },
    {
      "name": "Convenience Stores Thailand",
      "type": "molpay_paysbuy"
    },
    {
      "name": "MOLPoints",
      "type": "molpay_points"
    },
    {
      "name": "RHB Now",
      "type": "molpay_rhb"
    },
    {
      "name": "SAM by SingPost",
      "type": "molpay_singpost"
    },
    {
      "name": "MOLWallet",
      "type": "molpay_wallet"
    },
    {
      "name": "MoMo ATM",
      "type": "momo_atm"
    },
    {
      "name": "Momo Wallet",
      "type": "momo_wallet"
    },
    {
      "name": "Moneybookers",
      "type": "moneybookers"
    },
    {
      "name": "Multibanco",
      "type": "multibanco"
    },
    {
      "name": "De Nationale Musicalcard",
      "type": "musicalcard"
    },
    {
      "name": "Nationale Bioscoopbon",
      "type": "nationalebioscoopbon"
    },
    {
      "name": "Nationale Tuinbon",
      "type": "nationaletuinbon"
    },
    {
      "name": "Nationale Verwen Cadeaubon",
      "type": "nationaleverwencadeaubon"
    },
    {
      "name": "BankAxess",
      "type": "netaxept_bankaxess"
    },
    {
      "name": "NETELLER",
      "type": "neteller"
    },
    {
      "name": "Onebip",
      "type": "onebip"
    },
    {
      "name": "One Two Three",
      "type": "onetwothree"
    },
    {
      "name": "Online Banking PL",
      "type": "onlineBanking_PL"
    },
    {
      "name": "Online banking",
      "type": "openbanking_UK"
    },
    {
      "name": "Oxxo",
      "type": "oxxo"
    },
    {
      "name": "Pathe Giftcard",
      "type": "pathegiftcard"
    },
    {
      "name": "PayBright",
      "type": "paybright"
    },
    {
      "name": "Maya Wallet",
      "type": "paymaya_wallet"
    },
    {
      "name": "PayPal",
      "type": "paypal"
    },
    {
      "name": "Paysafecard",
      "type": "paysafecard"
    },
    {
      "name": "Payshop",
      "type": "payshop"
    },
    {
      "name": "PayD AMT via Paythru",
      "type": "paythru_amt"
    },
    {
      "name": "EFT via Paythru",
      "type": "paythru_eft"
    },
    {
      "name": "PayTM",
      "type": "paytm"
    },
    {
      "name": "PayU UPI",
      "type": "payu_IN_upi"
    },
    {
      "name": "EFT Pro via PayU",
      "type": "payu_ZA_eftpro"
    },
    {
      "name": "Google Pay",
      "type": "paywithgoogle"
    },
    {
      "name": "pix",
      "type": "pix"
    },
    {
      "name": "Plastix",
      "type": "plastix"
    },
    {
      "name": "Pluim",
      "type": "pluimgiftcard"
    },
    {
      "name": "Podium Card",
      "type": "podiumcard"
    },
    {
      "name": "POLi",
      "type": "poli"
    },
    {
      "name": "PPS",
      "type": "pps"
    },
    {
      "name": "Primera Cadeaukaart",
      "type": "primeracadeaucard"
    },
    {
      "name": "Illicado Gift Card",
      "type": "prosodie_illicado"
    },
    {
      "name": "PSE",
      "type": "pse"
    },
    {
      "name": "Qiwi Wallet",
      "type": "qiwiwallet"
    },
    {
      "name": "RatePay Invoice",
      "type": "ratepay"
    },
    {
      "name": "RatePay Direct Debit",
      "type": "ratepay_directdebit"
    },
    {
      "name": "Rituals Giftcard",
      "type": "rituals"
    },
    {
      "name": "Rob Peetoom Giftcard",
      "type": "robpeetoomgiftcard"
    },
    {
      "name": "SafetyPay",
      "type": "safetypay"
    },
    {
      "name": "SafetyPay Cash",
      "type": "safetypay_cash"
    },
    {
      "name": "Shoes&Accessories Cadeau",
      "type": "sagiftcard"
    },
    {
      "name": "Score Giftcard",
      "type": "scoregiftcard"
    },
    {
      "name": "SEB Direktbetalning",
      "type": "sebdirectpayment"
    },
    {
      "name": "SEPA Direct Debit",
      "type": "sepadirectdebit"
    },
    {
      "name": "7-Eleven",
      "type": "seveneleven"
    },
    {
      "name": "Premium SMS",
      "type": "sms"
    },
    {
      "name": "SVS",
      "type": "svs"
    },
    {
      "name": "Swish",
      "type": "swish"
    },
    {
      "name": "TCS Test GiftCard",
      "type": "tcstestgiftcard"
    },
    {
      "name": "TenPay",
      "type": "tenpay"
    },
    {
      "name": "The Sting Giftcard",
      "type": "thestinggiftcard"
    },
    {
      "name": "TrueMoney",
      "type": "truemoney"
    },
    {
      "name": "Trustly",
      "type": "trustly"
    },
    {
      "name": "Online Banking by Trustpay",
      "type": "trustpay"
    },
    {
      "name": "TWINT",
      "type": "twint"
    },
    {
      "name": "Ukash",
      "type": "ukash"
    },
    {
      "name": "UnionPay",
      "type": "unionpay"
    },
    {
      "name": "UPI Collect",
      "type": "upi_collect"
    },
    {
      "name": "Valuelink",
      "type": "valuelink"
    },
    {
      "name": "V&D Cadeaukaart",
      "type": "vdcadeaucard"
    },
    {
      "name": "Vipps",
      "type": "vipps"
    },
    {
      "name": "Visa Checkout",
      "type": "visacheckout"
    },
    {
      "name": "VVV Cadeaubon",
      "type": "vvvcadeaubon"
    },
    {
      "name": "VVV Giftcard",
      "type": "vvvgiftcard"
    },
    {
      "name": "Webshop Giftcard",
      "type": "webshopgiftcard"
    },
    {
      "name": "WeChat Pay",
      "type": "wechatpayMiniProgram"
    },
    {
      "name": "WeChat Pay",
      "type": "wechatpayQR"
    },
    {
      "name": "WeChat Pay",
      "type": "wechatpayWeb"
    },
    {
      "name": "WE Fashion Giftcard",
      "type": "wefashiongiftcard"
    },
    {
      "name": "Western Union",
      "type": "westernunion"
    },
    {
      "name": "Winkel Cheque",
      "type": "winkelcheque"
    },
    {
      "name": "WOS Card",
      "type": "woscard"
    },
    {
      "name": "Alfa-Click",
      "type": "yandex_alfaclick"
    },
    {
      "name": "Pay using bank card",
      "type": "yandex_bank_card"
    },
    {
      "name": "Cash terminals",
      "type": "yandex_cash"
    },
    {
      "name": "Pay using installments",
      "type": "yandex_installments"
    },
    {
      "name": "YooMoney",
      "type": "yandex_money"
    },
    {
      "name": "Promsvyazbank",
      "type": "yandex_promsvyazbank"
    },
    {
      "name": "SberPay",
      "type": "yandex_sberbank"
    },
    {
      "name": "WebMoney",
      "type": "yandex_webmoney"
    },
    {
      "name": "Your Gift",
      "type": "yourgift"
    },
    {
      "name": "Zip",
      "type": "zip"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Payments

Sends payment parameters (like amount, country, and currency) together with other required input details collected from the shopper. To know more about required parameters for specific payment methods, refer to our [payment method guides](https://docs.adyen.com/payment-methods).
The response depends on the [payment flow](https://docs.adyen.com/payment-methods#payment-flow):

* For a direct flow, the response includes a `pspReference` and a `resultCode` with the payment result, for example **Authorised** or **Refused**.
* For a redirect or additional action, the response contains an `action` object.

```csharp
PostPaymentsAsync(
    string idempotencyKey = null,
    Models.PaymentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentRequest`](../../doc/models/payment-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentResponse](../../doc/models/payment-response.md).

## Example Usage

```csharp
PaymentRequest body = new PaymentRequest
{
    Amount = new Amount2
    {
        Currency = "USD",
        MValue = 1000L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    PaymentMethod = PaymentRequestPaymentMethod.FromApplePay(
        new ApplePay
        {
            ApplePayToken = "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...",
            Type = Type6.Applepay,
        }
    ),
    Reference = "Your order number",
    ReturnUrl = "https://your-company.example.com/...",
};

try
{
    ApiResponse<PaymentResponse> result = await paymentsApi.PostPaymentsAsync(
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ServiceErrorException)
    {
       // TODO: Handle ServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "resultCode": "IdentifyShopper",
  "action": {
    "paymentData": "Ab02b4c0!BQABAgCuZFJrQOjSsl\\/zt+...",
    "paymentMethodType": "scheme",
    "authorisationToken": "Ab02b4c0!BQABAgAvrX03p...",
    "subtype": "fingerprint",
    "token": "eyJ0aHJlZURTTWV0aG9kTm90aWZpY...",
    "type": "threeDS2"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Payments-Details

Submits details for a payment created using `/payments`. This step is only needed when no final state has been reached on the `/payments` request, for example when the shopper was redirected to another page to complete the payment.

```csharp
PostPaymentsDetailsAsync(
    string idempotencyKey = null,
    Models.PaymentDetailsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentDetailsRequest`](../../doc/models/payment-details-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentDetailsResponse](../../doc/models/payment-details-response.md).

## Example Usage

```csharp
PaymentDetailsRequest body = new PaymentDetailsRequest
{
    Details = new PaymentCompletionDetails1
    {
        RedirectResult = "X6XtfGC3!Y...",
    },
};

try
{
    ApiResponse<PaymentDetailsResponse> result = await paymentsApi.PostPaymentsDetailsAsync(
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ServiceErrorException)
    {
       // TODO: Handle ServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "resultCode": "Authorised",
  "pspReference": "V4HZ4RBFJGXXGN82"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Sessions

Creates a payment session for [Drop-in](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Drop-in), [Components](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Components), and [Hosted Checkout](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Hosted+Checkout) integrations.

The response contains encrypted payment session data. The front end then uses the session data to make any required server-side calls for the payment flow.

You get the payment outcome asynchronously, in an [AUTHORISATION](https://docs.adyen.com/api-explorer/#/Webhooks/latest/post/AUTHORISATION) webhook.

```csharp
PostSessionsAsync(
    string idempotencyKey = null,
    Models.CreateCheckoutSessionRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`CreateCheckoutSessionRequest`](../../doc/models/create-checkout-session-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CreateCheckoutSessionResponse](../../doc/models/create-checkout-session-response.md).

## Example Usage

```csharp
CreateCheckoutSessionRequest body = new CreateCheckoutSessionRequest
{
    Amount = new Amount17
    {
        Currency = "EUR",
        MValue = 100L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_PAYMENT_REFERENCE",
    ReturnUrl = "https://your-company.example.com/checkout?shopperOrder=12xy..",
    CountryCode = "NL",
};

try
{
    ApiResponse<CreateCheckoutSessionResponse> result = await paymentsApi.PostSessionsAsync(
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "amount": {
    "currency": "EUR",
    "value": 100
  },
  "countryCode": "NL",
  "expiresAt": "2022-01-11T13:53:18+01:00",
  "id": "CS451F2AB1ED897A94",
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "reference": "YOUR_PAYMENT_REFERENCE",
  "returnUrl": "https://your-company.example.com/checkout?shopperOrder=12xy..",
  "sessionData": "Ab02b4c0!BQABAgBfYI29..."
}
```


# Get-Sessions-Session Id

Returns the status of the payment session with the `sessionId` and `sessionResult` specified in the path.

```csharp
GetSessionsSessionIdAsync(
    string sessionId,
    string sessionResult)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sessionId` | `string` | Template, Required | A unique identifier of the session. |
| `sessionResult` | `string` | Query, Required | The `sessionResult` value from the Drop-in or Component. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SessionResultResponse](../../doc/models/session-result-response.md).

## Example Usage

```csharp
string sessionId = "sessionId8";
string sessionResult = "sessionResult8";
try
{
    ApiResponse<SessionResultResponse> result = await paymentsApi.GetSessionsSessionIdAsync(
        sessionId,
        sessionResult
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "id": "CS12345678",
  "status": "completed"
}
```

