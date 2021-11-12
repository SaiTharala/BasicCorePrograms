using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class QuotientAndRemainder
    {
        public void Result()
        {
            Console.WriteLine("enter the Dividend");
            double dividend = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the Divisor");
            double divisor = Convert.ToDouble(Console.ReadLine());
            double quotient = dividend / divisor;
            double remainder = dividend % divisor;
            Console.WriteLine("Quotient is:" + quotient + " and " + "remainder is: " + remainder + "\n");
        }
    }
}