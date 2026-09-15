using Microsoft.Win32;
using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;


namespace _14.TallerCiclos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //----------------------Punto 1--------------------------
            //Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
            //le permitirá al usuario, introducir tantas calificaciones como así desee,
            //en el momento en que seleccione que no desea continuar capturando
            //calificaciones, el algoritmo debe presentar el promedio de las
            //calificaciones capturadas previamente.

            //double calificacion = 0;
            //double suma = 0;
            //int cantidadNotas = 0;
            //double promedio = 0;
            //String respuesta = "";

            //do 
            //{
            //    Console.WriteLine("Ingrese la calificación ");
            //    calificacion = double.Parse(Console.ReadLine());

            //    suma += calificacion;

            //    cantidadNotas++;

            //    Console.WriteLine("Desea ingresar otra calificación? (s/n)");
            //    respuesta = Console.ReadLine();

            //    if (respuesta.ToLower() != "s")
            //    {
            //        break;
            //    }

            //}
            //while (true);


            //----------------------Punto 2--------------------------
            //Se requiere un algoritmo para mostrar por pantalla los divisores de un
            //número ingresado por teclado.
            //Tener en cuenta que dados dos números enteros a y b, se dice que b es
            //divisor de a si se cumple que al efectuar una división entera a/ b el
            //residuo es 0, en C# utilizar el operador Mod para obtener el residuo de
            //una división de dos números.
            //Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3,
            //2, 1 que son los divisores del número 6.


            //int numero = 0;
            //String respuesta = "";


            //do { 

            //Console.WriteLine("Ingrese un número:");
            //numero = int.Parse(Console.ReadLine());

            //Console.WriteLine("Los divisores de {0} son:");
            //for (int i = numero; i > 0; i--)
            //{
            //    if (numero % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //    Console.WriteLine("Desea ingresar otro numero? (s/n)");
            //    respuesta = Console.ReadLine();

            //    if (respuesta.ToLower() != "s")
            //    {
            //        break;
            //    }

            //} while (numero <= 0);

            //----------------------Punto 3--------------------------
            //Dados dos números enteros ingresados por teclado: b que es la base y
            //e que es el exponente, se requiere calcular el resultado de la
            //potenciación.
            //Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
            //Mostrar por pantalla el resultado de la potenciación.
            //Seguir pidiendo por teclado la base y el exponente y realizar la
            //potenciación correspondiente, hasta que el usuario ingrese por teclado
            //el carácter de escape ‘n’


            //int NumeroBase = 0;
            //int exponente = 0;
            //String respuesta = "";

            //do 
            //{
            //    Console.WriteLine("Ingrese la base:");
            //    NumeroBase = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Ingrese el exponente:");
            //    exponente = int.Parse(Console.ReadLine());

            //    Console.WriteLine("El resultado es " + Math.Pow(NumeroBase, exponente));

            //    Console.WriteLine("Desea ingresar otro numero? (s/n)");
            //    respuesta = Console.ReadLine();

            //    if (respuesta.ToLower() != "s")
            //    {
            //        break;
            //    }


            //}
            //while (true);


            //----------------------Punto 4--------------------------
            //Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
            //kilómetros durante 10 días, para determinar si es apto para la prueba de
            //5 kilómetros.Para considerarlo apto debe cumplir las siguientes
            //condiciones:
            // Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
            // Que al menos en una de las pruebas realice un tiempo menor de 15
            //minutos.
            // Que su promedio sea menor o igual a 18 minutos.
            //Diseñar un algoritmo para registrar los datos y decidir si es apto para la
            //competencia.


            //int tiempo = 0;
            //int Condicion1 = 0;
            //int suma = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Ingrese el tiempo para el día {0}:", i);
            //    tiempo = int.Parse(Console.ReadLine());

            //    if (tiempo > 20)
            //    {
            //        Console.WriteLine("El atleta no es apto para la competencia.");
            //        break;
            //    }
            //    if (tiempo < 15)
            //    {
            //        Condicion1 = 1;
            //    }

            //    suma += tiempo;
            //}

            //if (Condicion1 == 1 && (suma / 10.0) <= 18)
            //{
            //    Console.WriteLine("El atleta es apto para la competencia.");
            //}
            //else
            //{
            //    Console.WriteLine("El atleta no es apto para la competencia.");
            //}


            //----------------------Punto 5--------------------------

            //Se aplicó una encuesta a n personas solicitando su opinión sobre el
            //tema del servicio militar obligatorio para las mujeres. Las opciones de
            //respuesta fueron: a favor, en contra y no responde. Se solicita un
            //algoritmo que calcule qué porcentaje de los encuestados marcó cada
            //una de las respuestas.

            //int cantidadPersonas = 0;
            //int opcion = 0;
            //int aFavor = 0;
            //int enContra = 0;
            //int noResponde = 0;


            //Console.WriteLine("Cuantas personas participaron en la encuesta?");
            //cantidadPersonas = int.Parse(Console.ReadLine());

            //for (int i = 0; i < cantidadPersonas; i++)
            //{
            //    Console.WriteLine("Seleccione una opcion");
            //    Console.WriteLine("1. A favor");
            //    Console.WriteLine("2. En contra");
            //    Console.WriteLine("3. No responde");
            //    opcion = int.Parse(Console.ReadLine());

            //    if ( opcion == 1 )
            //    {
            //        aFavor++;
            //    }
            //    else if ( opcion == 2 )
            //    {
            //        enContra++;
            //    }
            //    else if ( opcion == 3 )
            //    {
            //        noResponde++;
            //    }


            //}

            //Console.WriteLine("Los porcentajes correspondientes son:");
            //Console.WriteLine("A favor: {0}%", (aFavor / (double)cantidadPersonas) * 100);
            //Console.WriteLine("En contra: {0}%", (enContra / (double)cantidadPersonas) * 100);
            //Console.WriteLine("No responde: {0}%", (noResponde / (double)cantidadPersonas) * 100);



            //----------------------Punto 6--------------------------
            //Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos
            //de esos números son positivos, cuántos negativos, cuántos son neutros
            //(0); además que imprima por pantalla la sumatoria de los números
            //positivos y la de los negativos.


            //int numero = 0;
            //int numerosNegativos = 0;
            //int numerosPositivos = 0;
            //int numerosNeutros = 0;
            //int suma = 0;

            //for (int i = 0; i < 40; i++)
            //{

            //    Console.WriteLine("Ingrese el numero {0}", i+1);
            //    numero = int.Parse(Console.ReadLine());


            //    if (numero < 0)
            //    {
            //        numerosNegativos++;
            //    }
            //    else if (numero > 0)
            //    {
            //        numerosPositivos++;
            //    }
            //    else
            //    {
            //        numerosNeutros++;
            //    }

            //    suma += numero;


            //}

            //Console.WriteLine("Numeros negativos: {0}", numerosNegativos);
            //Console.WriteLine("Numeros positivos: {0}", numerosPositivos);
            //Console.WriteLine("Numeros neutros: {0}", numerosNeutros);
            //Console.WriteLine("Suma de todos los numeros: {0}", suma);


            //----------------------Punto 7--------------------------

            //Una persona desea realizar un muestreo con 70 personas para
            //determinar el promedio de peso de los niños, jóvenes, adultos y viejos
            //que existen en su zona y cuántos son de cada una de las categorías.
            //Las categorías están dadas por la siguiente tabla:

            //int edad = 0;
            //int cantidadNiños = 0;
            //int cantidadJovenes = 0;
            //int cantidadAdultos = 0;
            //int cantidadViejos = 0; 
            //double promPesoNiños = 0;
            //double promPesoJovenes = 0;
            //double promPesoAdultos = 0;
            //double promPesoViejos = 0;

            //for (int i = 0; i < 70; i++) 
            //{
            //    Console.WriteLine("Ingrese la edad de la persona");
            //    edad = int.Parse(Console.ReadLine());

            //    if (edad > 0 && edad <= 13)
            //    {
            //        cantidadNiños++;
            //        Console.WriteLine("Cual es el peso del niño");
            //        promPesoNiños += double.Parse(Console.ReadLine());
            //    }
            //    if (edad >= 14  && edad <= 30)
            //    {
            //        cantidadJovenes++;
            //        Console.WriteLine("Cual es el peso del Joven");
            //        promPesoJovenes += double.Parse(Console.ReadLine());
            //    }
            //    if (edad > 31 && edad <= 60)
            //    {
            //        cantidadAdultos++;
            //        Console.WriteLine("Cual es el peso del Adulto");
            //        promPesoAdultos += double.Parse(Console.ReadLine());
            //    }
            //    if (edad >= 61)
            //    {
            //        cantidadViejos++;
            //        Console.WriteLine("Cual es el peso del Anciano");
            //        promPesoViejos += double.Parse(Console.ReadLine());
            //    }

            //}

            //Console.WriteLine("El promedio de peso en niños fue " + promPesoNiños / cantidadNiños);
            //Console.WriteLine("El promedio de peso en jovenes fue " + promPesoJovenes / cantidadJovenes);
            //Console.WriteLine("El promedio de peso en Adultos fue " + promPesoAdultos / cantidadAdultos);
            //Console.WriteLine("El promedio de peso en Viejos fue " + promPesoViejos / cantidadViejos);

            //Console.WriteLine("Y la cantidad de niños fue de {0}, la de jovenes fue de {1}, la de adultos fue de {2} y la de viejos fue de {3}", cantidadNiños, cantidadJovenes, cantidadAdultos, cantidadViejos);


            //----------------------Punto 8--------------------------

            //El Departamento de Transito de Antioquia. desea saber de los n autos
            //que entran a la ciudad de Medellín, cuántos autos entran con
            //calcomanía de un determinado color.Conociendo el último dígito de la
            //placa de cada automóvil se puede determinar el color de la calcomanía,
            //para determinar lo anterior utilice la siguiente tabla:


            //int cantidadAutosEnMedellin = 0;
            //int ultimoDigito = 0;
            //int cantidadAmarillo = 0;
            //int cantidadRosa = 0;
            //int cantidadRoja = 0;
            //int cantidadVerde = 0;
            //int cantidadAzul = 0;

            //Console.WriteLine("Ingrese la cantidad de autos que entran a Medellín");
            //cantidadAutosEnMedellin = int.Parse(Console.ReadLine());

            //for (int i = 0; i < cantidadAutosEnMedellin; i++)
            //{
            //    Console.WriteLine("Ingrese el último dígito de la placa del auto {0}", i + 1);
            //    ultimoDigito = int.Parse(Console.ReadLine());


            //    if (ultimoDigito == 1 || ultimoDigito == 2)
            //    {
            //        cantidadAmarillo++;
            //    }
            //    else if (ultimoDigito == 3 || ultimoDigito == 4)
            //    {
            //        cantidadRosa++;
            //    }
            //    else if (ultimoDigito == 5 || ultimoDigito == 6)
            //    {
            //        cantidadRoja++;
            //    }
            //    else if (ultimoDigito == 7 || ultimoDigito == 8)
            //    {
            //        cantidadVerde++;
            //    }
            //    else if (ultimoDigito == 9 || ultimoDigito == 0)
            //    {
            //        cantidadAzul++;

            //    }
            //}

            //Console.WriteLine("la cantidad de autos con calcomanía amarilla es: {0}", cantidadAmarillo);
            //Console.WriteLine("la cantidad de autos con calcomanía rosa es: {0}", cantidadRosa);
            //Console.WriteLine("la cantidad de autos con calcomanía roja es: {0}", cantidadRoja);
            //Console.WriteLine("la cantidad de autos con calcomanía verde es: {0}", cantidadVerde);
            //Console.WriteLine("la cantidad de autos con calcomanía azul es: {0}", cantidadAzul);


        }
    }
}
