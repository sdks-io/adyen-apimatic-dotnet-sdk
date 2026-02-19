
# Three Ds 2 Request Data

## Structure

`ThreeDs2RequestData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AcctInfo` | [`AcctInfo1`](../../doc/models/acct-info-1.md) | Optional | Additional information about the cardholder’s account provided by the 3DS Requestor. |
| `AcctType` | [`AcctType?`](../../doc/models/acct-type.md) | Optional | Indicates the type of account. For example, for a multi-account card product. Length: 2 characters. Allowed values:<br><br>* **01** — Not applicable<br>* **02** — Credit<br>* **03** — Debit<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `AcquirerBin` | `string` | Optional | Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). The acquiring BIN enrolled for 3D Secure 2. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform. |
| `AcquirerMerchantId` | `string` | Optional | Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). The merchantId that is enrolled for 3D Secure 2 by the merchant's acquirer. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform. |
| `AddrMatch` | [`AddrMatch?`](../../doc/models/addr-match.md) | Optional | Indicates whether the cardholder shipping address and cardholder billing address are the same. Allowed values:<br><br>* **Y** — Shipping address matches billing address.<br>* **N** — Shipping address does not match billing address.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `AuthenticationOnly` | `bool?` | Optional | If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.<br><br>**Default**: `false` |
| `ChallengeIndicator` | [`ChallengeIndicator?`](../../doc/models/challenge-indicator.md) | Optional | Possibility to specify a preference for receiving a challenge from the issuer.<br>Allowed values:<br><br>* `noPreference`<br>* `requestNoChallenge`<br>* `requestChallenge`<br>* `requestChallengeAsMandate` |
| `DeviceChannel` | `string` | Required | The environment of the shopper.<br>Allowed values:<br><br>* `app`<br>* `browser` |
| `DeviceRenderOptions` | [`DeviceRenderOptions2`](../../doc/models/device-render-options-2.md) | Optional | Display options for the 3D Secure 2 SDK.<br>Optional and only for `deviceChannel` **app**. |
| `HomePhone` | [`Phone3`](../../doc/models/phone-3.md) | Optional | The home phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.<br><br>> Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the `shopperEmail`, and did not send the shopper's phone number in `telephoneNumber`. |
| `Mcc` | `string` | Optional | Required for merchants that have been enrolled for 3D Secure 2 by another party than Adyen, mostly [authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). The `mcc` is a four-digit code with which the previously given `acquirerMerchantID` is registered at the scheme. |
| `MerchantName` | `string` | Optional | Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). The merchant name that the issuer presents to the shopper if they get a challenge. We recommend to use the same value that you will use in the authorization. Maximum length is 40 characters.<br><br>> Optional for a [full 3D Secure 2 integration](https://docs.adyen.com/online-payments/3d-secure/native-3ds2/api-integration). Use this field if you are enrolled for 3D Secure 2 with us and want to override the merchant name already configured on your account. |
| `MessageVersion` | `string` | Optional | The `messageVersion` value indicating the 3D Secure 2 protocol version. |
| `MobilePhone` | [`Phone1`](../../doc/models/phone-1.md) | Optional | The mobile phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.<br><br>> Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the `shopperEmail`, and did not send the shopper's phone number in `telephoneNumber`. |
| `NotificationUrl` | `string` | Optional | URL to where the issuer should send the `CRes`. Required if you are not using components for `channel` **Web** or if you are using classic integration `deviceChannel` **browser**. |
| `PayTokenInd` | `bool?` | Optional | Value **true** indicates that the transaction was de-tokenised prior to being received by the ACS. |
| `PaymentAuthenticationUseCase` | `string` | Optional | Indicates the type of payment for which an authentication is requested (message extension) |
| `PurchaseInstalData` | `string` | Optional | Indicates the maximum number of authorisations permitted for instalment payments. Length: 1–3 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `3` |
| `RecurringExpiry` | `string` | Optional | Date after which no further authorisations shall be performed. Format: YYYYMMDD |
| `RecurringFrequency` | `string` | Optional | Indicates the minimum number of days between authorisations. Maximum length: 4 characters.<br><br>**Constraints**: *Maximum Length*: `4` |
| `SdkAppId` | `string` | Optional | The `sdkAppID` value as received from the 3D Secure 2 SDK.<br>Required for `deviceChannel` set to **app**. |
| `SdkEncData` | `string` | Optional | The `sdkEncData` value as received from the 3D Secure 2 SDK.<br>Required for `deviceChannel` set to **app**. |
| `SdkEphemPubKey` | [`SdkEphemPubKey3`](../../doc/models/sdk-ephem-pub-key-3.md) | Optional | The `sdkEphemPubKey` value as received from the 3D Secure 2 SDK.<br>Required for `deviceChannel` set to **app**. |
| `SdkMaxTimeout` | `int?` | Optional | The maximum amount of time in minutes for the 3D Secure 2 authentication process.<br>Optional and only for `deviceChannel` set to **app**. Defaults to **60** minutes.<br><br>**Default**: `60` |
| `SdkReferenceNumber` | `string` | Optional | The `sdkReferenceNumber` value as received from the 3D Secure 2 SDK.<br>Only for `deviceChannel` set to **app**. |
| `SdkTransId` | `string` | Optional | The `sdkTransID` value as received from the 3D Secure 2 SDK.<br>Only for `deviceChannel` set to **app**. |
| `SdkVersion` | `string` | Optional | Version of the 3D Secure 2 mobile SDK.<br>Only for `deviceChannel` set to **app**. |
| `ThreeDsCompInd` | `string` | Optional | Completion indicator for the device fingerprinting. |
| `ThreeDsRequestorAuthenticationInd` | `string` | Optional | Indicates the type of Authentication request. |
| `ThreeDsRequestorAuthenticationInfo` | [`ThreeDsRequestorAuthenticationInfo1`](../../doc/models/three-ds-requestor-authentication-info-1.md) | Optional | Information about how the 3DS Requestor authenticated the cardholder before or during the transaction |
| `ThreeDsRequestorChallengeInd` | [`ThreeDsRequestorChallengeInd?`](../../doc/models/three-ds-requestor-challenge-ind.md) | Optional | Indicates whether a challenge is requested for this transaction. Possible values:<br><br>* **01** — No preference<br>* **02** — No challenge requested<br>* **03** — Challenge requested (3DS Requestor preference)<br>* **04** — Challenge requested (Mandate)<br>* **05** — No challenge (transactional risk analysis is already performed)<br>* **06** — Data Only |
| `ThreeDsRequestorId` | `string` | Optional | Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only) for Visa. Unique 3D Secure requestor identifier assigned by the Directory Server when you enrol for 3D Secure 2. |
| `ThreeDsRequestorName` | `string` | Optional | Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only) for Visa. Unique 3D Secure requestor name assigned by the Directory Server when you enrol for 3D Secure 2. |
| `ThreeDsRequestorPriorAuthenticationInfo` | [`ThreeDsRequestorPriorAuthenticationInfo1`](../../doc/models/three-ds-requestor-prior-authentication-info-1.md) | Optional | Information about how the 3DS Requestor authenticated the cardholder as part of a previous 3DS transaction. |
| `ThreeDsRequestorUrl` | `string` | Optional | URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3D Secure 2 process. |
| `TransType` | [`TransType?`](../../doc/models/trans-type.md) | Optional | Identifies the type of transaction being authenticated. Length: 2 characters. Allowed values:<br><br>* **01** — Goods/Service Purchase<br>* **03** — Check Acceptance<br>* **10** — Account Funding<br>* **11** — Quasi-Cash Transaction<br>* **28** — Prepaid Activation and Load<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `TransactionType` | [`TransactionType?`](../../doc/models/transaction-type.md) | Optional | Identify the type of the transaction being authenticated. |
| `WhiteListStatus` | `string` | Optional | The `whiteListStatus` value returned from a previous 3D Secure 2 transaction, only applicable for 3D Secure 2 protocol version 2.2.0. |
| `WorkPhone` | [`Phone2`](../../doc/models/phone-2.md) | Optional | The work phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.<br><br>> Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the `shopperEmail`, and did not send the shopper's phone number in `telephoneNumber`. |

## Example (as JSON)

```json
{
  "authenticationOnly": false,
  "deviceChannel": "deviceChannel0",
  "sdkMaxTimeout": 60,
  "acctInfo": {
    "chAccAgeInd": "05",
    "chAccChange": "chAccChange8",
    "chAccChangeInd": "01",
    "chAccPwChange": "chAccPwChange8",
    "chAccPwChangeInd": "03"
  },
  "acctType": "02",
  "acquirerBIN": "acquirerBIN8",
  "acquirerMerchantID": "acquirerMerchantID6",
  "addrMatch": "Y"
}
```

