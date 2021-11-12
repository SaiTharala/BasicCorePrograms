﻿using System;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an Option To Execute the Program\n 1.flipcoin\n 2.LeapYearCheck\n 3.PowerOfTwo\n 4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Flipcoin coin = new Flipcoin();
                        coin.Play();
                        break;
                    case 2:
                        Leapyear check = new Leapyear();
                        check.LeapYearCheck();
                        break;
                    case 3:
                        PowerofTwo pow = new PowerofTwo();
                        pow.Power();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option..\n");
                        break;
                }
            }
        }
    }
}