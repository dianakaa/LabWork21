namespace Task5
{
    internal class Program
    {
        static double Power(double x, int n)
        {
            if (n < 0)
            {
                return -1;
            }
            if (n == 0)
            {
                return 1;
            }
            if (n % 2 == 0)
            {
                double y = Power(x, n / 2);
                return y * y;
            }
            else
            {
                double y = Power(x, (n - 1) / 2);
                return y * y * x;
            }
        }

        static void Main(string[] args)
        {
            double x = 2;
            int n = 3;
            double result = Power(x, n);
            Console.WriteLine($"{x}^{n}={result}");
        }
    }
}
