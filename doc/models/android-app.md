
# Android App

## Structure

`AndroidApp`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | The description that was provided when uploading the app. The description is not shown on the terminal. |
| `ErrorCode` | `string` | Optional | The error code of the Android app with the `status` of either **error** or **invalid**. |
| `Errors` | [`List<AndroidAppError>`](../../doc/models/android-app-error.md) | Optional | The list of errors of the Android app. |
| `Id` | `string` | Required | The unique identifier of the app. |
| `Label` | `string` | Optional | The app name that is shown on the terminal. |
| `PackageName` | `string` | Optional | The package name that uniquely identifies the Android app. |
| `Status` | [`Status5`](../../doc/models/status-5.md) | Required | The status of the app. Possible values:<br><br>* `processing`: the app is being signed and converted to a format that the terminal can handle.<br>* `error`: something went wrong. Check that the app matches the [requirements](https://docs.adyen.com/point-of-sale/android-terminals/app-requirements).<br>* `invalid`: there is something wrong with the APK file of the app.<br>* `ready`: the app has been signed and converted.<br>* `archived`: the app is no longer available. |
| `VersionCode` | `int?` | Optional | The version number of the app. |
| `VersionName` | `string` | Optional | The app version number that is shown on the terminal. |

## Example (as JSON)

```json
{
  "description": "description0",
  "errorCode": "errorCode6",
  "errors": [
    {
      "errorCode": "errorCode6",
      "terminalModels": [
        "terminalModels3",
        "terminalModels4"
      ]
    },
    {
      "errorCode": "errorCode6",
      "terminalModels": [
        "terminalModels3",
        "terminalModels4"
      ]
    }
  ],
  "id": "id0",
  "label": "label0",
  "packageName": "packageName6",
  "status": "invalid"
}
```

