using System;
namespace Recursividad
{
    class Ex25
    {
        public static void Main()
        {
            int num;
            int div = 2;

            Console.WriteLine("Introdueix el nombre");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero {0} en binari és {1}", num, DecimalToBinary(num));
        }
        public static int DecimalToBinary(int num)
        {
            if (0 == num)
            {
                return 0;
            }
            return num%2 + 10 * DecimalToBinary(num/2);
        }
    }
}