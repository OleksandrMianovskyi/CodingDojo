using System;
using System.Linq;

namespace Randori._6__FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var arg = new[] {1, 2, 2, 3, 3, 3, 0, 3, 3, 3, 1};
            Kata.find_it(arg);
        }
    }
    
    class Kata
    {
        public static int find_it(int[] s)
        {
            return s.Aggregate((_,o)=>_^o);
            
            //return s.First(x=>s.Count(y=>y==x)%2!=0);
            // return s.GroupBy(x=>x).First(x=>x.Count()%2!=0).Key;
            // return (from d in seq let t = seq.Count(x => x == d) where t % 2 != 0 select d).First();
        }
    }
}