using System;

namespace CurrencyToWords
{
    public static class NumberToWordExtensions
    {
        private static string[] _units = 
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", 
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        public static string ToWords(this long number)
        {
            if (number < 20)
                return _units[number];

            throw new NotImplementedException();
        }
    }
}
