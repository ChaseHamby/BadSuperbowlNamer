using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperbowlNamer_
{
    public class RomanNumeralConverter
    {
        public string ConvertStuff(int number)
        {
            if (number >= 9) return "IX";
            if (number >= 5) return "V";
            if (number >= 4) return "IV";
            if (number >= 1) return "I";

            var convertedNumber = number.ToString();

            return convertedNumber;
        }
    }
}
