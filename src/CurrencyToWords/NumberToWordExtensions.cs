using System;

namespace CurrencyToWords
{
    public static class NumberToWordExtensions
    {
        private static readonly string[] Units = 
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", 
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        private static readonly string[] Tens =
        {
            "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };

        public static string ToWords(this long number)
        {
            if (number < 20)
                return Units[number];

            return Tens[number / 10];
        }
    }
}
