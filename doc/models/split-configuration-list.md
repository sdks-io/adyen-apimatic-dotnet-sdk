
# Split Configuration List

## Structure

`SplitConfigurationList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<SplitConfiguration>`](../../doc/models/split-configuration.md) | Optional | List of split configurations applied to the stores under the merchant account. |

## Example (as JSON)

```json
{
  "data": [
    {
      "description": "description0",
      "rules": [
        {
          "cardRegion": "intraRegional",
          "currency": "currency2",
          "fundingSource": "prepaid",
          "paymentMethod": "paymentMethod4",
          "ruleId": "ruleId2",
          "shopperInteraction": "ANY",
          "splitLogic": {
            "acquiringFees": "deductFromLiableAccount",
            "additionalCommission": {
              "balanceAccountId": "balanceAccountId0",
              "fixedAmount": 100,
              "variablePercentage": 64
            },
            "adyenCommission": "deductFromLiableAccount",
            "adyenFees": "deductFromLiableAccount",
            "adyenMarkup": "deductFromLiableAccount",
            "commission": {
              "fixedAmount": 112,
              "variablePercentage": 52
            }
          }
        },
        {
          "cardRegion": "intraRegional",
          "currency": "currency2",
          "fundingSource": "prepaid",
          "paymentMethod": "paymentMethod4",
          "ruleId": "ruleId2",
          "shopperInteraction": "ANY",
          "splitLogic": {
            "acquiringFees": "deductFromLiableAccount",
            "additionalCommission": {
              "balanceAccountId": "balanceAccountId0",
              "fixedAmount": 100,
              "variablePercentage": 64
            },
            "adyenCommission": "deductFromLiableAccount",
            "adyenFees": "deductFromLiableAccount",
            "adyenMarkup": "deductFromLiableAccount",
            "commission": {
              "fixedAmount": 112,
              "variablePercentage": 52
            }
          }
        }
      ],
      "splitConfigurationId": "splitConfigurationId6"
    },
    {
      "description": "description0",
      "rules": [
        {
          "cardRegion": "intraRegional",
          "currency": "currency2",
          "fundingSource": "prepaid",
          "paymentMethod": "paymentMethod4",
          "ruleId": "ruleId2",
          "shopperInteraction": "ANY",
          "splitLogic": {
            "acquiringFees": "deductFromLiableAccount",
            "additionalCommission": {
              "balanceAccountId": "balanceAccountId0",
              "fixedAmount": 100,
              "variablePercentage": 64
            },
            "adyenCommission": "deductFromLiableAccount",
            "adyenFees": "deductFromLiableAccount",
            "adyenMarkup": "deductFromLiableAccount",
            "commission": {
              "fixedAmount": 112,
              "variablePercentage": 52
            }
          }
        },
        {
          "cardRegion": "intraRegional",
          "currency": "currency2",
          "fundingSource": "prepaid",
          "paymentMethod": "paymentMethod4",
          "ruleId": "ruleId2",
          "shopperInteraction": "ANY",
          "splitLogic": {
            "acquiringFees": "deductFromLiableAccount",
            "additionalCommission": {
              "balanceAccountId": "balanceAccountId0",
              "fixedAmount": 100,
              "variablePercentage": 64
            },
            "adyenCommission": "deductFromLiableAccount",
            "adyenFees": "deductFromLiableAccount",
            "adyenMarkup": "deductFromLiableAccount",
            "commission": {
              "fixedAmount": 112,
              "variablePercentage": 52
            }
          }
        }
      ],
      "splitConfigurationId": "splitConfigurationId6"
    }
  ]
}
```

