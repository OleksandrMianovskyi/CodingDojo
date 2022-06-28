using System;

namespace Randori._4_StringsMix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s1 = "my&friend&Paul has heavy hats! &";
            var s2 = "my friend John has many many friends &";
            Mixing.Mix(s1, s2);
            Console.ReadLine();
        }
    }
}