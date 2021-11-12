using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class Flipcoin
    {
        public void Play()
        {
            Console.WriteLine("Enter No. of Times To Flip Coin");
            int number = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int headCount = 0, tailCount = 0;
            for (int i = 0; i < number; i++)
            {
                double flip = random.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
            }
            headCount *= (100 / number);
            tailCount *= (100 / number);
            Console.WriteLine("Headscount percentage is:" + headCount + "%\n" + "Tailscount percentage is:" + tailCount + "%\n");
        }
    }
}
