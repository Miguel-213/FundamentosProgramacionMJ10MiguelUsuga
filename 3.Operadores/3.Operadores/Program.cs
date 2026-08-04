using System;
using System.Security.Cryptography;


namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Orden de evaluacion operadores numericos
            float dato1 = 4 * 3 / 2;
            float dato2 = 4f / 3 * 2;
            float dato3 = 4f * (2f / 3);
            float dato4 = 4 + 6 * 3;
            float dato5 = 4 + 6 * (2 - 1);
            Console.WriteLine(dato3);

            //Operadores logicos
            //Conjuncion - And - Y - &&
            Console.WriteLine("Tabla conjuncion");
            Console.WriteLine("V && V = " +(true && true));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("_-------------------------_");

            //Disyuncion - OR - O - ||
            Console.WriteLine("Tabla disyuncion");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("_-------------------------_");

            //Operadores de comparacion
            bool dato6 = 5 > 4;
            bool dato7 = 100 == 99;
            bool dato8 = 1002 != 102;
            bool dato9 = 10 >= 10;
            bool dato10 = 12 < 11 && 0 == 1;
            bool dato11 = dato8 && 0 != 10 || dato8;

            //Operador logico de negacion - !
            bool datox = true;
            bool datoy = !(datox);
        }
    }
}
