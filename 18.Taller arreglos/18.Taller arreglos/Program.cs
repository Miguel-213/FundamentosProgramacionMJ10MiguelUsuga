using System;


namespace _18.Taller_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            //----------Punto 1----------

            /*Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
            pantalla la suma de los elementos de cada columna. */
            //int[,] matriz = new int[10, 20];

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
            //    }
            //}

            //for(int j = 0; j < matriz.GetLength(1); j++)
            //{
            //    int suma = 0;
            //    for(int i = 0; i < matriz.GetLength(0); i++)
            //    {
            //        suma += matriz[i, j];
            //    }
            //    Console.WriteLine($"La suma de la columna {j + 1} es: {suma}");
            //}


            //----------Punto 2----------

            /*Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
            matriz con el intercambio de filas.*/


            //int filas = 0;
            //int columnas = 0;
            //String caracter = "";


            //Console.WriteLine("Ingrese el numero de filas que desea: ");
            //filas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el numero de columnas que desea: ");
            //columnas = int.Parse(Console.ReadLine());


            //String[,] caracteres = new String[filas, columnas];
            //String[,] caracteresInvertidos = new String[filas, columnas];


            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < columnas; j++)
            //    {
            //        Console.WriteLine("Ingrese un caracter para la posición [{0},{1}]: ", i, j);
            //        caracteres[i, j] = Console.ReadLine();
            //    }
            //}


            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0;j < columnas; j++)
            //    {
            //        caracteresInvertidos[i, j] = caracteres[filas - 1 - i, j];
            //    }
            //}
            //Console.WriteLine("Matriz original: ");
            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < columnas; j++)
            //    {
            //        Console.Write(caracteres[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Matriz con filas intercambiadas: ");
            //for (int i = 0; i<filas;i++)
            //{
            //    for(int j = 0; j<columnas; j++)
            //    {
            //        Console.Write(caracteresInvertidos[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //----------Punto 3----------

            /*
             Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
5x5 llena de números aleatorios. 
El algoritmo debe permitir:
 Usa la función Random para generar los números aleatorios. 
 Crea un arreglo adicional para almacenar la frecuencia de cada número. 
 Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número 

             */


            //int[,] numerosAleatorios = new int[5, 5];
            //int[] frecuencia = new int[10];


            //Console.WriteLine("Matriz creada: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        numerosAleatorios[i, j] = random.Next(1, 11);
            //        Console.Write(numerosAleatorios[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        frecuencia[numerosAleatorios[i, j] - 1]++;
            //    }

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //        Console.WriteLine("La frecuencia del numero " + (i+1) + " es: " + frecuencia[i]);
            //}


            //----------Punto 4----------


            /*Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en 
            posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la 
            posición de una "X".
            El algoritmo debe permitir:
             Usar la función Random para colocar las "X" en la matriz. 
             Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado. 
             Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la 
            posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz. */


            //String[,] tablero = new string[5, 5];


            //int[] XFila = new int[3];
            //int[] XColumna = new int[3];
            //int fila = 0;
            //int columna = 0;


            //for (int i = 0; i < 3; i++)
            //{
            //    XFila[i] = random.Next(0 , 5 );
            //    XColumna[i] = random.Next(0, 5);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    tablero[XFila[i], XColumna[i]] = "X";
            //}

            ////for (int i = 0; i < 5; i++)
            ////{
            ////    for (int j = 0; j < 5; j++)
            ////    {
            ////        if (tablero[i, j] == null) { Console.Write("O"); }
            ////        Console.Write(tablero[i,j]);

            ////    }
            ////    Console.WriteLine();
            ////}

            //for (int k = 0; k < 3; k++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Ingrese la fila en que esta la X");
            //    fila = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Ingrese la columna en que esta la X");
            //    columna = int.Parse(Console.ReadLine());

            //    if (tablero[fila-1, columna-1] == "X")
            //    {
            //        Console.WriteLine("Correcto, la X estaba en: " + fila + " - " + columna);
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Incorrecto");
            //    }


            //}



            //----------Punto 5----------

            /*. Desarrollar un programa e C# que: 
             Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz 
            de enteros 
             Cargue los datos de la matriz ingresándolos por teclado 
             Muestre la matriz ingresada 
             Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser 
            ahora la columna 1. 
             Mostrar la nueva matriz*/




            //int filas = 0;
            //int columnas = 0;


            //Console.WriteLine("Ingrese el numero de filas que desea: ");
            //filas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el numero de columnas que desea: ");
            //columnas = int.Parse(Console.ReadLine());

            //int[,] numeros = new int[filas, columnas];
            //int[,] numerosInvertidos = new int[columnas, filas];


            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < columnas; j++)
            //    {
            //        Console.WriteLine("Ingrese el numero en la posicion " + i + " " + j);
            //        numeros[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Matriz ingresada");
            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < columnas; j++)
            //    {
            //        Console.Write(" " + numeros[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < columnas; j++)
            //    {
            //        numerosInvertidos[j, i] = numeros[i, j];
            //    }
            //}

            //Console.WriteLine("Matriz con filas y columnas intercambiadas");
            //for (int i = 0; i < columnas; i++)
            //{
            //    for (int j = 0; j < filas; j++)
            //    {
            //        Console.Write(" " + numerosInvertidos[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            //----------Punto 6----------

            /*Crear una aplicación en C# que permita realizar las siguientes acciones: 
             Crear una matriz de n filas por m columnas 
             Llenar la matriz con números aleatorios del 1 al 3 (investigar la función random en C#) 
             Mostrar la matriz generada 
             Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el 
            número 3, y cuál de los tres números fue repetido más veces. */




            //int filas = 0;
            //int columnas = 0;
            //int numeroMayor = 0;
            //int indiceNumeroMayor = 0;
            //int numeroMayor2 = 0;
            //int indiceNumeroMayor2 = 0;



            //Console.WriteLine("Ingrese el numero de filas que desea: ");
            //filas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el numero de columnas que desea: ");
            //columnas = int.Parse(Console.ReadLine());


            //int[,] numerosAleatorios = new int[filas, columnas];
            //int[] frecuencia = new int[3];


            //Console.WriteLine("Matriz creada: ");
            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < columnas; j++)
            //    {
            //        numerosAleatorios[i, j] = random.Next(1, 4);
            //        Console.Write(numerosAleatorios[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < columnas; j++)
            //    {
            //        frecuencia[numerosAleatorios[i, j] - 1]++;
            //    }

            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("La frecuencia del numero " + (i + 1) + " es: " + frecuencia[i]);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    if (frecuencia[i] == numeroMayor)
            //    {
            //        numeroMayor2 = frecuencia[i];
            //        indiceNumeroMayor2 = i;
            //    }

            //    if (frecuencia[i] > numeroMayor)
            //    {
            //        numeroMayor = frecuencia[i];
            //        indiceNumeroMayor = i;
            //    }
                

            //}

            //Console.WriteLine("El numero que mas se repitio fue el " + (indiceNumeroMayor + 1) + " con un total de " + numeroMayor + " veces");

            //if(numeroMayor2 != 0) 
            //{
            //    Console.WriteLine("El numero " + (indiceNumeroMayor2 + 1) + " tambien se repitio " + numeroMayor2 + " veces");
            //}









        }
    }
}
