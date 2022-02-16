namespace Randori._7_OverTheRoad
{
    public static class CodeWars
    {
        public static long overTheRoad(long address, long n)
        {
            //var index = (address + 1) / 2;
            //var cof = address % 2 == 1 ? 0 : 1;
            return n * 2 - ((address % 2)^1) - 2 * ((address + 1) / 2 - 1);
        }
    }
}
