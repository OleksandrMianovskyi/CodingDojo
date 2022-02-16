using System.Linq;

namespace Randori._7.LastSurvivor
{

    public static class Kata
    {
        public static string LastSurvivor(string letters, int[] coords)
        {
           // return coords.Aggregate(letters, (x, c) => x.Remove(c, 1));

           return coords.Aggregate(letters, (s, i) => s[..i] + s[(i + 1)..]);

        }

    }
}