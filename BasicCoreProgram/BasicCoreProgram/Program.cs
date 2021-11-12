using System;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[]args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an Option To Execute the Program\n 1.flipcoin\n 2.LeapYearCheck\n 3.PowerOfTwo\n 4.harmonicNumber\n 5.PrimeFactors\n 6.QuotientAndRemainder \n 7.SwapTwoNumbers\n 8.EvenOrOddCheck\n 9.VowelOrConsonantCheck\n 10.Exit");
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
                        HarmonicNumber result = new HarmonicNumber();
                        result.Harmonic();
                        break;
                    case 5:
                        Factors prime = new Factors();
                        prime.PrimeFactors();
                        break;
                    case 6:
                        QuotientAndRemainder quotient = new QuotientAndRemainder();
                        quotient.Result();
                        break;
                    case 7:
                        SwapTwoNumbers swap = new SwapTwoNumbers();
                        swap.Swapping();
                        break;
                    case 8:
                        EvenOrOdd check1 = new EvenOrOdd();
                        check1.EvenOdd();
                        break;
                    case 9:
                        VowelOrConsonant check2 = new VowelOrConsonant();
                        check2.VowelConsonant();

                        break;
                    case 10:
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



