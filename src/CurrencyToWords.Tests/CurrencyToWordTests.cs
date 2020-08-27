using NUnit.Framework;

namespace CurrencyToWords.Tests
{
    [TestFixture]
    public class CurrencyToWordTests
    {
        [TestCase(0, "zero dollars")]
        [TestCase(2, "two dollars")]
        [TestCase(123, "one hundred and twenty three dollars")]
        public void WholeAmounts(decimal amount, string expected)
        {
            var result = amount.CurrencyToWords();
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(10, "ten dollars")]
        [TestCase(23, "twenty three dollars")]
        [TestCase(234, "two hundred and thirty four dollars")]
        public void WholeAmounts(long amount, string expected)
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

        [TestCase(0.02, "two cents")]
        [TestCase(0.12, "twelve cents")]
        [TestCase(0.50, "fifty cents")]
        public void Cents(decimal amount, string expected)
        {
            var result = amount.CurrencyToWords();
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0.01, "one cent")]
        [TestCase(0.11, "eleven cents")]
        [TestCase(0.21, "twenty one cent")]
        [TestCase(0.71, "seventy one cent")]
        public void CentsEndingWithOne(decimal amount, string expected)
        {
            var result = amount.CurrencyToWords();
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0, "zero dollars")]
        [TestCase(0.12, "twelve cents")]
        [TestCase(10.55, "ten dollars and fifty five cents")]
        [TestCase(120, "one hundred and twenty dollars")]
        public void RequiredCases(decimal amount, string expected)
        {
            var result = amount.CurrencyToWords();
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}