using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class Factors
    {
        public void PrimeFactors()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    number /= 2;
                    Console.WriteLine(i + " ");
                }
            }
            if (number > 2)
            {
                Console.WriteLine(number);
            }

        }
    }
}
