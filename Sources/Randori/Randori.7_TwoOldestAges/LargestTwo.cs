using System.Linq;

namespace Randori._7_TwoOldestAges
{
    public class LargestTwo
    {
        public static int[] TwoOldestAges(int[] ages)
        {
            return ages.OrderByDescending(x => x).Take(2).OrderBy(x => x).ToArray();
            //ages.OrderBy(x => x).Skip(ages.Length - 2).ToArray();
        }
    }
}