using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1.Clases;

namespace Ejercicio1.Clases
{
    internal class CompaniaDeVuelo
    {
        public int tarifaBasica;
        public string temporada;
        public string nombre;
        private Pasajero pasajero;
        private string aerolinea;
        public CompaniaDeVuelo (int tarifaBasica, string aerolinea, string temporada, string nombre, int edad, string esEstudiante)
        {
            this.tarifaBasica = tarifaBasica;
            this.aerolinea = aerolinea;
            this.temporada = temporada;
            this.pasajero = new Pasajero(nombre, edad, esEstudiante);
        }

        public static void DescuentoMenor()
        {
            if (Pasajero.
            {

            }
        }
    }
}
