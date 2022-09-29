using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    public class Pasaporte
    {
        private DateTime vencimiento;
        private DateTime emision;
        private string codigo;
        private int codigoPais;
        private string tipo;
    
        public Pasaporte(DateTime vencimiento, DateTime emision, string codigo,
            int codigoPais, string tipo)            
        {
            this.Emision = emision;
            this.Vencimiento = vencimiento;
            this.Codigo = codigo;
            this.CodigoPais = codigoPais;
            this.Tipo = tipo;
        }


        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int CodigoPais { get => codigoPais; set => codigoPais = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Emision { get => emision; set => emision = value; }
    }
}
