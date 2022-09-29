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
        List<Viajes> lista;//Lista original de viajes
        List<Viajes> nuevaLista;//Lista auxiliar para filtrar los viajes.
        List<Pasajero> listaFilter;//Lista auxiliar para filtrar los pasajeros.

        public List<Viajes> NuevaLista { get => nuevaLista; set => nuevaLista = value; }
        public List<Pasajero> ListaFilter { get => listaFilter; set => listaFilter = value; }
        public List<Viajes> Lista { get => lista; set => lista = value; }
        #endregion

        public ListaPasajeros(List<Viajes> lista) 
        {
            this.Lista = lista;
            InitializeComponent();
        }
        
        #region #Eventos
        //Cuando carga el form cargamos el comboBoxViaje con las fechas de los viajes de la lista.
        private void ListaPasajeros_Load(object sender, EventArgs e)
        {         
            ComboViaje(Lista);
        }

        //Cuando el comboFecha selecciona un item usamos ese indice para obtener la fecha del viaje seleccionado
        //Se utiliza una nueva lista para guardar los viajes en caso de que haya mas de uno en la misma fecha 
        //Y le pasamos esa nueva lista al ComboCrucero
        private void cmbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCrucero.Items.Clear();
            cmBoxNombre.Items.Clear();
            DateTime fecha = Lista[cmbFecha.SelectedIndex].Fecha;
            NuevaLista = Viajes.filterViaje(fecha, Lista);
            ComboCrucero(NuevaLista);
        }
        //Cuando el ComboBoxNombre selecciona un item usamos el indice para buscar en la lista de pasajeros
        //y mostrar los datos del mismo
        private void cmBoxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.showPasajero(Lista[0].Lista[cmBoxNombre.SelectedIndex]);
        }
           
        //Cuando el comboBoxCrucero se selecciona usamos el indice para sacar de la lista de Viajes auxiliar la lista de pasajeros
        //que le vamos a pasar al ComboBoxNombre
        private void cmbCrucero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBoxNombre.Items.Clear();
            ListaFilter = NuevaLista[cmbCrucero.SelectedIndex].Lista;
            ComboNombre(ListaFilter);
            cmBoxNombre.Enabled = true;
            showDestino(NuevaLista[cmbCrucero.SelectedIndex].Destino);
        }
        #endregion


        #region #Metodos
        
        
        //Carga los datos del pasajero elegido en el comboBoxNombre 
        public void showPasajero(Pasajero p)
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

        public void showDestino(string d)
        {
            txtDestino.Text = d;
        }

        //Carga en el comboBox los nombres de la lista correspondiente a lo seleccionado por el usuario en los otros comboBoxes
        private void ComboNombre(List<Pasajero> l)
        {
            foreach(Pasajero p in l)
            {
                cmBoxNombre.Items.Add(p.Nombre);
            }
        }

        //Carga los nombres de los cruceros que partiaron en viaje en la fecha seleccionada en el comboBoxFecha
        private void ComboCrucero(List<Viajes> l)
        {
            foreach (Viajes v in l) 
            {
                cmbCrucero.Items.Add(v.Crucero.Nombre);
            }
            cmbCrucero.Enabled = true;
        }
        //Carga la fecha de los viajes disponibles en la lista
        private void ComboViaje(List<Viajes> l)
        {
            foreach (Viajes viaje in l)
            {
                cmbFecha.Items.Add(viaje.Fecha.ToShortDateString());                
            }
            for (int i = 0; i < cmbFecha.Items.Count - 1; i++)
            {
                if (cmbFecha.Items[i].ToString() == l[i].Fecha.ToShortDateString())
                {
                    cmbFecha.Items.RemoveAt(i);
                }
            }
        }

        #endregion
    }
}
