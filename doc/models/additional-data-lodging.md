
# Additional Data Lodging

## Structure

`AdditionalDataLodging`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LodgingSpecialProgramCode` | `string` | Optional | A code that corresponds to the category of lodging charges for the payment. Possible values:<br><br>* 1: Lodging<br>* 2: No show reservation<br>* 3: Advanced deposit |
| `LodgingCheckInDate` | `string` | Optional | The arrival date.<br><br>* Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**. |
| `LodgingCheckOutDate` | `string` | Optional | The departure date.<br><br>* Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**. |
| `LodgingCustomerServiceTollFreeNumber` | `string` | Optional | The toll-free phone number for the lodging.<br><br>* Format: numeric<br>* Max length: 17 characters.<br>* For US and CA numbers must be 10 characters in length<br>* Must not start with a space<br>* Must not contain any special characters such as + or -<br>* Must not be all zeros. |
| `LodgingFireSafetyActIndicator` | `string` | Optional | Identifies that the facility complies with the Hotel and Motel Fire Safety Act of 1990. Must be 'Y' or 'N'.<br><br>* Format: alphabetic<br>* Max length: 1 character |
| `LodgingFolioCashAdvances` | `string` | Optional | The folio cash advances, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* Format: numeric<br>* Max length: 12 characters |
| `LodgingFolioNumber` | `string` | Optional | The card acceptor’s internal invoice or billing ID reference number.<br><br>* Max length: 25 characters<br>* Must not start with a space<br>* Must not contain any special characters<br>* Must not be all zeros. |
| `LodgingFoodBeverageCharges` | `string` | Optional | Any charges for food and beverages associated with the booking, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* Format: numeric<br>* Max length: 12 characters |
| `LodgingNoShowIndicator` | `string` | Optional | Indicates if the customer didn't check in for their booking.<br>Possible values:<br><br>* **Y**: the customer didn't check in<br>* **N**: the customer checked in |
| `LodgingPrepaidExpenses` | `string` | Optional | The prepaid expenses for the booking.<br><br>* Format: numeric<br>* Max length: 12 characters |
| `LodgingPropertyPhoneNumber` | `string` | Optional | The lodging property location's phone number.<br><br>* Format: numeric<br>* Min length: 10 characters<br>* Max length: 17 characters<br>* For US and CA numbers must be 10 characters in length<br>* Must not start with a space<br>* Must not contain any special characters such as + or -<br>* Must not be all zeros. |
| `LodgingRoom1NumberOfNights` | `string` | Optional | The total number of nights the room is booked for.<br><br>* Format: numeric<br>* Must be a number between 0 and 99<br>* Max length: 4 characters |
| `LodgingRoom1Rate` | `string` | Optional | The rate for the room, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* Format: numeric<br>* Max length: 12 characters<br>* Must not be a negative number |
| `LodgingTotalRoomTax` | `string` | Optional | The total room tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* Format: numeric<br>* Max length: 12 characters<br>* Must not be a negative number |
| `LodgingTotalTax` | `string` | Optional | The total tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* Format: numeric<br>* Max length: 12 characters<br>* Must not be a negative number |
| `TravelEntertainmentAuthDataDuration` | `string` | Optional | The number of nights. This should be included in the auth message.<br><br>* Format: numeric<br>* Max length: 4 characters |
| `TravelEntertainmentAuthDataMarket` | `string` | Optional | Indicates what market-specific dataset will be submitted. Must be 'H' for Hotel. This should be included in the auth message.<br><br>* Format: alphanumeric<br>* Max length: 1 character |

## Example (as JSON)

```json
{
  "lodging.SpecialProgramCode": "lodging.SpecialProgramCode8",
  "lodging.checkInDate": "lodging.checkInDate2",
  "lodging.checkOutDate": "lodging.checkOutDate6",
  "lodging.customerServiceTollFreeNumber": "lodging.customerServiceTollFreeNumber4",
  "lodging.fireSafetyActIndicator": "lodging.fireSafetyActIndicator4"
}
```

