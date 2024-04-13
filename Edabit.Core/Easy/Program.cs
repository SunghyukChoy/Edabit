using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Edabit.Core.Easy
{
    public class Program
    {
        public static int Addition(int num)
        {
            return num + 1;
        }

        public static int Factorial(int num)
        {
            // if (num == 0)
            // {
            //     return 0;
            // }
            // int multiply = 1;
            // for (int i = num; i >= 2; i--)
            // {
            //     multiply *= i;
            // }
            // return multiply;

            if (num == 1) return 1;
            return num * Factorial(num - 1);
        }

        public static string MonthName(int num)
        {
            return num switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => string.Empty,
            };
        }
    }
}
