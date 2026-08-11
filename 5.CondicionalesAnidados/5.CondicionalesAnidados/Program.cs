using System;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales anidados
            //b. Diseñar un algoritmo que lea tres numeros A, B y C y determine cual es el mayor de los tres.
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Ingrese el primer número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El número mayor es: " + num1);
                }
                else
                {
                    Console.WriteLine("El número mayor es: " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El número mayor es: " + num2);
                }
                else
                {
                    Console.WriteLine("El número mayor es: " + num3);
                }
            }
        }
    }
}
