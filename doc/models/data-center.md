
# Data Center

## Structure

`DataCenter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LivePrefix` | `string` | Optional | The unique [live URL prefix](https://docs.adyen.com/development-resources/live-endpoints#live-url-prefix) for your live endpoint. Each data center has its own live URL prefix.<br><br>This field is empty for requests made in the test environment. |
| `Name` | `string` | Optional | The name assigned to a data center, for example **EU** for the European data center. Possible values are:<br><br>* **default**: the European data center. This value is always returned in the test environment.<br>* **AU**<br>* **EU**<br>* **US** |

## Example (as JSON)

```json
{
  "livePrefix": "livePrefix4",
  "name": "name6"
}
```

