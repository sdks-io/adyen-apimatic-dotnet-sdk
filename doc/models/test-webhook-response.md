
# Test Webhook Response

## Structure

`TestWebhookResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<TestOutput>`](../../doc/models/test-output.md) | Optional | List with test results. Each test webhook we send has a list element with the result. |

## Example (as JSON)

```json
{
  "data": [
    {
      "merchantId": "merchantId6",
      "output": "output8",
      "requestSent": "requestSent0",
      "responseCode": "responseCode0",
      "responseTime": "responseTime8",
      "status": "status2"
    }
  ]
}
```

