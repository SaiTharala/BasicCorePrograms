using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class Leapyear
    {
        public void LeapYearCheck()
        {
            Console.WriteLine("Enter the Year To Check Whether Leap Year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine(year + " is Leap year\n");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year\n");
            }
        }
    }
}