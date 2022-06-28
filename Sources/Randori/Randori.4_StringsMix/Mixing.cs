using System.Collections.Generic;
using System.Linq;

namespace Randori._4_StringsMix
{
    public static class Mixing
    {
    /*return string.Join("/", Enumerable.Range('a', 'z')
        .Select(p => Tuple.Create((char)p, s1.Count(q => q == p), s2.Count(q => q == p)))
        .Where(p => p.Item2 > 1 || p.Item3 > 1)
        .Select(p => Tuple.Create(p.Item1, p.Item2 < p.Item3 ? 2 : p.Item2 > p.Item3 ? 1 : 5, Math.Max(p.Item2, p.Item3)))
        .OrderByDescending(p => p.Item3)
        .ThenBy(p => p.Item2)
        .ThenBy(p => p.Item1)
        .Select(t => (t.Item2 == 5 ? "=" : t.Item2.ToString()) + ":" + new string(t.Item1, t.Item3)));*/
        public static string Mix(string s1, string s2)
        {
            
            var a = s1.Where(char.IsLower).GroupBy(x => x).Where(x => x.Count() > 1).OrderByDescending(x => x.Count()).ToList();
            var a2 = s2.Where(char.IsLower).GroupBy(x => x).Where(x => x.Count() > 1).ToList();
            var result = new List<string>();
            foreach (var gr1 in a)
            {
                var gr2 = a2.FirstOrDefault(x => x.Key == gr1.Key);
                if (gr2 == null || gr1.Count() > gr2.Count())
                    result.Add($"1:{new string(gr1.Key, gr1.Count())}");
                else if (gr1.Count() < gr2.Count())
                    result.Add($"2:{new string(gr2.Key, gr2.Count())}");
                else
                    result.Add($"=:{new string(gr2.Key, gr2.Count())}");

                a2 = a2.Where(x => x.Key != gr1.Key).ToList();
            }

            foreach (var gr2 in a2)
            {
                var gr1 = a.FirstOrDefault(x => x.Key == gr2.Key);
                if (gr1 == null || gr2.Count() > gr1.Count())
                    result.Add($"2:{new string(gr2.Key, gr2.Count())}");
                else if (gr2.Count() < gr1.Count())
                    result.Add($"1:{new string(gr1.Key, gr1.Count())}");
                else
                    result.Add($"=:{new string(gr1.Key, gr1.Count())}");
            }

            var t = result.GroupBy(x => x.Length).OrderByDescending(x => x.Key).ToList();
            var r = "";
            foreach (var g in t)
            {
                var o = g.Select(x => x).ToList();
                var u = string.Join("/", o.Where(x => !x.StartsWith('=')).OrderByDescending(x => x.Length).ThenBy(x => x));
                var u2 = string.Join("/", o.Where(x => x.StartsWith('=')).OrderByDescending(x => x.Length).ThenBy(x => x));
                r += u2.Length != 0 ? $"{u}/{u2}/" : $"{u}/";
            }

            return r.Length == 0 ? "" : r.Remove(r.Length - 1);
        }

        private static void MakeString(IGrouping<char, char> gr1, IGrouping<char, char> gr2, List<string> result, int y, int x)
        {
            if (gr1 == null || gr2.Count() > gr1.Count())
                result.Add($"{y}:{new string(gr2.Key, gr2.Count())}");
            else if (gr2.Count() < gr1.Count())
                result.Add($"{x}:{new string(gr1.Key, gr1.Count())}");
            else
                result.Add($"=:{new string(gr2.Key, gr2.Count())}");
        }


        public static string Mix1(string s1, string s2)
        {
            var a = s1.Where(char.IsLower).GroupBy(x => x);
            var a2 = s2.Where(char.IsLower).GroupBy(x => x);


            var r = a.Zip(a2,
                    (gr1, gr2) => gr1.Count() == 1 && gr2.Count() == 1
                        ? ""
                        : $"{(gr1.Count() > gr2.Count() ? 1 : gr1.Count() == gr2.Count() ? 3 : 2)}:{new string(gr1.Key, gr1.Count() > gr2.Count() ? gr1.Count() : gr2.Count())}")
                .Where(x => x != "").ToList();


            var t = a.Select(x => $"1:{new string(x.Key, x.Count())}").Where(x => !r.Contains(x.Replace('1', '3'))).Where(x => x.Length > 3)
                .Where(x => !r.Contains($"2:{x.Substring(2)}"));
            var t2 = a2.Select(x => $"2:{new string(x.Key, x.Count())}").Where(x => !r.Contains(x.Replace('2', '3'))).Where(x => x.Length > 3);

            var b = t.Concat(r);
            b = b.Concat(t2);
            b = b.Distinct().OrderByDescending(x => x.Length)
                .ThenBy(x => x);
            ;


            return string.Join('/', b).Replace('3', '=');

            /*var a = s1.Where(char.IsLower).GroupBy(x => x);
            var a2 = s2.Where(char.IsLower).GroupBy(x => x);


            var r = a.Join(a2, gr1 => gr1.Key, gr2 => gr2.Key,
                    (gr1, gr2) => (gr1.Count()==1&&gr2.Count()==1)?"":($"{(gr1.Count() > gr2.Count() ? 1 : (gr1.Count() == gr2.Count() ? 3 : 2))}:{new string(gr1.Key, (gr1.Count() > gr2.Count() ? gr1.Count() : gr2.Count()))}"))
                .Where(x=>x!="")
                .OrderByDescending(x=>x.Length)
                .ThenBy(x=>x);

            return string.Join('/',r).Replace('3','=');*/
        }
    }
}