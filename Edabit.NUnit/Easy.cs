using Edabit.Core.Easy;

namespace Edabit.NUnit
{
    public class Easy
    {
        [Test]
        [TestCase(1, ExpectedResult = "January")]
        [TestCase(2, ExpectedResult = "February")]
        [TestCase(3, ExpectedResult = "March")]
        [TestCase(4, ExpectedResult = "April")]
        [TestCase(5, ExpectedResult = "May")]
        [TestCase(6, ExpectedResult = "June")]
        [TestCase(7, ExpectedResult = "July")]
        [TestCase(8, ExpectedResult = "August")]
        [TestCase(9, ExpectedResult = "September")]
        [TestCase(10, ExpectedResult = "October")]
        [TestCase(11, ExpectedResult = "November")]
        [TestCase(12, ExpectedResult = "December")]
        public static string MonthName(int num)
        {
            Console.WriteLine($"Input: {num}");
            return Program.MonthName(num);
        }

        [Test]
        [TestCase(2, ExpectedResult = 3)]
        [TestCase(-9, ExpectedResult = -8)]
        [TestCase(0, ExpectedResult = 1)]
        [TestCase(100, ExpectedResult = 101)]
        [TestCase(999, ExpectedResult = 1000)]
        [TestCase(73, ExpectedResult = 74)]
        public static int FixedTest(int num)
        {
            Console.WriteLine($"Input: {num}");
            return Program.Addition(num);
        }

        [Test]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(6, ExpectedResult = 720)]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(12, ExpectedResult = 479001600)]
        [TestCase(5, ExpectedResult = 120)]
        public static int FactorialTest(int num)
        {
            return Program.Factorial(num);
        }
    }
}