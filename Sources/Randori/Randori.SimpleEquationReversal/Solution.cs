using System.Linq;

namespace Randori.SimpleEquationReversal
{
    public class Solution
    {
        public static string Solve(string eq)
        {
            //string.Join("", Regex.Split(eq, @"(\*)|(\+)|(-)|(/)").Reverse());

            var charSeparators = new[] { '*', '+', '-', '/' };
            var operands = eq.Split(charSeparators).Reverse().ToList();
            var operators = eq.Where(z => charSeparators.Contains(z)).Reverse().ToList();
            var i = 0;
            return string.Join(string.Empty, operands.Select(o => { var r = i == operands.Count - 1 ? o : o + operators[i]; i++; return r; }));

            //var result = string.Empty;
            //var i = 0;
            //foreach (var item in operands)
            //{
            //    if (item == operands.Last())
            //    {
            //        result += item;
            //    }
            //    else
            //    {
            //        result += item + operators[i];
            //        i++;
            //    }
            //}

            //for (var j = 0; j < operands.Count; j++)
            //{
            //    var item = operands[j];
            //    result += j == operands.Count ? item : item + operators[j];
            //}

            //return result;
        }
    }
}