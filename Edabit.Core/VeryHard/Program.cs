using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace Edabit.Core.VeryHard
{
    public class Program
    {


        /**
        *split("()()()") ➞ ["()", "()", "()"]
        split("((()))") ➞ ["((()))"]
        split("((()))(())()()(()())") ➞ ["((()))", "(())", "()", "()", "(()())"]
        split("((())())(()(()()))") ➞ ["((())())", "(()(()()))"]
        */
        public static string[] Split(string tokens)
        {
            var list = new List<string>();
            var openCnt = 0;
            var tmp = string.Empty;
            for (int i = 0; i < tokens.Length; i++)
            {
                var ch = tokens[i];
                tmp += ch;
                if (ch == '(')
                {
                    openCnt++;
                }
                else if (ch == ')')
                {
                    openCnt--;
                }

                if (openCnt == 0)
                {
                    list.Add(tmp);
                    tmp = string.Empty;
                }
            }
            return list.ToArray();
        }
    }
}