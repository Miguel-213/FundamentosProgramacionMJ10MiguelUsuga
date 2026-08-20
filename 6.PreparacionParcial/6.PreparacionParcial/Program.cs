using System;
using System.Threading.Tasks;


namespace _6.PreparacionParcial
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //--------------------------------------PUNTO #1-------------------------------------
            //crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            //numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            //diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            //pantalla los números de menor a mayor.
            //Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            //ingresar números diferentes.

            // int numero1 = 0;
            // int numero2 = 0;
            // int numero3 = 0;
            // String numerosOrdenados = null;

            // do
            // {
            //     Console.WriteLine("Ingrese el primer número: ");
            //     numero1 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Ingrese el segundo número: ");
            //     numero2 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Ingrese el tercer número: ");
            //     numero3 = Convert.ToInt32(Console.ReadLine());
            //     if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            //     {
            //         Console.WriteLine("Los números son diferentes. Por favor, ingrese nuevamente.");
            //     }
            //     else
            //     {
            //         if (numero1 > numero2 && numero1 > numero3)
            //         {
            //             Console.WriteLine("El número mayor es: " + numero1);
            //             if (numero2 > numero3)
            //             {
            //                 numerosOrdenados = numero1 + ", " + numero2 + ", " + numero3;
            //             }
            //             else
            //             {
            //                 numerosOrdenados = numero1 + ", " + numero3 + ", " + numero2;
            //             }
            //         }
            //         else if (numero2 > numero1 && numero2 > numero3)
            //         {
            //             Console.WriteLine("El número mayor es: " + numero2);
            //             if (numero1 > numero3)
            //             {
            //                 numerosOrdenados = numero2 + ", " + numero1 + ", " + numero3;
            //             }
            //             else
            //             {
            //                 numerosOrdenados = numero2 + ", " + numero3 + ", " + numero1;
            //             }
            //         }
            //         else
            //         {
            //             Console.WriteLine("El número mayor es: " + numero3);
            //             if (numero1 > numero2)
            //             {
            //                 numerosOrdenados = numero3 + ", " + numero1 + ", " + numero2;
            //             }
            //             else
            //             {
            //                 numerosOrdenados = numero3 + ", " + numero2 + ", " + numero1;
            //             }
            //         }
            //         Console.WriteLine("Los números ordenados de menor a mayor son: " + numerosOrdenados);
            //     }

            // } while (numero1 == numero2 || numero1 == numero3 || numero2 == numero3);

            




            //--------------------------------------PUNTO #2-------------------------------------

            //El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
            //cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
            //a.Permita ingresar por teclado si el personaje está en estado invencible(True).
            //b.La cantidad de munición que tiene el personaje en el momento será calculada por el
            //sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#
            //c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y
            //10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
            //no hacer nada.

            //Random rnd = new Random();
            //bool estadoInvencible = false;

            //Console.WriteLine("¿Está el personaje en estado invencible? (true/false): ");
            //estadoInvencible = Convert.ToBoolean(Console.ReadLine());

            //int cantidadMunicion = rnd.Next(0, 51);
            //Console.WriteLine("Municion: " + cantidadMunicion);

            //if (estadoInvencible && cantidadMunicion >= 1 && cantidadMunicion <= 10) {

            //    Console.WriteLine("El personaje esta disparando");

            //}








            //--------------------------------------PUNTO #3-------------------------------------

            //Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1,y1), 
            //P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1
            //P3.La distancia entre dos puntos está dada por la siguiente formula:
            // d = √((x2 - x1)² +(y2 - y1)²) 
            //Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
            //dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
            //cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las
            //condiciones no se cumplen.

            //int x1, y1, x2, y2, x3, y3;

            //Console.WriteLine("ingrese la coordenada x1:");
            //x1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese la coordenada y1:");
            //y1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese la coordenada x2:");
            //x2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese la coordenada y2:");
            //y2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese la coordenada x3:");
            //x3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese la coordenada y3:");
            //y3 = Convert.ToInt32(Console.ReadLine());

            //double distancia1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            //double distancia2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            //double distancia3 = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));

            //if (distancia1 != 0 && distancia2 != 0 && distancia3 != 0)
            //{
            //    if (distancia1 + distancia2 > distancia3 && distancia1 + distancia3 > distancia2 && distancia2 + distancia3 > distancia1)
            //    {
            //        Console.WriteLine("Se puede construir un triangulo");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se puede construir un triangulo pues no cumple la propiedad de la desigualdad triangular");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No se puede construir un triangulo pues hay 2 o maspuntos en la misma posicion");
            //}


            //--------------------------------------PUNTO #4-------------------------------------

            //El personaje de un juego, solo se puede mover en forma horizontal (Izquierda o Derecha), 
            //crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
            //hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
            // Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
            //derecha
            // Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la izquierda
            // En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
            //dirección

            //do
            //{
            //    ConsoleKeyInfo tecla = Console.ReadKey();

            //    if (tecla.Key == ConsoleKey.D)
            //    {
            //        Console.WriteLine("\nEl personaje se mueve a la derecha.");
            //    }
            //    else if (tecla.Key == ConsoleKey.I)
            //    {
            //        Console.WriteLine("\nEl personaje se mueve a la izquierda.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nNo me puedo mover en otra dirección.");
            //    }

            //} while(true);




            //--------------------------------------PUNTO #5-------------------------------------

            //El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
            //el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
            // Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje. 
            //(Función Random)
            // Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego.En
            //caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
            //ninguna acción”. 
            // Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
            //carácter que se ingrese: 
            //o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando” 
            //o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana” 
            //o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo” 
            //o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible” 


            //Random rnd = new Random();
            //int vidas = rnd.Next(0, 6);

            //if (vidas > 0)
            //{
            //    Console.WriteLine(vidas);
            //    Console.WriteLine("que accion desea realizar?\n 1. Disparar (presiona 'c')\n 2. Hablar con la Rana (presiona 'x')\n 3. Modo Turbo (presiona 't')\n 4. Invencible (presiona 'i')");

            //    ConsoleKeyInfo teclaPresionada = Console.ReadKey();
            //    switch(teclaPresionada.Key)
            //    {
            //        case ConsoleKey.C:
            //            Console.WriteLine("el personaje está disparando");
            //            break;
            //        case ConsoleKey.X:
            //            Console.WriteLine("el personaje está hablando con la Rana");
            //            break;
            //        case ConsoleKey.T:
            //            Console.WriteLine("el personaje está en modo Turbo");
            //            break;
            //        case ConsoleKey.I:
            //            Console.WriteLine("el personaje es Invencible");
            //            break;
            //        default:
            //            Console.WriteLine("Acción no válida");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción");
            //}



            //--------------------------------------PUNTO #6-------------------------------------

            //Realizar la prueba de escritorio para el siguiente algoritmo, según los casos propuestos a 
            //continuación.
            //Caso1: finalProm > 0
            //Caso2: finalProm = 20
            //Caso3: finalProm = 15
            //Caso4: finalProm <= 0

            //double finalProm;
            //string state = "Error";

            //Console.Write("Ingrese el promedio final del alumno: ");
            //finalProm = double.Parse(Console.ReadLine());

            //if (finalProm >= 0)
            //{
            //    if (finalProm <= 5)
            //    {
            //        state = "Desaprobado";
            //    }
            //    else
            //    {
            //        if (finalProm <= 10)
            //        {
            //            state = "Vacacional";
            //        }
            //        else
            //        {
            //            if (finalProm <= 15)
            //            {
            //                state = "Requiere mejorar";
            //            }
            //            else
            //            {
            //                if (finalProm <= 20)
            //                {
            //                    state = "Supera las expectativas";
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Ingrese un promedio correcto.");
            //                }
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ingrese un promedio correcto.");
            //}

            //Console.WriteLine("El estado del alumno es: " + state);

            //-------------------------PRUEBAS DE ESCRITORIO----------------------------------------
            /*

            |Instrucciones|valor ingresado|state|Resultado esperado|resultado obtenido|
            ---------------------------------------------------------------------------
            |finalProm > 0|        8      |true |       |Vacacional        |
            |finalProm<=5 |        8      |false|
            |finalProm<=10|        8      |true |
            |finalProm<=15|        8      |true |
            |finalProm<=20|        8      |true |


            */
        }
    }
}