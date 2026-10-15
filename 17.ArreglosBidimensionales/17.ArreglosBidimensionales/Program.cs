using System;

namespace _17.ArreglosBidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensinoales o matrices

            //int[,] numeros = new int[2,3];

            //Numeros[2 , 1] = 10; No se puede almacenar porque el indice de la fila no existe

            //Numeros[1 , 3] = 10; No se puede almacenar porque el indice de la columna no existe

            //numeros[0, 0] = 12;
            //numeros[0, 1] = 100;
            //numeros[0, 2] = 56;
            //numeros[1, 0] = 45;
            //numeros[1, 1] = 8;
            //numeros[1, 2] = 10;

            //Console.WriteLine("El valor almacenado en numeros[1, 0] es: " + numeros[1, 0]);

            //char[,] simbolos = new char[3, 2];

            //for (int i = 0; i < 3; i++) 
            //{
            //    for (int j = 0;j<2;j++)
            //    {
            //        Console.WriteLine("Ingrese el caracter para simbolos[" + i + ", " + j + "]: ");
            //        simbolos[i, j] = char.Parse(Console.ReadLine());
            //    }
            //}

            ////Recorrer el arreglo bidimensional para mostrar los valores almacenados

            //for (int i = 0; i < simbolos.GetLength(0); i++) //GetLength(0) devuelve el numero de filas del arreglo
            //{
            //    for(int j = 0; j < simbolos.GetLength(1); j++) //GetLength(1) devuelve el numero de columnas del arreglo
            //    {
            //        Console.Write(simbolos[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //String[,] nombres = {
            //    {"Juan", "Pedro", "Maria", "Pepe"},
            //    {"Ana", "Luis", "Carlos", "Sofia"},
            //    {"Sofia", "Diego", "Valentina", "Juan"}
            //};



            //-----------Ejercicio 1-----------

            //int[,] matriz = new int[10, 20];


            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = 100;

            //    }
            //}

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //-----------Ejercicio 2-----------


            int[,] numeros = new int[2, 3];
            int[,] numeros2 = new int[2, 3];
            int[,] suma = new int[2, 3];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine("Ingrese el valor para numeros[" + i + ", " + j + "]: ");
                    numeros[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < numeros2.GetLength(0); i++)
            {
                for (int j = 0; j < numeros2.GetLength(1); j++)
                {
                    Console.WriteLine("Ingrese el valor para numeros2[" + i + ", " + j + "]: ");
                    numeros2[i, j] = int.Parse(Console.ReadLine());

                    suma[i, j] = numeros[i, j] + numeros2[i, j];
                }
            }

            // Mostrar la matriz resultante
            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    Console.Write(suma[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
