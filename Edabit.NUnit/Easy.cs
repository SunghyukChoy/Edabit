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
    }
}