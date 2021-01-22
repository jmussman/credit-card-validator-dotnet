// ICreditCardValidator.cs
// Copyright © 2019-2020 Joel Mussman. All rights reserved.
//

using System;

namespace com.wonderfulwidgets.retail {

    /// <summary>
    /// Interface that supports validting credit card numbers input as strings of digits.
    /// </summary>
    public interface ICreditCardValidator {

        /// <summary>Accepts a string of digits and validates the credit card number using the Luhn algorithm.</summary>
        /// <param name="cardNumber">The string of digits in the card number; digits only, no spaces or dashes.</param>
        /// <returns>true if the card number is valid.</returns>
        /// <exception cref="NullReferenceException">when the card number is null.</exception>
        public bool ValidateCardNumber(String cardNumber);
    }
}