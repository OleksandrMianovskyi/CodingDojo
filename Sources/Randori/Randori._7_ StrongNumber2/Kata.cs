using System.Linq;

namespace Randori._7__StrongNumber2
{
    public static class Kata
    {
        public static string StrongNumber(int number)
        {
            return $"{number}".Select(x => (int)char.GetNumericValue(x)).Sum(x => x == default ? 1 : Enumerable.Range(1, x).Aggregate((f, s) => f * s)) == number ? "STRONG!!!!" : "Not Strong !!";
        }
    }
}
