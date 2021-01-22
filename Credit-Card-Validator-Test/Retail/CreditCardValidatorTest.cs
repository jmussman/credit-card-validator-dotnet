// CreditCardValidatorTests.cs
// Copyright © 2019-2020 Joel Mussman. All rights reserved.
//

using System;
using Xunit;

namespace com.wonderfulwidgets.retail {

    public class CardValidatorTest {

        private CreditCardValidator cardValidator;

        private void GivenNewCardValidator() {

            cardValidator = new CreditCardValidator();
        }

        [Fact]
        public void EmptyCardNumberRejected() {

            GivenNewCardValidator();

            Assert.False(cardValidator.ValidateCardNumber(""));
        }

        [Fact]
        public void NullCardNumberException() {

            GivenNewCardValidator();

            Assert.Throws<NullReferenceException>(() => cardValidator.ValidateCardNumber(null));
        }

        [Fact]
        public void AcceptsValidCardNumber() {

            GivenNewCardValidator();

            Assert.True(cardValidator.ValidateCardNumber("378282246310005"));
        }

        [Theory]
        [InlineData("378282246310006")]
        [InlineData("37828224631000a")]
        [InlineData("37828224631000$")]
        [InlineData("37828224631000A")]
        public void RejectsInvalidCardNumber(String cardNumber) {

            GivenNewCardValidator();

            Assert.False(cardValidator.ValidateCardNumber(cardNumber));
        }
    }
}