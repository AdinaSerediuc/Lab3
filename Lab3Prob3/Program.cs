using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex 3
            Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom
            */

            Console.Write("Introduceti un sir de caractere: ");
            string input = Console.ReadLine();

            string cleanedInput = input.Replace(" ", "").ToLower();

            if (IsPalindrome(cleanedInput))
            {
                Console.WriteLine("Este un palindrom.");
            }
            else
            {
                Console.WriteLine("Nu este un palindrom.");
            }
        }

        static bool IsPalindrome(string text)
        {
            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (text[left] != text[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
