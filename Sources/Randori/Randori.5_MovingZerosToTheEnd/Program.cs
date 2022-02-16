using System;
using System.Linq;

namespace Randori._5_MovingZerosToTheEnd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a =MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1});
            Console.Read();
        }

        public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderByDescending(x => x==0).ToArray();
        }
    }
}