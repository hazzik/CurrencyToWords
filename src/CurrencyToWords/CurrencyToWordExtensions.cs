namespace CurrencyToWords
{
    public static class CurrencyToWordExtensions
    {
        public static string CurrencyToWords(this decimal amount)
        {
            var dollars = (long) amount;
            return dollars.ToWords() + " dollar" + Inflection(dollars);
        }

        private static string Inflection(long amount)
        {
            if (amount % 10 == 1 && amount % 100 != 11) return string.Empty;
            return "s";
        }
    }
}