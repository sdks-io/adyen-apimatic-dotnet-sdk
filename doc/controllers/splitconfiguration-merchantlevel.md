# Splitconfiguration-Merchantlevel

```csharp
SplitconfigurationMerchantlevelApi splitconfigurationMerchantlevelApi = client.SplitconfigurationMerchantlevelApi;
```

## Class Name

`SplitconfigurationMerchantlevelApi`

## Methods

* [List Split Configurations](../../doc/controllers/splitconfiguration-merchantlevel.md#list-split-configurations)
* [Create Split Configuration](../../doc/controllers/splitconfiguration-merchantlevel.md#create-split-configuration)
* [Delete Split Configuration](../../doc/controllers/splitconfiguration-merchantlevel.md#delete-split-configuration)
* [Get Split Configuration](../../doc/controllers/splitconfiguration-merchantlevel.md#get-split-configuration)
* [Update Split Configuration](../../doc/controllers/splitconfiguration-merchantlevel.md#update-split-configuration)
* [Create Split Configuration Rule](../../doc/controllers/splitconfiguration-merchantlevel.md#create-split-configuration-rule)
* [Delete Split Configuration Rule](../../doc/controllers/splitconfiguration-merchantlevel.md#delete-split-configuration-rule)
* [Update Split Configuration Rule](../../doc/controllers/splitconfiguration-merchantlevel.md#update-split-configuration-rule)
* [Update Split Logic](../../doc/controllers/splitconfiguration-merchantlevel.md#update-split-logic)


# List Split Configurations

Returns the list of split configuration profiles for the merchant account.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API - SplitConfiguration read and write

```csharp
ListSplitConfigurationsAsync(
    string merchantId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SplitConfigurationList](../../doc/models/split-configuration-list.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
try
{
    ApiResponse<SplitConfigurationList> result = await splitConfigurationMerchantLevelApi.ListSplitConfigurationsAsync(merchantId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
      "description": "Your description for the split configuration",
      "rules": [
        {
          "currency": "GBP",
          "fundingSource": "ANY",
          "paymentMethod": "ANY",
          "ruleId": "SCRL4224P22322585HP89PPCST6BCZ",
          "shopperInteraction": "ANY",
          "splitLogic": {
            "additionalCommission": {
              "fixedAmount": 100,
              "variablePercentage": 100,
              "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
            },
            "chargeback": "deductFromLiableAccount",
            "commission": {
              "fixedAmount": 200,
              "variablePercentage": 100
            },
            "splitLogicId": "SCLG4224P22322585HP89PPCSV27VP",
            "paymentFee": "deductFromLiableAccount",
            "remainder": "addToOneBalanceAccount",
            "tip": "addToOneBalanceAccount"
          }
        }
      ],
      "splitConfigurationId": "SCNF4224P22322585HP89PPCSS24MF"
    },
    {
      "description": "Your description for the second split configuration",
      "rules": [
        {
          "currency": "ANY",
          "fundingSource": "ANY",
          "paymentMethod": "ANY",
          "ruleId": "SCRL4224P22322585HPCX384JW65VW",
          "shopperInteraction": "ANY",
          "splitLogic": {
            "additionalCommission": {
              "fixedAmount": 10,
              "variablePercentage": 50,
              "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
            },
            "chargeback": "deductFromLiableAccount",
            "commission": {
              "fixedAmount": 10,
              "variablePercentage": 100
            },
            "splitLogicId": "SCLG4224P22322585HPCX384JX52M2",
            "paymentFee": "deductFromLiableAccount",
            "remainder": "addToOneBalanceAccount",
            "tip": "addToOneBalanceAccount"
          }
        },
        {
          "currency": "EUR",
          "fundingSource": "ANY",
          "paymentMethod": "visa",
          "ruleId": "SCRL4224P22322585HPCX5V4KV6L2R",
          "shopperInteraction": "ANY",
          "splitLogic": {
            "additionalCommission": {
              "fixedAmount": 100,
              "variablePercentage": 0,
              "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
            },
            "chargeback": "deductFromLiableAccount",
            "commission": {
              "fixedAmount": 100,
              "variablePercentage": 100
            },
            "splitLogicId": "SCLG4224P22322585HPCX5V4KW26C9",
            "paymentFee": "deductFromLiableAccount",
            "remainder": "addToLiableAccount",
            "tip": "addToLiableAccount"
          }
        }
      ],
      "splitConfigurationId": "SCNF4224P22322585HPCX384JV6JGX"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Create Split Configuration

Creates a split configuration profile to [split payments automatically](https://docs.adyen.com/platforms/automatic-split-configuration/). After you [associate it with a store](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId)/stores/(storeId)#request-splitConfiguration) in your merchant account, it splits the funds of all transactions processed through that store between your liable balance account and [your user's balance account](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId)/stores/(storeId)#request-splitConfiguration-balanceAccountId).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API - SplitConfiguration read and write

```csharp
CreateSplitConfigurationAsync(
    string merchantId,
    Models.SplitConfiguration body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `body` | [`SplitConfiguration`](../../doc/models/split-configuration.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SplitConfiguration](../../doc/models/split-configuration.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
SplitConfiguration body = new SplitConfiguration
{
    Description = "Your description for the split configuration",
    Rules = new List<SplitConfigurationRule>
    {
        new SplitConfigurationRule
        {
            Currency = "ANY",
            FundingSource = FundingSource1.Any,
            PaymentMethod = "ANY",
            ShopperInteraction = ShopperInteraction11.Any,
            SplitLogic = new SplitConfigurationLogic2
            {
                Commission = new Commission1
                {
                    FixedAmount = 10L,
                    VariablePercentage = 100L,
                },
                AdditionalCommission = new AdditionalCommission1
                {
                    BalanceAccountId = "BA3227C223222H5HQ2XX77VVH",
                    FixedAmount = 10L,
                    VariablePercentage = 50L,
                },
                Chargeback = Behavior.DeductFromLiableAccount,
                PaymentFee = PaymentFee.DeductFromLiableAccount,
                Remainder = Remainder.AddToOneBalanceAccount,
                Tip = Tip.AddToOneBalanceAccount,
            },
        },
    },
};

try
{
    ApiResponse<SplitConfiguration> result = await splitConfigurationMerchantLevelApi.CreateSplitConfigurationAsync(
        merchantId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "description": "Your description for the split configuration",
  "rules": [
    {
      "currency": "ANY",
      "fundingSource": "ANY",
      "paymentMethod": "ANY",
      "ruleId": "SCRL4224P22322585HPCX384JW65VW",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 10,
          "variablePercentage": 50,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 10,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX384JX52M2",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToOneBalanceAccount",
        "tip": "addToOneBalanceAccount"
      }
    }
  ],
  "splitConfigurationId": "SCNF4224P22322585HPCX384JV6JGX"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Delete Split Configuration

Deletes the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API - SplitConfiguration read and write

```csharp
DeleteSplitConfigurationAsync(
    string merchantId,
    string splitConfigurationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `splitConfigurationId` | `string` | Template, Required | The unique identifier of the split configuration. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SplitConfiguration](../../doc/models/split-configuration.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string splitConfigurationId = "splitConfigurationId4";
try
{
    ApiResponse<SplitConfiguration> result = await splitConfigurationMerchantLevelApi.DeleteSplitConfigurationAsync(
        merchantId,
        splitConfigurationId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Get Split Configuration

Returns the details of the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API - SplitConfiguration read and write

```csharp
GetSplitConfigurationAsync(
    string merchantId,
    string splitConfigurationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `splitConfigurationId` | `string` | Template, Required | The unique identifier of the split configuration. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SplitConfiguration](../../doc/models/split-configuration.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string splitConfigurationId = "splitConfigurationId4";
try
{
    ApiResponse<SplitConfiguration> result = await splitConfigurationMerchantLevelApi.GetSplitConfigurationAsync(
        merchantId,
        splitConfigurationId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "description": "Your description for the split configuration",
  "rules": [
    {
      "currency": "ANY",
      "fundingSource": "ANY",
      "paymentMethod": "ANY",
      "ruleId": "SCRL4224P22322585HPCX384JW65VW",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 10,
          "variablePercentage": 50,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 10,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX384JX52M2",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToOneBalanceAccount",
        "tip": "addToOneBalanceAccount"
      }
    },
    {
      "currency": "EUR",
      "fundingSource": "ANY",
      "paymentMethod": "visa",
      "ruleId": "SCRL4224P22322585HPCX5V4KV6L2R",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 100,
          "variablePercentage": 0,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 100,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX5V4KW26C9",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToLiableAccount",
        "tip": "addToLiableAccount"
      }
    }
  ],
  "splitConfigurationId": "SCNF4224P22322585HPCX384JV6JGX"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Update Split Configuration

Changes the description of the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API - SplitConfiguration read and write

```csharp
UpdateSplitConfigurationAsync(
    string merchantId,
    string splitConfigurationId,
    Models.UpdateSplitConfigurationRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `splitConfigurationId` | `string` | Template, Required | The unique identifier of the split configuration. |
| `body` | [`UpdateSplitConfigurationRequest`](../../doc/models/update-split-configuration-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SplitConfiguration](../../doc/models/split-configuration.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string splitConfigurationId = "splitConfigurationId4";
UpdateSplitConfigurationRequest body = new UpdateSplitConfigurationRequest
{
    Description = "Updated description for the split configuration",
};

try
{
    ApiResponse<SplitConfiguration> result = await splitConfigurationMerchantLevelApi.UpdateSplitConfigurationAsync(
        merchantId,
        splitConfigurationId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "description": "Updated description for the split configuration",
  "rules": [
    {
      "currency": "ANY",
      "fundingSource": "ANY",
      "paymentMethod": "ANY",
      "ruleId": "SCRL4224P22322585HPCX384JW65VW",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 10,
          "variablePercentage": 50,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 10,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX384JX52M2",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToOneBalanceAccount",
        "tip": "addToOneBalanceAccount"
      }
    },
    {
      "currency": "EUR",
      "fundingSource": "ANY",
      "paymentMethod": "visa",
      "ruleId": "SCRL4224P22322585HPCX5V4KV6L2R",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 100,
          "variablePercentage": 0,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 100,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX5V4KW26C9",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToLiableAccount",
        "tip": "addToLiableAccount"
      }
    }
  ],
  "splitConfigurationId": "SCNF4224P22322585HPCX384JV6JGX"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Create Split Configuration Rule

[Creates a rule](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#create-rule) in the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API - SplitConfiguration read and write

```csharp
CreateSplitConfigurationRuleAsync(
    string merchantId,
    string splitConfigurationId,
    Models.SplitConfigurationRule body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `splitConfigurationId` | `string` | Template, Required | The unique identifier of the split configuration. |
| `body` | [`SplitConfigurationRule`](../../doc/models/split-configuration-rule.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SplitConfiguration](../../doc/models/split-configuration.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string splitConfigurationId = "splitConfigurationId4";
SplitConfigurationRule body = new SplitConfigurationRule
{
    Currency = "USD",
    FundingSource = FundingSource1.Any,
    PaymentMethod = "visa",
    ShopperInteraction = ShopperInteraction11.Pos,
    SplitLogic = new SplitConfigurationLogic2
    {
        Commission = new Commission1
        {
            FixedAmount = 10L,
            VariablePercentage = 100L,
        },
        AdditionalCommission = new AdditionalCommission1
        {
            BalanceAccountId = "BA3227C223222H5HQ2XX77VVH",
            FixedAmount = 10L,
            VariablePercentage = 50L,
        },
        Chargeback = Behavior.DeductFromLiableAccount,
        PaymentFee = PaymentFee.DeductFromLiableAccount,
        Remainder = Remainder.AddToLiableAccount,
        Tip = Tip.AddToOneBalanceAccount,
    },
};

try
{
    ApiResponse<SplitConfiguration> result = await splitConfigurationMerchantLevelApi.CreateSplitConfigurationRuleAsync(
        merchantId,
        splitConfigurationId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "description": "My first split configuration",
  "rules": [
    {
      "currency": "ANY",
      "fundingSource": "ANY",
      "paymentMethod": "ANY",
      "ruleId": "SCRL4224P22322585HPCX384JW65VW",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 10,
          "variablePercentage": 50,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 10,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX384JX52M2",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToOneBalanceAccount",
        "tip": "addToOneBalanceAccount"
      }
    },
    {
      "currency": "USD",
      "fundingSource": "ANY",
      "paymentMethod": "visa",
      "ruleId": "SCRL4224P22322585HPCX5V4KV6L2R",
      "shopperInteraction": "POS",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 10,
          "variablePercentage": 50,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 10,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX5V4KW26C9",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToLiableAccount",
        "tip": "addToOneBalanceAccount"
      }
    }
  ],
  "splitConfigurationId": "SCNF4224P22322585HPCX384JV6JGX"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Delete Split Configuration Rule

Deletes the rule specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API - SplitConfiguration read and write

```csharp
DeleteSplitConfigurationRuleAsync(
    string merchantId,
    string splitConfigurationId,
    string ruleId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `splitConfigurationId` | `string` | Template, Required | The unique identifier of the split configuration. |
| `ruleId` | `string` | Template, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SplitConfiguration](../../doc/models/split-configuration.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string splitConfigurationId = "splitConfigurationId4";
string ruleId = "ruleId4";
try
{
    ApiResponse<SplitConfiguration> result = await splitConfigurationMerchantLevelApi.DeleteSplitConfigurationRuleAsync(
        merchantId,
        splitConfigurationId,
        ruleId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Update Split Configuration Rule

Changes the [split conditions of the rule](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-condition) specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API - SplitConfiguration read and write

```csharp
UpdateSplitConfigurationRuleAsync(
    string merchantId,
    string splitConfigurationId,
    string ruleId,
    Models.UpdateSplitConfigurationRuleRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `splitConfigurationId` | `string` | Template, Required | The identifier of the split configuration. |
| `ruleId` | `string` | Template, Required | The unique identifier of the split configuration rule. |
| `body` | [`UpdateSplitConfigurationRuleRequest`](../../doc/models/update-split-configuration-rule-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SplitConfiguration](../../doc/models/split-configuration.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string splitConfigurationId = "splitConfigurationId4";
string ruleId = "ruleId4";
UpdateSplitConfigurationRuleRequest body = new UpdateSplitConfigurationRuleRequest
{
    Currency = "EUR",
    FundingSource = "ANY",
    PaymentMethod = "visa",
    ShopperInteraction = "ANY",
};

try
{
    ApiResponse<SplitConfiguration> result = await splitConfigurationMerchantLevelApi.UpdateSplitConfigurationRuleAsync(
        merchantId,
        splitConfigurationId,
        ruleId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "description": "Your description for the split configuration",
  "rules": [
    {
      "currency": "ANY",
      "fundingSource": "ANY",
      "paymentMethod": "ANY",
      "ruleId": "SCRL4224P22322585HPCX384JW65VW",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 10,
          "variablePercentage": 50,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 10,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX384JX52M2",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToOneBalanceAccount",
        "tip": "addToOneBalanceAccount"
      }
    },
    {
      "currency": "EUR",
      "fundingSource": "ANY",
      "paymentMethod": "visa",
      "ruleId": "SCRL4224P22322585HPCX5V4KV6L2R",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 10,
          "variablePercentage": 50,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 10,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX5V4KW26C9",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToLiableAccount",
        "tip": "addToOneBalanceAccount"
      }
    }
  ],
  "splitConfigurationId": "SCNF4224P22322585HPCX384JV6JGX"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Update Split Logic

Changes the [split logic](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-split-logic) specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API - SplitConfiguration read and write

```csharp
UpdateSplitLogicAsync(
    string merchantId,
    string splitConfigurationId,
    string ruleId,
    string splitLogicId,
    Models.UpdateSplitConfigurationLogicRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `splitConfigurationId` | `string` | Template, Required | The unique identifier of the split configuration. |
| `ruleId` | `string` | Template, Required | The unique identifier of the split configuration rule. |
| `splitLogicId` | `string` | Template, Required | The unique identifier of the split configuration split. |
| `body` | [`UpdateSplitConfigurationLogicRequest`](../../doc/models/update-split-configuration-logic-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SplitConfiguration](../../doc/models/split-configuration.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string splitConfigurationId = "splitConfigurationId4";
string ruleId = "ruleId4";
string splitLogicId = "splitLogicId4";
UpdateSplitConfigurationLogicRequest body = new UpdateSplitConfigurationLogicRequest
{
    Commission = new Commission1
    {
        FixedAmount = 100L,
        VariablePercentage = 100L,
    },
    AdditionalCommission = new AdditionalCommission1
    {
        BalanceAccountId = "BA3227C223222H5HQ2XX77VVH",
        FixedAmount = 100L,
        VariablePercentage = 0L,
    },
    Chargeback = Behavior.DeductFromLiableAccount,
    PaymentFee = PaymentFee.DeductFromLiableAccount,
    Remainder = Remainder.AddToLiableAccount,
    Tip = Tip.AddToLiableAccount,
};

try
{
    ApiResponse<SplitConfiguration> result = await splitConfigurationMerchantLevelApi.UpdateSplitLogicAsync(
        merchantId,
        splitConfigurationId,
        ruleId,
        splitLogicId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "description": "Your description for the split configuration",
  "rules": [
    {
      "currency": "ANY",
      "fundingSource": "ANY",
      "paymentMethod": "ANY",
      "ruleId": "SCRL4224P22322585HPCX384JW65VW",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 10,
          "variablePercentage": 50,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 10,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX384JX52M2",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToOneBalanceAccount",
        "tip": "addToOneBalanceAccount"
      }
    },
    {
      "currency": "EUR",
      "fundingSource": "ANY",
      "paymentMethod": "visa",
      "ruleId": "SCRL4224P22322585HPCX5V4KV6L2R",
      "shopperInteraction": "ANY",
      "splitLogic": {
        "additionalCommission": {
          "fixedAmount": 100,
          "variablePercentage": 0,
          "balanceAccountId": "BA3227C223222H5HQ2XX77VVH"
        },
        "chargeback": "deductFromLiableAccount",
        "commission": {
          "fixedAmount": 100,
          "variablePercentage": 100
        },
        "splitLogicId": "SCLG4224P22322585HPCX5V4KW26C9",
        "paymentFee": "deductFromLiableAccount",
        "remainder": "addToLiableAccount",
        "tip": "addToLiableAccount"
      }
    }
  ],
  "splitConfigurationId": "SCNF4224P22322585HPCX384JV6JGX"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |

