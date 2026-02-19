
# Payment Validations Name Result Raw Response 2

Contains the raw response(s) returned by the scheme for the name validation.

## Structure

`PaymentValidationsNameResultRawResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Optional | The raw first name validation result that Adyen received from the scheme. First name validation result is only returned for Visa. |
| `FullName` | `string` | Optional | The raw full name validation result that Adyen received from the scheme. Full name is the only field that is validated for Mastercard |
| `LastName` | `string` | Optional | The raw last name validation result that Adyen received from the scheme. Last name validation result is only returned for Visa. |
| `MiddleName` | `string` | Optional | The raw middle name validation result that Adyen received from the scheme. Middle name validation result is only returned for Visa. |
| `Status` | `string` | Optional | The raw name validation status value that Adyen received from the scheme. Only returned for Visa. |

## Example (as JSON)

```json
{
  "firstName": "firstName8",
  "fullName": "fullName6",
  "lastName": "lastName0",
  "middleName": "middleName4",
  "status": "status2"
}
```

