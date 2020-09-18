using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;

namespace Randori.SimpleEquationReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"30*d/c-b+a";   
            var pattern = "((\\d*\\.\\d+)|(\\d+)|([\\+\\-\\*/\\(\\)]))";
            var t = Regex.Split(input, pattern).Reverse();

            foreach (string result in t) 
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
