
# Shopper Name 1

The shopper's full name. This object is required for some payment methods such as AfterPay, Klarna, or if you're enrolled in the PayPal Seller Protection program.

## Structure

`ShopperName1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Required | The first name.<br><br>**Constraints**: *Maximum Length*: `80` |
| `LastName` | `string` | Required | The last name.<br><br>**Constraints**: *Maximum Length*: `80` |

## Example (as JSON)

```json
{
  "firstName": "firstName4",
  "lastName": "lastName4"
}
```

