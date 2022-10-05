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
            ListaPasaportes = new List<Pasaporte>();

            ListaCruceros.Add( new Crucero("BA – 1 – 000 – 18", "Freedom", 100, 7000, 220));
            ListaCruceros.Add( new Crucero("BA – 2 – 001 – 19", "Felicty", 150, 7500, 300));
            ListaCruceros.Add( new Crucero("BA – 3 – 014 – 23", "Aida", 200, 10000, 500));
            ListaCruceros.Add( new Crucero("BA – 8 – 018 – 31", "Advanced", 90, 9500, 200));
            ListaCruceros.Add( new Crucero("BA – 15 – 032 – 44", "Cunard", 80, 9000, 180));
            ListaCruceros.Add( new Crucero("BA – 6 – 003 – 10", "Holland", 300, 15000, 600));
            ListaCruceros.Add( new Crucero("BA – 4 – 099 – 28", "Princess", 250, 800, 500));

            //PASAPORTES
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 5, 3), "10252292", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 3, 3), "10152294", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 3, 23), "12152294", 325, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 5, 3), "12152294", 325, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 9, 20), new(2020, 10, 23), "210152294", 205, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 9, 20), new(2020, 5, 2), "10252294", 205, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 3, 2), "10159292", 325, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 3, 23), "10152294", 205, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 5, 2), "10122292", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 3, 2), "10152294", 205, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 1, 3), "10292294", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 20), new(2020, 1, 23), "10152294", 205, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 20), new(2020, 9, 2), "10152994", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 5, 3), "20152294", 325, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 9, 2), "12152294", 205, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 4, 2), new(2020, 9, 23), "10152294", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 2), new(2020, 5, 23), "10952294", 205, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 9, 23), "10122294", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 2), new(2020, 2, 23), "10252294", 305, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 5, 23), "90129294", 325, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 2, 23), "12192294", 302, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 5, 23), "10152994", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 0), new(2020, 2, 23), "20192294", 205, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 5, 23), "10152294", 305, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 2), new(2020, 3, 23), "12952294", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 5, 3), "20152294", 325, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 9, 2), "19152294", 305, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 4, 2), new(2020, 9, 23), "10952294", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 2), new(2020, 5, 23), "10252294", 325, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 9, 23), "1012994", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 2), new(2020, 2, 23), "10259294", 205, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 5, 23), "10192294", 305, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 2, 23), "19152994", 305, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 5, 23), "10152294", 325, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 0), new(2020, 2, 23), "20152294", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 5, 23), "10192294", 325, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 2), new(2020, 3, 23), "12952294", 205, Tipo.Oficial.ToString()));

            //PASAJEROS
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Alberto", "Masculino", "3835534", "URU", new(1975, 6, 127), ListaPasaportes[0]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Juan", "Viviene", "Masculino", "3854534", "USA", new(1995, 6, 12), ListaPasaportes[1]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Jimmie", "Fettes", "Femenino", "3835534", "PAR", new(1995, 6, 1), ListaPasaportes[2]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Juan", "Walshaw", "Masculino", "3854534", "BRA", new(1995, 6, 7), ListaPasaportes[3]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Letta", "Viviene", "Masculino", "3835534", "USA", new(1995, 6, 27), ListaPasaportes[4]));
            ListaPasajeros.Add(new Pasajero(35, true, true, "Vincents", "Guidoni", "Femenino", "3835534", "ARG", new(1975, 6, 17), ListaPasaportes[5]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Walshaw", "No binario", "383534", "ARG", new(1975, 5, 12), ListaPasaportes[6]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Emmalynn", "Barrand", "Masculino", "3835534", "ARG", new(1995, 3, 2), ListaPasaportes[7]));
            ListaPasajeros.Add(new Pasajero(23, true, true, "Letta", "Thayre", "Masculino", "3835534", "BRA", new(1995, 2, 7), ListaPasaportes[8]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Jerome", "Wrightem", "Femenino", "3834554", "USA", new(1995, 1, 21), ListaPasaportes[9]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Barrand", "Masculino", "5834534", "URU", new(1995, 4, 17), ListaPasaportes[10]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Jimmie", "Guidoni", "Masculino", "3834534", "ARG", new(1979, 3, 2), ListaPasaportes[11]));
            ListaPasajeros.Add(new Pasajero(35, true, false, "Juan", "Walshaw", "No binario", "3835534", "URU", new(1995, 6, 7), ListaPasaportes[12]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Viviene", "Craven", "Femenino", "3854534", "ARG", new(1979, 6, 2), ListaPasaportes[13]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Oswald", "Fettes", "Masculino", "3854534", "USA", new(1995, 12, 17), ListaPasaportes[14]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Juan", "Guidoni", "Masculino", "5834554", "PAR", new(1995, 6, 12), ListaPasaportes[15]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Emmalynn", "Gubbins", "Masculino", "3854534", "ARG", new(1995, 7, 27), ListaPasaportes[16]));
            ListaPasajeros.Add(new Pasajero(35, true, true, "Letta", "Walshaw", "Masculino", "3835554", "BRA", new(1979, 6, 17), ListaPasaportes[17]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Jerome", "Craven", "No binario", "3534534", "ARG", new(1995, 1, 9), ListaPasaportes[18]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Viviene", "Femenino", "3834534", "USA", new(1995, 12, 7), ListaPasaportes[19]));
            ListaPasajeros.Add(new Pasajero(23, true, true, "Emmalynn", "Fettes", "Masculino", "383534", "ARG", new(1975, 6, 7), ListaPasaportes[20]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Guidoni", "No binario", "5834534", "BRA", new(1992, 9, 13), ListaPasaportes[21]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Jimmie", "Alberto", "Masculino", "3834534", "USA", new(1999, 12, 12), ListaPasaportes[22]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Juan", "Alberto", "Femenino", "3835534", "URU", new(19912, 11, 29), ListaPasaportes[23]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Letta", "Alberto", "Masculino", "3834534", "ARG", new(1995, 6, 28), ListaPasaportes[24]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Guidoni", "No binario", "5834534", "BRA", new(1979, 10, 23), ListaPasaportes[25]));
            ListaPasajeros.Add(new Pasajero(23, true, true, "Jimmie", "Wrightem", "Masculino", "3854554", "USA", new(1995, 6, 22), ListaPasaportes[26]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Yanaton", "Alberto", "Masculino", "3535534", "URU", new(1979, 2, 21), ListaPasaportes[27]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Mohamed", "Masculino", "3834534", "URU", new(1979, 12, 12), ListaPasaportes[28]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Emmalynn", "Guidoni", "Masculino", "3834554", "ARG", new(1995, 6, 27), ListaPasaportes[29]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Alberto", "No binario", "3834554", "ARG", new(1979, 6, 27), ListaPasaportes[30]));
            ListaPasajeros.Add(new Pasajero(23, true, true, "Jimmie", "Alberto", "Masculino", "3835534", "USA", new(1975, 8, 17), ListaPasaportes[31]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Oswald", "Craven", "Masculino", "3834534", "BRA", new(1995, 6, 27), ListaPasaportes[2]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Letta", "Mohamed", "Masculino", "3854534", "ARG", new(1975, 6, 127), ListaPasaportes[3]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Vincents", "Wrightem", "Femenino", "3834534", "BRA", new(1979, 12, 22), ListaPasaportes[4]));
            ListaPasajeros.Add(new Pasajero(35, true, true, "Juan", "Guidoni", "Masculino", "3535535", "USA", new(1975, 3, 21), ListaPasaportes[9]));
            ListaPasajeros.Add(new Pasajero(35, true, false, "Jimmie", "Walshaw", "No binario", "3834534", "ARG", new(199, 5, 27), ListaPasaportes[10]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Oswald", "Craven", "Masculino", "3854534", "BRA", new(1995, 9, 12), ListaPasaportes[14]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Jerome", "Gubbins", "Femenino", "3534554", "USA", new(1995, 12, 12), ListaPasaportes[25]));


            //HISTORIAL           
            ListaViajes.Add(new Viajes(destinos.Acapulco, new(2019, 3, 4), ListaCruceros[0]));
            ListaViajes.Add(new Viajes(destinos.Atenas, new(2020, 8, 5), ListaCruceros[1]));
            ListaViajes.Add(new Viajes(destinos.Bangkok, new(2021, 9, 4), ListaCruceros[2]));
            ListaViajes.Add(new Viajes(destinos.Cartagena, new(2019, 22, 6), ListaCruceros[3]));
            ListaViajes.Add(new Viajes(destinos.Miami, new(2020, 5, 10), ListaCruceros[4]));
            ListaViajes.Add(new Viajes(destinos.Recife, new(2021, 3, 7), ListaCruceros[1]));
            ListaViajes.Add(new Viajes(destinos.Montevideo, new(2019, 5, 9), ListaCruceros[5]));
            ListaViajes.Add(new Viajes(destinos.Taipei, new(2018, 1, 1), ListaCruceros[1]));
            ListaViajes.Add(new Viajes(destinos.Ushuaia, new(2020, 2, 2), ListaCruceros[6]));
            ListaViajes.Add(new Viajes(destinos.Montevideo, new(2019, 3, 3), ListaCruceros[2]));
            ListaViajes.Add(new Viajes(destinos.PuertoMadryn, new(2020, 4, 4), ListaCruceros[3]));
            ListaViajes.Add(new Viajes(destinos.RioDeJaneiro, new(2019, 1, 6), ListaCruceros[1]));
            ListaViajes.Add(new Viajes(destinos.Santiago, new(2020, 7, 7), ListaCruceros[6]));
            ListaViajes.Add(new Viajes(destinos.Lima, new(2019, 5, 12), ListaCruceros[2]));
            ListaViajes.Add(new Viajes(destinos.LaHabana, new(2020, 2, 10), ListaCruceros[3]));
            //ACTUALES          
            ListaViajes.Add(new Viajes(destinos.IslaGalapagos, new(2023, 4, 12), ListaCruceros[0]));
            ListaViajes.Add(new Viajes(destinos.Venecia, new(2023, 1, 9), ListaCruceros[1]));
            ListaViajes.Add(new Viajes(destinos.PuertoMadryn, new(2023, 2, 8), ListaCruceros[2]));
            ListaViajes.Add(new Viajes(destinos.IslaDePascua, new(2023, 3, 6), ListaCruceros[3]));
            ListaViajes.Add(new Viajes(destinos.Montevideo, new(2023, 7, 24), ListaCruceros[4]));
            ListaViajes.Add(new Viajes(destinos.Cartagena, new(2023, 6, 20), ListaCruceros[5]));
            ListaViajes.Add(new Viajes(destinos.Atenas, new(2023, 7, 13), ListaCruceros[6]));
            ListaViajes.Add(new Viajes(destinos.Acapulco, new(2023, 8, 21), ListaCruceros[0]));
            ListaViajes.Add(new Viajes(destinos.Santiago, new(2022, 12, 9), ListaCruceros[1]));
            ListaViajes.Add(new Viajes(destinos.Montevideo, new(2022, 12, 24), ListaCruceros[3]));
            ListaViajes.Add(new Viajes(destinos.Bangkok, new(2022, 12, 30), ListaCruceros[4]));


            ListaViajes[0].Lista.Add(ListaPasajeros[0]);
            ListaViajes[0].Lista.Add(ListaPasajeros[1]);
            ListaViajes[0].Lista.Add(ListaPasajeros[2]);
            ListaViajes[0].Lista.Add(ListaPasajeros[3]);
            ListaViajes[0].Lista.Add(ListaPasajeros[4]);

            ListaViajes[1].Lista.Add(ListaPasajeros[5]);
            ListaViajes[1].Lista.Add(ListaPasajeros[6]);
            ListaViajes[1].Lista.Add(ListaPasajeros[7]);
            ListaViajes[1].Lista.Add(ListaPasajeros[8]);
            ListaViajes[1].Lista.Add(ListaPasajeros[9]);
            ListaViajes[1].Lista.Add(ListaPasajeros[10]);

            ListaViajes[2].Lista.Add(ListaPasajeros[3]);
            ListaViajes[2].Lista.Add(ListaPasajeros[11]);
            ListaViajes[2].Lista.Add(ListaPasajeros[12]);
            ListaViajes[2].Lista.Add(ListaPasajeros[3]);

            ListaViajes[3].Lista.Add(ListaPasajeros[13]);
            ListaViajes[3].Lista.Add(ListaPasajeros[3]);
            ListaViajes[3].Lista.Add(ListaPasajeros[14]);
            ListaViajes[3].Lista.Add(ListaPasajeros[15]);
            ListaViajes[3].Lista.Add(ListaPasajeros[3]);
            ListaViajes[3].Lista.Add(ListaPasajeros[16]);

            ListaViajes[4].Lista.Add(ListaPasajeros[17]);
            ListaViajes[4].Lista.Add(ListaPasajeros[3]);

            ListaViajes[5].Lista.Add(ListaPasajeros[18]);
            ListaViajes[5].Lista.Add(ListaPasajeros[19]);

            ListaViajes[6].Lista.Add(ListaPasajeros[20]);
            ListaViajes[6].Lista.Add(ListaPasajeros[0]);
            ListaViajes[6].Lista.Add(ListaPasajeros[0]);

            ListaViajes[7].Lista.Add(ListaPasajeros[17]);
            ListaViajes[7].Lista.Add(ListaPasajeros[20]);
            ListaViajes[7].Lista.Add(ListaPasajeros[21]);
            ListaViajes[7].Lista.Add(ListaPasajeros[3]);
            
            ListaViajes[8].Lista.Add(ListaPasajeros[19]);
            ListaViajes[8].Lista.Add(ListaPasajeros[8]);
            ListaViajes[8].Lista.Add(ListaPasajeros[7]);
            ListaViajes[8].Lista.Add(ListaPasajeros[17]);

            ListaViajes[9].Lista.Add(ListaPasajeros[10]);
            ListaViajes[9].Lista.Add(ListaPasajeros[17]);
            ListaViajes[9].Lista.Add(ListaPasajeros[3]);
            ListaViajes[9].Lista.Add(ListaPasajeros[19]);

            ListaViajes[10].Lista.Add(ListaPasajeros[14]);
            ListaViajes[10].Lista.Add(ListaPasajeros[3]);
            ListaViajes[10].Lista.Add(ListaPasajeros[17]);
            ListaViajes[10].Lista.Add(ListaPasajeros[21]);


            ListaViajes[11].Lista.Add(ListaPasajeros[4]);
            ListaViajes[11].Lista.Add(ListaPasajeros[3]);
            ListaViajes[11].Lista.Add(ListaPasajeros[17]);

            ListaViajes[12].Lista.Add(ListaPasajeros[9]);
            ListaViajes[12].Lista.Add(ListaPasajeros[2]);
            ListaViajes[12].Lista.Add(ListaPasajeros[22]);
            ListaViajes[12].Lista.Add(ListaPasajeros[17]);

            ListaViajes[13].Lista.Add(ListaPasajeros[9]);
            ListaViajes[13].Lista.Add(ListaPasajeros[3]);
            ListaViajes[13].Lista.Add(ListaPasajeros[17]);

            ListaViajes[14].Lista.Add(ListaPasajeros[20]);
            ListaViajes[14].Lista.Add(ListaPasajeros[19]);
            ListaViajes[14].Lista.Add(ListaPasajeros[3]);
            ListaViajes[14].Lista.Add(ListaPasajeros[21]);

            ListaViajes[15].Lista.Add(ListaPasajeros[21]);
            ListaViajes[15].Lista.Add(ListaPasajeros[22]);
            ListaViajes[15].Lista.Add(ListaPasajeros[3]);

            ListaViajes[16].Lista.Add(ListaPasajeros[17]);
            ListaViajes[16].Lista.Add(ListaPasajeros[23]);
            ListaViajes[16].Lista.Add(ListaPasajeros[19]);

            ListaViajes[17].Lista.Add(ListaPasajeros[17]);
            ListaViajes[17].Lista.Add(ListaPasajeros[24]);
            ListaViajes[17].Lista.Add(ListaPasajeros[25]);

            ListaViajes[18].Lista.Add(ListaPasajeros[17]);
            ListaViajes[18].Lista.Add(ListaPasajeros[26]);
            ListaViajes[18].Lista.Add(ListaPasajeros[27]);

            ListaViajes[19].Lista.Add(ListaPasajeros[0]);
            ListaViajes[19].Lista.Add(ListaPasajeros[0]);
            ListaViajes[19].Lista.Add(ListaPasajeros[28]);
            ListaViajes[19].Lista.Add(ListaPasajeros[3]);

            ListaViajes[20].Lista.Add(ListaPasajeros[29]);
            ListaViajes[20].Lista.Add(ListaPasajeros[19]);
            ListaViajes[20].Lista.Add(ListaPasajeros[30]);
            ListaViajes[20].Lista.Add(ListaPasajeros[17]);

            ListaViajes[21].Lista.Add(ListaPasajeros[15]);
            ListaViajes[21].Lista.Add(ListaPasajeros[13]);
            ListaViajes[21].Lista.Add(ListaPasajeros[17]);
            ListaViajes[21].Lista.Add(ListaPasajeros[3]);

            ListaViajes[22].Lista.Add(ListaPasajeros[20]);
            ListaViajes[22].Lista.Add(ListaPasajeros[22]);
            ListaViajes[22].Lista.Add(ListaPasajeros[20]);

            ListaViajes[23].Lista.Add(ListaPasajeros[19]);
            ListaViajes[23].Lista.Add(ListaPasajeros[18]);
            ListaViajes[23].Lista.Add(ListaPasajeros[10]);

            ListaViajes[24].Lista.Add(ListaPasajeros[17]);
            ListaViajes[24].Lista.Add(ListaPasajeros[19]);
            ListaViajes[24].Lista.Add(ListaPasajeros[3]);

            ListaViajes[25].Lista.Add(ListaPasajeros[9]);
            ListaViajes[25].Lista.Add(ListaPasajeros[17]);
            ListaViajes[25].Lista.Add(ListaPasajeros[4]);
        }
    }


}
