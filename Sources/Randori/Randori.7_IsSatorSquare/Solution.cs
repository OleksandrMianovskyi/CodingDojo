using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Randori._7_IsSatorSquare
{
    public static class Solution
    {
        public static bool IsSatorSquare(char[,] tablet)
        {
            var n = tablet.GetUpperBound(1);

            for (int i = 0; i <= n; i++)
            {
                var index = Enumerable.Range(0, tablet.GetLength(1));
                var column = new string(index.Select(x => tablet[x, i]).ToArray());
               Console.WriteLine(column);
            }

            var columns = new List<string>();
            var columnsInvert = new List<string>();
            var rows = new List<string>();
            var rowsInvert = new List<string>();
            
            for (int i = 0; i <= n; i++)
            {
                var index = Enumerable.Range(0, tablet.GetLength(1));
                var column = new string(index.Select(x => tablet[x, i]).ToArray());
                columns.Add(column);
                columnsInvert.Add(new string(column.Reverse().ToArray()));
                var row = new string(index.Select(x => tablet[i, x]).ToArray());
                rows.Add(row);
                rowsInvert.Add(new string(row.Reverse().ToArray()));
            }

            //var a = columns.Intersect(columnsInvert);
            //var b = rows.Intersect(rowsInvert);
            //var c = columns.Intersect(rows);
            //var t = columnsInvert.Intersect(rowsInvert);
            //var p = columns.Intersect(rowsInvert);
            //var o = columnsInvert.Intersect(rows);


            //return a==b&&b==c&&c==t&&t==p&&p==o;
            return columns.SequenceEqual(columnsInvert) && columns.SequenceEqual(rows) && rows.SequenceEqual(rowsInvert);


            //return columns.Intersect(columnsInvert).Intersect(rows).Intersect(rowsInvert).Count() == n + 1;
        }

        class Solution
        {
            public static bool IsSatorSquare(char[,] tablet)
            {
                for (int i = 0; i < tablet.GetLength(0); i++)
                {
                    for (int j = 0; j < tablet.GetLength(1); j++)
                    {
                        if (tablet[i, j] != tablet[tablet.GetLength(0) - i - 1, tablet.GetLength(1) - j - 1] || tablet[i, j] != tablet[j, i])
                            return false;
                    }
                }



                return true;
            }
        }
    }
}