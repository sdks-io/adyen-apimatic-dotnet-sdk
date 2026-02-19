
# Checkout Forward Response From Url 2

The details of the response Adyen received from the third party.

## Structure

`CheckoutForwardResponseFromUrl2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Body` | `string` | Optional | The body of the response Adyen received from the third party, in string format. |
| `Headers` | `Dictionary<string, string>` | Optional | The HTTP headers of the response Adyen received from the third party. |
| `Status` | `int?` | Optional | The HTTP status of the response Adyen received from the third party. |

## Example (as JSON)

```json
{
  "body": "body8",
  "headers": {
    "key0": "headers5",
    "key1": "headers6",
    "key2": "headers7"
  },
  "status": 2
}
```

