using System;

namespace BadSuperbowlNamer_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number to Roman NUmberal converter //

            var converter = new RomanNumeralConverter();

            Console.WriteLine("Give me a number");
            var input = Convert.ToInt32(Console.ReadLine());

            try
            {
                var result = converter.ConvertStuff(input);
                Console.WriteLine($"{input} is converted to the roman numeral {result}");

            }
            catch (InvalidInputException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

            // Roman Numberal to Number converter //

            Console.WriteLine("Give me a roman numeral");
            var romanInput = Console.ReadLine();

            try
            {
                var romanResult = converter.RomanToInteger(romanInput);
                Console.WriteLine($"{romanInput} is converted to the number {romanResult}");
            }
            catch (InvalidInputException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
