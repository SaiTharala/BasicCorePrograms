using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class PowerofTwo
    {
        public void Power()
        {
            Console.WriteLine("Enter the Power Number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("2 ^ {0}" + " = " + "{1}", i, +Math.Pow(2, i));
            }
        }
    }
}