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
    public partial class GrupoFamiliar : Form
    {
        private List<Viajes> lista;
        public List<Viajes> Lista { get => lista; set => lista = value; }
        public GrupoFamiliar(List<Viajes> listaViajes)
        {
            this.Lista = listaViajes;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaViajes.Items.Clear();
            bool todoOk = true;
            bool casino = false;
            bool piscina = false;
            bool gimnasio = false;
            bool cine = false;
            List<Viajes> lista;
            if (checkCasino.Checked) casino = true;
            if (checkCine.Checked) cine = true;
            if (checkGimnasio.Checked) gimnasio = true;
            if (checkPiscina.Checked) piscina = true;
            if (txtCantidad.Text == "")
            {
                errorProvider1.SetError(txtCantidad, "Ingrese la cantidad de personas del grupo familiar.");
                todoOk = false;
            }
            else if(todoOk) 
            {
                MessageBox.Show("Los viajes que aparezcan en la lista seran aquellos que cumplen con los requisitos ingresados.");
                lista = obtenerViajes(this.Lista);
                foreach (Viajes v in lista)
                {
                    cargarListBox(v, piscina, casino, gimnasio, cine);
                }
                if (listaViajes.Items.Count == 0) listaViajes.Items.Add("No se encontraron viajes disponibles con esos requisitos");
            }
        }

        private List<Viajes> obtenerViajes(List<Viajes> l)
        {
            List<Viajes> aux = new();
            int disponibilidad = 0;
            int personas = int.Parse(txtCantidad.Text);
            foreach (Viajes v in l)
            {
                if (v.FechaSalida > DateTime.Today)
                {
                    disponibilidad = v.CalcularDisponibilidad();
                    if (disponibilidad > personas)
                    {
                        aux.Add(v);
                    }
                }               
            }
            return aux;
        }

        private void cargarListBox(Viajes v, bool piscina, bool casino, bool gimnasio, bool cine)
        {
            if (v.Crucero.Piscina == piscina && v.Crucero.Casino == casino && v.Crucero.Gimnasio == gimnasio && v.Crucero.Cine == cine)
            {
                listaViajes.Items.Add($"Nombre Crucero:{v.Crucero.Nombre}  Fecha de salida: {v.FechaSalida}  Disponibilidad:{v.CalcularDisponibilidad()} ");
            }
        }


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == '\b')) e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new();
            ListaPasajeros formPasajeros = new();
            home.Show();
            home.OcultarFormPanel(formPasajeros);
        }

        private void eliminarRepetidos()
        {
            for (int i = 0; i < listaViajes.Items.Count - 2; i++)
            {
                for (int j = listaViajes.Items.Count - 1; j > i; j--)
                {
                    if (listaViajes.Items[i].ToString() == listaViajes.Items[j].ToString()) listaViajes.Items.RemoveAt(j);
                }
            }
        }

        private void GrupoFamiliar_Load(object sender, EventArgs e)
        {
           
        }
    }
}




     
    

