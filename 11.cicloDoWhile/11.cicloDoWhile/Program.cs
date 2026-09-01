using System;

namespace _11.cicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int contador = 1;
            //int acomulador = 0;

            //do 
            //{

            //    acomulador += contador;
            //        contador++;

            //} while (contador <= 1);



            //------------------------------------------------------------------------------------//

            //1.Algoritmo que solicita un numero y genere su correspondiente tabla de multiplicar dede el 1 hasta el 10. y asi sucesivamente hasta que el usuario no desee continuar generando tablas de multiplicar

            //int numeroTabla = 0;
            //string continuar = "";


            //do 
            //{
            //    Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
            //    numeroTabla = Convert.ToInt16(Console.ReadLine());

            //    for (int i = 1; i <= 10;i++) 
            //    {
            //        Console.WriteLine(numeroTabla + " x " + i + " = " + (numeroTabla * i));

            //    }

            //    Console.WriteLine("¿Desea continuar generando tablas de multiplicar? (y/n)");
            //    continuar = Console.ReadLine();
            //    if (continuar != "y")
            //    {
            //        break;
            //    }

            //} while (true);



            //------------------------------------------------------------------------------------//

            //2.Crear un algoritmo que permita calcular y mostrar por pantalla lo snumeros primos hasta el numero 100



            //Todos los numeros no primos 


            //int numero = 2;

            //do
            //{
            //    for (int i = numero - 1; i >= 2; i--)
            //    {

            //        if (numero % i == 0)
            //        {
            //            Console.WriteLine(numero);
            //        }

            //    }

            //    numero++;
            //} while (numero < 100);


            int numero = 3;

            do
            {
                bool esPrimo = true;

                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    Console.WriteLine(numero);
                }

                numero++;
            } while (numero < 100);




        }
    }
}
