using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperbowlNamer_
{
    public class RomanNumeralConverter
    {

        // Convers Ints to Roman Numerals //

        public string ConvertStuff(int number)
        {
            try
            {
                if (number < 0) throw new InvalidInputException();
                if (number < 1) return string.Empty;
                if (number >= 1000) return "M" + ConvertStuff(number - 1000);
                if (number >= 900) return "CM" + ConvertStuff(number - 900);
                if (number >= 500) return "D" + ConvertStuff(number - 500);
                if (number >= 400) return "CD" + ConvertStuff(number - 400);
                if (number >= 100) return "C" + ConvertStuff(number - 100);
                if (number >= 90) return "XC" + ConvertStuff(number - 90);
                if (number >= 50) return "L" + ConvertStuff(number - 50);
                if (number >= 40) return "XL" + ConvertStuff(number - 40);
                if (number >= 10) return "X" + ConvertStuff(number - 10);
                if (number >= 9) return "IX" + ConvertStuff(number - 9);
                if (number >= 5) return "V" + ConvertStuff(number - 5);
                if (number >= 4) return "IV" + ConvertStuff(number - 4);
                if (number >= 1) return "I" + ConvertStuff(number - 1);

                var convertedNumber = number.ToString();

                return convertedNumber;
            }
            catch (ArgumentOutOfRangeException)
            {

                throw new InvalidInputException();
            }
        }

        // Converts Roman Numerals to Ints //

        public string ConvertRoman(string roman)
        {
            try
            {
                if (roman == "") return string.Empty;
                if (roman == "M") return "1000";
                if (roman == "CM") return "900";
                if (roman == "D") return "500";
                if (roman == "CD") return "400";
                if (roman == "C") return "100";
                if (roman == "XC") return "90";
                if (roman == "L") return "50";
                if (roman == "XL") return "40";
                if (roman == "X") return "10";
                if (roman == "IX") return "9";
                if (roman == "V") return "5";
                if (roman == "IV") return "4";
                if (roman == "I") return "1";

                var convertedRoman = Convert.ToInt32(roman);
                return roman;
            }
            catch (ArgumentOutOfRangeException)
            {

                throw new InvalidInputException();
            }
        }
    }
}
