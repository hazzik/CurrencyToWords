using NUnit.Framework;

namespace CurrencyToWords.Tests
{
    [TestFixture]
    public class CurrencyToWordTests
    {
        [TestCase(0, "zero dollars")]
        [TestCase(2, "two dollars")]
        [TestCase(123, "one hundred and twenty three dollars")]
        public void TestWholeAmounts(decimal amount, string expected)
        {
            var result = amount.CurrencyToWords();
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(1, "one dollar")]
        [TestCase(11, "eleven dollars")]
        [TestCase(21, "twenty one dollar")]
        [TestCase(71, "seventy one dollar")]
        [TestCase(111, "one hundred and eleven dollars")]
        [TestCase(151, "one hundred and fifty one dollar")]
        public void AmountsEndingWithOne(decimal amount, string expected)
        {
            var result = amount.CurrencyToWords();
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}