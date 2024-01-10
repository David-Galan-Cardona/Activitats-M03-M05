/*
 * Autor: David Galán
 * Data: 27/11/2023
 * Exercici 7. Implementa un programa que retorni el la potència d'un nombre introduït per teclat, utilitzant un dels mètodes implementats en la API de .Net. 
 */
using System;
namespace activitats
{
    public class Exercici7
    {
        static void Main(string[] args)
        {
            double bas, exp;
            const string Base = "Introdueix un nombre base", Exp = "Introdueix un nombre exponent";
            Console.WriteLine(Base);
            bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Exp);
            exp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(bas,exp));
        }
    }
}