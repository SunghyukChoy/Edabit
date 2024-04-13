using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edabit.Core.Medium
{
    public class Program
    {


        public static string NameShuffle(string str)
        {
            var words = str.Split(" ");
            return words[1] + " " + words[0];
        }
    }
}