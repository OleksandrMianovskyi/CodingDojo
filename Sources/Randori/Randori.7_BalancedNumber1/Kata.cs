using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Randori._7_BalancedNumber1
{
    public class Kata
    {
        public static string BalancedNumber(int number)
        {
            var numberString = number.ToString();

            var s = ((numberString.Count() - 1) / 2);

            Func<IEnumerable<char>, int> sumExpr = (charArr) => charArr.Select(o => (int)o).Sum();

            return sumExpr(numberString.Take(s)) == sumExpr(numberString.Reverse().Take(s)) ? "Balanced" : "Not Balanced";

            //double middle = number.ToString().Length / 2.0;
            //var leftSum = number.ToString().Take((int)Math.Ceiling(middle - 1)).Sum(x => x);
            //var rightSum = number.ToString().Skip((int)++middle).Sum(x => x);
            //return leftSum == rightSum ? "Balanced" : "Not Balanced";

            //return $"{number}".Take(($"{number}".Length + 1) / 2 - 1).Sum(c => c) == $"{number}".Skip($"{number}".Length / 2 + 1).Sum(c => c)
            //    ? "Balanced"
            //    : "Not Balanced";
        }
    }
}