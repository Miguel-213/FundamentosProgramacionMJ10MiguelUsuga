using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CiclosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.
            int numeroIngresado = 0;
            int resultadoSuma = 0;

            do
            {
                Console.WriteLine("ingresa un numero positivo para sumar, ingresa uno negativo para terminar");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado >= 0)
                {
                    resultadoSuma += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("El resultado de la suma es: " + resultadoSuma);
                    break;
                }
                } while (true) ;
            }
    }
}

