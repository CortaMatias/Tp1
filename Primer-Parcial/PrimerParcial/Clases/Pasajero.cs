﻿using System;
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
            string nombre, string apellido, string genero,string dni,string pais, DateTime nacimiento,
            Pasaporte pasaporte) : base (nombre, apellido,genero,dni, pais,nacimiento, pasaporte)
        {
            this.Equipaje = equipaje;
            this.Premium = premium;
            this.BolsoDeMano = bolsoDeMano;
        }
        public int Equipaje { get => equipaje; set => equipaje = value; }
        public bool Premium { get => premium; set => premium = value; }
        public bool BolsoDeMano { get => bolsoDeMano; set => bolsoDeMano = value; }

        #region #Metodos
        public string MostrarPasajero(string destino, string salida)
        {
            StringBuilder sb = new();
            sb.Append($"Nombre: {this.Nombre} - Apellido: {this.Apellido}" +
                $" - Genero: {this.Genero} - Dni: {this.Dni} - Pais: {this.Pais}" +
                $"  - Edad: {this.Edad} - Cod. Pasaporte: {this.Pasaporte.Codigo.ToString()}" +
                $" - Venc. Pasaporte: {this.Pasaporte.Vencimiento.ToShortDateString()}" +
                $"- Destino: {destino} " +
                $"- Fecha de Salida: {salida}");
            return sb.ToString();
        }

        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            if (p1.Dni == p2.Dni) return true;
            else return false;
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Pasajero)
            {
                ret = this == ((Pasajero)obj);
            }
            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion 

    }
}
