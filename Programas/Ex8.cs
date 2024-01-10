/*
 * Autor: David Galán
 * Data: 27/11/2023
 * Exercici 8. Implementa un mètode que retorni 10 nombres al·leatoris entre 0 i 256.
 */
using System;
namespace activitats
{
    public class Exercici8
    {
        static void Main(string[] args)
        {
            Random randoms = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randoms.Next(0,257));
            }

        }
    }
}