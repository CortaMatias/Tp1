using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    class Pasaporte : Pasajero
    {
        private DateTime vencimiento;
        private string codigo;
        private string lugarNacimiento;
        private int codigoPais;
        private string pais;
    
        public Pasaporte(DateTime vencimiento, string codigo, string lugarNacimiento, int codigoPais,
            string nombre, string apellido, int edad,string sexo, string equipaje, string pais)
        {
            this.vencimiento = vencimiento;
            this.codigo = codigo;
            this.codigoPais = codigoPais;
            this.lugarNacimiento = lugarNacimiento;
            base.Apellido = apellido;
            base.Nombre = nombre;
            base.Edad = edad;
            base.Sexo = sexo;
            base.Equipaje = equipaje;
            this.pais = pais;
        }


    
    }
}
