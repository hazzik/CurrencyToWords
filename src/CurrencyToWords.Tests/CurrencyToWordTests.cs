using NUnit.Framework;

namespace CurrencyToWords.Tests
{
    [TestFixture]
    public class CurrencyToWordTests
    {
        [TestCase(2, "two dollars")]
        [TestCase(123, "one hundred and twenty three dollars")]
        public void TestWholeAmounts(decimal amount, string expected)
        {
            var result = amount.CurrencyToWords();
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}