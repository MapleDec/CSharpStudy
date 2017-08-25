using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyond_exercise1
{
    class LiveTime
    {
        public static void GetLivedTime()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please input your birthday: eg:1991-12-12");

            string date = Console.ReadLine();
            DateTime birthday = Convert.ToDateTime(date);
            DateTime today = DateTime.Now;

            double timeSpanDay = (today - birthday).TotalDays;
            double timeSpanMinute = (today - birthday).TotalMinutes;
                  
            Console.WriteLine("Today is {0} {1}", today,today.DayOfWeek);

            Console.WriteLine("You have lived " + timeSpanDay + " days");
            Console.WriteLine("You have lived " + timeSpanMinute + " minutes");
            Console.ResetColor();
        }
    }
}
