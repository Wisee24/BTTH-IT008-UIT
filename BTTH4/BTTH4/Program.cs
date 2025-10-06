using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month, year;
            while (true)
            {
                Console.Write("Enter month: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out month))
                {
                    break;
                }
                else
                    Console.WriteLine("Please enter a valid integer.");
            }
            while (true)
            {
                Console.Write("Enter year: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out year))
                {
                    break;
                }
                else
                    Console.WriteLine("Please enter a valid integer.");
            }
            int day = FindDay(month, year);
            while (day == -1)
            {
                Console.WriteLine("You did not enter a valid month or year, please try another month/year ");
                Console.Write("Enter month: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter year: ");
                year = Convert.ToInt32(Console.ReadLine());
                day = FindDay(month, year);
            }
            Console.WriteLine($"There are {day} days in {month}/{year}");

        }

        static int FindDay(int month, int year)
        {
            if((month < 1 || month  > 12) || (year <= 0))
                return -1;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if (month == 2)
            {
                if (IsLeapYear(year))
                    return 29;
                else
                    return 28;
            }
            else
                return 30;
            
        }
        static bool IsLeapYear(int year)
        {
            if (year % 4 != 0) { return false; }
            if (year % 100 != 0) { return true; }
            if (year % 400 != 0) { return false; }
            return true;
        }
    }

}
