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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="destino"></param>
        /// <returns></returns>
        public static bool operator ==(Viajes v, destinos destino)
        {
            return (destino == v.Destino);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="destino"></param>
        /// <returns></returns>
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

        /// <summary>
        ///  Calcula la cantidad de pasajeros premium que hay en un viaje.
        /// </summary>
        /// <returns></returns>
        public int CalcularPasajeroPremium()
        {
            int contador = 0;
            foreach (Pasajero p in Lista)
            {
                if (p.Premium == true) contador++;
            }
            return contador;
        }

        /// <summary>
        /// Calcula la cantidad de pasajeros turista que hay en un viaje.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Calcula la fecha en la que va a volver el viaje a partir de la fecha de salida y la duracion
        /// </summary>
        /// <param name="duracion"></param>
        /// <returns></returns>
        private DateTime calcularVuelta(int duracion)
        {
            DateTime salida = this.FechaSalida;
            DateTime FechaRegreso = salida.AddHours(duracion);
            return FechaRegreso;
        }

        /// <summary>
        /// Devuelve en una lista de viajes los viajes que coincidan con la fecha que pasamos por parametro.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public static List<Viajes> filterViaje(DateTime f, List<Viajes> l)
        {
            List<Viajes> lista = new List<Viajes>();
            foreach (Viajes v in l)
            {
                if (v.FechaSalida == f) lista.Add(v);
            }
            return lista;
        }


        /// <summary>
        /// Calcula el espacio disponible en la bodega y retona ese valor (en kg)
        /// </summary>
        /// <returns></returns>
        public int CalcularEspacioBodega()
        {
            int equipaje = 0;
            foreach (Pasajero p in this.Lista)
            {
                equipaje = p.Equipaje + equipaje;
            }
            return this.Crucero.Bodega - equipaje;
        }

        /// <summary>
        /// Calcula la disponibilidad de pasajeros para el viaje en cierto crucero.
        /// </summary>
        /// <returns></returns>
        public int CalcularDisponibilidad()
        {
            return this.Crucero.CapacidadPersonas - this.Lista.Count;
        }

        /// <summary>
        /// Calcula la cantidad disponible para pasejeros de tipo Premium
        /// </summary>
        /// <returns></returns>
        public int calcularDisponibilidadPremium()
        {
            return this.CamarotePremium - (CantidadPremium() / 2);
        }


        /// <summary>
        /// Calcula la cantidad disponible para pasajeros de tipo Turista
        /// </summary>
        /// <returns></returns>
        public int CalcularDisponibilidadTurista()
        {
            return this.CamaroteTurista - (CantidadTurista() / 2);
        }

        /// <summary>
        /// Calcula la cantidad de pasajeros turistas que hay en un viaje
        /// </summary>
        /// <returns></returns>
        public int CantidadTurista()
        {
            int contador = 0;
            foreach (Pasajero p in this.Lista)
            {
                if (p.Premium == false) contador++;
            }
            return contador;
        }


        /// <summary>
        /// Calcula la cantidad de pasajeros premium que hay en un viaje
        /// </summary>
        /// <returns></returns>
        public int CantidadPremium()
        {
            int contador = 0;
            foreach (Pasajero p in this.Lista)
            {
                if (p.Premium == true) contador++;
            }
            return contador;
        }


        /// <summary>
        /// Calcula la cantidad de Camarotes premium que hay disponibles.
        /// </summary>
        /// <param name="c1"></param>
        /// <returns></returns>
        public static int CalcularCamarotesPremium(Crucero c1)
        {
            int camarotesPremium = (int)(c1.Camarotes * 0.35);
            return camarotesPremium;
        }


        /// <summary>
        /// Calcula la cantidad de Camarotes turistas que hay disponibles
        /// </summary>
        /// <param name="c1"></param>
        /// <returns></returns>
        public static int CalcularCamarotesTurista(Crucero c1)
        {
            int camarotesTurista = (int)(c1.Camarotes * 0.65);
            return camarotesTurista;
        }


        /// <summary>
        /// Calcula la duracion del viaje de manera aleatoria.
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// Calcula el precio que va a tener un pasaje para un pasajero.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Calcula las ganancias totales de los viajes regionales
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Calcula la ganancia total de los viajes ExtraRegionales
        /// </summary>
        /// <returns></returns>
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
