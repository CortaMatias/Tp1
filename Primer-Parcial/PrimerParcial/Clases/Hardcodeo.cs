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

        public static List<Viajes> ListaViajes { get => listaViajes;}
        public static List<Crucero> ListaCruceros { get => listaCruceros; }
        public static List<Pasajero> ListaPasajeros { get => listaPasajeros;}
        public static List<Pasaporte> ListaPasaportes { get => listaPasaportes;}

        static Hardcodeo()
        {
            listaViajes = new List<Viajes>();
            listaCruceros = new List<Crucero>();
            listaPasajeros = new List<Pasajero>();
            listaPasaportes = new List<Pasaporte>();

            ListaCruceros.Add( new Crucero("BA – 000 – 18", "Freedom", 100, 7000, 220,true,true,true,true));
            ListaCruceros.Add( new Crucero("BA – 001 – 19", "Felicty", 150, 7500, 300,false,true,false,true));
            ListaCruceros.Add( new Crucero("BA – 014 – 23", "Aida", 200, 10000, 500,true,true,false,true));
            ListaCruceros.Add( new Crucero("BA – 018 – 31", "Advanced", 90, 9500, 200,true,false,true,false));
            ListaCruceros.Add( new Crucero("BA – 032 – 44", "Cunard", 80, 9000, 180,true,true,false,false));
            ListaCruceros.Add( new Crucero("BA – 003 – 10", "Holland", 300, 15000, 600,false,false,true,true));
            ListaCruceros.Add( new Crucero("BA – 099 – 28", "Princess", 250, 8000, 500,false,false,false,false));

            //PASAPORTES
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 5, 3), "7894255", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 3, 3), "65422233", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 3, 23), "12342222", 325, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 5, 3), "69752211", 325, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 9, 20), new(2020, 10, 23), "21236221", 205, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 9, 20), new(2020, 5, 2), "12592289", 205, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 3, 2), "35659256", 325, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 3, 23), "28155544", 205, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 5, 2), "62342232", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 3, 2), "45692229", 205, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 20), new(2020, 1, 3), "32872216", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 20), new(2020, 1, 23), "12452221", 205, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 20), new(2020, 9, 2), "95232972", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 5, 3), "56982269", 325, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 9, 2), "365782256", 205, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 4, 2), new(2020, 9, 23), "85422252", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 2), new(2020, 5, 23), "95312243", 205, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 9, 23), "11252226", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 2), new(2020, 2, 23), "27462214", 305, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 5, 23), "85629217", 325, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 2, 23), "25642257", 302, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 5, 23), "75962989", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 1), new(2020, 2, 23), "56212288", 205, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 5, 23), "354124561", 305, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 2), new(2020, 3, 23), "64524564", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 20), new(2020, 5, 3), "745622456", 325, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 9, 2), "452124562", 305, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 4, 2), new(2020, 9, 23), "598728966", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 3, 2), new(2020, 5, 23), "786129874", 325, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 9, 23), "12655413", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 2), new(2020, 2, 23), "162596542", 205, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 5, 23), "18192789", 305, Tipo.Diplomatico.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 2, 23), "19152897", 305, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 1, 2), new(2020, 5, 23), "841522565", 325, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 3), new(2020, 2, 23), "95152135", 305, Tipo.Oficial.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 2, 2), new(2020, 5, 23), "19192124", 325, Tipo.Ordinario.ToString()));
            ListaPasaportes.Add(new Pasaporte(new(2024, 5, 2), new(2020, 3, 23), "16952123", 205, Tipo.Oficial.ToString()));

            //PASAJEROS
            ListaPasajeros.Add(new Pasajero(25, false, true, "Pablo", "Alberto", "Masculino", "2135590", "URU", new(1959, 6, 12), ListaPasaportes[0]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Juan", "Viviene", "Masculino", "3754550", "USA", new(1952, 6, 12), ListaPasaportes[1]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Jimmie", "Fettes", "Femenino", "4235540", "PAR", new(1956, 6, 1), ListaPasaportes[2]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Francisco", "Walshaw", "Masculino", "3054530", "BRA", new(1950, 6, 7), ListaPasaportes[3]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Letta", "Viviene", "Masculino", "3235510", "USA", new(1945, 6, 27), ListaPasaportes[4]));
            ListaPasajeros.Add(new Pasajero(35, true, true, "Vincents", "Guidoni", "Femenino", "4235520", "ARG", new(1975, 6, 17), ListaPasaportes[5]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Emiliano", "Walshaw", "No binario", "283542", "ARG", new(1967, 5, 12), ListaPasaportes[6]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Sandra", "Barrand", "Masculino", "2735541", "ARG", new(1966, 3, 2), ListaPasaportes[7]));
            ListaPasajeros.Add(new Pasajero(23, true, true, "Letta", "Thayre", "Masculino", "1735556", "BRA", new(1984, 2, 7), ListaPasaportes[8]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Emanuel", "Wrightem", "Femenino", "1834555", "USA", new(1995, 1, 21), ListaPasaportes[9]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Barrand", "Masculino", "2234581", "URU", new(1985, 4, 17), ListaPasaportes[10]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Nacho", "Guidoni", "Masculino", "3034529", "ARG", new(1979, 3, 2), ListaPasaportes[11]));
            ListaPasajeros.Add(new Pasajero(35, true, false, "Marcos", "Walshaw", "No binario", "4035524", "URU", new(1996, 6, 7), ListaPasaportes[12]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Viviene", "Craven", "Femenino", "3954523", "ARG", new(1987, 6, 2), ListaPasaportes[13]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Oswald", "Fettes", "Masculino", "3154571", "USA", new(1985, 12, 17), ListaPasaportes[14]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Mariano", "Guidoni", "Masculino", "3334575", "PAR", new(1981, 6, 12), ListaPasaportes[15]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Emmalynn", "Gubbins", "Masculino", "2554565", "ARG", new(1972, 7, 27), ListaPasaportes[16]));
            ListaPasajeros.Add(new Pasajero(35, true, true, "Mariana", "Walshaw", "Masculino", "2635598", "BRA", new(1979, 6, 17), ListaPasaportes[17]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Jerome", "Craven", "No binario", "1134512", "ARG", new(1971, 1, 9), ListaPasaportes[18]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Viviene", "Femenino", "1234521", "USA", new(1978, 12, 7), ListaPasaportes[19]));
            ListaPasajeros.Add(new Pasajero(23, true, true, "Rocio", "Fettes", "Masculino", "153554", "ARG", new(1977, 6, 7), ListaPasaportes[20]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Guidoni", "No binario", "2634554", "BRA", new(2001, 9, 13), ListaPasaportes[21]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Jimmie", "Alberto", "Masculino", "2934589", "USA", new(2002, 12, 12), ListaPasaportes[22]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Juan", "Alberto", "Femenino", "2535522", "URU", new(2000, 11, 29), ListaPasaportes[23]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Marcela", "Alberto", "Masculino", "3434513", "ARG", new(1996, 6, 28), ListaPasaportes[24]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Guidoni", "No binario", "3934511", "BRA", new(1992, 10, 23), ListaPasaportes[25]));
            ListaPasajeros.Add(new Pasajero(23, true, true, "Jimmie", "Wrightem", "Masculino", "2054517", "USA", new(1999, 6, 22), ListaPasaportes[26]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Gloria", "Alberto", "Masculino", "4035523", "URU", new(1977, 2, 21), ListaPasaportes[27]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Mohamed", "Masculino", "3034581", "URU", new(1979, 12, 12), ListaPasaportes[28]));
            ListaPasajeros.Add(new Pasajero(25, true, true, "Emmalynn", "Guidoni", "Masculino", "3234586", "ARG", new(1964, 6, 13), ListaPasaportes[29]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Juan", "Alberto", "No binario", "36345597", "ARG", new(1965, 6, 22), ListaPasaportes[30]));
            ListaPasajeros.Add(new Pasajero(23, true, true, "Jimmie", "Alberto", "Masculino", "3835596", "USA", new(1955, 8, 17), ListaPasaportes[31]));
            ListaPasajeros.Add(new Pasajero(25, false, false, "Oswald", "Craven", "Masculino", "3134599", "BRA", new(1988, 6, 21), ListaPasaportes[2]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Micaela", "Mohamed", "Masculino", "4354587", "ARG", new(1975, 6, 12), ListaPasaportes[3]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Vincents", "Wrightem", "Femenino", "2234546", "BRA", new(1979, 12, 22), ListaPasaportes[4]));
            ListaPasajeros.Add(new Pasajero(35, true, true, "Thiago", "Guidoni", "Masculino", "2835516", "USA", new(1975, 3, 21), ListaPasaportes[9]));
            ListaPasajeros.Add(new Pasajero(35, true, false, "Jimmie", "Walshaw", "No binario", "2134587", "ARG", new(1970, 5, 27), ListaPasaportes[10]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Oswald", "Craven", "Masculino", "1154533", "BRA", new(1988, 9, 15), ListaPasaportes[14]));
            ListaPasajeros.Add(new Pasajero(25, false, true, "Jerome", "Gubbins", "Femenino", "1934522", "USA", new(1991, 12, 13), ListaPasaportes[25]));


            //HISTORIAL           
            ListaViajes.Add(new Viajes(destinos.Acapulco, new(2019, 3, 4), ListaCruceros[0]));
            ListaViajes.Add(new Viajes(destinos.Atenas, new(2020, 8, 5), ListaCruceros[1]));
            ListaViajes.Add(new Viajes(destinos.Bangkok, new(2021, 9, 4), ListaCruceros[2]));
            ListaViajes.Add(new Viajes(destinos.Cartagena, new(2019, 2, 6), ListaCruceros[3]));
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
            ListaViajes.Add(new Viajes(destinos.Miami, new(2023, 8, 21), ListaCruceros[0]));
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
            ListaViajes[2].Lista.Add(ListaPasajeros[16]);

            ListaViajes[3].Lista.Add(ListaPasajeros[13]);
            ListaViajes[3].Lista.Add(ListaPasajeros[9]);
            ListaViajes[3].Lista.Add(ListaPasajeros[14]);
            ListaViajes[3].Lista.Add(ListaPasajeros[15]);
            ListaViajes[3].Lista.Add(ListaPasajeros[7]);
            ListaViajes[3].Lista.Add(ListaPasajeros[16]);

            ListaViajes[4].Lista.Add(ListaPasajeros[17]);
            ListaViajes[4].Lista.Add(ListaPasajeros[6]);

            ListaViajes[5].Lista.Add(ListaPasajeros[18]);
            ListaViajes[5].Lista.Add(ListaPasajeros[19]);

            ListaViajes[6].Lista.Add(ListaPasajeros[20]);
            ListaViajes[6].Lista.Add(ListaPasajeros[10]);
            ListaViajes[6].Lista.Add(ListaPasajeros[0]);

            ListaViajes[7].Lista.Add(ListaPasajeros[17]);
            ListaViajes[7].Lista.Add(ListaPasajeros[20]);
            ListaViajes[7].Lista.Add(ListaPasajeros[21]);
            ListaViajes[7].Lista.Add(ListaPasajeros[6]);
            
            ListaViajes[8].Lista.Add(ListaPasajeros[19]);
            ListaViajes[8].Lista.Add(ListaPasajeros[8]);
            ListaViajes[8].Lista.Add(ListaPasajeros[9]);
            ListaViajes[8].Lista.Add(ListaPasajeros[17]);

            ListaViajes[9].Lista.Add(ListaPasajeros[10]);
            ListaViajes[9].Lista.Add(ListaPasajeros[11]);
            ListaViajes[9].Lista.Add(ListaPasajeros[3]);
            ListaViajes[9].Lista.Add(ListaPasajeros[19]);

            ListaViajes[10].Lista.Add(ListaPasajeros[14]);
            ListaViajes[10].Lista.Add(ListaPasajeros[24]);
            ListaViajes[10].Lista.Add(ListaPasajeros[13]);
            ListaViajes[10].Lista.Add(ListaPasajeros[21]);


            ListaViajes[11].Lista.Add(ListaPasajeros[4]);
            ListaViajes[11].Lista.Add(ListaPasajeros[23]);
            ListaViajes[11].Lista.Add(ListaPasajeros[15]);

            ListaViajes[12].Lista.Add(ListaPasajeros[9]);
            ListaViajes[12].Lista.Add(ListaPasajeros[2]);
            ListaViajes[12].Lista.Add(ListaPasajeros[22]);
            ListaViajes[12].Lista.Add(ListaPasajeros[11]);

            ListaViajes[13].Lista.Add(ListaPasajeros[9]);
            ListaViajes[13].Lista.Add(ListaPasajeros[3]);
            ListaViajes[13].Lista.Add(ListaPasajeros[12]);

            ListaViajes[14].Lista.Add(ListaPasajeros[20]);
            ListaViajes[14].Lista.Add(ListaPasajeros[15]);
            ListaViajes[14].Lista.Add(ListaPasajeros[19]);
            ListaViajes[14].Lista.Add(ListaPasajeros[21]);

            ListaViajes[15].Lista.Add(ListaPasajeros[21]);
            ListaViajes[15].Lista.Add(ListaPasajeros[22]);
            ListaViajes[15].Lista.Add(ListaPasajeros[3]);

            ListaViajes[16].Lista.Add(ListaPasajeros[24]);
            ListaViajes[16].Lista.Add(ListaPasajeros[23]);
            ListaViajes[16].Lista.Add(ListaPasajeros[19]);

            ListaViajes[17].Lista.Add(ListaPasajeros[13]);
            ListaViajes[17].Lista.Add(ListaPasajeros[24]);
            ListaViajes[17].Lista.Add(ListaPasajeros[25]);

            ListaViajes[18].Lista.Add(ListaPasajeros[17]);
            ListaViajes[18].Lista.Add(ListaPasajeros[26]);
            ListaViajes[18].Lista.Add(ListaPasajeros[27]);

            ListaViajes[19].Lista.Add(ListaPasajeros[0]);
            ListaViajes[19].Lista.Add(ListaPasajeros[24]);
            ListaViajes[19].Lista.Add(ListaPasajeros[28]);
            ListaViajes[19].Lista.Add(ListaPasajeros[3]);

            ListaViajes[20].Lista.Add(ListaPasajeros[29]);
            ListaViajes[20].Lista.Add(ListaPasajeros[19]);
            ListaViajes[20].Lista.Add(ListaPasajeros[30]);
            ListaViajes[20].Lista.Add(ListaPasajeros[21]);

            ListaViajes[21].Lista.Add(ListaPasajeros[15]);
            ListaViajes[21].Lista.Add(ListaPasajeros[13]);
            ListaViajes[21].Lista.Add(ListaPasajeros[10]);
            ListaViajes[21].Lista.Add(ListaPasajeros[5]);

            ListaViajes[22].Lista.Add(ListaPasajeros[20]);
            ListaViajes[22].Lista.Add(ListaPasajeros[22]);
            ListaViajes[22].Lista.Add(ListaPasajeros[20]);

            ListaViajes[23].Lista.Add(ListaPasajeros[19]);
            ListaViajes[23].Lista.Add(ListaPasajeros[18]);
            ListaViajes[23].Lista.Add(ListaPasajeros[10]);

            ListaViajes[24].Lista.Add(ListaPasajeros[17]);
            ListaViajes[24].Lista.Add(ListaPasajeros[19]);
            ListaViajes[24].Lista.Add(ListaPasajeros[31]);

            ListaViajes[25].Lista.Add(ListaPasajeros[9]);
            ListaViajes[25].Lista.Add(ListaPasajeros[20]);
            ListaViajes[25].Lista.Add(ListaPasajeros[4]);
        }
    }


}
