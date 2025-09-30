using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(0, 101);
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int num;

            int[] arr2 = SmallestPerfectSquare(arr, out num);

            Console.WriteLine("The sum of all odd numbers is: " + OddSum(arr));
            Console.WriteLine("There are " + PrimeCount(arr) + " prime numbers in the array ");
            if (num != -1)
                Console.WriteLine($"The smallest perfect square is {num} at index/indices: ");
            else
                Console.WriteLine("There's no perfect square in the array ");
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (i == arr2.Length - 1)
                        Console.WriteLine(arr2[i]);
                    else
                        Console.Write(arr2[i] + ", ");
                }
            
        }
        static int OddSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 2 == 1)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static int PrimeCount(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if(IsPrime(arr[i]))
                {
                    count++;
                }
            }
            return count;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            else 
                for(int i = 2; i * i <=  number; ++i)
                {
                    if (number % i == 0)
                        return false;
                }
            return true;
        }
        static int[] SmallestPerfectSquare(int[] arr, out int num)
        {
            List<int> a = new List<int>();
            int smallest = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPerfectSquare(arr[i]))
                {
                    if (smallest == -1 || arr[i] < smallest)
                    {
                        smallest = arr[i];
                    }
                }
            }
            num = smallest;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == smallest)
                {
                    a.Add(i);
                }
            }
            return a.ToArray();

        }
        static bool IsPerfectSquare(int n)
        {
            if (n < 1) return false;
            int root = (int)Math.Sqrt(n);
            return root * root == n;
        }
    }

}
