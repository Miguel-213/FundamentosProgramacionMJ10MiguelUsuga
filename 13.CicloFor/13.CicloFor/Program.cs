using System;
using System.Security.AccessControl;


namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int acumulador = 0;

            for(int i = 0; i <= 5; i++)
            {
                acumulador += i;
            }
            Console.WriteLine("La suma de los primeros 5 enteros es: " + acumulador);  

        }
    }
}
