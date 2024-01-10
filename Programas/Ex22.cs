/*
 * Autor: David Galán
 * Data: 18/12/2023
 * 22. Implementa un programa que simuli el moviment d'un objecte en un entorn 2D, representant així un escenari de videojoc. 
 * L'objecte té una posició inicial en l'origen (0, 0) i es mou en funció d'una velocitat i direcció controlades per funcions trigonomètriques. 
 * La velocitat inicial de l'objecte és d'1.0 unitats per segon, i la direcció inicial és de 45 graus respecte a l'eix positiu x. 
 * Durant la simulació, la direcció de l'objecte canviarà en intervals de 10 graus per a simular esdeveniments en el joc. 
 * Mostra la posició actual de l'objecte en cada iteració de la simulació. La simulació ha de tenir una durada total de 5 segons. 
 * Implementa el seu test unitari.
 */
using System;
namespace activitats
{
    class Exercici22
    {
        public static void Main(string[] args)
        {
            double xPosition=1, yPosition=1, degrees=(Math.PI/4), module, auxY, auxX;
            
            for(int i = 0; i < 5; i++)
            {
                module = Math.Sqrt(2 * yPosition + 2 * xPosition);
                Console.WriteLine($"Posición actual: ({Math.Round(xPosition, 2)}, {Math.Round(yPosition, 2)}). Angulo: {Math.Round(degrees * 180 / Math.PI),0}º");
                degrees = ChangeDegrees(degrees);
                auxY = yPosition;
                auxX = xPosition;
                xPosition = module*Math.Cos(degrees)+auxX-Math.Cos(degrees);
                yPosition = module * Math.Sin(degrees) + auxY - Math.Sin(degrees);
            }
            Console.WriteLine(degrees * 360 / (2 * Math.PI));
        }
        public static double ChangeDegrees(double degrees)
        {
            Random rnd = new Random();
            double aux;
            int sum = 10;
            if (rnd.Next(0,2)==0)
            {
                sum *= -1;
            }
            aux = degrees * (360 / 2)/ Math.PI + sum;
            return aux * Math.PI / 180;
        }
    }
}