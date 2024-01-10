/*
 * Autor: David Galán
 * Data: 4/12/2023
 * 19. Implementa un programa que retorni el màxim i mínim de dos valors enters introduïts per teclat.
 */
using System;
namespace activitats
{
    public class Exercici19
    {
        public static void Main(string[] args)
        {
            const string InputNum = "Introdueix el primer nombre", SecondInputNum = "Introdueix el segon nombre";
            int input, secondInput;
            Console.WriteLine(InputNum);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SecondInputNum);
            secondInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El nombre més gran és {Bigger(input, secondInput)} y el més petit és {Smaller(input, secondInput)}");
        }

        public static double Bigger(int input, int secondInput)
        {
            return Math.Max(input, secondInput);
        }
        public static double Smaller(int input, int secondInput)
        {
            return Math.Min(input, secondInput);
        }
    }
}