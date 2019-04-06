using BadSuperbowlNamer_;
using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class convert_user_input_to_integers
    {
        [Theory]
        [InlineData("M", "1000")]

        public void any_roman_numeral_should_be_converted_to_an_integer(string romanInput, string expectedResult)
        {
            // Arrange
            var converter = new RomanNumeralConverter();

            // Act
            var actualResult = converter.ConvertRoman(romanInput);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
