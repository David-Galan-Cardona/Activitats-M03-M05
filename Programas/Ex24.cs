using System;
namespace Recursividad
{
    class Ex1
    {
        public static void Main()
        {
            int numA, numB;

            Console.WriteLine("Introdueix el primer nombre");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix el segon nombre");
            numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iterativa");
            Console.WriteLine(MultIt(numA, numB));
            Console.WriteLine("Recursiva");
            Console.WriteLine(MultRec(numA, numB));

        }
        public static int MultIt(int numA, int numB)
        {
            int result = 0;
            while (numA > 1)
            {
                if (numA % 2 != 0)
                {
                    result += numB;
                }
                numA /= 2;
                numB *= 2;
            }
            if (numA % 2 != 0)
            {
                result += numB;
            }
            return result;
        }
        public static int MultRec(int numA, int numB)
        {
            if (numA == 1)
            {
                return numB;
            }
            if (numA % 2 != 0)
            {
                return numB + MultRec(numA/2, numB*2);
            }
            return MultRec(numA / 2, numB * 2);
        }
    }
}