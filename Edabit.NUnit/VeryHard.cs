using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edabit.Core.VeryHard;
using NUnit.Framework;

namespace Edabit.NUnit
{
    public class VeryHard
    {
        [Test]
        [TestCase("()()()", ExpectedResult = new[] { "()", "()", "()" })]
        [TestCase("((()))", ExpectedResult = new[] { "((()))" })]
        [TestCase("((()))(())()()(()())", ExpectedResult = new[] { "((()))", "(())", "()", "()", "(()())" })]
        [TestCase("((())())(()(()()))", ExpectedResult = new[] { "((())())", "(()(()()))" })]
        public static string[] SplitTest(string str)
        {
            return Program.Split(str);
        }
    }
}