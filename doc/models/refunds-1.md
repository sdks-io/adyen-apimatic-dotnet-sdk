
# Refunds 1

Settings for refunds.

## Structure

`Refunds1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Referenced` | [`Referenced1`](../../doc/models/referenced-1.md) | Optional | Settings for referenced refunds. |
| `Unreferenced` | [`Unreferenced2`](../../doc/models/unreferenced-2.md) | Optional | Settings for unreferenced refunds. |

## Example (as JSON)

```json
{
  "referenced": {
    "enableStandaloneRefunds": false
  },
  "unreferenced": {
    "enableUnreferencedRefunds": false
  }
}
```

