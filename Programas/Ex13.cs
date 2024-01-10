/*
 * Autor: David Galán
 * Data: 29/11/2023
 * 13. Implementa un algorisme que demani 20 nombres enters per teclat i retorni els valors de les posicions senars.
 */
using System;
namespace activitats
{
    public class Exercici13
    {
        public static void Main()
        {
            int [] input = new int[20];
            const string Input = "Introdueix 20 nombres";
            Console.WriteLine(Input);
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            int [] newArray = Senars(input);

            for (int i = 0;i < newArray.Length; i++)
            {
                Console.Write(newArray[i]+" ");
            }
        }
        public static int[] Senars(int[] input)
        {
            int[] result = new int[10];
            int j=0;
            for (int i = 0; i<input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result[j] = input[i];
                    j++;
                }
            }
            return result;
        }
    }
}