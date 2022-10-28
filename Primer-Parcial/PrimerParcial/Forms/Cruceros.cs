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

        public List<Viajes> Lista { get => lista; set => lista = value; }
        public List<Crucero> Listacruceros { get => listacruceros; set => listacruceros = value; }


        public Cruceros(List<Crucero> cruceros, List<Viajes> lista)
        {
            this.Listacruceros = cruceros;
            this.Lista = lista;
            InitializeComponent();
        }

        #region #Eventos
        private void Cruceros_Load(object sender, EventArgs e)
        {
            cargarComboCrucero(Listacruceros);
        }

        /// <summary>
        /// Evento que obtiene el Crucero seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNombreCrucero_SelectedIndexChanged(object sender, EventArgs e)
        {
            Crucero seleccionado = Listacruceros[cmbNombreCrucero.SelectedIndex];
            showCrucero(seleccionado, Lista);

        }

        /// <summary>
        /// Evento que habilita el formulario los componentes del formulario para ingresar un crucero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            button2.Visible = true;
            button2.Enabled = true;
            txtNombre.Visible = true;
            label14.Visible = true;
            txtPiscina.Enabled = true;
            txtCine.Enabled = true;
            txtGimnasio.Enabled = true;
            txtCasino.Enabled = true;
            txtPiscina.Items.Add("Si");
            txtPiscina.Items.Add("No");
            txtGimnasio.Items.Add("Si");
            txtGimnasio.Items.Add("No");
            txtCine.Items.Add("Si");
            txtCine.Items.Add("No");
            txtCasino.Items.Add("Si");
            txtCasino.Items.Add("No");
            cmbNombreCrucero.Items.Clear();
            cmbNombreCrucero.Text = "";
            foreach (var t in grpDatos.Controls)
            {
                if (t is TextBox)
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

        /// <summary>
        /// Evento que se activa al tocar el boton de validar que avisa si se pudo agregar el crucero o si hubo algun error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
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
                    }
                }
            }
        }

        /// <summary>
        /// Evento que desactiva los campos del formulario para agregar un crucero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    txtPiscina.Items.Clear();
                    txtGimnasio.Items.Clear();
                    txtCine.Items.Clear();
                    txtCasino.Items.Clear();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNombreCrucero_Click(object sender, EventArgs e)
        {
            txtCasino.Enabled = false;

            txtPiscina.Enabled = false;

            txtGimnasio.Enabled = false;

            txtCine.Enabled = false;
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !Char.IsNumber(e.KeyChar)) e.Handled = true;
        }

        private void txtCamarotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == '\b')) e.Handled = true;
        }

        private void txtPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == '\b')) e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b')) e.Handled = true;
        }

        private void txtCine_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCasino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtGimnasio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPiscina_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        #endregion

        #region #Metodos

        /// <summary>
        /// Carga en el comboBox los nombres de los cruceros
        /// </summary>
        /// <param name="cruceros"></param>
        private void cargarComboCrucero(List<Crucero> cruceros)
        {
            foreach (Crucero c in cruceros)
            {
                cmbNombreCrucero.Items.Add(c.Nombre);
            }
        }

        /// <summary>
        /// Muestra los datos de un crucero en los componentes del form
        /// </summary>
        /// <param name="c"></param>
        /// <param name="l"></param>
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
        }


        /// <summary>
        /// Valida los datos ingresados para agregar el crucero y si pasa las validaciones lo agrega a la lista
        /// </summary>
        /// <returns></returns>
        private bool validarCampos()
        {
            bool piscina = false;
            bool casino = false;
            bool cine = false;
            bool gimnasio = false;
            bool todoOk = true;
            foreach (var item in grpDatos.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = item as TextBox;
                    if (t.Name != "txtViajes" && t.Name != "txtHoras" && t.Name != "txtTurista" && t.Name != "txtPremium")
                    {
                        if (t.Text == "")
                        {
                            errorProvider1.SetError(t, "Rellene los campos correspondientes");
                            todoOk = false;
                        }
                        else
                        {
                            string s = t.Text;
                            if (t.Name == "txtCamarotes") if (int.Parse(t.Text) > 1000 || int.Parse(t.Text) < 10)
                                {
                                    errorProvider1.SetError(t, "Ingrese un numero de camarotes valido (entre 10 y 1000)");
                                    todoOk = false;
                                }
                            if (t.Name == "txtBodega") if (int.Parse(t.Text) > 40000 || int.Parse(t.Text) < 1000)
                                {
                                    todoOk = false;
                                    errorProvider1.SetError(t, "Ingrese un numero valido (entre 1000 y 40000)");
                                }

                            if (t.Name == "txtMatricula") if (s.Length != 10)
                                {
                                    todoOk = false;
                                    errorProvider1.SetError(t, "Ingrese un alfanumerico de 10 digitos");
                                }
                            if (t.Name == "txtPasajeros") if (int.Parse(t.Text) > 20000 || int.Parse(t.Text) < 50)
                                {
                                    todoOk = false;
                                    errorProvider1.SetError(t, "Ingrese un numero valido (entre 50 y 20000)");
                                }
                        }
                    }

                }
                if (item is ComboBox)
                {
                    ComboBox c = item as ComboBox;
                    if (c.SelectedItem == null)
                    {
                        errorProvider1.SetError(c, "Rellene los campos correspondientes");
                        todoOk = false;
                    }
                    else
                    {
                       if(c.Name == "txtCasino")
                        {
                            if (txtCasino.SelectedItem.ToString() == "Si") casino = true;
                            else casino = false;
                        }
                        
                       if(c.Name == "txtPiscina")
                        {
                            if (txtPiscina.SelectedItem.ToString() == "Si") piscina = true;
                            else piscina = false;
                        }
                      
                       if(c.Name == "txtGimnasio")
                        {
                            if (txtGimnasio.SelectedItem.ToString() == "Si") gimnasio = true;
                            else gimnasio = false;
                        }
                        
                       if(c.Name == "txtCine")
                        {
                            if (txtCine.SelectedItem.ToString() == "Si") cine = true;
                            else cine = false;
                        }
                        
                    }

                }

            }
            if (todoOk)
            {
                Crucero nuevo = new(txtMatricula.Text, txtNombre.Text, int.Parse(txtCamarotes.Text),
          int.Parse(txtBodega.Text), int.Parse(txtPasajeros.Text), casino, gimnasio, cine, piscina);
                Listacruceros.Add(nuevo);
            }
            return todoOk;
        }

        #endregion


    }
}
