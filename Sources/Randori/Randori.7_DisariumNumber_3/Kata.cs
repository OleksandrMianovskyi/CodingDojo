using System.Linq;
using System;

namespace Randori._7_DisariumNumber_3
{
    public class Kata
    {
        public static string DisariumNumber(int n) => $"{n}".Select((c, i) => Math.Pow(char.GetNumericValue(c), i + 1)).Sum() == n ? "Disarium !!" : "Not !!";
    }
}