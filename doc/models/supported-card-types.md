
# Supported Card Types

## Structure

`SupportedCardTypes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credit` | `bool?` | Optional | Set to **true** to accept credit cards. |
| `Debit` | `bool?` | Optional | Set to **true** to accept debit cards. |
| `DeferredDebit` | `bool?` | Optional | Set to **true** to accept cards that allow deferred debit. |
| `Prepaid` | `bool?` | Optional | Set to **true** to accept prepaid cards. |
| `Unknown` | `bool?` | Optional | Set to **true** to accept card types for which the terminal can't determine the funding source while offline. |

## Example (as JSON)

```json
{
  "credit": false,
  "debit": false,
  "deferredDebit": false,
  "prepaid": false,
  "unknown": false
}
```

