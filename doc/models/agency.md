
# Agency

## Structure

`Agency`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InvoiceNumber` | `string` | Optional | The reference number for the invoice, issued by the agency.<br><br>* Encoding: ASCII<br>* minLength: 1 character<br>* maxLength: 6 characters |
| `PlanName` | `string` | Optional | The two-letter agency plan identifier.<br><br>* Encoding: ASCII<br>* minLength: 2 characters<br>* maxLength: 2 characters |

## Example (as JSON)

```json
{
  "invoiceNumber": "invoiceNumber6",
  "planName": "planName6"
}
```

