using System;
namespace Recursividad
{
    class Ex27
    {
        public static void Main()
        {
            int num;
            int div = 2;

            Console.WriteLine("Introdueix el nombre");
            num = Convert.ToInt32(Console.ReadLine());
            if (num != 1) Console.WriteLine(Prime(num, div) ? "Es primer" : "No es primer");
            else Console.WriteLine("Es primer");
        }
        public static bool Prime(int num, int div)
        {
            if (div==num)
            {
                return true;
            }
            else if (num%div == 0)
            {
                return false;
            }
            return Prime(num, div+1);
        }
    }
}