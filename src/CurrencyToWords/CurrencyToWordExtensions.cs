namespace CurrencyToWords
{
    public static class CurrencyToWordExtensions
    {
        public static string CurrencyToWords(this decimal amount)
        {
            var dollars = (long) amount;
            return dollars.ToWords() + " dollars";
        }
    }
}