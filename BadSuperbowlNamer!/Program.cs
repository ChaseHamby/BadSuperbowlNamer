using System;

namespace BadSuperbowlNamer_
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
