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
            Console.Write("Enter day/month/year: ");
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());

            Weekday h = (Weekday)((day + (13*(month+1)/5) + (year % 100) + ((year%100)/4) + (Math.Floor(year/100.0)/4) + 100) % 7);
            Console.WriteLine(h);
        }

    }
    enum Weekday
    {
        Saturday = 0,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
 

}
