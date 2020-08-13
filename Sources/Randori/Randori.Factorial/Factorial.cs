using System.Numerics;

namespace Randori.Factorial
{
    public class Factorial
    {
        public BigInteger Calculate(int number)
        {
            if (number <= 1)
            {
                return 1;
            }

            var result = number * Calculate(number - 1);

            return result;
        }
    }
}