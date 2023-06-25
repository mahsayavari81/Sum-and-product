using System;

namespace Project
{
    class Test1
    {
        public static void Main()
        {
            Console.WriteLine("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Even(x);
            }
            else
            {
                Odd(x);
            }
        }
        private static void Even(int x)
        {
            int sum = 0, zarb = 1;
            for (int i = 2; i <= x; i++)
            {
                sum += i;
                zarb *= i;

                Console.WriteLine($"Sum: {sum} Zarb: {zarb}");
            }
        }
        private static void Odd(int x)
        {
            int sum = 0, zarb = 1;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
                zarb *= i;

                Console.WriteLine($"Sum: {sum} Zarb: {zarb}");
            }
        }
    }
}