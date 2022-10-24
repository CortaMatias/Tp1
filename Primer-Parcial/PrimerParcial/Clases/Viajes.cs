using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    public class Viajes
    {
        private string partida ;
        private static int precioRegional;
        private static int precioExtraRegional;
        private destinos destino;
        private DateTime fechaSalida;
        private DateTime fechaRegreso;
        private Crucero crucero;
        private int camarotePremium;
        private int camaroteTurista;
        private int duracionViaje;
        private List<Pasajero> lista;

        #region #Constructores
        public Viajes(destinos destino, DateTime fecha, Crucero crucero) : this()
        {
            this.partida = "Buenos Aires";
            this.Destino = destino;
            this.FechaSalida = fecha;
            this.Crucero = crucero;
            this.CamarotePremium = CalcularCamarotesPremium(this.Crucero);
            this.CamaroteTurista = CalcularCamarotesTurista(this.Crucero);
            this.DuracionViaje = CalcularDuracion();
            this.FechaRegreso = calcularVuelta(DuracionViaje);
        }

        static Viajes()
        {
            precioRegional = 57;
            precioExtraRegional = 120;
        }

        public Viajes()
        {
            this.Lista = new List<Pasajero>();
        }
        #endregion

        #region #Propiedades
        public string Partida { get => partida; set => partida = value; }
        public Crucero Crucero { get => crucero; set => crucero = value; }
        public int CamarotePremium { get => camarotePremium; set => camarotePremium = value; }
        public int CamaroteTurista { get => camaroteTurista; set => camaroteTurista = value; }
        public List<Pasajero> Lista { get => lista; set => lista = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int DuracionViaje { get => duracionViaje; set => duracionViaje = value; }
        public destinos Destino { get => destino; set => destino = value; }
        public DateTime FechaRegreso { get => fechaRegreso; set => fechaRegreso = value; }
        #endregion

        #region #Metodos
        public static bool operator ==(Viajes v, destinos destino)
        {
            return (destino == v.Destino);
        }
        public static bool operator !=(Viajes v, destinos destino)
        {
            return !(v.Crucero.Nombre == destino.ToString());
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Viajes)
            {
                ret = this == ((Viajes)obj);
            }
            return ret;
        }

        public int CalcularPasajeroPremium()
        {
            int contador = 0;
            foreach (Pasajero p in Lista)
            {
                if (p.Premium == true) contador++;
            }
            return contador;
        }

        public int CalcularPasajeroTurista()
        {
            int contador = 0;
            foreach (Pasajero p in Lista)
            {
                if (p.Premium == false) contador++;
            }
            return contador;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
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
            sb.AppendLine($"Disponibilidad: {this.CalcularDisponibilidad()}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }

        private DateTime calcularVuelta(int duracion)
        {
            DateTime salida = this.FechaSalida;
            DateTime FechaRegreso = salida.AddHours(duracion);
            return FechaRegreso;
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


        public int CalcularEspacioBodega()
        {
            int equipaje = 0;
            foreach (Pasajero p in this.Lista)
            {
                equipaje = p.Equipaje + equipaje;
            }
            return this.Crucero.Bodega - equipaje;
        }

        public int CalcularDisponibilidad()
        {
            return this.Crucero.CapacidadPersonas - this.Lista.Count;
        }

        public int calcularDisponibilidadPremium()
        {
            return this.CamarotePremium - (CantidadPremium() / 2);
        }

        public int CalcularDisponibilidadTurista()
        {
            return this.CamaroteTurista - (CantidadTurista() / 2);
        }

        public int CantidadTurista()
        {
            int contador = 0;
            foreach (Pasajero p in this.Lista)
            {
                if (p.Premium == false) contador++;
            }
            return contador;
        }

        public int CantidadPremium()
        {
            int contador = 0;
            foreach (Pasajero p in this.Lista)
            {
                if (p.Premium == true) contador++;
            }
            return contador;
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
                if (this.Destino == (destinos)i) { duracion = r.Next(72, 361); break; }
                else { duracion = r.Next(480, 721); }
            }
            return duracion;
        }



        public float CalcularPrecioViaje(Pasajero p)
        {
            int costoHora;
            float costoBruto;
            if ((int)this.Destino > 0 && (int)this.Destino < 11)
            {
                costoHora = Viajes.precioRegional;
                costoBruto = costoHora * this.DuracionViaje;
            }
            else
            {
                costoHora = Viajes.precioExtraRegional;
                costoBruto = costoHora * this.DuracionViaje;
            }
            if (p.Premium) costoBruto = costoBruto * 1.20F;
            return costoBruto;
        }

        public float CalcularGananciasRegionales()
        {
            float ganancias = 0;
            if ((int)this.Destino < 11)
            {
                foreach (Pasajero p in this.Lista)
                {
                    ganancias += CalcularPrecioViaje(p);
                }
            }
            return ganancias;
        }

        public float CalcularGananciasExtraRegionales()
        {
            float ganancias = 0;
            if ((int)this.Destino > 10)
            {
                foreach (Pasajero p in this.Lista)
                {
                    ganancias += CalcularPrecioViaje(p);
                }
            }
            return ganancias;
        }
        #endregion
    }
}
