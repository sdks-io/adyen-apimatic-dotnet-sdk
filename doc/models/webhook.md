
# Webhook

## Structure

`Webhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Links` | [`WebhookLinks2`](../../doc/models/webhook-links-2.md) | Optional | References to resources connected with this webhook. |
| `AcceptsExpiredCertificate` | `bool?` | Optional | Indicates if expired SSL certificates are accepted. Default value: **false**. |
| `AcceptsSelfSignedCertificate` | `bool?` | Optional | Indicates if self-signed SSL certificates are accepted. Default value: **false**. |
| `AcceptsUntrustedRootCertificate` | `bool?` | Optional | Indicates if untrusted SSL certificates are accepted. Default value: **false**. |
| `AccountReference` | `string` | Optional | Reference to the account the webook is set on. |
| `Active` | `bool` | Required | Indicates if the webhook configuration is active. The field must be **true** for you to receive webhooks about events related an account. |
| `AdditionalSettings` | [`AdditionalSettingsResponse1`](../../doc/models/additional-settings-response-1.md) | Optional | Additional shopper and transaction information to be included in your [standard webhooks](https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes). Find out more about the available [additional settings](https://docs.adyen.com/development-resources/webhooks/additional-settings). |
| `CertificateAlias` | `string` | Optional | The alias of our SSL certificate. When you receive a notification from us, the alias from the HMAC signature will match this alias. |
| `CommunicationFormat` | [`CommunicationFormat`](../../doc/models/communication-format.md) | Required | Format or protocol for receiving webhooks. Possible values:<br><br>* **soap**<br>* **http**<br>* **json** |
| `Description` | `string` | Optional | Your description for this webhook configuration. |
| `EncryptionProtocol` | [`EncryptionProtocol?`](../../doc/models/encryption-protocol.md) | Optional | SSL version to access the public webhook URL specified in the `url` field. Possible values:<br><br>* **TLSv1.3**<br>* **TLSv1.2**<br>* **HTTP** - Only allowed on Test environment.<br><br>If not specified, the webhook will use `sslVersion`: **TLSv1.2**. |
| `FilterMerchantAccountType` | [`FilterMerchantAccountType1?`](../../doc/models/filter-merchant-account-type-1.md) | Optional | Shows how merchant accounts are included in company-level webhooks. Possible values:<br><br>* **includeAccounts**<br>* **excludeAccounts**<br>* **allAccounts**: Includes all merchant accounts, and does not require specifying `filterMerchantAccounts`. |
| `FilterMerchantAccounts` | `List<string>` | Optional | A list of merchant account names that are included or excluded from receiving the webhook. Inclusion or exclusion is based on the value defined for `filterMerchantAccountType`.<br><br>Required if `filterMerchantAccountType` is either:<br><br>* **includeAccounts**<br>* **excludeAccounts**<br><br>Not needed for `filterMerchantAccountType`: **allAccounts**. |
| `HasError` | `bool?` | Optional | Indicates if the webhook configuration has errors that need troubleshooting. If the value is **true**, troubleshoot the configuration using the [testing endpoint](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookid}/test). |
| `HasPassword` | `bool?` | Optional | Indicates if the webhook is password protected. |
| `HmacKeyCheckValue` | `string` | Optional | The [checksum](https://en.wikipedia.org/wiki/Key_checksum_value) of the HMAC key generated for this webhook. You can use this value to uniquely identify the HMAC key configured for this webhook. |
| `Id` | `string` | Optional | Unique identifier for this webhook. |
| `NetworkType` | [`NetworkType2?`](../../doc/models/network-type-2.md) | Optional | Network type for Terminal API details webhooks. |
| `PopulateSoapActionHeader` | `bool?` | Optional | Indicates if the SOAP action header needs to be populated. Default value: **false**.<br><br>Only applies if `communicationFormat`: **soap**. |
| `Type` | `string` | Required | The type of webhook. Possible values are:<br><br>- **standard**<br>- **account-settings-notification**<br>- **banktransfer-notification**<br>- **boletobancario-notification**<br>- **directdebit-notification**<br>- **ach-notification-of-change-notification**<br>- **direct-debit-notice-of-change-notification**<br>- **pending-notification**<br>- **ideal-notification**<br>- **ideal-pending-notification**<br>- **report-notification**<br>- **terminal-api-notification**<br>- **terminal-settings**<br>- **terminal-boarding**<br><br>Find out more about [standard webhooks](https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes) and [other types of webhooks](https://docs.adyen.com/development-resources/webhooks/webhook-types/#other-webhooks). |
| `Url` | `string` | Required | Public URL where webhooks will be sent, for example **https://www.domain.com/webhook-endpoint**. |
| `Username` | `string` | Optional | Username to access the webhook URL. |

## Example (as JSON)

```json
{
  "active": false,
  "communicationFormat": "soap",
  "encryptionProtocol": "TLSv1.2",
  "type": "type4",
  "url": "http://www.adyen.com",
  "_links": {
    "company": {
      "href": "href2"
    },
    "generateHmac": {
      "href": "href6"
    },
    "merchant": {
      "href": "href6"
    },
    "self": {
      "href": "href0"
    },
    "testWebhook": {
      "href": "href6"
    }
  },
  "acceptsExpiredCertificate": false,
  "acceptsSelfSignedCertificate": false,
  "acceptsUntrustedRootCertificate": false,
  "accountReference": "accountReference6"
}
```

