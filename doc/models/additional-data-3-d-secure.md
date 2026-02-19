
# Additional Data 3 D Secure

## Structure

`AdditionalData3DSecure`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Allow3Ds2` | `string` | Optional | Indicates if you are able to process 3D Secure 2 transactions natively on your payment page. Send this parameter when you are using `/payments` endpoint with any of our [native 3D Secure 2 solutions](https://docs.adyen.com/online-payments/3d-secure/native-3ds2).<br><br>> This parameter only indicates readiness to support native 3D Secure 2 authentication. To specify if you _want_ to perform 3D Secure, use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) or send the `executeThreeD` parameter.<br><br>Possible values:<br><br>* **true** - Ready to support native 3D Secure 2 authentication. Setting this to true does not mean always applying 3D Secure 2. Adyen selects redirect or native authentication based on your configuration to optimize authorization rates and improve the shopper's experience.<br>* **false** – Not ready to support native 3D Secure 2 authentication. Adyen offers redirect 3D Secure 2 authentication instead, based on your configuration. |
| `ChallengeWindowSize` | [`ChallengeWindowSize?`](../../doc/models/challenge-window-size.md) | Optional | Dimensions of the 3DS2 challenge window to be displayed to the cardholder.<br><br>Possible values:<br><br>* **01** - size of 250x400<br>* **02** - size of 390x400<br>* **03** - size of 500x600<br>* **04** - size of 600x400<br>* **05** - Fullscreen |
| `ExecuteThreeD` | `string` | Optional | Indicates if you want to perform 3D Secure authentication on a transaction.<br><br>> Alternatively, you can use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) to configure rules for applying 3D Secure.<br><br>Possible values:<br><br>* **true** – Perform 3D Secure authentication.<br>* **false** – Don't perform 3D Secure authentication. Note that this setting results in refusals if the issuer mandates 3D Secure because of the PSD2 directive  or other, national regulations. |
| `MpiImplementationType` | `string` | Optional | In case of Secure+, this field must be set to **CUPSecurePlus**. |
| `ScaExemption` | `string` | Optional | Indicates the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that you want to request for the transaction.<br><br>Possible values:<br><br>* **lowValue**<br>* **secureCorporate**<br>* **trustedBeneficiary**<br>* **transactionRiskAnalysis** |
| `ThreeDsVersion` | `string` | Optional | Indicates your preference for the 3D Secure version.<br><br>> If you use this parameter, you override the checks from Adyen's Authentication Engine. We recommend to use this field only if you have an extensive knowledge of 3D Secure.<br><br>Possible values:<br><br>* **2.1.0**: Apply 3D Secure version 2.1.0.<br>* **2.2.0**: Apply 3D Secure version 2.2.0. If the issuer does not support version 2.2.0, we will fall back to 2.1.0.<br><br>The following rules apply:<br><br>* If you prefer 2.1.0 or 2.2.0 but we receive a negative `transStatus` in the `ARes`, we will apply the fallback policy configured in your account.<br>* If you the BIN is not enrolled, you will receive an error. |

## Example (as JSON)

```json
{
  "allow3DS2": "allow3DS24",
  "challengeWindowSize": "03",
  "executeThreeD": "executeThreeD6",
  "mpiImplementationType": "mpiImplementationType8",
  "scaExemption": "scaExemption0"
}
```

