/*
 * Autor: David Galán
 * Data: 18/12/2023
 * 21. Implementa un programa que demani un nombre romà i retorni el seu valor enter.
 */
using System;
using System.Text;
namespace activitats
{
    class Exercici21
    {
        static void Main(string[] args)
        {
            string num;
            Console.WriteLine("Escriu un nombre romà");
            num = Console.ReadLine() ?? "";
            Console.WriteLine("El valor és");
            if (roman_to_int(num) != 0)
            {
                Console.WriteLine(roman_to_int(num));
            }
            else { Console.WriteLine("El nombre no existeix"); }

        }


        public static int roman_to_int(string str1)
        {
            str1 = str1.ToUpper();
            int num = 0;
            bool allRomanNumbers = true;
            for (int i = 0; i < str1.Length; i++)
            {
                if (i > 0 && find_value(str1[i]) > find_value(str1[i - 1]))
                {
                    num += find_value(str1[i]) - find_value(str1[i - 1]) * 2;
                }
                else if (i > 0 && (find_value(str1[i]) == 0 || find_value(str1[i - 1])==0))
                {
                    allRomanNumbers = false;
                }
                else
                {
                    num += find_value(str1[i]);
                }
            }
            if (allRomanNumbers==false)
            {
                return 0;
            }
            return num;
        }

        public static int find_value(char chr)
        {
            switch (chr)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}