using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    public class Viajes
    {
        private string partida;
        private string destino;
        private DateTime fecha;
        private string crucero;
        private int camarotePremium;
        private int camaroteTurista;
        private double costoPremium;
        private double costoTurista;
        private double duracionViaje;
        private List<Pasajero> lista;

        public Viajes(string partida, string destino, DateTime fecha, string crucero, int camarotePremium
            , int camaroteTurista, double costoPremium, double costoTurista, double duracionViaje)
        {
            this.Partida = partida;
            this.Destino = destino;
            this.Fecha = fecha;
            this.Crucero = crucero;
            this.CamarotePremium = camarotePremium;
            this.CamaroteTurista = camaroteTurista;
            this.CostoPremium = costoPremium;
            this.CostoTurista = costoTurista;
            this.DuracionViaje = duracionViaje;
        }

        public string Partida { get => partida; set => partida = value; }
        public string Destino { get => destino; set => destino = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Crucero { get => crucero; set => crucero = value; }
        public int CamarotePremium { get => camarotePremium; set => camarotePremium = value; }
        public int CamaroteTurista { get => camaroteTurista; set => camaroteTurista = value; }
        public double CostoPremium { get => costoPremium; set => costoPremium = value; }
        public double CostoTurista { get => costoTurista; set => costoTurista = value; }
        public double DuracionViaje { get => duracionViaje; set => duracionViaje = value; }
        internal List<Pasajero> Lista { get => lista; set => lista = value; }
    }
}
