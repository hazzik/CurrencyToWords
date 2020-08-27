using System;
using System.Collections.Generic;

namespace CurrencyToWords
{
    public static class NumberToWordExtensions
    {
        private static readonly string[] Units = 
        {
            "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", 
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        private static readonly string[] Tens =
        {
            "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };

        /// <summary>
        /// An extension method to return a number written ot in English words
        /// </summary>
        public static string ToWords(this byte number) => ToWords((long) number);

        /// <summary>
        /// An extension method to return a number written ot in English words
        /// </summary>
        public static string ToWords(this short number) => ToWords((long) number);

        /// <summary>
        /// An extension method to return a number written ot in English words
        /// </summary>
        public static string ToWords(this int number) => ToWords((long) number);

        /// <summary>
        /// An extension method to return a number written ot in English words
        /// </summary>
        public static string ToWords(this long number)
        {
            if (number > 1000 || number < 0) throw new ArgumentException($"Only numbers between 0 and 1000 are supported, got {number}", nameof(number));

            if (number == 0) return "zero";
            if (number == 1000) return "one thousand";
            var parts = new List<string>();
            if (number >= 100)
            {
                var hundreds = number / 100;
                parts.Add(Units[hundreds]);
                parts.Add("hundred");
                number %= 100;

                if (number > 0) parts.Add("and");
            }

            if (number >= 20)
            {
                var tens = number / 10;
                parts.Add(Tens[tens]);
                number %= 10;
            }

            if (number > 0)
            {
                parts.Add(Units[number]);
            }

            return string.Join(" ", parts);
        }
    }
}
