
# Opi 1

Settings for an Oracle Payment Interface (OPI) integration.

## Structure

`Opi1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EnablePayAtTable` | `bool?` | Optional | Indicates if Pay at table is enabled. |
| `PayAtTableStoreNumber` | `string` | Optional | The store number to use for Pay at Table. |
| `PayAtTableUrl` | `string` | Optional | The URL and port number used for Pay at Table communication. |

## Example (as JSON)

```json
{
  "enablePayAtTable": false,
  "payAtTableStoreNumber": "payAtTableStoreNumber6",
  "payAtTableURL": "payAtTableURL6"
}
```

