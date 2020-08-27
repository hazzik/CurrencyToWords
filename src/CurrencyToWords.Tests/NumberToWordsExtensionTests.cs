using NUnit.Framework;

namespace CurrencyToWords.Tests
{
    [TestFixture]
    public class NumberToWordsExtensionTests
    {
        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(3, "three")]
        [TestCase(4, "four")]
        [TestCase(5, "five")]
        [TestCase(6, "six")]
        [TestCase(7, "seven")]
        [TestCase(8, "eight")]
        [TestCase(9, "nine")]
        [TestCase(10, "ten")]
        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fifteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eighteen")]
        [TestCase(19, "nineteen")]
        public void NumbersUnderTwenty(long number, string expected)
        {
            var result = number.ToWords();
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(10, "ten")]
        [TestCase(20, "twenty")]
        [TestCase(30, "thirty")]
        [TestCase(40, "forty")]
        [TestCase(50, "fifty")]
        [TestCase(60, "sixty")]
        [TestCase(70, "seventy")]
        [TestCase(80, "eighty")]
        [TestCase(90, "ninety")]
        public void WholeTens(long number, string expected)
        {
            var result = number.ToWords();
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(100, "one hundred")]
        [TestCase(200, "two hundred")]
        [TestCase(300, "three hundred")]
        [TestCase(400, "four hundred")]
        [TestCase(500, "five hundred")]
        [TestCase(600, "six hundred")]
        [TestCase(700, "seven hundred")]
        [TestCase(800, "eight hundred")]
        [TestCase(900, "nine hundred")]
        public void WholeHundreds(long number, string expected)
        {
            var result = number.ToWords();
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(31, "thirty one")]
        [TestCase(55, "fifty five")]
        [TestCase(63, "sixty three")]
        [TestCase(69, "sixty nine")]
        public void NumbersUnderAHundred(long number, string expected)
        {
            var result = number.ToWords();
            Assert.That(result, Is.EqualTo(expected));
        }

        
        [TestCase(101, "one hundred and one")]
        [TestCase(111, "one hundred and eleven")]
        [TestCase(231, "two hundred and thirty one")]
        [TestCase(455, "four hundred and fifty five")]
        [TestCase(563, "five hundred and sixty three")]
        [TestCase(669, "six hundred and sixty nine")]
        [TestCase(999, "nine hundred and ninety nine")]
        public void NumbersUnderAThousand(long number, string expected)
        {
            var result = number.ToWords();
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void OneThousand()
        {
            var number = 1000;
            var result = number.ToWords();
            Assert.That(result, Is.EqualTo("one thousand"));
        }
    }
}