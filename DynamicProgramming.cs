using System;

namespace Algorithm_Homework_1
{
    internal class DynamicProgramming
    {
        static int Fibonacci(int n)
        {
            int[] fibo = new int[n + 2];
            fibo[0] = 0;
            fibo[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }

            return fibo[n];
        }

        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your number: ");
                int n = Convert.ToInt16(Console.ReadLine());
                int result = Fibonacci(n);

                Console.WriteLine($"The {n}'th number in the Fibonacci is " + result);
            }
        }
    }
}
