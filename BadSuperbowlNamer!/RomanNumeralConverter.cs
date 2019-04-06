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

        public Dictionary<char, int> Romans = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public int RomanToInteger(string roman)
        {
            try
            {
                int number = 0;
                for (int i = 0; i < roman.Length; i++)

                // looks at the next roman numeral and decides if the number should be subtracted or added
                {
                    if (i + 1 < roman.Length && Romans[roman[i]] < Romans[roman[i + 1]]) 
                    {
                        number -= Romans[roman[i]];
                    }
                    else
                    {
                        number += Romans[roman[i]];
                    }
                }
                return number;
            }
            catch (InvalidInputException)
            {

                throw new InvalidInputException();
            }
        }
    }
}
