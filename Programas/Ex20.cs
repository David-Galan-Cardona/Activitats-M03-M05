/*
 * Autor: David Galán
 * Data: 13/12/2023
 * 20. Implementa un programa que donat un nombre decimal introduït per teclat retorni la part entera i la part decimal d’aquest.
 */
using System;
namespace activitats
{
    public class Exercici20
    {
        public static void Main(string[] args)
        {
            const string InputNum = "Introdueix el nombre";
            double input;
            Console.WriteLine(InputNum);
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La part entera és {Enter(input)} y la decimal és {Decimals(input)}");
        }

        public static double Enter(double input)
        {
            return Math.Round(input);
        }
        public static double Decimals(double input)
        {

            return input- Math.Round(input);
        }
    }
}