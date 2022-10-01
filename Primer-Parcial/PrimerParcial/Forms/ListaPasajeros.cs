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
    public partial class ListaPasajeros : Form
    {
        #region #atributos
        private List<Viajes> lista = new ();//Lista original de viajes
        private List<Viajes> nuevaLista = new();//Lista auxiliar para filtrar los viajes.
        private List<Pasajero> listaFilter = new();//Lista auxiliar para filtrar los pasajeros.

        public List<Viajes> NuevaLista { get => nuevaLista; set => nuevaLista = value; }
        public List<Pasajero> ListaFilter { get => listaFilter; set => listaFilter = value; }
        public List<Viajes> Lista { get => lista; set => lista = value; }
        #endregion

        public ListaPasajeros() 
        {
            InitializeComponent();
        }
        
        #region #Eventos
        //Cuando carga el form cargamos el comboBoxViaje con el nombre de los cruceros
        private void ListaPasajeros_Load(object sender, EventArgs e)
        {
            ComboCrucero(Lista);
        }


        private void cmbCrucero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFecha.Items.Clear();
             string c = ObtenerCrucero();
             ComboViaje(Lista, c);
            cmbFecha.Enabled = true;
        }

        private void cmbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBoxNombre.Items.Clear();
            string p = ObtenerFecha();
            string c = ObtenerCrucero();
            foreach (Viajes v in Lista)
            {
                DateTime f = v.FechaSalida;
                string fecha = f.ToShortDateString();
                if(fecha == p && v.Crucero.Nombre == c)
                {
                    showDestino(v.Destino.ToString());
                    ListaFilter = v.Lista;
                }
            }
           
            ComboNombre(ListaFilter);
            cmBoxNombre.Enabled = true;
        }

        private void cmBoxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = ObtenerPasajero();
            foreach(Pasajero p in ListaFilter )
            {
                if (p.Nombre == n) 
                {          
                    show(p);
                }            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbCrucero.SelectedItem != null && cmbFecha.SelectedItem != null) habilitarAdd();
            else MessageBox.Show("Primero debe seleccionar un viaje (Nombre del crucero y Fecha de salida)", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbCrucero_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitarAdd();
        }

        private void cmBoxNombre_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitarAdd();
        }

        private void cmbFecha_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitarAdd();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //VALIDAR DATOS PASAJERO
        }
        #endregion



        #region #Metodos

        public void inicializarLista(List<Viajes> lista)
        {
            this.Lista = lista;
        }
        //Carga los datos del pasajero elegido en el comboBoxNombre 
        protected virtual void show(Pasajero p)
        {
            txtNombre.Text = p.Nombre;
            txtGenero.Text = p.Genero;
            txtApellido.Text = p.Apellido;
            txtEdad.Text = p.Edad.ToString();
            txtDNI.Text = p.Dni.ToString();
            txtPais.Text = p.Pais;
            txtPasaporte.Text = p.Pasaporte.Tipo;
            txtEmision.Text = p.Pasaporte.Emision.ToShortDateString();
            txtVencimiento.Text = p.Pasaporte.Vencimiento.ToShortDateString();
            txtCodigoPas.Text = p.Pasaporte.Codigo;
            txtCodigoPais.Text = p.Pasaporte.CodigoPais.ToString();
            txtEquipaje.Text = p.Equipaje.ToString();
            if (p.BolsoDeMano) txtBolso.Text = "Si";
            else txtBolso.Text = "No";
            if (p.Premium) txtPremium.Text = "Si";
            else txtPremium.Text = "No";
            txtNacimiento.Text = p.Nacimiento.ToShortDateString();
        }

        protected virtual void showDestino(string d)
        {
            txtDestino.Text = d;
        }

        //Carga en el comboBox los nombres de la lista correspondiente a lo seleccionado por el usuario en los otros comboBoxes
        protected void ComboNombre(List<Pasajero> l)
        {
            foreach(Pasajero p in l)  cmBoxNombre.Items.Add(p.Nombre);                               
        }

        //Carga los nombres de los cruceros que partiaron en viaje en la fecha seleccionada en el comboBoxFecha
        private void ComboCrucero(List<Viajes> l)
        {
          foreach(Viajes c in l)
            {
                cmbCrucero.Items.Add(c.Crucero.Nombre);
            }
            for (int i= 0 ; i < cmbCrucero.Items.Count - 2; i++) 
            {
                for(int j = cmbCrucero.Items.Count - 1; j > i+1 ; j--)
                {
                    if (cmbCrucero.Items[i].ToString() == cmbCrucero.Items[j].ToString()) cmbCrucero.Items.RemoveAt(j);
                }
            }
        }

        //Carga la fecha de los viajes disponibles en la lista
        private void ComboViaje(List<Viajes> l, string crucero)
        {
            foreach(Viajes v in l)
            {
               if(v.Crucero.Nombre.ToString() == crucero)
                {
                    cmbFecha.Items.Add(v.FechaSalida.ToShortDateString());
                }
            }
        }

        private string ObtenerCrucero()
        {
            object NombreCrucero = cmbCrucero.SelectedItem;
            string nombre = Convert.ToString(NombreCrucero);
            return nombre;
        }

        private string ObtenerFecha()
        {
            object fecha = cmbFecha.SelectedItem;
            string f = Convert.ToString(fecha);
            return f;
        }

        private string ObtenerPasajero()
        {
            object NombrePasajero = cmBoxNombre.SelectedItem;
            string nombre = Convert.ToString(NombrePasajero);
            return nombre;
        }

        protected virtual void habilitarAdd()
        {
            btnValidar.Visible = true;
            btnValidar.Enabled = true;
            foreach (var t in grpDatos.Controls)
            {
                if (t is TextBox)
                {
                    TextBox text = t as TextBox;
                    text.Enabled = true;
                    text.Text = "";
                    if (text.Name == "txtEdad") text.BackColor = Color.Black;
                }
            }         
        }
        protected virtual void deshabilitarAdd()
        {
            btnValidar.Visible = false;
            btnValidar.Enabled = false;
            foreach(var t in grpDatos.Controls)
            {
                if(t is TextBox)
                {
                    TextBox text = t as TextBox;
                    text.Enabled = false;
                    if (text.Name == "txtEdad") text.BackColor = Color.White;
                }
            }
        }










        #endregion


    }
}
