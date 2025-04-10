using System;
using estaciones.Models;

namespace estaciones.Services
{
    class FechaSerivices
    {
        public static Fecha IngresarFecha()
        {
            Fecha nuevaFecha = new Fecha();
            bool fechaValida = false;

            do
            {
                try
                {
                    Console.WriteLine("Ingrese el día:");
                    int dia = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el mes:");
                    int mes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el año:");
                    int anio = int.Parse(Console.ReadLine());

                    nuevaFecha = new Fecha(dia, mes, anio);

                    if (nuevaFecha.ValidarFecha())
                    {
                        fechaValida = true;
                        Console.WriteLine("Fecha válida ingresada: {0}/{1}/{2}", nuevaFecha.Dia, nuevaFecha.Mes, nuevaFecha.Anio);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("La fecha ingresada no es válida. Por favor, intente nuevamente.");
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Entrada no válida. Por favor, ingrese valores numéricos.");
                }
            } while (!fechaValida);
            return nuevaFecha;
        }

        public static string DefinirEstacion(Fecha fechaValida,char hemisferio)
        {
            int dia = fechaValida.Dia;
            int mes = fechaValida.Mes;
            string estacion;
            if (hemisferio == 'N') 
            {

                if ((mes == 3 && dia >= 21) || mes == 4 || mes == 5 || (mes == 6 && dia <= 20))
                    estacion = "Primavera";
                else if ((mes == 6 && dia >= 21) || mes == 7 || mes == 8 || (mes == 9 && dia <= 22))
                    estacion = "Verano";
                else if ((mes == 9 && dia >= 23) || mes == 10 || mes == 11 || (mes == 12 && dia <= 20))
                    estacion = "Otoño";
                else
                    estacion = "Invierno";
            }
            else
            {

                if ((mes == 3 && dia >= 21) || mes == 4 || mes == 5 || (mes == 6 && dia <= 20))
                    estacion = "Otoño";
                else if ((mes == 6 && dia >= 21) || mes == 7 || mes == 8 || (mes == 9 && dia <= 22))
                    estacion = "Invierno";
                else if ((mes == 9 && dia >= 23) || mes == 10 || mes == 11 || (mes == 12 && dia <= 20))
                    estacion = "Primavera";
                else
                    estacion = "Verano";
            }
            return estacion;
        }
    }
}