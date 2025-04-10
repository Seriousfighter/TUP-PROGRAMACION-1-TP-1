using System;
using System.Collections.Generic;


namespace estaciones.Services
{
    class Menu
    {
        private readonly List<string> opciones;
        private readonly string titulo;
        public Menu(string titulo,List<string> opciones)
        {
            this.opciones = opciones ?? new List<string>();
            this.titulo = titulo;
        }

        public int Mostrar()
        {
            int opcion = -1;
            bool opcionValida = false;

            while (!opcionValida)
            {
                Console.Clear();
                Console.WriteLine(this.titulo);
                // Mostrar opciones
                for (int i = 0; i < opciones.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {opciones[i]}");
                }
                Console.WriteLine("0 - Salir");
                Console.WriteLine("Seleccione una opción, 1 a {0}:", opciones.Count);

                // Leer y validar la entrada del usuario
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out opcion))
                {
                    if (opcion >= 0 && opcion <= opciones.Count)
                    {
                        opcionValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese una opción válida \nPresione una tecla para continuar.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Por favor ingrese una opción válida \nPresione una tecla para continuar.");
                    Console.ReadKey();
                }
            }

            return opcion;
        }
    }
}
