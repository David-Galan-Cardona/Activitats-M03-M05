/*
 * Autor: David Galán
 * Data: 27/11/2023
 * Exercici 3. Implementa un programa que retorni el valor absolut d'un nombre introduït per teclat.
 */
using System;
namespace activitats
{
    public class Exercici3
    {
        static void Main(string[] args)
        {
            int input;
            const string Input = "Introdueix un nombre";
            Console.WriteLine(Input);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Absolut(input));
        }
        public static int Absolut(int input)
        {
            if (input < 0)
            {
                return input = -input;
            }
            else
            {
                return input;
            }
        }
    }
}
