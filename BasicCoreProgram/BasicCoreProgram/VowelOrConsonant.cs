using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class VowelOrConsonant
    {
        public void VowelConsonant()
        {
            Console.WriteLine("Enter the Alphabet To Check");
            char str = Convert.ToChar(Console.ReadLine());
            char letter = char.ToLower(str);
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("It is a Vowel");
            }
            else
            {
                Console.WriteLine("It is a Consonant");
            }
        }
    }
}
