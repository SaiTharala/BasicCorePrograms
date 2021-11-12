using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class EvenOrOdd
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter The Number To Check Even or Odd");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered Number Is Even");
            }
            else
            {
                Console.WriteLine("Entered Number Is Odd");
            }
        }
    }
}
