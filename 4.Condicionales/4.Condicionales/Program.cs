using System;

namespace _4.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de control ondicional

            //1. Cree un programa que solicite al usuario su edad y en caso de que el usuario sea mayor de edad, muestre el mensaje "Bienvenido a mi sitio web"


            //byte edad = 0;

            //do
            //{

            //    Console.WriteLine("ingresa tu edad");
            //    edad = Convert.ToByte(Console.ReadLine());

            //    if (edad < 0 || edad > 150)
            //    {
            //        Console.WriteLine("edad no válida. por favor, ingresa una edad real");
            //    }

            //    else if (edad >= 18)
            //    {
            //        Console.WriteLine ("bienvenido a mi sitio web");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("No es apto para el contenido de este sitio");
            //        break;
            //    }

            //} while (true);



            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona indicando que debe abonar impuestos, de lo contrario mostrar el mensaje ¨Persona excenta de impuestos¨.


            //String nombre = "";
            //float sueldo = 0;

            //Console.WriteLine("Ingresa tu nombre:");
            //nombre = Console.ReadLine();

            //Console.WriteLine("Ingresa tu sueldo:");
            //sueldo = float.Parse(Console.ReadLine());

            //if (sueldo > 3000)
            //{
            //    Console.WriteLine(nombre + " debes abonar impuestos.");
            //}
            //else
            //{
            //    Console.WriteLine("persona excenta de impuestos");
            //}


            //Crear un algoritmo que permita ingresar 2 numeros, si el primer numero es mayor al segundo numero, informar su suma y diferencia, en caso contrario informar el producto y ka division del primer numero con el segundo numero.


            Console.WriteLine("Ingresa el primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("La suma es: " + (num1 + num2));
                Console.WriteLine("La diferencia es: " + (num1 - num2));
            }
            else if (num2 > num1)
            {

                Console.WriteLine("El producto es: " + (num1 * num2));
                Console.WriteLine("La división es: " + (double)num1 / num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Los números son iguales.");
            }

        }
    }
}
