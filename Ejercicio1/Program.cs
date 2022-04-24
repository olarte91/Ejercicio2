using System;
using Ejercicio1.Clases;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tarifaBasica = Convert.ToInt32(Console.ReadLine());
            string aerolinea = Console.ReadLine();
            string temporada = Console.ReadLine();
            string nombre = Console.ReadLine();
            int edad = Convert.ToInt32(Console.ReadLine());
            string esEstudiante = Console.ReadLine();

            CompaniaDeVuelo compania = new CompaniaDeVuelo(tarifaBasica,aerolinea, temporada, nombre, edad, esEstudiante);
        }
    }
}
