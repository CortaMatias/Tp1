using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    public class Crucero
    {
        private string matricula;
        private string nombre;
        private int camarotes;
        private int salones;
        private int casinos = 0;
        private double bodega;


        public Crucero(string matricula, string nombre, int camarotes, int salones, double bodega)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.camarotes = camarotes;
            this.salones = salones;
            this.bodega = bodega;
        }
        public Crucero(string matricula, string nombre, int camarotes, int salones, double bodega, int casinos) : this(matricula, nombre, camarotes, salones, bodega)
        {
            this.casinos = casinos;
        }

        public string Matricula { get => matricula;}
        public string Nombre { get => nombre;}
        public int Camarotes { get => camarotes;}
        public int Salones { get => salones;}
        public int Casinos { get => casinos; }
        public double Bodega { get => bodega;}
    }
}
