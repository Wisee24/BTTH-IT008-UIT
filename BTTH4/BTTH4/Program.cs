using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month, year;
            Console.Write("Enter month/year: ");
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            int day = FindDay(month, year);
            if (day != -1)
                Console.WriteLine($"There are {day} days in {month}/{year}");
            else
                Console.WriteLine("You did not enter a valid month or year");
        }

        static int FindDay(int month, int year)
        {
            if(month < 1 || month  > 12)
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
