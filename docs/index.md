<a name='assembly'></a>
# CreditCardValidator

## Contents

- [CreditCardValidator](#T-OpenCardServices-Validator-CreditCardValidator 'OpenCardServices.Validator.CreditCardValidator')
  - [ValidateCardNumber(cardNumber)](#M-OpenCardServices-Validator-CreditCardValidator-ValidateCardNumber-System-String- 'OpenCardServices.Validator.CreditCardValidator.ValidateCardNumber(System.String)')
- [ICreditCardValidator](#T-OpenCardServices-Validator-ICreditCardValidator 'OpenCardServices.Validator.ICreditCardValidator')
  - [ValidateCardNumber(cardNumber)](#M-OpenCardServices-Validator-ICreditCardValidator-ValidateCardNumber-System-String- 'OpenCardServices.Validator.ICreditCardValidator.ValidateCardNumber(System.String)')

<a name='T-OpenCardServices-Validator-CreditCardValidator'></a>
## CreditCardValidator `type`

##### Namespace

OpenCardServices.Validator

##### Summary

Supports validting credit card numbers input as strings of digits using the Luhn algorithm.
Note that this algorithm follows the algorithm described in the text from Wikipedia and works from
right to left.
This differs from the pseudo-code provided in the same Wikipedia article which works from
left to right, and actually wastes time getting checksum first. All you have to do
is walk all the way through the string and you'll pick the checkup up in the sum, it never has parity.

<a name='M-OpenCardServices-Validator-CreditCardValidator-ValidateCardNumber-System-String-'></a>
### ValidateCardNumber(cardNumber) `method`

##### Summary

Accepts a string of digits and validates the credit card number using the Luhn algorithm.

##### Returns

true if the card number is valid.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cardNumber | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string of digits in the card number; digits only, no spaces or dashes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | when the card number is null. |

<a name='T-OpenCardServices-Validator-ICreditCardValidator'></a>
## ICreditCardValidator `type`

##### Namespace

OpenCardServices.Validator

##### Summary

Interface that supports validting credit card numbers input as strings of digits.

<a name='M-OpenCardServices-Validator-ICreditCardValidator-ValidateCardNumber-System-String-'></a>
### ValidateCardNumber(cardNumber) `method`

##### Summary

Accepts a string of digits and validates the credit card number using the Luhn algorithm.

##### Returns

true if the card number is valid.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cardNumber | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string of digits in the card number; digits only, no spaces or dashes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | when the card number is null. |
