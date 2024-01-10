/*
 * Autor: David Galán
 * Data: 27/11/2023
 * Exercici 9. Implementa un mètode per a utilitzar en un programa principal, o invocat per un altre mètode, que permeti validar 
 * si un nombre és més petit que un valor (introduït per teclat) o és dins d’un rang (està dins de dos valors introduïts per teclat). 
 * Els missatges que es mostraran han de poder ser parametritzables.
 */
using System;
namespace activitats
{
    public class Exercici9
    {
        public static void Main(string[] args)
        {
            int inputValue, comparator, min, max, choice;
            const string InputValue = "Introdueix un nombre", Question = "Que vols fer? \n1.Comprovar si el nombre és més petit que un altre \n2.Comprovar si el nombre està dins d'un rang",
                Comparator = "Amb quin nombre ho vols comparar?", Min = "Escull el valor mínim", Max = "Escull el valor màxim", ErrorRang = "Introdueix un nombre més gran que el valor mínim",
                Error="Introdueix un nombre vàlid";
            Console.WriteLine(InputValue);
            inputValue=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Question);
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine(Error);
                choice = Convert.ToInt32(Console.ReadLine());
            }
            if (choice == 1)
            {
                Console.WriteLine(Comparator);
                comparator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Compare(inputValue, comparator));
            }
            else
            {
                Console.WriteLine(Min);
                min= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Max);
                max= Convert.ToInt32(Console.ReadLine());
                while (max <= min)
                {
                    Console.WriteLine(ErrorRang);
                    max = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(Compare(min,max, inputValue));
            }
        }
        public static string Compare(int value, int comparator)
        {
            if (value < comparator)
            {
                return $"El nombre {value} és més petit que el nombre {comparator}";
            }
            else if (value > comparator)
            {
                return $"El nombre {comparator} és més petit que el nombre {value}";
            }
            else 
            { 
                return "Els dos nombres són iguals";
            }
        }
        public static string Compare(int min, int max, int inputValue)
        {
            if (inputValue < max && inputValue > min)
            {
                return "El nombre està dins del rang";
            }
            else
            {
                return "El nombre no està dins del rang";
            }
        }
    }
}