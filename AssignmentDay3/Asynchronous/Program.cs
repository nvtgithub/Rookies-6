namespace Assignment
{
    public class Program
    {
        public static void Main(String[] args)
        {
            GetPrimeNumbers(1, 100);
            GetPrimeNumbers(100, 200);

            Console.ReadKey();
        }

        static async Task GetPrimeNumbers(int min, int max)
        {
            await Task.Run(() =>
            {
                for (int i = min; i <= max; i++)
                {
                    if (IsPrimeNumber(i))
                    {
                        Console.WriteLine(" " + i);
                    }
                }
            });
        }

        static bool IsPrimeNumber(int n)
        {
            int i;

            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}