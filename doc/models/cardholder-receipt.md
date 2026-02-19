
# Cardholder Receipt

## Structure

`CardholderReceipt`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HeaderForAuthorizedReceipt` | `string` | Optional | The structure of the header to show on the shopper receipt. You can define the order of one or two header lines and blank lines. For example, **header1,header2,filler**. The text of the header lines is defined in the Customer Area under **In-person payments** > **Terminal settings** > **Receipts** in the **Receipt lines** block. |

## Example (as JSON)

```json
{
  "headerForAuthorizedReceipt": "headerForAuthorizedReceipt6"
}
```

