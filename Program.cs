using System;
using System.Collections.Generic;
using estaciones.Models;
using estaciones.Services;

namespace estaciones
{
    /*
     * V 1.0
     * El enfoque abordado es demasiado complejo para la simplicidad de lo que se pide.
     * A pesar de la complejidad no es perfecto ni sigue buenas practicas
     * Aun asi lo realice de esta manera para practicar mas en profundidad el manejo de C#
     * 
     * Estructura:
     * Ya que se trabajara con fechas, defini dicho modelo de la manera mas abstracta posible (sin recurrir a clases abstractas)
     * ############################################################
     * Modelo Fecha:
     *  atributos:
     *   dia
     *   mes
     *   anio
     *  metodos:
     *   ValidarFecha
     *   EsAnioBisiesto
     * ############################################################
     * FechaServicio
     *  metodos:
     *      IngresarFecha() maneja el menu de ingreso de fechas y las valida con el metodo ValidarFecha.
     *      DefinirEstacion() tomando la fecha retornada por IngresarFecha y un caracter representando el hemisferio, 
     *      retorna un string con la estacion correspondiente.
     * ############################################################
     * Program
     *  metodos:
     *      main()
     *      MostrarEstacion() recibe un string con la estacion y lo imprime en pantalla
     * ############################################################
     * Menu
     *  Simplemente un menu reutilizable al que le paso una lista de opciones, valida que la entrada sea correcta
     *  y retorna el valor selecionado o 0 si se desea salir.
     * ############################################################  
     * Mejoras
     *  Crear la clase estaciones heredada de fecha, agregarle ahi los metodos de FechaServices y el metodo MostrarEstacion.
     *  Al retirar la funcion mostrarEstaciones de Program, habilitaria a sea mas reutilizable esta clase,
     *  El metodo MostrarEstacion, si bien es un simple Console.WriteLine, me permite modificar la forma en la que se muestra la informacion.
     *  Mejorar la consistencia de nombre de variables y metodos.
     *  
     */
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            List<string> opciones = new List<string>
            {
                "Hemisferio Norte",
                "Hemisferio Sur",
            };
            string titulo = "Bienvenido al programa de estaciones.";
            Menu menuPrincipal = new Menu(titulo,opciones);
            int opcion;
            do{
                
                opcion = menuPrincipal.Mostrar();
                Fecha fechaNueva;
                string estacion;
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Hemisferio Norte");
                        fechaNueva = FechaSerivices.IngresarFecha();
                        estacion = FechaSerivices.DefinirEstacion(fechaNueva, 'N');
                        MostrarEstacion(estacion);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Hemisferio Sur");
                        fechaNueva = FechaSerivices.IngresarFecha();
                        estacion = FechaSerivices.DefinirEstacion(fechaNueva, 'S');
                        MostrarEstacion(estacion);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }
        private static void MostrarEstacion(string estacion)
        {
            Console.WriteLine("La estacion es: "+estacion);
        }

    }
}
