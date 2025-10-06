using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out n))
                {
                    if (n < 0)
                    {
                        Console.WriteLine("Please enter a positive integer.");
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a postitive integer.");
                }

            }

            if (n < 2)
            {
                Console.Write("The sum of all prime number that is smaller than the entered number is: ");
                Console.WriteLine(sum);
                return;
            }

            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            Console.Write("The sum of all prime number that is smaller than the entered number is: ");
            Console.WriteLine(sum);
        }
        static bool IsPrime(int n)
        {
            if (n == 2)
                return true;
            else
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
            return true;
        }
    }

}
