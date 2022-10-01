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
    public partial class Cruceros : Form
    {
        private Crucero[] listacruceros;
        private List<Viajes> lista;

 
        public List<Viajes> Lista { get => lista; set => lista = value; }
        public Crucero[] Listacruceros { get => listacruceros; set => listacruceros = value; }

        public Cruceros(Crucero[] cruceros, List<Viajes> lista)
        {
            this.Listacruceros = cruceros;
            this.Lista = lista;
            InitializeComponent();
        }
        



        private void Cruceros_Load(object sender, EventArgs e)
        {
            cargarComboCrucero(Listacruceros);
        }

        private void cargarComboCrucero(Crucero[] cruceros)
        {
            foreach(Crucero c in cruceros)
            {
                cmbNombreCrucero.Items.Add(c.Nombre);
            }
        }

        

        private void cmbNombreCrucero_SelectedIndexChanged(object sender, EventArgs e)
        {
            Crucero seleccionado = Listacruceros[cmbNombreCrucero.SelectedIndex];
            showCrucero(seleccionado, Lista);
          
        }


        private void OcultarFormPanel(Form f)
        {
            foreach (Form t in panel1.Controls)
            {
                if (f.Text != t.Text) f.Hide();
            }
            AbrirFormEnUnPanel(f);
        }

        private void AbrirFormEnUnPanel(object formhija)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void showCrucero(Crucero c, List<Viajes> l)
        {
            txtMatricula.Text = c.Matricula;
            txtCamarotes.Text = c.Camarotes.ToString();
            txtPremium.Text = Viajes.CalcularCamarotesPremium(c).ToString();
            txtTurista.Text = Viajes.CalcularCamarotesTurista(c).ToString();
            txtBodega.Text = c.Bodega.ToString();
            txtPasajeros.Text = c.CapacidadPersonas.ToString();
            if (c.Piscina == true) txtPiscina.Text = "Si"; else txtPiscina.Text = "No";
            if (c.Gimnasio == true) txtGimnasio.Text = "Si"; else txtGimnasio.Text = "No";
            if (c.Cine == true) txtCine.Text = "Si"; else txtCine.Text = "No";
            if (c.Casino == true) txtCasino.Text = "Si"; else txtCasino.Text = "No";
            txtHoras.Text = c.CalcularHorasTotales(l).ToString();
            txtViajes.Text = c.CalcularViajesTotales(l).ToString();
            if (c.RutaFoto != "") pcbCrucero.Image = Image.FromFile(c.RutaFoto);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button2.Enabled = true;
            cmbNombreCrucero.Items.Clear();
            cmbNombreCrucero.Text = "";
            foreach(var t in grpDatos.Controls)
            {
                if(t is TextBox)
                {
                    TextBox item = t as TextBox;
                    if (item.Name != "txtViajes"
                    && item.Name != "txtHoras"
                    && item.Name != "txtTurista"
                    && item.Name != "txtPremium") item.Enabled = true;
                    else if (item.Name == "txtViajes"
                        || item.Name == "txtHoras"
                        || item.Name == "txtTurista"
                        || item.Name == "txtPremium") item.BackColor = Color.Black;

                    item.Text = "";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VALIDAR DATOS CRUCERO
        }



        private void cmbNombreCrucero_MouseDown(object sender, MouseEventArgs e)
        {
            if (cmbNombreCrucero.Text == "")
            {
                button2.Visible = false;
                button2.Enabled = false;
                cmbNombreCrucero.Items.Clear();
                cargarComboCrucero(this.listacruceros);

                foreach (var t in grpDatos.Controls)
                {
                    if (t is TextBox)
                    {
                        TextBox item = t as TextBox;
                        if (item.Name == "txtViajes"
                        || item.Name == "txtHoras"
                        || item.Name == "txtTurista"
                        || item.Name == "txtPremium") item.BackColor = Color.White;
                         
                        item.Enabled = false;
                    }

                }
            }
        }
    }
}
