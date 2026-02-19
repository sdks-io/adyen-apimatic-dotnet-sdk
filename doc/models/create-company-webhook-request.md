
# Create Company Webhook Request

## Structure

`CreateCompanyWebhookRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AcceptsExpiredCertificate` | `bool?` | Optional | Indicates if expired SSL certificates are accepted. Default value: **false**. |
| `AcceptsSelfSignedCertificate` | `bool?` | Optional | Indicates if self-signed SSL certificates are accepted. Default value: **false**. |
| `AcceptsUntrustedRootCertificate` | `bool?` | Optional | Indicates if untrusted SSL certificates are accepted. Default value: **false**. |
| `Active` | `bool` | Required | Indicates if the webhook configuration is active. The field must be **true** for us to send webhooks about events related an account. |
| `AdditionalSettings` | [`AdditionalSettings1`](../../doc/models/additional-settings-1.md) | Optional | Additional shopper and transaction information to be included in your [standard webhooks](https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes). Find out more about the available [additional settings](https://docs.adyen.com/development-resources/webhooks/additional-settings). |
| `CommunicationFormat` | [`CommunicationFormat`](../../doc/models/communication-format.md) | Required | Format or protocol for receiving webhooks. Possible values:<br><br>* **soap**<br>* **http**<br>* **json** |
| `Description` | `string` | Optional | Your description for this webhook configuration. |
| `EncryptionProtocol` | [`EncryptionProtocol?`](../../doc/models/encryption-protocol.md) | Optional | SSL version to access the public webhook URL specified in the `url` field. Possible values:<br><br>* **TLSv1.3**<br>* **TLSv1.2**<br>* **HTTP** - Only allowed on Test environment.<br><br>If not specified, the webhook will use `sslVersion`: **TLSv1.2**. |
| `FilterMerchantAccountType` | [`FilterMerchantAccountType`](../../doc/models/filter-merchant-account-type.md) | Required | Shows how merchant accounts are filtered when configuring the webhook.<br><br>Possible values:<br><br>* **allAccounts** : Includes all merchant accounts, and does not require specifying `filterMerchantAccounts`.<br>* **includeAccounts** : The webhook is configured for the merchant accounts listed in `filterMerchantAccounts`.<br>* **excludeAccounts** : The webhook is not configured for the merchant accounts listed in `filterMerchantAccounts`. |
| `FilterMerchantAccounts` | `List<string>` | Required | A list of merchant account names that are included or excluded from receiving the webhook. Inclusion or exclusion is based on the value defined for `filterMerchantAccountType`.<br><br>Required if `filterMerchantAccountType` is either:<br><br>* **includeAccounts**<br>* **excludeAccounts**<br><br>Not needed for `filterMerchantAccountType`: **allAccounts**. |
| `NetworkType` | [`NetworkType?`](../../doc/models/network-type.md) | Optional | Network type for Terminal API notification webhooks. Possible values:<br><br>* **public**<br>* **local**<br><br>Default Value: **public**. |
| `Password` | `string` | Optional | Password to access the webhook URL. |
| `PopulateSoapActionHeader` | `bool?` | Optional | Indicates if the SOAP action header needs to be populated. Default value: **false**.<br><br>Only applies if `communicationFormat`: **soap**. |
| `Type` | `string` | Required | The type of webhook that is being created. Possible values are:<br><br>- **standard**<br>- **account-settings-notification**<br>- **banktransfer-notification**<br>- **boletobancario-notification**<br>- **directdebit-notification**<br>- **ach-notification-of-change-notification**<br>- **direct-debit-notice-of-change-notification**<br>- **pending-notification**<br>- **ideal-notification**<br>- **ideal-pending-notification**<br>- **report-notification**<br>- **rreq-notification**<br>- **terminal-settings**<br>- **terminal-boarding**<br><br>Find out more about [standard webhooks](https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes) and [other types of webhooks](https://docs.adyen.com/development-resources/webhooks/webhook-types/#other-webhooks). |
| `Url` | `string` | Required | Public URL where webhooks will be sent, for example **https://www.domain.com/webhook-endpoint**. |
| `Username` | `string` | Optional | Username to access the webhook URL.<br><br>**Constraints**: *Maximum Length*: `255` |

## Example (as JSON)

```json
{
  "active": false,
  "communicationFormat": "soap",
  "encryptionProtocol": "TLSv1.2",
  "filterMerchantAccountType": "excludeAccounts",
  "filterMerchantAccounts": [
    "filterMerchantAccounts6",
    "filterMerchantAccounts5",
    "filterMerchantAccounts4"
  ],
  "type": "type0",
  "url": "http://www.adyen.com",
  "acceptsExpiredCertificate": false,
  "acceptsSelfSignedCertificate": false,
  "acceptsUntrustedRootCertificate": false,
  "additionalSettings": {
    "includeEventCodes": [
      "includeEventCodes8"
    ],
    "properties": {
      "key0": false,
      "key1": true
    }
  },
  "description": "description0"
}
```

