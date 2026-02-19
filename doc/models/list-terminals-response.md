
# List Terminals Response

## Structure

`ListTerminalsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Links` | [`PaginationLinks1`](../../doc/models/pagination-links-1.md) | Optional | Pagination references. |
| `Data` | [`List<Terminal>`](../../doc/models/terminal.md) | Optional | The list of terminals and their details. |
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
      "assignment": {
        "companyId": "companyId6",
        "merchantId": "merchantId2",
        "reassignmentTarget": {
          "companyId": "companyId4",
          "inventory": false,
          "merchantId": "merchantId0",
          "storeId": "storeId8"
        },
        "status": "inventory",
        "storeId": "storeId0"
      },
      "connectivity": {
        "bluetooth": {
          "ipAddress": "ipAddress2",
          "macAddress": "macAddress2"
        },
        "cellular": {
          "iccid": "iccid6",
          "iccid2": "iccid24",
          "status": "deprecated"
        },
        "ethernet": {
          "ipAddress": "ipAddress2",
          "linkNegotiation": "linkNegotiation6",
          "macAddress": "macAddress2"
        },
        "wifi": {
          "ipAddress": "ipAddress8",
          "macAddress": "macAddress6",
          "ssid": "ssid4"
        }
      },
      "firmwareVersion": "firmwareVersion2",
      "id": "id0",
      "installedAPKs": [
        {
          "confirmationDate": "2016-03-13T12:52:32.123Z",
          "packageName": "packageName6",
          "versionName": "versionName6"
        }
      ]
    },
    {
      "assignment": {
        "companyId": "companyId6",
        "merchantId": "merchantId2",
        "reassignmentTarget": {
          "companyId": "companyId4",
          "inventory": false,
          "merchantId": "merchantId0",
          "storeId": "storeId8"
        },
        "status": "inventory",
        "storeId": "storeId0"
      },
      "connectivity": {
        "bluetooth": {
          "ipAddress": "ipAddress2",
          "macAddress": "macAddress2"
        },
        "cellular": {
          "iccid": "iccid6",
          "iccid2": "iccid24",
          "status": "deprecated"
        },
        "ethernet": {
          "ipAddress": "ipAddress2",
          "linkNegotiation": "linkNegotiation6",
          "macAddress": "macAddress2"
        },
        "wifi": {
          "ipAddress": "ipAddress8",
          "macAddress": "macAddress6",
          "ssid": "ssid4"
        }
      },
      "firmwareVersion": "firmwareVersion2",
      "id": "id0",
      "installedAPKs": [
        {
          "confirmationDate": "2016-03-13T12:52:32.123Z",
          "packageName": "packageName6",
          "versionName": "versionName6"
        }
      ]
    }
  ],
  "itemsTotal": 90,
  "pagesTotal": 52
}
```

