using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConstanteTiposOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                //Constantes

                const String iva = "19%";
                String nombre = "Miguel";
                nombre = "Pedro";
                //
                //iva = "20%"; Una variable const no puede cambiar el valor

                //Tipos de datos
                byte dato1 = 255; //Enteros
                int dato2 = 256; //Enteros
                ulong dato3 = 1236333; //Enteros
                float dato4 = 5.3f; //Decimales
                double dato5 = 2123.3265d; //Decimales
                char dato6 = ' '; //Un caracter
                String dato7 = "kjdfbaiufhc sdiufhaonisdf"; //Cadena de caracteres
                bool dato8 = false;  //Verdadero o falso
                object dato9 = new object();
                //Operadores
                //Numericos
                //Cambio de signo
                int dato10 = 5;
                int dato11 = -dato10;
                int dato12 = +dato11;
                int dato13 = -dato12;
                Console.WriteLine("dato10: {0}, dato11: {1}, dato12: {2}, dato13 {3} ", dato10, dato11, dato12, dato13);

                //operadores aritmeticos
                int dato14 = 5 + 3; //Suma
                int dato15 = dato14 - 2; //resta
                int dato16 = 10 * 3;
                int dato17 = 5 / 3;
                Console.WriteLine("suma: {0}, resta: {1}, multiplicacion: {2}, division: {3}", dato14, dato15, dato16, dato17);

                //incremento - decremento
                int dato18 = 1;
                dato18++; //Incremento en 1
                dato18-- ; //Decremento en 1
                dato18+= 2 ; //Incremento en 2


            }
        }
    }

}