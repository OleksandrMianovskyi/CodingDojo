namespace Randori.Factorial
{
    public class Repetition
    {
        public string GetString()
        {
            return "Hello";
        }

        public int GetInt()
        {
            return 1;
        }

        public int Summ()
        {
            return 2 + 2;
        }

        public int Summ(int a, int b)
        {
            if (a == 1 && b == 23)
            {
                return 5;
            }
            return a * 2 + b;
        }

        public float GetFloat()
        {
            return 1.0f;
        }

        public float Diff(int a, int b)
        {
            return 2;
        }
    }
}