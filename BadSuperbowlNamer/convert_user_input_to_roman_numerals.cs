using BadSuperbowlNamer_;
using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class convert_user_input_to_roman_numerals
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        [InlineData(12, "XII")]
        [InlineData(16, "XVI")]
        [InlineData(29, "XXIX")]
        [InlineData(44, "XLIV")]
        [InlineData(45, "XLV")]
        [InlineData(68, "LXVIII")]
        [InlineData(83, "LXXXIII")]
        [InlineData(97, "XCVII")]
        [InlineData(99, "XCIX")]
        [InlineData(500, "D")]
        [InlineData(501, "DI")]
        [InlineData(649, "DCXLIX")]
        [InlineData(798, "DCCXCVIII")]
        [InlineData(891, "DCCCXCI")]
        [InlineData(1000, "M")]
        [InlineData(1004, "MIV")]
        [InlineData(1006, "MVI")]
        [InlineData(1023, "MXXIII")]
        [InlineData(2014, "MMXIV")]
        [InlineData(3999, "MMMCMXCIX")]


        public void any_number_should_be_converted_to_roman_numeral(int input, string expectedResult)
        {
            // Arrange
            var converter = new RomanNumeralConverter();

            // Act
            var actualResult = converter.ConvertStuff(input);

            // Assert
            Assert.Equal(expectedResult, actualResult); 
        }

        // LEAVING ALL OF THESE FACTS COMMENTED OUT SO I HAVE THEM FOR FUTURE REFERENCE //

        //[Fact]
        //public void number_4_should_be_roman_numberal_IV()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 4;
        //    var expectedResult = "IV";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_5_should_be_roman_numberal_V()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 5;
        //    var expectedResult = "V";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_9_should_be_roman_numberal_IX()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 9;
        //    var expectedResult = "IX";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_12_should_be_roman_numberal_XII()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 12;
        //    var expectedResult = "XII";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_16_should_be_roman_numberal_XVI()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 16;
        //    var expectedResult = "XVI";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_29_should_be_roman_numberal_XXIX()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 29;
        //    var expectedResult = "XXIX";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_44_should_be_roman_numberal_XLIV()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 44;
        //    var expectedResult = "XLIV";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_45_should_be_roman_numberal_XLV()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 45;
        //    var expectedResult = "XLV";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_68_should_be_roman_numberal_LXVIII()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 68;
        //    var expectedResult = "LXVIII";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_83_should_be_roman_numberal_LXXXIII()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 83;
        //    var expectedResult = "LXXXIII";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_97_should_be_roman_numberal_XCVII()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 97;
        //    var expectedResult = "XCVII";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_99_should_be_roman_numberal_XCIX()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 99;
        //    var expectedResult = "XCIX";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_500_should_be_roman_numberal_D()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 500;
        //    var expectedResult = "D";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_501_should_be_roman_numberal_DI()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 501;
        //    var expectedResult = "DI";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_649_should_be_roman_numberal_DCXLIX()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 649;
        //    var expectedResult = "DCXLIX";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_798_should_be_roman_numberal_DCCXCVIII()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 798;
        //    var expectedResult = "DCCXCVIII";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_891_should_be_roman_numberal_DCCCXCI()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 891;
        //    var expectedResult = "DCCCXCI";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_1000_should_be_roman_numberal_M()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 1000;
        //    var expectedResult = "M";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_1004_should_be_roman_numberal_MIV()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 1004;
        //    var expectedResult = "MIV";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_1006_should_be_roman_numberal_MVI()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 1006;
        //    var expectedResult = "MVI";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_1023_should_be_roman_numberal_MXXIII()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 1023;
        //    var expectedResult = "MXXIII";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_2014_should_be_roman_numberal_MMXIV()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 2014;
        //    var expectedResult = "MMXIV";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        //[Fact]
        //public void number_3999_should_be_roman_numberal_MMMCMXCIX()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 3999;
        //    var expectedResult = "MMMCMXCIX";

        //    // Act
        //    var actualResult = converter.ConvertStuff(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}
    }
}
