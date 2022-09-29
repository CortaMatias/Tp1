using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{

    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string genero;
        private long dni;
        private Pasaporte pasaporte;
        private string pais;
        private DateTime nacimiento;

        public Persona(string nombre, string apellido, string genero, long dni, string pais, DateTime nacimiento,Pasaporte pasaporte)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.genero = genero;
            this.Pasaporte = pasaporte;
            this.Dni = dni;
            this.Pais = pais;
            this.Nacimiento = nacimiento;
            this.Edad = calcularEdad(nacimiento);
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public Pasaporte Pasaporte { get => pasaporte; set => pasaporte = value; }
        public long Dni { get => dni; set => dni = value; }
        public string Pais { get => pais; set => pais = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }


        public int calcularEdad(DateTime f)
        {
            //Validar cuando ingresa la fecha de nacimiento que no sea mayor a la fecha actual
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - f.Year;
            return edad;
        }
    }

    
}
