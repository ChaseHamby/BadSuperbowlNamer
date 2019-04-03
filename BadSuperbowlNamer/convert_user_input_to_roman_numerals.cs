using BadSuperbowlNamer_;
using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class convert_user_input_to_roman_numerals
    {
        [Fact]
        public void number_1_should_be_roman_numberal_I()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 1;
            var expectedResult = "I";

            // Act
            var actualResult = converter.ConvertStuff(input);

            // Assert
            Assert.Equal(expectedResult, actualResult); 
        }

        [Fact]
        public void number_5_should_be_roman_numberal_V()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 5;
            var expectedResult = "V";

            // Act
            var actualResult = converter.ConvertStuff(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
