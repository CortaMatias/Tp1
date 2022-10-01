using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    public class Viajes
    {
        private static string partida = "Puerto de Buenos Aires";
        private static double costoPremium = 1.20;
        private static double costoTurista = 1;
        private static double precioRegional = 57;
        private static double precioExtraRegional = 120;
        private string destino;
        private DateTime fechaSalida;
        private DateTime fechaRegreso;
        private Crucero crucero;
        private int camarotePremium;
        private int camaroteTurista;
        private int duracionViaje;
        private List<Pasajero> lista;

        public Viajes(string destino, DateTime fecha, Crucero crucero, int camarotePremium
            , int camaroteTurista) : this()
        {
            this.Destino = destino;
            this.FechaSalida = fecha;
            this.Crucero = crucero;
            this.CamarotePremium = camarotePremium;
            this.CamaroteTurista = camaroteTurista;
            this.DuracionViaje = CalcularDuracion();
        }
        private Viajes()
        {
            this.Lista = new List<Pasajero>();
        }

        public string Partida { get => partida; set => partida = value; }
        public string Destino { get => destino; set => destino = value; }
        public Crucero Crucero { get => crucero; set => crucero = value; }
        public int CamarotePremium { get => camarotePremium; set => camarotePremium = value; }
        public int CamaroteTurista { get => camaroteTurista; set => camaroteTurista = value; }
        public double CostoPremium { get => costoPremium; set => costoPremium = value; }
        public double CostoTurista { get => costoTurista; set => costoTurista = value; }
        public List<Pasajero> Lista { get => lista; set => lista = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int DuracionViaje { get => duracionViaje; set => duracionViaje = value; }

        public static bool operator == (Viajes v, destinos destino)
        {
            return (destino.ToString() == v.Destino);
        }
        public static bool operator !=(Viajes v, destinos destino)
        {
            return !(v.Crucero.Nombre == destino.ToString());
        }



        public static void AgregarViaje(Viajes v1, List<Viajes> list)
        {
            if (Viajes.ValidarDatosViaje(v1)) list.Add(v1);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Destino: {this.Destino}");
            sb.AppendLine($"Fecha de salida: {this.FechaSalida}");
            sb.AppendLine($"Crucero: {this.Crucero}");
            sb.AppendLine($"Duracion: {this.DuracionViaje}");
            sb.AppendLine($"Camarotes Premium: {this.camarotePremium}");
            sb.AppendLine($"Camarotes Turista:{this.CamaroteTurista}");
            sb.AppendLine($"Pasajeros totales: {this.Lista.Count}");
            sb.AppendLine($"Disponibilidad: {this.CalcularDisponibilidad(this.Crucero,this)}");
            return sb.ToString();
        }

        public static List<Viajes> filterViaje(DateTime f, List<Viajes> l)
        {
            List<Viajes> lista = new List<Viajes>();
            foreach (Viajes v in l)
            {
                if (v.FechaSalida == f) lista.Add(v);
            }
            return lista;
        }

        public static string Mostrar(Viajes v1)
        {
            return v1.Mostrar();
        }

        public int CalcularDisponibilidad(Crucero c1, Viajes v1)
        {          
            return c1.CapacidadPersonas - v1.Lista.Count;
        }

        public static int CalcularCamarotesPremium(Crucero c1)
        {
            int camarotesPremium = (int)(c1.Camarotes * 0.35);
            return camarotesPremium;
        }

        public static int CalcularCamarotesTurista(Crucero c1)
        {
            int camarotesTurista = (int)(c1.Camarotes * 0.65);
            return camarotesTurista;
        }

        private int CalcularDuracion()
        {
            int duracion = 0;
            Random r = new Random();
            foreach (var i in Enum.GetValues(typeof(destinos))) 
            {
                if (this.Destino == i.ToString()) { duracion = r.Next(72, 361); break; }
                else { duracion = r.Next(480, 721); }
            }
            return duracion;
        }


        
        


        

        private static bool ValidarDatosPasajero(Pasajero p1) {
            //VALIDAR DATOS DEL PASAJERO.
            return true;
        }
        
        private static bool ValidarDatosCrucero()
        {
            //VALIDAR DATOS CRUCERO.
            return true;
        }

        public static void AgregarPasajero(Pasajero p1, Viajes v1)
        {
            if (Viajes.ValidarDatosPasajero(p1))
            {
                v1.Lista.Add(p1);
            }
        }

        public static bool ValidarDatosViaje(Viajes v1)
        {
            //Validar DAtos del viaje
            return true;
        }
        

    }
}
