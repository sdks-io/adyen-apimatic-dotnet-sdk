
# List Company Users Response

## Structure

`ListCompanyUsersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Links` | [`PaginationLinks1`](../../doc/models/pagination-links-1.md) | Optional | Pagination references. |
| `Data` | [`List<CompanyUser>`](../../doc/models/company-user.md) | Optional | The list of users. |
| `ItemsTotal` | `int` | Required | Total number of items. |
| `PagesTotal` | `int` | Required | Total number of pages. |

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
      "_links": {
        "self": {
          "href": "href0"
        }
      },
      "accountGroups": [
        "accountGroups7"
      ],
      "active": false,
      "apps": [
        "apps4",
        "apps5",
        "apps6"
      ],
      "associatedMerchantAccounts": [
        "associatedMerchantAccounts0",
        "associatedMerchantAccounts1",
        "associatedMerchantAccounts2"
      ],
      "email": "email6",
      "id": "id0",
      "roles": [
        "roles8"
      ],
      "timeZoneCode": "timeZoneCode2",
      "username": "username0"
    },
    {
      "_links": {
        "self": {
          "href": "href0"
        }
      },
      "accountGroups": [
        "accountGroups7"
      ],
      "active": false,
      "apps": [
        "apps4",
        "apps5",
        "apps6"
      ],
      "associatedMerchantAccounts": [
        "associatedMerchantAccounts0",
        "associatedMerchantAccounts1",
        "associatedMerchantAccounts2"
      ],
      "email": "email6",
      "id": "id0",
      "roles": [
        "roles8"
      ],
      "timeZoneCode": "timeZoneCode2",
      "username": "username0"
    },
    {
      "_links": {
        "self": {
          "href": "href0"
        }
      },
      "accountGroups": [
        "accountGroups7"
      ],
      "active": false,
      "apps": [
        "apps4",
        "apps5",
        "apps6"
      ],
      "associatedMerchantAccounts": [
        "associatedMerchantAccounts0",
        "associatedMerchantAccounts1",
        "associatedMerchantAccounts2"
      ],
      "email": "email6",
      "id": "id0",
      "roles": [
        "roles8"
      ],
      "timeZoneCode": "timeZoneCode2",
      "username": "username0"
    }
  ],
  "itemsTotal": 162,
  "pagesTotal": 124
}
```

