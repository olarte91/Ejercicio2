using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1.Clases;

namespace Ejercicio1.Clases
{
    internal class Pasajero
    {
        private string nombre;
        private int edad;
        private string esEstudiante;

        public Pasajero (string nombre, int edad, string esEstudiante)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.esEstudiante = esEstudiante;
        }
    }
}
