using System;

namespace prime_number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                long num = Convert.ToInt64(Console.ReadLine());
                int factors = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        factors++;
                    }
                }
                if (factors == 2)
                {
                    Console.WriteLine("Yes, it is a prime number.");
                }
                else
                {
                    Console.WriteLine("No, it is not a prime number.");
                }
            }
        }
    }
}
