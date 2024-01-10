/*
 * Autor: David Galán
 * Data: 27/11/2023
 * Exercici 4. Implementa un mètode que rebi un text i el retorni a majúscules o a minúscules (segons el cas).
 */
using System;
namespace activitats
{
    public class Exercici4
    {
        static void Main(string[] args)
        {
            int choice=0;
            string input;
            const string Input = "Introdueix un text", Cas="1 = majúscules, 2 = minúscules";
            Console.WriteLine(Input);
            input = Console.ReadLine();
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine(Cas);
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine(Mayus(input));
                }
                else if (choice == 2)
                {
                    Console.WriteLine(Minus(input));
                }
            }


        }
        public static string Mayus(string input)
        {
            input = input.ToUpper();
            return input;
        }
        public static string Minus(string input)
        {
            input = input.ToLower();
            return input;
        }
    }
}
