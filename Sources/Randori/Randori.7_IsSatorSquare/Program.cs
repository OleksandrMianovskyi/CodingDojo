using System;

namespace Randori._7_IsSatorSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.IsSatorSquare(new char[4, 4] {
                {'K', 'N', 'I', 'T'},
                {'N', 'O', 'R', 'I'},  //  warning: O and 0 look similar
                {'I', 'R', '0', 'N'},  //           but are not the same
                {'T', 'I', 'N', 'K'}});
            Console.WriteLine("Hello World!");
        }
    }
}
