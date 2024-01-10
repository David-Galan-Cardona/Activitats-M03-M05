/*
 * Autor: David Galán
 * Data: 04/12/2023
 * 16. Implementa un programa que demani a l’usuari quants valors vol introduir, de manera que el programa generi una llista a partir de valors introduïts per teclat 
 * i retorni el producte de tots els elements d’aquesta. Els valors que l’usuari pot introduir són entre (15, 100) i l’usuari disposa de 5 intents en total.
 */
using System;
namespace activitats
{
    public class Exercici16
    {
        public static void Main(string[] args)
        {
            const string InputValues = "Indica quants valors vols introduir:", InputNum = "introdueix un valor entre el 15 i el 100 (inclosos). Tens 5 intents com a màxim",
                NotValid = "El valor introduït no és vàlid.", Exceed = "Has superat el total d'intents.";
            const int Min = 15, Max = 100;
            int quantity, input, errors = 0;
            Console.WriteLine(InputValues);
            quantity = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[quantity];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (errors < 5)
                {
                    Console.WriteLine(InputNum);
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input < Min || input > Max)
                    {
                        Console.WriteLine(NotValid);
                        errors++;
                        i--;
                    }
                    else
                    {
                        numbers[i] = input;
                    }
                }
            }
            Console.WriteLine(errors == 5 ? Exceed : Multiply(numbers));
        }
        public static int Multiply(int[] numbers)
        {
            int answer = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                answer *= numbers[i];
            }
            return answer;
        }
    }
}