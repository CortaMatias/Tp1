using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    class Pasajero
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string sexo;
        private string equipaje;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Equipaje { get => equipaje; set => equipaje = value; }
    }
}
