/*
 * Autor: David Galán
 * Data: 29/11/2023
 * 12. Demanar per teclat el nombre de litres consumits aquest mes i calcular la factura d’aigua, tenint en compte les següents dades:
 * La quota fixa és de 6€.
 * Els primers 50 litres d’aigua són de franc.
 * Entre 50 i 200 litres, el litre costa 0,1€
 * A partir de 200 el litre costa 0,3€.
 */
using System;
namespace activitats
{
    public class Exercici12
    {
        public static void Main()
        {
            int input;
            const string Input = "Introdueix els litres";
            Console.WriteLine(Input);
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Has gastat {Litres(input)} euros");
        }
        public static double Litres(int input)
        {
            double result = 6;
            input = input - 50;
            if (input > 0)
            {
                if (input <= 150)
                {
                    result = result + input * 0.1;
                }
                else
                {
                    result = result + 150 * 0.1;
                    input = input - 150;
                    result = result + input * 0.3;
                }
            }
            return result;
        }
    }
}