using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Logic
    {
        public static void Pro()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i * i != n)
                        sum = sum + i + n / i;
                    else
                        sum = sum + i;
                }
            }
            // If sum of divisors is equal to n, then n is a perfect number
            if (sum == n && n != 1)
            {
                Console.WriteLine($"The number {n} is a perfect number");
            }
            else
            {
                Console.WriteLine($"The number {n} is not a perfect number");
            }
        }
    }
}
