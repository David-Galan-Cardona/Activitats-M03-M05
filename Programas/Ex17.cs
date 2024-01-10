/*
 * Autor: David Galán
 * Data: 4/12/2023
 * 17. Implementa un programa que llegeixi graus en escala Celsius (CC) i els converteixi en graus en escala Fahrenheit (FF). Arrodoneix el resultat a 2 dígits 
 * després del punt decimal.
 */
using System;
namespace activitats
{
    public class Exercici17
    {
        public static void Main(string[] args)
        {
            const string InputNum = "Introdueix un valor en celsius";
            int input;
            Console.WriteLine(InputNum);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Això són {Degrees(input)} graus Farenheit");
        }
            
        public static double Degrees(int input)
        {
            const int mult = 9, div = 5, sum = 32;
            double answer;
            answer = input * mult / div + sum;
            return Math.Round(answer, 2);
        }
    }
}