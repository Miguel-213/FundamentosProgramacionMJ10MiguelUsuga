using System;

namespace _9_EjericioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Pida al usuario una cantidad x de numeros y diga cuantos son mayores que cero, cuantos son menores que cero y cuantos son iguales a cero.

            //int cantidadNumeros = 0;
            //int numero = 0;
            //int mayoresQueCero = 0;
            //int menoresQueCero = 0;
            //int igualesQueCero = 0;
            //String respuesta = "";

            //while (true) {

            //    Console.WriteLine("Ingrese la cantidad de numeros que va a ingresar");
            //    cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 1; i< cantidadNumeros + 1;i++) {

            //        Console.WriteLine("Ingrese el numero " + i);
            //        numero = Convert.ToInt32(Console.ReadLine());

            //        switch (numero)
            //        {
            //            case int n when n > 0:
            //                mayoresQueCero++;
            //                break;
            //            case int n when n < 0:
            //                menoresQueCero++;
            //                break;
            //            case 0:
            //                igualesQueCero++;
            //                break;
            //        }

            //    }

            //    Console.WriteLine("Los numeros mayores a cero son: " + mayoresQueCero);
            //    Console.WriteLine("Los numeros menores a cero son: " + menoresQueCero);
            //    Console.WriteLine("Los numeros iguales a cero son: " + igualesQueCero);

            //    Console.WriteLine("Desea continuar? (s/n)");
            //    respuesta = Console.ReadLine();

            //    if (respuesta != "s")
            //    {
            //        break;
            //    }

            //}


            //2. Escribir un algoritmo que cuente cuantos numeros pares hay en un rango de numeros del 1 al numero n

            int numero = 0;
            int cantidadPares = 0;

            Console.WriteLine("Ingrese el numero n");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    cantidadPares++;
                }
            }

            Console.WriteLine("La cantidad de numeros pares del 1 al " + numero + " es: " + cantidadPares);

        }
    }
}
