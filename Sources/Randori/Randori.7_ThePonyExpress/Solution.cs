namespace Randori._7_ThePonyExpress
{
    public static class Solution
    {
        //public static int Riders(int[] s) => s.Aggregate(new []{0, 1}, (t, i) => t[0] + i > 100 ? new []{i, t[1] + 1} : new []{t[0] + i, t[1]})[1];
        public static int Riders(int[] stations)
        {
            var riders = 1;
            var d = 0;
            foreach (var i in stations)
            {
                if (d + i <= 100) { d += i; continue; }

                riders++;
                d = i;
            }

            return riders;
        }
    }
}