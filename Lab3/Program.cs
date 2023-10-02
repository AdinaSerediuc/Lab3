using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        /*
         * Ex1
        Se citeste de la tastatura un vector continant n numere intregi , n fiind si el citit la randul sau citit de la tastatura .
        Scrieti functii care vor returna
        •Cel mai mare numar din vector
        •Cel mai mic numar din vector
        •Numerele divizibile cu 3
        •Scrieti o functie care va inversa elementele vectorului , apelati o si afisati I rezultatul
        Optional
        •Numerele prime din vector
        Apelati functiile si afisati le rezultatele
        */
        {
            Console.WriteLine("Hello there :)");



            int n = int.Parse(Console.ReadLine());
            int[] vector = CitesteVector(n);
            int celMaiMareNumar = GasesteCelMaiMareNumar(vector);
            int celMaiMicNumar = GasesteCelMaiMicNumar(vector);

            Console.WriteLine("Cel mai mare numar din vector este: " + celMaiMareNumar);
            Console.WriteLine("Cel mai mic numar din vector este: " + celMaiMicNumar);

            VerificaDivizibilitateLa3(vector);

            AfiseazaVector("Vectorul initial: ", vector);

            InverseazaVector(vector);
            AfiseazaVector("Vectorul după inversare: ", vector);

            VerificaNumerePrime(vector);



        }

        static int[] CitesteVector(int n)
        {
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = i + 1;
            }
            return vector;
        }

        static int GasesteCelMaiMareNumar(int[] vector)
        {
            /*if (vector == null || vector.Length == 0)
            {
                Console.WriteLine("Vectorul nu poate fi null sau gol.");
            }*/
            int celMaiMareNumar = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] > celMaiMareNumar)
                {
                    celMaiMareNumar = vector[i];
                }
            }
            return celMaiMareNumar;

        }

        static int GasesteCelMaiMicNumar(int[] vector)
        {
            /*if (vector == null || vector.Length == 0)
            {
                Console.WriteLine("Vectorul nu poate fi null sau gol.");
            }*/

            int celMaiMicNumar = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < celMaiMicNumar)
                {
                    celMaiMicNumar = vector[i];
                }
            }
            return celMaiMicNumar;
        }

        static void VerificaDivizibilitateLa3(int[] vector)
        {
            Console.WriteLine("Numerele divizibile la 3 din vector sunt:");
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] % 3 == 0)
                {
                    Console.Write(vector[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void AfiseazaVector(string mesaj, int[] vector)
        {
            Console.Write(mesaj);
            foreach (var numar in vector)
            {
                Console.Write(numar + " ");
            }
            Console.WriteLine();
        }

        public static void InverseazaVector(int[] vector)
        {
            int stanga = 0;
            int dreapta = vector.Length - 1;

            while (stanga < dreapta)
            {
                int temp = vector[stanga];
                vector[stanga] = vector[dreapta];
                vector[dreapta] = temp;

                stanga++;
                dreapta--;
            }
        }

    }
}
