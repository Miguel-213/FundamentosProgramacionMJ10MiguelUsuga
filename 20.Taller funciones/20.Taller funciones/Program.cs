using System;

namespace _20.Taller_funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------Ejercicio 1--------------------------------------
            /*
             * Desarrolla un programa que permita: 
             Ingresar una palabra 
             LLevar la palabra ingresada a un vector de caracteres 
             Contar la cantidad de vocales y consonantes en la palabra proporcionada por el 
            usuario. 
            */

            //String palabra = "";
            //String opcion = "";

            //do
            //{

            //    Console.WriteLine("Ingrese una palabra: ");

            //    ContarVocalesYConsonantes(palabra);


            //    Console.WriteLine("Desea continuar? (s/n)");
            //    opcion = Console.ReadLine();

            //    if (opcion.ToLower() != "s")
            //    {
            //        break;
            //    }

            //} while (true);


            //------------------------------Ejercicio 2--------------------------------------

            /*Crear un programa que permita gestionar una lista de tareas: 
             Agregar tareas. 
             Eliminar tareas 
             Mostrar la lista de tareas. 
             */

                String opcion = "";
                String[] tareas = new String[0];
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea");
                Console.WriteLine("3. Mostrar tareas");
                Console.WriteLine("4. Salir\n");


                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine();
                        tareas = AgregarTarea(tareas);
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine();
                        tareas = EliminarTarea(tareas);
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        MostrarTareas(tareas);
                        Console.WriteLine();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }


            } while (true);


        }

        //------------------------------Ejercicio 1--------------------------------------
        //static void ContarVocalesYConsonantes(String palabra) 
        //{

        //    int vocales = 0;
        //    int consonantes = 0;
        //    palabra = Console.ReadLine();

        //    char[] vector = new char[palabra.Length];



        //    for(int i = 0; i < palabra.Length; i++)
        //    {
        //        char letra = palabra[i];

        //        if(letra.ToString().ToLower() == "a" || letra.ToString().ToLower() == "e" || letra.ToString().ToLower() == "i" || letra.ToString().ToLower() == "o" || letra.ToString().ToLower() == "u")
        //        {
        //            vocales++;
        //        }
        //        else
        //        {
        //            consonantes++;
        //        }
        //    }
        //    Console.WriteLine($"La palabra '{palabra}' tiene {vocales} vocales y {consonantes} consonantes.");

        //}


        //------------------------------Ejercicio 2--------------------------------------


        static String[] AgregarTarea(String[] listaActual)
        {
            Array.Resize(ref listaActual, listaActual.Length + 1);


            Console.WriteLine("Ingrese la nueva tarea:");
            listaActual[listaActual.Length - 1] = Console.ReadLine();

            return listaActual;
        }

        static String[] EliminarTarea(String[] listaActual)
        {
            MostrarTareas(listaActual);
            Console.WriteLine("\nIngrese el numero de la tarea a eliminar:");
            int tareaABorrar = Convert.ToInt32(Console.ReadLine()) - 1;
            if (tareaABorrar >= 0 && tareaABorrar < listaActual.Length)
            {
                for (int i = tareaABorrar; i < listaActual.Length - 1; i++)
                {
                    listaActual[i] = listaActual[i + 1];
                }
                Array.Resize(ref listaActual, listaActual.Length - 1);
            }
            else
            {
                Console.WriteLine("Indice no valido.");
            }
            return listaActual;
        }


        static void MostrarTareas(String[] tareas)
        {
            Console.WriteLine("Lista de tareas:");
            for (int i = 0; i < tareas.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }


    }
}
