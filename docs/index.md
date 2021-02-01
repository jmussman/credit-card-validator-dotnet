<?xml version="1.0"?>
<doc>
    <assembly>
        <name>CreditCardValidator</name>
    </assembly>
    <members>
        <member name="T:OpenCardServices.Validator.CreditCardValidator">
            <summary>
            Supports validting credit card numbers input as strings of digits using the Luhn algorithm.
            Note that this algorithm follows the algorithm described in the text from Wikipedia and works from
            right to left.
            This differs from the pseudo-code provided in the same Wikipedia article which works from
            left to right, and actually wastes time getting checksum first. All you have to do
            is walk all the way through the string and you'll pick the checkup up in the sum, it never has parity.
            </summary>
        </member>
        <member name="M:OpenCardServices.Validator.CreditCardValidator.ValidateCardNumber(System.String)">
            <summary>Accepts a string of digits and validates the credit card number using the Luhn algorithm.</summary>
            <param name="cardNumber">The string of digits in the card number; digits only, no spaces or dashes.</param>
            <returns>true if the card number is valid.</returns>
            <exception cref="T:System.NullReferenceException">when the card number is null.</exception>
        </member>
        <member name="T:OpenCardServices.Validator.ICreditCardValidator">
            <summary>
            Interface that supports validting credit card numbers input as strings of digits.
            </summary>
        </member>
        <member name="M:OpenCardServices.Validator.ICreditCardValidator.ValidateCardNumber(System.String)">
            <summary>Accepts a string of digits and validates the credit card number using the Luhn algorithm.</summary>
            <param name="cardNumber">The string of digits in the card number; digits only, no spaces or dashes.</param>
            <returns>true if the card number is valid.</returns>
            <exception cref="T:System.NullReferenceException">when the card number is null.</exception>
        </member>
    </members>
</doc>
