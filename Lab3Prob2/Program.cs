using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex 2
             Scrieti un program care va afisa pozitia unui substring intr un string, ambele siruri de caractere fiind citite de la tastatura
            */

                Console.WriteLine("Introduceti un sir de caractere:");
                string text = Console.ReadLine();

                Console.WriteLine("Introduceti subsirul cautat:");
                string subString = Console.ReadLine();

                int pozitie = GasestePozitieSubString(text, subString);

            if (pozitie != -1)
            {
                Console.WriteLine("Subsirul " + subString + " se afla la pozitia " + pozitie + " in sirul dat.");
            }

            else
            {
                Console.WriteLine("Subsirul " + subString + " nu a fost gasit in sirul dat.");
            }
            }

            static int GasestePozitieSubString(string text, string subString)
            {
                int pozitie = text.IndexOf(subString);
                return pozitie;
            }
        }
    }
