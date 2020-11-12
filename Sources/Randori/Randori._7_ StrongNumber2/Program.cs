using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randori._7__StrongNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (Kata.StrongNumber(i)=="STRONG!!!!")
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(".....");
            Console.ReadLine();
        }
    }
}
