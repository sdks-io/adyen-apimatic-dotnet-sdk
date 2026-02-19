
# Localized Information 4

The localized information of the store.

## Structure

`LocalizedInformation4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LocalShopperStatement` | [`List<LocalShopperStatement>`](../../doc/models/local-shopper-statement.md) | Required | An array of local shopper statements. Card schemes use this in the bank statement.<br><br>For Japan local shopper statements in both ja-Hani and ja-Kana are required. |

## Example (as JSON)

```json
{
  "localShopperStatement": [
    {
      "script": "script4",
      "value": "value6"
    }
  ]
}
```

