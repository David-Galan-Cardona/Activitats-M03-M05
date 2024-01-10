/*
 * Autor: David Galán
 * Data: 27/11/2023
 * Exercici 5. Demanar un nombre per teclat i indicar per pantalla si aquest nombre és positiu i menor que 100.
 */
using System;
namespace activitats
{
    public class Exercici5
    {
        static void Main(string[] args)
        {
            int input = 0;
            const string Input = "Introdueix un nombre", True = "El nombre està dins de l'interval", False = "El nombre no està dins de l'interval";
            Console.WriteLine(Input);
            input = Convert.ToInt32(Console.ReadLine());
            if (Validate(input))
            {
                Console.WriteLine(True);
            }
            else
            {
                Console.WriteLine(False);
            }
        }
        public static bool Validate(int input)
        {
            if (input >= 0 && input < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
