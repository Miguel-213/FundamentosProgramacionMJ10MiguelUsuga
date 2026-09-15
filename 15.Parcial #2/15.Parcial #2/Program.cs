using System;

namespace _15.Parcial__2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------Parcial #2---------------

            /* 
            Doña Ana, la tendera del barrio, necesita un programa para calcular el valor total de una venta que consta de 10 productos. El programa debe aplicar un porcentaje de IVA a cada producto según su valor base ingresado, siguiendo estrictamente estas reglas:
            Estructura Repetitiva: Utiliza un ciclo para procesar exactamente los 10 productos de la venta.
            Ingreso y Reglas de IVA: Por cada producto, solicita su valor base por teclado y aplica el impuesto correspondiente:
            Si el valor del producto es mayor a 10.000, se le aplica un 15% de IVA.
            Si el valor del producto está entre 5.000 y 10.000 (inclusive), se le aplica un 17% de IVA (Nota: condición ajustada para cubrir todo el rango).
            Si el valor del producto es menor de 5.000, se le aplica un 19% de IVA.
            Cálculos por iteración: Para cada producto, calcula su subtotal (valor base + valor del IVA correspondiente) y muéstralo en pantalla junto con el IVA aplicado.
            Acumulación y Cierre: A medida que avanza el ciclo, acumula los subtotales de los 10 productos. Al finalizar las 10 iteraciones, muestra en pantalla el valor total de la venta.
             */

            double precioProducto = 0;
            double precioTotal = 0;


            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Cual es el valor del producto {0}:", i + 1);
                precioProducto = double.Parse(Console.ReadLine());

                if (precioProducto >= 10000)
                {
                    precioProducto = precioProducto + (precioProducto * 0.15);
                    Console.WriteLine("El precio del producto es " + precioProducto + "Y el iva aplicado es el 15%");
                }
                else if (precioProducto >= 5000 && precioProducto <= 10000)
                {
                    precioProducto = precioProducto + (precioProducto * 0.17);
                    Console.WriteLine("El precio del producto es " + precioProducto + "Y el iva aplicado es el 17%");
                }
                else if (precioProducto < 5000)
                {
                    precioProducto = precioProducto + (precioProducto * 0.19);
                    Console.WriteLine("El precio del producto es " + precioProducto + "Y el iva aplicado es el 19%");
                }

                precioTotal += precioProducto;
            }

            Console.WriteLine("El precio total de la venta es: " + precioTotal);
        }
    }
}