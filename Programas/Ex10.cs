/*
 * Autor: David Galán
 * Data: 28/11/2023
 * Exercici 10.Implementa un programa que generi una llista de 10 valors aleatoris entre el 0 i el 200, demani un valor per teclat i informi per pantalla 
 * si aquest valor indicat es troba a la llista.
 */
using System;
namespace activitats
{
    public class Exercici10
    {
        public static void Main(string[] args)
        {
            int input;
            const string Input = "Introdueix un valor";
            Console.WriteLine(Input);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Found(input));

        }
        public static string Found (int input)
        {
            int j = 0;
            bool found = false;
            Random rnd = new Random();
            int[] Randoms = new int[10];
            for (int i = 0; i < Randoms.Length; i++)
            {
                Randoms[i] = rnd.Next(0, 201);
            }
            while (j < Randoms.Length && !found)
            {
                for (int i = 0;i < Randoms.Length; i++)
                {
                    if (Randoms[i] == input)
                    {
                        found = true;
                    }
                }
                j++;
            }
            if (!found)
            {
                return "El nombre no és entre els valors aleatoris";
            }
            else
            {
                return "El nombre és entre dels valors aleatoris";
            }
        }
    }
}