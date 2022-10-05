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
        private List<Crucero> listacruceros;
        private List<Viajes> lista;
        private bool v1;
        private bool v2;
        private bool v3;
        private bool v4;
        private bool v5;
        private bool v6;
        private bool v7;
        private bool v8;
        private bool v9;

        public List<Viajes> Lista { get => lista; set => lista = value; }
        public List<Crucero> Listacruceros { get => listacruceros; set => listacruceros = value; }
        public bool V1 { get => v1; set => v1 = value; }
        public bool V2 { get => v2; set => v2 = value; }
        public bool V3 { get => v3; set => v3 = value; }
        public bool V4 { get => v4; set => v4 = value; }
        public bool V5 { get => v5; set => v5 = value; }
        public bool V6 { get => v6; set => v6 = value; }
        public bool V7 { get => v7; set => v7 = value; }

        public Cruceros(List<Crucero> cruceros, List<Viajes> lista)
        {
            this.Listacruceros = cruceros;
            this.Lista = lista;
            InitializeComponent();
        }
        



        private void Cruceros_Load(object sender, EventArgs e)
        {
            cargarComboCrucero(Listacruceros);
        }

        private void cargarComboCrucero(List<Crucero> cruceros)
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
            txtNombre.Visible = true;
            label14.Visible = true;
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
            if (validarCampos()) MessageBox.Show("Crucero agregado a la lista");
            else
            {
                MessageBox.Show("Error. Intentelo de nuevo");
                foreach (var t in grpDatos.Controls)
                {
                    if (t is TextBox)
                    {
                        TextBox item = t as TextBox;
                        if (item.Name != "txtViajes"
                        && item.Name != "txtHoras"
                        && item.Name != "txtTurista"
                        && item.Name != "txtPremium") item.Enabled = true;
                        item.Text = "";
                    }

                }
            }
        }

        private bool validarCampos()
        {
            bool piscina;
            bool casino;
            bool cine;
            bool gimnasio;
            bool ok = true;
            if (txtMatricula.Text == ""
                || txtBodega.Text == ""
                || txtCamarotes.Text == ""
                || txtPasajeros.Text == ""
                || txtPiscina.Text == ""
                || txtGimnasio.Text == ""
                || txtCine.Text == ""
                || txtCasino.Text == ""
                || txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(button2, "Rellene todos los espacios correspondientes");
            } else if (v1 == true &&
                v2 == true && v3 == true &&
                v4 == true && v5 == true &&
                v6 == true && v7 == true &&
                v8 == true && v9 == true)
            {
                if (txtCasino.Text == "Si" || txtCasino.Text == "si") casino = true;
                else casino = false;
                if (txtPiscina.Text == "Si" || txtPiscina.Text == "si") piscina = true;
                else piscina = false;
                if (txtGimnasio.Text == "Si" || txtGimnasio.Text == "si") gimnasio = true;
                else gimnasio = false;
                if (txtCine.Text == "Si" || txtCine.Text == "si") cine = true;
                else cine = false;

                Crucero nuevo = new(txtMatricula.Text, txtNombre.Text, int.Parse(txtCamarotes.Text),
                 int.Parse(txtBodega.Text), int.Parse(txtPasajeros.Text), casino, gimnasio, cine, piscina);
                Listacruceros.Add(nuevo);
 
            }            
            return ok;
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

        private void txtMatricula_Validating(object sender, CancelEventArgs e)
        {
            string matricula = txtMatricula.Text;
            if (matricula.Length != 8)
            {
                errorProvider1.SetError(txtMatricula, "Ingrese un valor alfanumerico de 8 digitos");
                v1 = false;
            }
            else
            {
                v1 = true; errorProvider1.Clear();
            }

        }

        private void txtCamarotes_Validating(object sender, CancelEventArgs e)
        {
            int camarotes;
            bool esInt = int.TryParse(txtCamarotes.Text, out camarotes);
            
            if (!esInt || camarotes < 30)
            {
                errorProvider1.SetError(txtCamarotes, "Ingrese un numero entero que sea mayor a 30");
                v2 = false;
            }
            else
            {
                v2 = true; errorProvider1.Clear();
            }
        }

        private void txtBodega_Validating(object sender, CancelEventArgs e)
        {
            int bodega;
            bool esInt = int.TryParse(txtBodega.Text, out bodega);
            if (!esInt || bodega < 100)
            {
                errorProvider1.SetError(txtBodega, "Ingrese un numero entero que sea mayor a 1000");
                v3 = false;
            }
            else
            {
                v3 = true; errorProvider1.Clear();
            }
        }

        private void txtPasajeros_Validating(object sender, CancelEventArgs e)
        {
            int pasajeros;
            bool esInt = int.TryParse(txtPasajeros.Text, out pasajeros);
            if (!esInt || pasajeros < 100)
            {
                errorProvider1.SetError(txtPasajeros, "Ingrese un numero entero que sea mayor a 100");
                v4 = false;
            }
            else
            {
                v4 = true; errorProvider1.Clear();
            }
        }

        private void txtPiscina_Validating(object sender, CancelEventArgs e)
        {
            string piscina = txtPiscina.Text;
            if (piscina != "Si" && piscina != "si" && piscina != "No" && piscina != "no")
            {
                errorProvider1.SetError(txtPiscina, "Ingrese Si/si o No/no");
                v5 = false;
            }
            else
            {
                v5 = true; errorProvider1.Clear();
            }
        }

        private void txtGimnasio_Validating(object sender, CancelEventArgs e)
        {
            string gimnasio = txtGimnasio.Text;
            if (gimnasio != "Si" && gimnasio != "si" && gimnasio != "No" && gimnasio != "no")
            {
                errorProvider1.SetError(txtGimnasio, "Ingrese Si/si o No/no");
                v6 = false;
            }
            else
            {
                v6 = true; errorProvider1.Clear();
            }
        }

        private void txtCine_Validating(object sender, CancelEventArgs e)
        {
            string gimnasio =txtCine.Text;
            if (gimnasio != "Si" && gimnasio != "si" && gimnasio != "No" && gimnasio != "no") {
                errorProvider1.SetError(txtCine, "Ingrese Si/si o No/no"); v7 = false; }
            else
            {
                v7 = true; errorProvider1.Clear();
            }
        }

        private void txtCasino_TextChanged(object sender, EventArgs e)
        {
            string gimnasio = txtCasino.Text;
            if (gimnasio != "Si" && gimnasio != "si" && gimnasio != "No" && gimnasio != "no") 
            {
                errorProvider1.SetError(txtCasino, "Ingrese Si/si o No/no"); v8 = false;
            }
            else
            {
                v8 = true; errorProvider1.Clear();
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = txtNombre.Text;
            if (nombre.Length > 25)
            {
                errorProvider1.SetError(txtNombre, "Nombre demasiado largo"); v9 = false;
            }
            else
            {
                v9 = true; errorProvider1.Clear();
            }
        }
    }
}
