
# Checkout Forward Response From Url

## Structure

`CheckoutForwardResponseFromUrl`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Body` | `string` | Optional | The body of the response Adyen received from the third party, in string format. |
| `Headers` | `Dictionary<string, string>` | Optional | The HTTP headers of the response Adyen received from the third party. |
| `Status` | `int?` | Optional | The HTTP status of the response Adyen received from the third party. |

## Example (as JSON)

```json
{
  "body": "body0",
  "headers": {
    "key0": "headers7",
    "key1": "headers8",
    "key2": "headers9"
  },
  "status": 152
}
```

