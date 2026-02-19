
# Create Company Api Credential Request

## Structure

`CreateCompanyApiCredentialRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllowedOrigins` | `List<string>` | Optional | List of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the new API credential. |
| `AssociatedMerchantAccounts` | `List<string>` | Optional | List of merchant accounts that the API credential has access to. |
| `Description` | `string` | Optional | Description of the API credential. |
| `Roles` | `List<string>` | Optional | List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential. Only roles assigned to 'ws@Company.<CompanyName>' can be assigned to other API credentials. |

## Example (as JSON)

```json
{
  "allowedOrigins": [
    "allowedOrigins6",
    "allowedOrigins5",
    "allowedOrigins4"
  ],
  "associatedMerchantAccounts": [
    "associatedMerchantAccounts0",
    "associatedMerchantAccounts1"
  ],
  "description": "description0",
  "roles": [
    "roles4",
    "roles3"
  ]
}
```

