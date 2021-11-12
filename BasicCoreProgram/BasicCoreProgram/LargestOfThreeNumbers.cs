using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class LargestOfThreeNumbers
    {
        public void LargestOfThree()
        {
            int first, second, third;
            Console.WriteLine("Enter First Number");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            third = Convert.ToInt32(Console.ReadLine());
            if (first > second && first > third)
            {
                Console.WriteLine(first + " is the Greatest Among All Three");
            }
            if (second > first && second > third)
            {
                Console.WriteLine(second + " is the Greatest Among All Three");
            }
            else
            {
                Console.WriteLine(third + " is the Greatest Among All Three");
            }
        }
    }
}