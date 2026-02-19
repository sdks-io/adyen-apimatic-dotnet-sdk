
# Input Detail

## Structure

`InputDetail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Configuration` | `Dictionary<string, string>` | Optional | Configuration parameters for the required input. |
| `Details` | [`List<SubInputDetail>`](../../doc/models/sub-input-detail.md) | Optional | Input details can also be provided recursively. |
| `InputDetails` | [`List<SubInputDetail>`](../../doc/models/sub-input-detail.md) | Optional | Input details can also be provided recursively (deprecated). |
| `ItemSearchUrl` | `string` | Optional | In case of a select, the URL from which to query the items. |
| `Items` | [`List<Item>`](../../doc/models/item.md) | Optional | In case of a select, the items to choose from. |
| `Key` | `string` | Optional | The value to provide in the result. |
| `Optional` | `bool?` | Optional | True if this input value is optional. |
| `Type` | `string` | Optional | The type of the required input. |
| `MValue` | `string` | Optional | The value can be pre-filled, if available. |

## Example (as JSON)

```json
{
  "configuration": {
    "key0": "configuration0",
    "key1": "configuration1",
    "key2": "configuration2"
  },
  "details": [
    {
      "configuration": {
        "key0": "configuration6",
        "key1": "configuration7"
      },
      "items": [
        {
          "id": "id8",
          "name": "name8"
        }
      ],
      "key": "key0",
      "optional": false,
      "type": "type0"
    },
    {
      "configuration": {
        "key0": "configuration6",
        "key1": "configuration7"
      },
      "items": [
        {
          "id": "id8",
          "name": "name8"
        }
      ],
      "key": "key0",
      "optional": false,
      "type": "type0"
    },
    {
      "configuration": {
        "key0": "configuration6",
        "key1": "configuration7"
      },
      "items": [
        {
          "id": "id8",
          "name": "name8"
        }
      ],
      "key": "key0",
      "optional": false,
      "type": "type0"
    }
  ],
  "inputDetails": [
    {
      "configuration": {
        "key0": "configuration6"
      },
      "items": [
        {
          "id": "id8",
          "name": "name8"
        },
        {
          "id": "id8",
          "name": "name8"
        },
        {
          "id": "id8",
          "name": "name8"
        }
      ],
      "key": "key0",
      "optional": false,
      "type": "type0"
    },
    {
      "configuration": {
        "key0": "configuration6"
      },
      "items": [
        {
          "id": "id8",
          "name": "name8"
        },
        {
          "id": "id8",
          "name": "name8"
        },
        {
          "id": "id8",
          "name": "name8"
        }
      ],
      "key": "key0",
      "optional": false,
      "type": "type0"
    }
  ],
  "itemSearchUrl": "itemSearchUrl0",
  "items": [
    {
      "id": "id8",
      "name": "name8"
    },
    {
      "id": "id8",
      "name": "name8"
    }
  ]
}
```

