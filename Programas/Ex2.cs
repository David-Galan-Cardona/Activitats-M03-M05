/*
 * Autor: David Galán
 * Data: 21/11/2023
 * Exercici 2. Crea un programa que demani per teclat un la base i l’exponent i retorni la potència.
 */
using System;
namespace activitats
{
    public class Exercici2
    {
        static void Main(string[] args)
        {
            double bas;
            int exp;
            const string IntroBase = "Introdueix la base", IntroExp = "Introdueix l'exponent:";
            Console.WriteLine(IntroBase);
            bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(IntroExp);
            exp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Potencia(bas,exp));
        }
        public static double Potencia(double bas, int exp)
        {
            double output=bas;
            for (int i = exp; i > 1; i--)
            {
                output = output * bas;
            }
            if (exp == 0)
            {
                output = 1;
            }
            if (exp == 1)
            {
                output = bas;
            }
            if (exp < 0)
            {
                for (int i = 0; i > exp-1; i--)
                {
                    output = output / bas;
                }
            }
            return output;
        }
    }
}