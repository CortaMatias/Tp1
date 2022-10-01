using PrimerParcial.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.Forms
{
    public partial class Historial : Form
    {
        private List<Viajes> lista;

        public List<Viajes> Lista { get => lista; set => lista = value; }

        public Historial(List<Viajes> lista)
        {
            this.Lista = lista;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Historial_Load(object sender, EventArgs e)
        {
            string destinos = "Destinos x Facturacion";
            string pasajeros = "Pasajeros frecuentes";
            string todos = "Todos los pasajeros";
            string elegido = "Destino mas elegido";
            comboFiltro.Items.Add(destinos);
            comboFiltro.Items.Add(elegido);
            comboFiltro.Items.Add(pasajeros);
            comboFiltro.Items.Add(todos);
        }

        private void comboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFiltro.SelectedItem.ToString() == "Todos los pasajeros")
                mostrarPasajeros();
            else if (comboFiltro.SelectedItem.ToString() == "Destinos x Facturacion") { }
            else if (comboFiltro.SelectedItem.ToString() == "Destino mas elegido") 
            {
                listDatos.Items.Clear();
                listDatos.Items.Add(DestinoMasElegido());
            }                      
        }

        private void comboFiltro_MouseClick(object sender, MouseEventArgs e)
        {
            listDatos.Items.Clear();
        }


        public string DestinoMasElegido()
        {
            StringBuilder sb = new();
            destinos maximoValorKey;
            int veces = 0;
            Dictionary<destinos, int> destino = new Dictionary<destinos, int>();           
            foreach (var i in Enum.GetValues(typeof(destinos)))
            {
                destino.Add((destinos)i, 0);
                foreach (Viajes v in Lista)
                    if (v.Destino == i.ToString()) destino[(destinos)i]++;
                    else destino[(destinos)i] = 1;
            }
            maximoValorKey = destino.OrderByDescending(x => x.Value).First().Key;
            veces = destino.OrderByDescending(x => x.Value).First().Value;
            sb.Append($"El destino mas elegido es  {maximoValorKey.ToString()} y se eligio {veces} veces");
            return sb.ToString();
        }



        private void mostrarPasajeros()
        {
            grpFiltrarPasajeros.Visible = true;
            grpFiltrarPasajeros.Enabled = true;
            foreach (Viajes v in Lista)
                foreach (Pasajero p in v.Lista)
                {
                    listDatos.Items.Add($" Dni: {p.Dni}   Nombre : {p.Nombre}");
                }

            for (int i = 0; i < listDatos.Items.Count - 2; i++)
            {
                for (int j = listDatos.Items.Count - 1; j > i; j--)
                {
                    if (listDatos.Items[i].ToString() == listDatos.Items[j].ToString()) listDatos.Items.RemoveAt(j);
                }
            }
        }
    }
}
