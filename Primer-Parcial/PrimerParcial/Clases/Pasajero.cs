using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    public class Pasajero : Persona
    {
        private int equipaje; //En kilos.
        private bool premium;
        private bool bolsoDeMano;
       
        public Pasajero(int equipaje, bool premium, bool bolsoDeMano, 
            string nombre, string apellido, string genero,long dni,string pais, DateTime nacimiento,
            Pasaporte pasaporte) : base (nombre, apellido,genero,dni, pais,nacimiento, pasaporte)
        {
            this.Equipaje = equipaje;
            this.Premium = premium;
            this.BolsoDeMano = bolsoDeMano;
        }
        public int Equipaje { get => equipaje; set => equipaje = value; }
        public bool Premium { get => premium; set => premium = value; }
        public bool BolsoDeMano { get => bolsoDeMano; set => bolsoDeMano = value; }


       

    }
}
