
# Create Company User Request

## Structure

`CreateCompanyUserRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountGroups` | `List<string>` | Optional | The list of [account groups](https://docs.adyen.com/account/account-structure#account-groups) associated with this user. |
| `AssociatedMerchantAccounts` | `List<string>` | Optional | The list of [merchant accounts](https://docs.adyen.com/account/account-structure#merchant-accounts) associated with this user. |
| `Email` | `string` | Required | The email address of the user. |
| `LoginMethod` | `string` | Optional | The requested login method for the user. To use SSO, you must already have SSO configured with Adyen before creating the user.<br><br>Possible values: **Username & account**, **Email**, or **SSO** |
| `Name` | [`Name`](../../doc/models/name.md) | Required | The user's full name.<br><br>Allowed length: 1—80 characters. |
| `Roles` | `List<string>` | Optional | The list of [roles](https://docs.adyen.com/account/user-roles) for this user. |
| `TimeZoneCode` | `string` | Optional | The [tz database name](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones) of the time zone of the user. For example, **Europe/Amsterdam**. |
| `Username` | `string` | Required | The user's email address that will be their username. Must be the same as the one in the `email` field.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |

## Example (as JSON)

```json
{
  "accountGroups": [
    "accountGroups7",
    "accountGroups8",
    "accountGroups9"
  ],
  "associatedMerchantAccounts": [
    "associatedMerchantAccounts2"
  ],
  "email": "email4",
  "loginMethod": "loginMethod4",
  "name": {
    "firstName": "firstName4",
    "lastName": "lastName4"
  },
  "roles": [
    "roles4",
    "roles5",
    "roles6"
  ],
  "timeZoneCode": "timeZoneCode4",
  "username": "username8"
}
```

