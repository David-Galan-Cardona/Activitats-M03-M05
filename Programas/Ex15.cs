/*
 * Autor: David Galán
 * Data: 29/11/2023
 * 15. Implementa un programa que demani l’any i aquest retorni si és un any de traspàs. NO es poden fer servir funcions pròpies de C#.
 */
using System;
namespace activitats
{
    public class Exercici15
    {
        public static void Main()
        {
            int input;
            const string Input = "Introdueix un any";
            Console.WriteLine(Input);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Traspas(input));
        }
        public static bool Traspas(int input)
        {
            return input%4!=0? false: true;
        }
    }
}