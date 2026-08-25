using System;
namespace _8.Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 1;
            int acomulador = 0;

            while (contador <= 5)
            {
                acomulador += contador;
                contador++;
            }
            Console.WriteLine("La suma de los 5 primeros numeros enteros es " + acomulador);
        }
    }
}
