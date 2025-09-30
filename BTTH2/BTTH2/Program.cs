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
            Console.Write("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (n < 2)
            {
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
