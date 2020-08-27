using System;
using System.Collections.Generic;

namespace CurrencyToWords
{
    public static class CurrencyToWordExtensions
    {
        private const int CentsInADollar = 100;

        /// <summary>
        /// An extension method to return a dollar value written ot in English words
        /// </summary>
        public static string CurrencyToWords(this byte amount) => CurrencyToWords((long) amount);

        /// <summary>
        /// An extension method to return a dollar value written ot in English words
        /// </summary>
        public static string CurrencyToWords(this short amount) => CurrencyToWords((long) amount);

        /// <summary>
        /// An extension method to return a dollar value written ot in English words
        /// </summary>
        public static string CurrencyToWords(this int amount) => CurrencyToWords((long) amount);

        /// <summary>
        /// An extension method to return a dollar value written ot in English words
        /// </summary>
        public static string CurrencyToWords(this long amount)
        {
            if (amount > 1000 || amount < 0)
            {
                throw new ArgumentException($"Only numbers between 0 and 1000 are supported, got {amount}", nameof(amount));
            }
            
            return DollarsAsWords(amount);
        }

        /// <summary>
        /// An extension method to return a dollar value written ot in English words
        /// </summary>
        public static string CurrencyToWords(this decimal amount)
        {
            if (amount > 1000 || amount < 0)
            {
                throw new ArgumentException($"Only numbers between 0 and 1000 are supported, got {amount}", nameof(amount));
            }

            if (amount < 0.01m)
            {
                return "zero dollars";
            }

            var dollars = GetWholeDollars(amount);
            var cents = GetOnlyCents(amount);

            var parts = new List<string>();
            if (dollars > 0)
            {
                parts.Add(DollarsAsWords(dollars));
            }

            if (cents > 0)
            {
                parts.Add(CentsAsWords(cents));
            }

            return string.Join(" and ", parts);
        }

        private static string CentsAsWords(long cents) => 
            $"{cents.ToWords()} cent{InflectEnding(cents)}";

        private static string DollarsAsWords(long dollars) => 
            $"{dollars.ToWords()} dollar{InflectEnding(dollars)}";

        private static long GetWholeDollars(decimal amount) => 
            (long) amount;

        private static long GetOnlyCents(decimal amount) =>
            (long) (amount * CentsInADollar % CentsInADollar);

        private static string InflectEnding(long amount)
        {
            if (amount % 10 == 1 && amount % 100 != 11) return string.Empty;
            return "s";
        }
    }
}