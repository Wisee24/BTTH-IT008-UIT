using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH6
{
    internal class Program
    {
        struct TwoDIndex
        {
            public int n;
            public int m;
            public void Print()
            {
                Console.WriteLine($"[{n}, {m}]");
            }
        }
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Enter # of rows and columns for the matrix: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Enter element at index [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            PrintMatrix(matrix, n, m);
            FindLS(matrix, n, m);
            FindHighestSumRow(matrix, n, m);
            int sumOfNotPrime = SumOfNotPrime(matrix, n, m);
            Console.WriteLine("The sum of all numbers that are not prime in the matrix is: " + sumOfNotPrime);
            DeleteRow(matrix, ref n, ref m);
            PrintMatrix(matrix, n, m);
            DeleteLargestNumberColumn(matrix, ref n, ref m);
            PrintMatrix(matrix, n, m);

        }

        static void PrintMatrix(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void FindLS(int[,] matrix, int n, int m)
        {
            int largest = matrix[0, 0];
            int smallest = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > largest)
                        largest = matrix[i, j];
                    if (matrix[i, j] < smallest)
                        smallest = matrix[i, j];
                }
            }
            TwoDIndex index;
            List<TwoDIndex> largestIndices = new List<TwoDIndex>();
            List<TwoDIndex> smallestIndices = new List<TwoDIndex>();
            if (largest == smallest)
            {
                Console.WriteLine("The entire matrix contains the same number at all indices ");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == largest) 
                    {
                        index.n = i;
                        index.m = j;
                        largestIndices.Add(index);
                    }
                    if (matrix[i, j] == smallest) 
                    {
                        index.n = i;
                        index.m = j;
                        smallestIndices.Add(index);
                    }
                }
            }
            Console.WriteLine("The largest numbers in the matrix are at index/indices: ");
            for(int i = 0; i < largestIndices.Count; i++)
            {
                largestIndices[i].Print();
            }
            Console.WriteLine("The smallest numbers in the matrix are at index/indices: ");
            for (int i = 0; i < smallestIndices.Count; i++)
            {
                smallestIndices[i].Print();
            }

        }
        static void FindHighestSumRow(int[,] matrix, int n, int m)
        {
            List<int> SumRows = new List<int>();
            List<int> HighestRows = new List<int>();
            int Highest = 0;
            for (int i = 0; i < n; ++i)
            {
                int Value = 0;
                for (int j = 0; j < m; ++j)
                {
                    Value += matrix[i, j];
                }
                SumRows.Add(Value);
                if (Value > Highest)
                {
                    Highest = Value;
                }
            }
            for (int i = 0; i < n; ++i)
            {
                if (SumRows[i] == Highest)

                {
                    HighestRows.Add(i);
                }
            }
            Console.Write("The rows with the highest sum are: ");
            for(int i = 0; i < HighestRows.Count; i++)
            {
                if(i == HighestRows.Count - 1)
                    Console.WriteLine(HighestRows[i]);
                else
                    Console.Write(HighestRows[i] + ", ");
            }
        }

        static int SumOfNotPrime(int[,] matrix, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (!(IsPrime(matrix[i, j])))
                    {
                        sum += matrix[i, j];
                    }
                }

            }
            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            else
                for (int i = 2; i * i <= number; ++i)
                {
                    if (number % i == 0)
                        return false;
                }
            return true;
        }
        static void DeleteRow(int[,] matrix, ref int n, ref int m)
        {
            Console.Write("Enter the row number to delete: ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k >= n)
            {
                Console.WriteLine("There is no number " + k + " row");
                return;
            }
            for (int i = k; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = matrix[i + 1, j];
                }
            }
            n--;

        }
        static void DeleteLargestNumberColumn(int[,] matrix, ref int n, ref int m)
        {
            int largest = matrix[0, 0];
            List<int> columns = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > largest)
                    {
                        largest = matrix[i, j];
                    }
                }
            }
            for (int j = m - 1; j >= 0; j--)  
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] == largest)
                    {
                        columns.Add(j);
                        break;
                    }
                }
            }
            for (int k = 0; k < columns.Count; k++)
            {
                for (int j = columns[k]; j < m - 1; j++)
                {
                    for(int i = 0; i < n; i++)
                    {
                        matrix[i, j] = matrix[i, j + 1];
                    }
                }
                m--;
            }
            
        }
    }
}
