/*
 * Autor: David Galán
 * Data: 27/11/2023
 * Exercici 6. Implementa un programa que retorni el valor absolut d'un nombre introduït per teclat, utilitzant un dels mètodes implementats en la API de .Net. 
 */
using System;
namespace activitats
{
    public class Exercici6
    {
        static void Main(string[] args)
        {
            int input;
            const string Input = "Introdueix un nombre";
            Console.WriteLine(Input);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(input));
        }
    }
}