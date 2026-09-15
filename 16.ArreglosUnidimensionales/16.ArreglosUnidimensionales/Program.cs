using System;


namespace _16.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = new int[5];
            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;
            //numeros[5] = 60;

            //Console.WriteLine("El numero almacenado en la posicion 4 ocon indice 3 es: " + numeros[3]);

            ////Otras formas de declarar e inicializar vectores
            //char[] simbolos = new char[] { '?', '/', 'o', '5'};
            //bool[] ValoresVerdad = new bool[] { true, false, true, false, true, true };


            ////Recorrer para llenar datos en el vector
            //String[] nombres = new String[7];
            //for (int i = 0; i < nombres.Length; i++) 
            //{
            //    Console.WriteLine("Ingrese el nombre para la posicion " + i + ": ");
            //    nombres[i] = Console.ReadLine();

            //}

            ////Recorrer para recuperar datos almacenados
            //for (int i = 0; i < nombres.Length; i++)
            //{
            //    Console.Write(nombres[i] + " | ");
            //}


            //Ejercicio 1: Crear un arreglo llamado enteros de 100 elementos, asignar el numero 10 en cada una de las posiciones y luego mostrar el contenido del arreglo en pantalla.

            //int[] enteros = new int[100];

            //for (int i = 0; i < enteros.Length; i++)
            //{
            //    enteros[i] = 10;
            //}

            ////Mostrar el contenido del arreglo

            //for (int i = 0; i < enteros.Length; i++)
            //{
            //    Console.Write(enteros[i] + " | ");
            //}



            //Ejercicio 2: Crear un algoritmo que permita solicitar 10 numeros, los cuales seran almacenados en un arrego, al final debe visualizar el promedio de esos numeros


            //int[] numeros = new int[10];
            //double promedio = 0;

            //for (int i = 0; i < numeros.Length; i++) 
            //{
            //    Console.WriteLine("Ingrese el numero para la posicion " + (i+1) + " :");
            //    numeros[i] = int.Parse(Console.ReadLine());
            //    promedio += numeros[i];
            //}


            //promedio = promedio / 10;

            //Console.WriteLine("El promedio de los numeros es: " + promedio);

            //Ejercicio 3: Llene un arreglo con 15 numeros ingressados por teclado. una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo. Finalmente, determine cual es el numero mayor, y cual es el numero menor, junto con la posicion que ocupa cada uno dentro del arreglo


            int[] numeros = new int[15];
            int mayor = 0;
            int menor = 0;
            int posicionMayor = 0;
            int posicionMenor = 0;


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el numero para la posicion " + (i + 1) + " :");
                numeros[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    menor = numeros[i];
                }

                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posicionMayor = i;
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicionMenor = i;
                }

            }


            for (int i = 0; i < numeros.Length; i++) 
            {
                Console.WriteLine("El numero en la posicion " + (i+1) + " es: " + numeros[i]);
            }

            Console.WriteLine("El numero mayor es " + mayor + " y se encuentra en la posicion " + (posicionMayor + 1));
            Console.WriteLine("El numero menor es " + menor + " y se encuentra en la posicion " + (posicionMenor + 1));




        }
    }
}
