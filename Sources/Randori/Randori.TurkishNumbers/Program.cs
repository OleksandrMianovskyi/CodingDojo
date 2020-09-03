using System.Collections.Generic;

namespace Randori.TurkishNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class TurkishNumber
    {
        public string GetTurkishNumber(int x)
        {
            var odin = new List<string> { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

            var dva = new List<string> { "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

            if (x < 10) return odin[x];

            var c = dva[int.Parse((x / 10).ToString()) - 1];

            if (x % 10 == 0) return c;

            return $"{c} {odin[x % 10]}";
        }
    }
}
