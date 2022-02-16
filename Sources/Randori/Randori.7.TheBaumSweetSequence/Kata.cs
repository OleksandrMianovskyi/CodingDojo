using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Randori._7.TheBaumSweetSequence
{
    public static class Kata
    {
        public static IEnumerable<int> BaumSweet()
        {
            var r = new Regex(@"^.(..)*$");
            return Enumerable.Range(0, 1000000).Select(x =>
            {
                if (x==0)
                {
                    return 1;
                }

                return r.IsMatch(Convert.ToString(x, 2)) ? 0 : 1;
            });
        }
    }
}