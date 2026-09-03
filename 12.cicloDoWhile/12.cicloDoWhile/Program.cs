using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.cicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1: Hacer un programa que permita ingresar el nombre, numero de cuenta y saldo de un usuario, si el saldo es mayor o igual a 3.000.000 mostrar un mensaje indicando que es apto para el credito, si no lo es mostrar un mensaje indicando que no es apto para el credito. Al final del programa mostrar la cantidad de usuarios ingresados y el saldo promedio de todos los usuarios.

            //String nombre = "";
            //String numeroCuenta = "";
            //int saldo = 0;
            //int totalUsuarios = 0;
            //int saldoTotal = 0;

            //do{
            //    Console.WriteLine("Ingrese el nombre del usuario:");
            //    nombre = Console.ReadLine();

            //    Console.WriteLine("Ingresa el numero de cuenta del usuario: ");
            //    numeroCuenta = Console.ReadLine();

            //    Console.WriteLine("Ingrese el saldo del usuario: ");
            //    saldo = int.Parse(Console.ReadLine());


            //    if (saldo >= 3000000)
            //    {
            //        Console.WriteLine(nombre + " con numero de cuenta " + numeroCuenta + " Y salario:" + saldo + " Es apto para el credito");
            //    }
            //    else 
            //    {
            //        Console.WriteLine(nombre + " con numero de cuenta " + numeroCuenta + " Y salario:" + saldo + " No es apto para el credito"); 
            //    }

            //    Console.WriteLine("Desea ingresar otro usuario? (s/n)");
            //    totalUsuarios++;
            //    saldoTotal += saldo;


            //    string respuesta = Console.ReadLine();
            //    if (respuesta != "s" && respuesta != "S")
            //    {
            //        saldoTotal = saldoTotal/ totalUsuarios;

            //        Console.WriteLine("La cantidad de usuarios es: " + totalUsuarios);
            //        Console.WriteLine("El saldo promedio es: " + saldoTotal);
            //        break;
            //    }
            //} while (true);



            //Crear un algoritmo que:
            //-Permita al usuario ingresar una contraseña
            //-Se repita hasta que ingrese la contraseña correcta(por ejemplo 1234)
            //-Mostrar cuantos intentos realizo

            int contraseña = 0;
            int intentos = 0;
            int intentoAdivinarContraseña = 0;




            Console.WriteLine("Ingrese la contraseña:");
            contraseña = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese la contraseña:");
                intentoAdivinarContraseña = int.Parse(Console.ReadLine());

                intentos++;

                if (intentoAdivinarContraseña == contraseña)
                {
                    Console.WriteLine("Contraseña correcta");
                    Console.WriteLine("Intentos realizados: " + intentos);
                    break;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                }
            } while (true);






        }
    }
}
