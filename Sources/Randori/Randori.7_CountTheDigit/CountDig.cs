using System.Linq;

namespace Randori._7_CountTheDigit
{
    public static class CountDig
    {
        public static int NbDig(int n, int d)
        {
            return Enumerable.Range(0, n + 1).Select(i => (i * i).ToString().Count(x => int.Parse(x.ToString()) == d)).Sum();
        }
    }
}