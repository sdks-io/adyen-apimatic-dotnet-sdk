
# Additional Data Car Rental

## Structure

`AdditionalDataCarRental`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CarRentalCheckOutDate` | `string` | Optional | The pick-up date.<br><br>* Date format: `yyyyMMdd` |
| `CarRentalCustomerServiceTollFreeNumber` | `string` | Optional | The customer service phone number of the car rental company.<br><br>* Format: Alphanumeric<br>* maxLength: 17<br>* For US and CA numbers must be 10 characters in length<br>* Must not start with a space<br>* Must not contain any special characters such as + or -<br>  *Must not be all zeros. |
| `CarRentalDaysRented` | `string` | Optional | Number of days for which the car is being rented.<br><br>* Format: Numeric<br>* maxLength: 4<br>* Must not be all spaces |
| `CarRentalFuelCharges` | `string` | Optional | Any fuel charges associated with the rental, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* Format: Numeric<br>* maxLength: 12 |
| `CarRentalInsuranceCharges` | `string` | Optional | Any insurance charges associated with the rental, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* Format: Numeric<br>* maxLength: 12<br>* Must not be all spaces<br>  *Must not be all zeros. |
| `CarRentalLocationCity` | `string` | Optional | The city where the car is rented.<br><br>* Format: Alphanumeric<br>* maxLength: 18<br>* Must not start with a space or be all spaces<br>  *Must not be all zeros. |
| `CarRentalLocationCountry` | `string` | Optional | The country where the car is rented, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format.<br><br>* Format: Alphanumeric<br>* maxLength: 2 |
| `CarRentalLocationStateProvince` | `string` | Optional | The state or province where the car is rented.<br><br>* Format: Alphanumeric<br>* maxLength: 2<br>* Must not start with a space or be all spaces<br>  *Must not be all zeros. |
| `CarRentalNoShowIndicator` | `string` | Optional | Indicates if the customer didn't pick up their rental car.<br><br>* Y - Customer did not pick up their car<br>* N - Not applicable |
| `CarRentalOneWayDropOffCharges` | `string` | Optional | The charge for not returning a car to the original rental location, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* maxLength: 12 |
| `CarRentalRate` | `string` | Optional | The daily rental rate, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* Format: Alphanumeric<br>* maxLength: 12 |
| `CarRentalRateIndicator` | `string` | Optional | Specifies whether the given rate is applied daily or weekly.<br><br>* D - Daily rate<br>* W - Weekly rate |
| `CarRentalRentalAgreementNumber` | `string` | Optional | The rental agreement number for the car rental.<br><br>* Format: Alphanumeric<br>* maxLength: 9<br>* Must not start with a space or be all spaces<br>  *Must not be all zeros. |
| `CarRentalRentalClassId` | `string` | Optional | The classification of the rental car.<br><br>* Format: Alphanumeric<br>* maxLength: 4<br>* Must not start with a space or be all spaces<br>  *Must not be all zeros. |
| `CarRentalRenterName` | `string` | Optional | The name of the person renting the car.<br><br>* Format: Alphanumeric<br>* maxLength: 26<br>* If you send more than 26 characters, the name is truncated<br>* Must not start with a space or be all spaces<br>  *Must not be all zeros. |
| `CarRentalReturnCity` | `string` | Optional | The city where the car must be returned.<br><br>* Format: Alphanumeric<br>* maxLength: 18<br>* Must not start with a space or be all spaces<br>  *Must not be all zeros. |
| `CarRentalReturnCountry` | `string` | Optional | The country where the car must be returned, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format.<br><br>* Format: Alphanumeric<br>* maxLength: 2 |
| `CarRentalReturnDate` | `string` | Optional | The last date to return the car by.<br><br>* Date format: `yyyyMMdd`<br>* maxLength: 8 |
| `CarRentalReturnLocationId` | `string` | Optional | The agency code, phone number, or address abbreviation<br><br>* Format: Alphanumeric<br>* maxLength: 10<br>* Must not start with a space or be all spaces<br>  *Must not be all zeros. |
| `CarRentalReturnStateProvince` | `string` | Optional | The state or province where the car must be returned.<br><br>* Format: Alphanumeric<br>* maxLength: 3<br>* Must not start with a space or be all spaces<br>  *Must not be all zeros. |
| `CarRentalTaxExemptIndicator` | `string` | Optional | Indicates if the goods or services were tax-exempt, or if tax was not paid on them.<br><br>Values:<br><br>* Y - Goods or services were tax exempt<br>* N - Tax was not collected |
| `TravelEntertainmentAuthDataDuration` | `string` | Optional | Number of days the car is rented for. This should be included in the auth message.<br><br>* Format: Numeric<br>* maxLength: 4 |
| `TravelEntertainmentAuthDataMarket` | `string` | Optional | Indicates what market-specific dataset will be submitted or is being submitted. Value should be 'A' for car rental. This should be included in the auth message.<br><br>* Format: Alphanumeric<br>* maxLength: 1 |

## Example (as JSON)

```json
{
  "carRental.checkOutDate": "carRental.checkOutDate4",
  "carRental.customerServiceTollFreeNumber": "carRental.customerServiceTollFreeNumber6",
  "carRental.daysRented": "carRental.daysRented8",
  "carRental.fuelCharges": "carRental.fuelCharges6",
  "carRental.insuranceCharges": "carRental.insuranceCharges6"
}
```

