using System;
namespace Recursividad
{
    class Ex1
    {
        public static void Main()
        {
            int num;

            Console.WriteLine("Introdueix el nombre");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumaDig(num));

        }
        public static int SumaDig(int num)
        {
            if (num / 10 == 0)
            {
                return num;
            }
            return num % 10 + SumaDig(num/10);
        }
    }
}