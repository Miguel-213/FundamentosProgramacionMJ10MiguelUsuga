using System;

namespace _7.parcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Un conjunto de personas debe ser clasificado en uno de cuatro grupos: A, B, C o D, de acuerdo con diferentes características de la persona.
            La clasificación se realizará teniendo en cuenta el sexo, la edad, el último dígito del documento de identidad y, únicamente en un caso específico, el dominio del idioma inglés.
            Reglas de clasificación
            Grupo A
            Una persona pertenece al grupo A si cumple alguna de las siguientes condiciones:
            Es mujer, tiene entre 16 y 20 años, inclusive, y el último dígito de su documento de identidad es 0, 4 u 8.
            Es hombre, tiene entre 18 y 22 años, inclusive, y el último dígito de su documento de identidad es 1, 5 o 9.
            Grupo B
            Una persona pertenece al grupo B si cumple alguna de las siguientes condiciones:
            Es mujer, tiene entre 21 y 25 años, inclusive, y el último dígito de su documento de identidad es 3 o 7.
            Es hombre, tiene entre 23 y 26 años, inclusive, y el último dígito de su documento de identidad es 2 o 6.
            Grupo C
            Una persona pertenece al grupo C si:
            Tiene exactamente 15 años, y
            Domina el idioma inglés.
            Importante: el programa solo debe solicitar información sobre el dominio del idioma inglés cuando la persona    tenga      exactamente 15 años. Para las personas de cualquier otra edad, esta información no debe ser     solicitada.
            Grupo D
            Una persona pertenece al grupo D cuando no cumple ninguna de las condiciones establecidas para los grupos A, B o C.
            Los grupos son excluyentes, por lo que cada persona debe ser clasificada en un único grupo.
            Objetivo
            Desarrolle un programa en C# que:
            Solicite el sexo de la persona (masculino o femenino).
            Solicite la edad, como un número entero positivo.
            Solicite el último dígito del documento de identidad, que debe ser un número entre 0 y 9.
            Si la persona tiene 15 años, solicite además si domina el idioma inglés (sí o no).
            Analice la información ingresada y determine el grupo al que pertenece la persona.
            Muestre en pantalla el grupo correspondiente: A, B, C o D.
            Nota: El programa debe utilizar adecuadamente estructuras condicionales para tomar las decisiones necesarias y debe evitar solicitar información que no sea necesaria para determinar la clasificación.
             */

            String nombre = "";
            int sexo = 0;
            int edad = 0;
            int ultimoDigitoDocumento = 0;
            bool dominaIngles = false;

            Console.WriteLine("Ingresa tu sexo\n -Masculino  (1) \n -Femenino  (2)");
            sexo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad");
            edad = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingresa el ultimo digito de tu documento de identidad");
            ultimoDigitoDocumento = int.Parse(Console.ReadLine());



            if ((sexo == 2 && edad >= 16 && edad <= 20 && (ultimoDigitoDocumento == 0 || ultimoDigitoDocumento == 4 || ultimoDigitoDocumento == 8)) || (sexo == 1 && edad >= 18 && edad <= 22 && (ultimoDigitoDocumento == 1 || ultimoDigitoDocumento == 5 || ultimoDigitoDocumento == 9)))
            {
                Console.WriteLine("Esta persona corresponde al grupo A");
            }
            else if ((sexo == 2 && edad >= 21 && edad <= 25 && (ultimoDigitoDocumento == 3 || ultimoDigitoDocumento == 7)) || (sexo == 1 && edad >= 23 && edad <= 26 && (ultimoDigitoDocumento == 2 || ultimoDigitoDocumento == 6)))
            {
                Console.WriteLine("Esta persona corresponde al grupo B");
            }
            else if (edad == 15)
            {
                Console.WriteLine("Dominas el idioma ingles?\n -si  (1) \n -no  (2)");
                int respuesta = int.Parse(Console.ReadLine());
                dominaIngles = (respuesta == 1);

                if (dominaIngles) { Console.WriteLine("Esta persona corresponde al grupo C"); }
            }
            else
            {
                Console.WriteLine("Esta persona corresponde al grupo D");
            }













        }
    }
}
