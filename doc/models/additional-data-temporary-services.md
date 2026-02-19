
# Additional Data Temporary Services

## Structure

`AdditionalDataTemporaryServices`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EnhancedSchemeDataCustomerReference` | `string` | Optional | The customer code, if supplied by a customer.<br><br>* Encoding: ASCII<br>* maxLength: 25 |
| `EnhancedSchemeDataEmployeeName` | `string` | Optional | The name or ID of the person working in a temporary capacity.<br><br>* maxLength: 40.<br>* Must not be all spaces.<br>  *Must not be all zeros. |
| `EnhancedSchemeDataJobDescription` | `string` | Optional | The job description of the person working in a temporary capacity.<br><br>* maxLength: 40<br>* Must not be all spaces.<br>  *Must not be all zeros. |
| `EnhancedSchemeDataRegularHoursRate` | `string` | Optional | The amount paid for regular hours worked, [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* maxLength: 7<br>* Must not be empty<br>* Can be all zeros |
| `EnhancedSchemeDataRegularHoursWorked` | `string` | Optional | The hours worked.<br><br>* maxLength: 7<br>* Must not be empty<br>* Can be all zeros |
| `EnhancedSchemeDataRequestName` | `string` | Optional | The name of the person requesting temporary services.<br><br>* maxLength: 40<br>* Must not be all zeros<br>* Must not be all spaces |
| `EnhancedSchemeDataTempStartDate` | `string` | Optional | The billing period start date.<br><br>* Format: ddMMyy<br>* maxLength: 6 |
| `EnhancedSchemeDataTempWeekEnding` | `string` | Optional | The billing period end date.<br><br>* Format: ddMMyy<br>* maxLength: 6 |
| `EnhancedSchemeDataTotalTaxAmount` | `string` | Optional | The total tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes). For example, 2000 means USD 20.00<br><br>* maxLength: 12 |

## Example (as JSON)

```json
{
  "enhancedSchemeData.customerReference": "enhancedSchemeData.customerReference4",
  "enhancedSchemeData.employeeName": "enhancedSchemeData.employeeName4",
  "enhancedSchemeData.jobDescription": "enhancedSchemeData.jobDescription4",
  "enhancedSchemeData.regularHoursRate": "enhancedSchemeData.regularHoursRate8",
  "enhancedSchemeData.regularHoursWorked": "enhancedSchemeData.regularHoursWorked8"
}
```

