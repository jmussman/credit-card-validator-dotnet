// CreditCardValidator.java
// Copyright © 2019-2021 Joel Mussman. All rights reserved.
//

using System;

namespace com.wonderfulwidgets.retail {

    /// <summary>
    /// Supports validting credit card numbers input as strings of digits using the Luhn algorithm.
    /// Note that this algorithm follows the algorithm described in the text from Wikipedia and works from
    /// right to left.
    /// This differs from the pseudo-code provided in the same Wikipedia article which works from
    /// left to right, and actually wastes time getting checksum first. All you have to do
    /// is walk all the way through the string and you'll pick the checkup up in the sum, it never has parity.
    /// </summary>
    public class CreditCardValidator : ICreditCardValidator {

        /// <summary>Accepts a string of digits and validates the credit card number using the Luhn algorithm.</summary>
        /// <param name="cardNumber">The string of digits in the card number; digits only, no spaces or dashes.</param>
        /// <returns>true if the card number is valid.</returns>
        /// <exception cref="NullReferenceException">when the card number is null.</exception>
        public bool ValidateCardNumber(String cardNumber) {

            bool result = false;
            int parity = cardNumber.Length % 2;
            int sum = 0;

            for (int i = cardNumber.Length - 1; i >= 0; --i) {

                int digit = (int)Char.GetNumericValue(cardNumber[i]) * ((i % 2 == parity) ? 2 : 1);

                sum += (digit > 9) ? digit - 9 : digit;
            }

            if (sum > 0 && sum % 10 == 0) {

                result = true;
            }

            return result;
        }
    }
}