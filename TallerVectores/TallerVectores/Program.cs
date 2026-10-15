using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;


namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
            //encuentre y muestre el valor máximo y mínimo de los números ingresados. 


            //int[] numeros = new int[15];
            //int valorMaximo = 0;
            //int valorMinimo = 0;

            //for (int i = 0; i < 15; i++)
            //{
            //    Console.Write("Ingrese el número {0}: ", (i + 1));
            //    numeros[i] = int.Parse(Console.ReadLine());

            //    if(i == 0)
            //    {
            //        valorMaximo = numeros[i];
            //        valorMinimo = numeros[i];
            //    }

            //    if (numeros[i] > valorMaximo)
            //    {
            //        valorMaximo = numeros[i];
            //    }
            //    if (numeros[i] < valorMinimo)
            //    {
            //        valorMinimo = numeros[i];
            //    }
            //}

            //Console.WriteLine("El meyor de los numeros es " + valorMaximo);
            //Console.WriteLine("El menor de los numeros es " + valorMinimo);


            //2. Escribir un algoritmo que permita: 
            //a.Crear dos vectores del mismo tamaño. 
            //b.Llenarlos con números.
            //c.Comparar posición por posición.
            //d.Indicar cuántos elementos son iguales. 

            //int tamaño = 0;

            //Console.WriteLine("Ingrese el tamaño de los vectores: ");
            //tamaño = int.Parse(Console.ReadLine());

            //int[] vector1 = new int[tamaño];
            //int[] vector2 = new int[tamaño];

            //for (int i = 0; i < tamaño; i++)
            //{
            //    Console.Write("Ingrese el número {0} del vector 1: ", (i + 1));
            //    vector1[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < tamaño; i++)
            //{
            //    Console.Write("Ingrese el número {0} del vector 2: ", (i + 1));
            //    vector2[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < tamaño; i++)
            //{
            //    if (vector1[i] == vector2[i])
            //    {
            //        Console.WriteLine("El elemento " + vector1[i] + " en la posición " + i + " es igual en ambos vectores.");
            //    }
            //}


            //3. Escribir un algoritmo que permita: 
            //a.Llenar un vector[20] con números enteros(positivos o negativos) ingresados por el
            //usuario o generados aleatoriamente.
            //b.Calcular y mostrar el promedio aritmético de todos los elementos almacenados en
            //el vector.
            //c.Recorrer nuevamente el vector para contar e indicar cuántos números son
            //mayores que el promedio y cuántos son menores que este. 
            //d.Mostrar en pantalla el vector completo junto con los resultados obtenidos.



            //int[] vector = new int[20];
            //int suma = 0;
            //double promedio = 0;
            //int contadorMayor = 0;
            //int contadorMenor = 0;

            //Console.WriteLine("Desea ingresar los números manualmente? (s/n)");
            //string respuesta = Console.ReadLine();

            //if (respuesta.ToLower() == "s")
            //{
            //    for (int i = 0; i < 20; i++)
            //    {
            //        Console.Write("Ingrese el número {0}: ", (i + 1));
            //        vector[i] = int.Parse(Console.ReadLine());
            //        suma += vector[i];
            //    }
            //}
            //else
            //{
            //    Random random = new Random();
            //    for (int i = 0; i < 20; i++)
            //    {
            //        vector[i] = random.Next(-100, 101);
            //        suma += vector[i];  
            //    }
            //}

            //promedio = suma / 20;

            //for (int i = 0; i < 20; i++)
            //{
            //    if (vector[i] > promedio)
            //    {
            //        contadorMayor++;
            //    }
            //    else if (vector[i] < promedio)
            //    {
            //        contadorMenor++;
            //    }
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Elemento {0}: {1}", (i + 1), vector[i]);
            //}

            //Console.WriteLine("Promedio: {0}", promedio);
            //Console.WriteLine("Elementos mayores que el promedio: {0}", contadorMayor);
            //Console.WriteLine("Elementos menores que el promedio: {0}", contadorMenor);


            //Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el 
            //orden de los elementos del vector. Se deben mostrar lo dos vectores. 

            //int tamaño = 0;

            //Console.WriteLine("De que tamaño desea el vector?");
            //tamaño = int.Parse(Console.ReadLine());

            //String[] caracteres = new string[tamaño];
            //String[] caracteresInvertidos = new string[tamaño];


            //for (int i = 0; i < tamaño; i++)
            //{
            //    Console.Write("Ingrese el caracter {0}: ", (i + 1));
            //    caracteres[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < tamaño; i++)
            //{
            //    caracteresInvertidos[i] = caracteres[tamaño -1 - i];
            //}

            //Console.WriteLine("Vector original:");
            //for(int i = 0; i < tamaño; i++)
            //{
            //    Console.Write("Caracter {0}: {1}", (i + 1), caracteres[i] + "  |  ");
            //}

            //Console.WriteLine("\nVector invertido:");
            //for (int i = 0; i < tamaño; i++)
            //{
            //    Console.Write("Caracter {0}: {1}", (i + 1), caracteresInvertidos[i] + "  |  ");
            //}


            //Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre 
            //0 y 50.Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el
            //número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el
            //vector resaltando el número en un color diferente.Si no se encuentra el número, se debe
            //devolver y mostrar - 1.


            int[] vector = new int[20];
            int numeroBuscado = 0;

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                vector[i] = random.Next(0, 51);
            }

            Console.WriteLine("Que numero estas buscando?");
            numeroBuscado = int.Parse(Console.ReadLine());


            for (int i = 0; i < 20; i++) 
            {
                if (vector[i] != numeroBuscado)
                {
                    Console.WriteLine("El numero en la poscicion {0}", (i+1) + " es: " + vector[i]);
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El numero en la poscicion {0}", (i+1) + " es: " + vector[i]);
                    Console.ResetColor();
                }
            }

            //6.Escribir un algoritmo que permita: 
//            a.Crear un vector con rango impar, exceptuando el 1.
//            b.Pedirle al usuario un número entero y almacenarlo en la mitad del vector. 
//c.Llenar la primera mitad del vector, con los números menores al número almacenado
//en la posición de la mitad. 
//d.Llenar la parte inicial del vector, con los números menores al número almacenado
//en la posición de la mitad. 
//e.Llenar la parte final del vector, con los números mayores al número almacenado en
//la posición de la mitad. 
//f.Mostrar el vector en pantalla.




        }
    }
}
