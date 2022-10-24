using System;
using System.Collections.Generic;
using System.Drawing;
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
        private bool piscina = false;
        private bool gimnasio = false;
        private bool cine = false;
        private bool casino = false;
        private int bodega;
        private int capacidadPersonas;
        


        public Crucero(string matricula, string nombre, int camarotes,  int bodega, int capacidadPersonas)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.camarotes = camarotes;
            this.bodega = bodega;
            this.CapacidadPersonas = capacidadPersonas;
        }        

        public Crucero(string matricula, string nombre, int camarotes, int bodega, int capacidadPersonas, bool casinos, bool gimnasio, bool cine, bool piscina) : this(matricula, nombre, camarotes, bodega, capacidadPersonas)
        {
            this.Piscina = piscina;
            this.Casino = casinos;
            this.Gimnasio = gimnasio;
            this.Cine = cine;
        }
        public string Matricula { get => matricula;}
        public string Nombre { get => nombre;}
        public int Camarotes { get => camarotes;}
        public int Bodega { get => bodega;}
        public int CapacidadPersonas { get => capacidadPersonas; set => capacidadPersonas = value; }
        public bool Piscina { get => piscina; set => piscina = value; }
        public bool Gimnasio { get => gimnasio; set => gimnasio = value; }
        public bool Cine { get => cine; set => cine = value; }
        public bool Casino { get => casino; set => casino = value; }

        #region #Metodos
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


        public int CalcularHorasTotales(List<Viajes> l)
        {
            int duracionTotal = 0;
            foreach (Viajes v in l)
            {
                if (this.Nombre == v.Crucero.Nombre)
                {
                    duracionTotal += v.DuracionViaje;
                }
            }
            return duracionTotal;
        }

        public int CalcularViajesTotales(List<Viajes> l)
        {
            int contadorViajes = 0;
            foreach (Viajes v in l)
            {
                if (this.Nombre == v.Crucero.Nombre)
                {
                    contadorViajes++;
                }
            }
            return contadorViajes;
        }
        #endregion
    }
}
