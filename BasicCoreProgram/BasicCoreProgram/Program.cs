using System;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an Option To Execute the Program\n 1.flipcoin\n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Flipcoin coin = new Flipcoin();
                        coin.Play();
                        break;
                    case 2:
                        flag = false;
                        break;
                }

            }
        }
    }
}
