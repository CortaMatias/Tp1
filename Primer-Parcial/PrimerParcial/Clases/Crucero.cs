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
        private int piscina = 0;
        private int gimnasio = 0;
        private int cine = 0;
        private int casino = 0;
        private double bodega;
        private int capacidadPersonas;


        public Crucero(string matricula, string nombre, int camarotes,  double bodega, int capacidadPersonas)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.camarotes = camarotes;
            this.bodega = bodega;
            this.CapacidadPersonas = capacidadPersonas;
        }
        public Crucero(string matricula, string nombre, int camarotes, double bodega, int capacidadPersonas, int casinos) : this(matricula, nombre, camarotes, bodega, capacidadPersonas)
        {
            this.Casino = casinos;
        }

        public Crucero(string matricula, string nombre, int camarotes, double bodega, int capacidadPersonas, int casinos, int gimnasio) : this(matricula, nombre, camarotes,  bodega, capacidadPersonas,casinos)
        {
            this.Gimnasio = gimnasio;
        }

        public Crucero(string matricula, string nombre, int camarotes, double bodega, int capacidadPersonas, int casinos, int gimnasio, int cine) : this(matricula, nombre, camarotes, bodega, capacidadPersonas, casinos, gimnasio)
        {
            this.Cine = cine;
        }

        public Crucero(string matricula, string nombre, int camarotes, double bodega, int capacidadPersonas, int casinos, int gimnasio, int cine, int piscina) : this(matricula, nombre, camarotes, bodega, capacidadPersonas,casinos, gimnasio, cine)
        {
            this.Piscina = piscina;
        }

        public string Matricula { get => matricula;}
        public string Nombre { get => nombre;}
        public int Camarotes { get => camarotes;}
        public int Casino { get => casino; set => casino = value; }
        public double Bodega { get => bodega;}
        public int Piscina { get => piscina; set => piscina = value; }
        public int Gimnasio { get => gimnasio; set => gimnasio = value; }
        public int Cine { get => cine; set => cine = value; }
        public int CapacidadPersonas { get => capacidadPersonas; set => capacidadPersonas = value; }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Crucero: {this.Nombre}");
            sb.AppendLine($"Matricula: {this.Matricula}");
            sb.AppendLine($"Camarotes: {this.Camarotes}");
            sb.AppendLine($"Cap. Bodega: {this.Bodega}");
            sb.AppendLine($"Casino: {this.Casino}");
            sb.AppendLine($"Piscina: {this.Piscina}");
            sb.AppendLine($"Gimnasio: {this.Gimnasio}");
            sb.AppendLine($"Cine: {this.Cine}");

            return sb.ToString();
        }

        public static string Mostrar(Crucero c1)
        {
            return c1.Mostrar();
        }

    }
}
