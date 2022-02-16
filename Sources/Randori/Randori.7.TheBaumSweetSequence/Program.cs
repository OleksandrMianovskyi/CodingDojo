using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Randori._7.TheBaumSweetSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Enumerable.Range(0, 1000000);
            var r = new Regex(@"^.(..)*$");
            var b = r.IsMatch(Convert.ToString(5, 2));
            var a = Kata.BaumSweet().Take(7).ToList();
            Console.WriteLine("Hello World!");
        }
    }
}
