/*
 * Autor: David Galán
 * Data: 4/12/2023
 * 18. Implementa un mètode que rebiun nombre enter (minuts) i retorni la seva conversió a segons.
 */
using System;
namespace activitats
{
    public class Exercici18
    {
        public static void Main(string[] args)
        {
            const string InputNum = "Introdueix els minuts";
            int input;
            Console.WriteLine(InputNum);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Això són {MinutesToSeconds(input)} segons");
        }

        public static double MinutesToSeconds(int input)
        {
            return input*60;
        }
    }
}