using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class SwapTwoNumbers
    {
        public void Swapping()
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Enter First Number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("After Swapping First number=" + firstNumber + " and Second Number=" + secondNumber + "\n");
        }
    }
}