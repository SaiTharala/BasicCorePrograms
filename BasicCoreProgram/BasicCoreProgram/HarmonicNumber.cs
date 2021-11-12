using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class HarmonicNumber
    {
        public void Harmonic()
        {
            double i, result = 0;
            Console.WriteLine("Enter the Number");
            double number = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                Console.WriteLine("1/" + i + "=" + (1 / i));
                result += (1 / i);
            }
            Console.WriteLine("Sum of Series upto {0} terms : {1} \n", number, result);
        }
    }
}
