/*
 * Autor: David Galán
 * Data: 28/11/2023
 * Exercici 11.Implementa un programa que demani un valor per teclat i retorni el seu factorial.
 */
using System;
namespace activitats
{
    public class Exercici11
    {
        public static void Main()
        {
            int input;
            const string Input = "Introdueix un valor", Error="Valor invàlid";
            Console.WriteLine(Input);
            input = Convert.ToInt32(Console.ReadLine());
            if (input >= 0 )
            {
                Console.WriteLine(Factorial(input));
            }
            else
            {
                Console.WriteLine(Error);
            }
        }
        public static int Factorial(int input)
        {
            int result = 1;
            if (input == 0)
            {
                result = 0;
            }
            while (input > 0)
            {
                result *= input;
                input--;
            }
            return result;
        }
    }
}