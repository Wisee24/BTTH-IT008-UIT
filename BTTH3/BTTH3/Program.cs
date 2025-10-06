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
            int day, month, year;
            while(true)
            {
                Console.Write("Enter day: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out day))
                {
                    break;
                }
                else
                    Console.WriteLine("Please enter a valid integer.");
            }
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

            if(IsValidDate(day, month, year))
            {
                Console.WriteLine($"{day}/{month}/{year} is a valid date");
            }
            else
                Console.WriteLine($"{day}/{month}/{year} is not a valid date");
        }
        static bool IsValidDate(int day, int month, int year)
        {
            if ((day < 1 || day > 31) || (month < 1 || month > 12) || (year <= 0))
                return false;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                return true;
            else if (month == 2)
            {
                if (day <= 29)
                {
                    if (IsLeapYear(year))
                        return true;
                    if (day == 29)
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            }
            else
                if (day == 31)
                return false;
            else
                return true;
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
