using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edabit.Core.Medium;
using NUnit.Framework;

namespace Edabit.NUnit
{
    public class Medium
    {
        [Test]
        [TestCase("Donald Trump", ExpectedResult = "Trump Donald")]
        [TestCase("Rosie O'Donnel", ExpectedResult = "O'Donnel Rosie")]
        [TestCase("Seymour Butts", ExpectedResult = "Butts Seymour")]
        [TestCase("Ebony Greene", ExpectedResult = "Greene Ebony")]
        [TestCase("Ken Kennedy", ExpectedResult = "Kennedy Ken")]
        [TestCase("Allison Gonzalez", ExpectedResult = "Gonzalez Allison")]
        [TestCase("Albert Frazier", ExpectedResult = "Frazier Albert")]
        [TestCase("Eloise Hopkins", ExpectedResult = "Hopkins Eloise")]
        [TestCase("Donnie Welch", ExpectedResult = "Welch Donnie")]
        [TestCase("Vernon Thomas", ExpectedResult = "Thomas Vernon")]
        public static string FixedTest(string str)
        {
            return Program.NameShuffle(str);
        }
    }
}