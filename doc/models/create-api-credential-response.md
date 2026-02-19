
# Create Api Credential Response

## Structure

`CreateApiCredentialResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Links` | [`ApiCredentialLinks2`](../../doc/models/api-credential-links-2.md) | Optional | References to resources linked to the API credential. |
| `Active` | `bool` | Required | Indicates if the API credential is enabled. Must be set to **true** to use the credential in your integration. |
| `AllowedIpAddresses` | `List<string>` | Required | List of IP addresses from which your client can make requests.<br><br>If the list is empty, we allow requests from any IP.<br>If the list is not empty and we get a request from an IP which is not on the list, you get a security error. |
| `AllowedOrigins` | [`List<AllowedOrigin>`](../../doc/models/allowed-origin.md) | Optional | List containing the [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) linked to the API credential. |
| `ApiKey` | `string` | Required | The API key for the API credential that was created. |
| `ClientKey` | `string` | Required | Public key used for [client-side authentication](https://docs.adyen.com/development-resources/client-side-authentication). The client key is required for Drop-in and Components integrations. |
| `Description` | `string` | Optional | Description of the API credential.<br><br>**Constraints**: *Maximum Length*: `50` |
| `Id` | `string` | Required | Unique identifier of the API credential. |
| `Password` | `string` | Required | The password for the API credential that was created. |
| `Roles` | `List<string>` | Required | List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential. |
| `Username` | `string` | Required | The name of the [API credential](https://docs.adyen.com/development-resources/api-credentials), for example **ws@Company.TestCompany**. |

## Example (as JSON)

```json
{
  "_links": {
    "allowedOrigins": {
      "href": "href6"
    },
    "company": {
      "href": "href2"
    },
    "generateApiKey": {
      "href": "href6"
    },
    "generateClientKey": {
      "href": "href4"
    },
    "merchant": {
      "href": "href6"
    },
    "self": {
      "href": "href0"
    }
  },
  "active": false,
  "allowedIpAddresses": [
    "allowedIpAddresses5",
    "allowedIpAddresses4",
    "allowedIpAddresses3"
  ],
  "allowedOrigins": [
    {
      "_links": {
        "self": {
          "href": "href0"
        }
      },
      "domain": "domain0",
      "id": "id4"
    },
    {
      "_links": {
        "self": {
          "href": "href0"
        }
      },
      "domain": "domain0",
      "id": "id4"
    }
  ],
  "apiKey": "apiKey0",
  "clientKey": "clientKey6",
  "description": "description0",
  "id": "id0",
  "password": "password4",
  "roles": [
    "roles6",
    "roles7",
    "roles8"
  ],
  "username": "username0"
}
```

