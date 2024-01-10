/*
 * Autor: David Galán
 * Data: 29/11/2023
 * 14. Implementa un algorisme que donat un nombre introduït per teclat:
 * calculi quants digits té i ho mostri per pantalla
 * sumi els dígits amb valor parell (si n’hi han) i mostri el resultat per pantalla
 * sumi els dígits senars (si n’hi han)  i mostri el resultat per pantalla
 */
using System;
namespace activitats
{
    public class Exercici14
    {
        public static void Main()
        {
            int input;
            const string Input = "Introdueix un nombre";
            Console.WriteLine(Input);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Digits(input));
            Console.WriteLine(Suma(input));
            Console.WriteLine(Resta(input));
        }
        public static int Digits(int input)
        {
            int digits = 0;
            while (input != 0)
            {
                input /= 10;
                digits++;
            }
            return digits;
        }
        public static int Suma(int input)
        {
            int stored = input;
            int sum = 0;
            int[] number = new int[Digits(input)];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = input % 10;
                input /= 10;
            }
            input = stored;
            for (int i = 0;i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    sum += number[i];
                }

            }
            return sum;
        }
        public static int Resta(int input)
        {
            int stored = input;
            int sum = 0;
            int[] number = new int[Digits(input)];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = input % 10;
                input /= 10;
            }
            input = stored;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    sum += number[i];
                }

            }
            return sum;
        }
    }
}