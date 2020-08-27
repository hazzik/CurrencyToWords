using System.Collections.Generic;

namespace CurrencyToWords
{
    public static class CurrencyToWordExtensions
    {
        public static string CurrencyToWords(this decimal amount)
        {
            if (amount == 0)
            {
                return "zero dollars";
            }

            var dollars = GetWholeDollars(amount);
            var cents = GetOnlyCents(amount);

            var parts = new List<string>();
            if (dollars > 0)
            {
                parts.Add($"{dollars.ToWords()} dollar{Inflection(dollars)}");
            }

            if (cents > 0)
            {
                parts.Add($"{cents.ToWords()} cent{Inflection(cents)}");
            }

            return string.Join(" and ", parts);
        }
  
        private static long GetWholeDollars(decimal amount) => (long) amount;

        private static long GetOnlyCents(decimal amount)
        {
            return (long) (amount * 100 % 100);
        }

        private static string Inflection(long amount)
        {
            if (amount % 10 == 1 && amount % 100 != 11) return string.Empty;
            return "s";
        }
    }
}