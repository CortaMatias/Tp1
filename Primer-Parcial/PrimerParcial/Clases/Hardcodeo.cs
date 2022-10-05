using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    static class Hardcodeo
    {

        private static List<Viajes> listaViajes;
        private static List<Crucero> listaCruceros;
        private static List<Pasajero> listaPasajeros;
        private static List<Pasaporte> listaPasaportes;

        public static List<Viajes> ListaViajes { get => listaViajes; set => listaViajes = value; }
        public static List<Crucero> ListaCruceros { get => listaCruceros; set => listaCruceros = value; }
        public static List<Pasajero> ListaPasajeros { get => listaPasajeros; set => listaPasajeros = value; }
        public static List<Pasaporte> ListaPasaportes { get => listaPasaportes; set => listaPasaportes = value; }

        static Hardcodeo()
        {
            listaViajes = new List<Viajes>();
            listaCruceros = new List<Crucero>();
            listaPasajeros = new List<Pasajero>();
            listaPasaportes = new List<Pasaporte>();
        }


        public static void CargarCruceros()
        {


        }

        public static void CargarPasajeros()
        {


        }

        public static void CargarViajes()
        {


        }




    }


}
