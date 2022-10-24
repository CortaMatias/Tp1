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
        private List<Crucero> listaCruceros = new();

        public List<Viajes> NuevaLista { get => nuevaLista; set => nuevaLista = value; }
        public List<Pasajero> ListaFilter { get => listaFilter; set => listaFilter = value; }
        public List<Viajes> Lista { get => lista; set => lista = value; }
        public List<Crucero> ListaCruceros { get => listaCruceros; set => listaCruceros = value; }
        #endregion

        public ListaPasajeros() 
        {
            InitializeComponent();
        }
        
        #region #Eventos
        //Cuando carga el form cargamos el comboBoxViaje con el nombre de los cruceros
        private void ListaPasajeros_Load(object sender, EventArgs e)
        {
            txtEmision.Enabled = false;
            txtVencimiento.Enabled = false;
            txtEquipaje.Enabled = false;
            ComboCrucero(this.ListaCruceros);
        }


        protected  void cmbCrucero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFecha.Items.Clear();
             string c = ObtenerCrucero();
             ComboViaje(Lista, c);
            cmbFecha.Enabled = true;
        }

        protected void cmbFecha_SelectedIndexChanged(object sender, EventArgs e)
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
            for (int i = 0; i < cmbFecha.Items.Count - 2; i++)
            {
                for (int j = cmbFecha.Items.Count - 1; j > i; j--)
                {
                    if (cmbFecha.Items[i].ToString() == cmbFecha.Items[j].ToString()) cmbFecha.Items.RemoveAt(i);
                }
            }

            ComboNombre(ListaFilter);
            cmBoxNombre.Enabled = true;
        }

        private void cmBoxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBolso.Enabled = false;
            txtGenero.Enabled = false;
            txtNacimiento.Enabled = false;
            txtVencimiento.Enabled = false;
            txtEmision.Enabled = false;
            txtPremium.Enabled = false;
            txtPasaporte.Enabled = false;
            string n = ObtenerPasajero();
            foreach(Pasajero p in ListaFilter )
            {
                if (p.Nombre == n) 
                {          
                    show(p, Lista[0]);
                }            
            }
        }

        protected virtual void button2_Click(object sender, EventArgs e)
        {           
            cmBoxNombre.Text = "";    
            txtNacimiento.Value = DateTime.Today;
            txtVencimiento.Value = DateTime.Today;
            txtEmision.Value = DateTime.Today;
            txtBolso.Enabled = true;
            txtPasaporte.Enabled = true;
            txtPremium.Enabled = true;
            txtGenero.Enabled = true;
            txtNacimiento.Enabled = true;
            txtDestino.Enabled = false;

            if (cmbCrucero.SelectedItem != null && cmbFecha.SelectedItem != null)
            {
                DateTime fechaViaje;
                fechaViaje = DateTime.Parse(ObtenerFecha());
                if (fechaViaje > DateTime.Today)
                {
                    habilitarAdd();
                    MessageBox.Show("Para ver las caracteristicas del crucero dirijase a Info. Cruceros\n\n" +
                        "Para ver las caracteristicas, disponibilidad etc. del viaje dirijase a Info. Viajes\n\n" +
                        "Si los datos son validos el pasajero se agregara al viaje seleccionado");
                }
                else MessageBox.Show("No puede agregar pasajeros a un viaje que ya salio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else MessageBox.Show("Primero debe seleccionar un viaje (Nombre del crucero y Fecha de salida)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected virtual void cmbCrucero_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitarAdd();
        }

        protected virtual void cmBoxNombre_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitarAdd();
        }

        protected virtual void cmbFecha_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitarAdd();
        }

        protected virtual void btnValidar_Click(object sender, EventArgs e)
        {  
            if (Validar())
            {
                MessageBox.Show("Pasajero agregado con exito");
            }
            else MessageBox.Show("Error al agregar pasajero.");
        }

        protected virtual void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nombre = txtNombre.Text;
            IngresarString(e, nombre);

        }

        protected virtual void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = txtApellido.Text;
            IngresarString(e, s);
        }

        protected virtual void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = txtPais.Text;
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsLower(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        protected virtual void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = txtDNI.Text;
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == '\b')) e.Handled = true;
        }

        protected virtual void txtEquipaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = txtEquipaje.Text;
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == '\b')) e.Handled = true;
        }

        protected virtual void txtCodigoPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = txtCodigoPais.Text;
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == '\b')) e.Handled = true;
        }

        protected virtual void txtCodigoPas_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = txtCodigoPais.Text;

            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == '\b') && (!Char.IsLetter(e.KeyChar))) e.Handled = true;
        }

        protected virtual void txtPremium_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEquipaje.Enabled = true;
        }

        protected virtual void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        protected virtual void txtPasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        protected virtual void txtPremium_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        protected virtual void txtNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtEmision.Enabled = true;
        }

        protected virtual void  txtEmision_ValueChanged(object sender, EventArgs e)
        {
            txtVencimiento.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrupoFamiliar formFamilia = new(Lista);
            formFamilia.Show();
        }
        #endregion



        #region #Metodos

        public void inicializarLista(List<Viajes> lista, List<Crucero> listaCruceros)
        {
            this.Lista = lista;
            this.ListaCruceros = listaCruceros;


        }
        //Carga los datos del pasajero elegido en el comboBoxNombre 
        protected virtual void show(Pasajero p, Viajes v)
        {
            txtNombre.Text = p.Nombre;
            txtGenero.Text = p.Genero;
            txtApellido.Text = p.Apellido;
            txtEdad.Text = p.Edad.ToString();
            txtDNI.Text = p.Dni.ToString();
            txtPais.Text = p.Pais;
            txtPasaporte.Text = p.Pasaporte.Tipo.ToString();
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
        private void ComboCrucero(List<Crucero> l)
        {
          foreach(Crucero c in l)
            {
                cmbCrucero.Items.Add(c.Nombre);
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
            txtGenero.Items.Clear();
            txtPasaporte.Items.Clear();
            txtBolso.Items.Clear();
            txtGenero.Text = "";
            txtPasaporte.Text = "";
            txtBolso.Text = "";
            txtPremium.Items.Add("Si");
            txtPremium.Items.Add("No");
            txtBolso.Items.Add("Si");
            txtBolso.Items.Add("No");
            txtPasaporte.Items.Add(Tipo.Diplomatico.ToString());
            txtPasaporte.Items.Add(Tipo.Oficial.ToString());
            txtPasaporte.Items.Add(Tipo.Ordinario.ToString());
            txtGenero.Items.Add("Masculino");
            txtGenero.Items.Add("Femenino");
            txtGenero.Items.Add("No binario");
            btnValidar.Visible = true;
            btnValidar.Enabled = true;
            helpProvider1.SetHelpString(txtEquipaje, "Para rellenar este campo complete primero el campo Premium");

            foreach (var t in grpDatos.Controls)
            {
                if (t is TextBox)
                {
                    TextBox text = t as TextBox;
                    text.Enabled = true;
                    if(text.Name != "txtDestino")text.Text = "";
                    if (text.Name == "txtEdad")
                    {
                        text.Enabled = false;                             
                        text.BackColor = Color.Black;
                    }
                    if (text.Name == "txtEquipaje" || text.Name == "txtDestino") text.Enabled = false;
                }
            }         
        }
     
        protected virtual void deshabilitarAdd()
        {

            errorProvider1.Clear();
            btnValidar.Visible = false;
            btnValidar.Enabled = false;
            foreach (var t in grpDatos.Controls)
            {
                if (t is TextBox)
                {
                    TextBox text = t as TextBox;
                    text.Enabled = false;
                    if (text.Name == "txtEdad") text.BackColor = Color.White;
                }
                txtNacimiento.Enabled = false;
                txtVencimiento.Enabled = false;
                txtEmision.Enabled = false;
            }
            txtBolso.Items.Clear();
        }


        private Pasajero AddPasajero(string n, string ap, string pais, string genero, string dni,
           string equipaje, string cp, DateTime nacimiento,
            string pasa, string pc, string b, DateTime pe, DateTime pv, string tipoPasajero , Viajes v)
        {
            bool premium;
            bool bolsoMano;
            if (tipoPasajero == "Si") premium = true;
            else premium = false;
            if (b == "Si") bolsoMano = true;
            else bolsoMano = false;

            Pasajero nuevo = new(int.Parse(equipaje),premium, bolsoMano,n,ap,genero,dni,pais, nacimiento, new Pasaporte(pv,pe,pc,int.Parse(cp), tipoPasajero));
            return nuevo;
        }

        protected virtual bool Validar()
        {
            errorProvider1.Clear();
            bool todoOk = true;
            bool todoOkCombo = true;
            bool todoOkText = true;
            bool todoOkDateTime = true;
            DateTime fecha = DateTime.Today;
            foreach (var item in grpDatos.Controls)
            {
                if(item is ComboBox)
                {
                    ComboBox c = item as ComboBox;
                    todoOkCombo = ValidarComboBox(c);
                }
                else if(item is TextBox)
                {
                    TextBox t = item as TextBox;
                    todoOkText = ValidarTextBox(t);
                } 
                else if(item is DateTimePicker)
                {
                    DateTimePicker d = item as DateTimePicker;
                    todoOkDateTime = ValidarDateTime(d);
                }   
                if(!todoOkCombo || !todoOkDateTime || !todoOkText)
                {
                    todoOk = false;
                }
            }    
            
            if (todoOk)
            {
                errorProvider1.Clear();
                Viajes v = obtenerViaje();
                Pasajero nuevo = AddPasajero(txtNombre.Text, txtApellido.Text, txtPais.Text, txtGenero.SelectedItem.ToString(),
                    txtDNI.Text, txtEquipaje.Text, txtCodigoPais.Text, txtNacimiento.Value, txtPremium.SelectedItem.ToString(),
                    txtCodigoPas.Text, txtBolso.SelectedItem.ToString(), txtEmision.Value, txtVencimiento.Value, txtPasaporte.SelectedItem.ToString(), v);
 
                float precio = v.CalcularPrecioViaje(nuevo);
                if(MessageBox.Show($"El precio total del viaje sera {precio}USD, ¿Desea confirmar la compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    v.Lista.Add(nuevo);
                    todoOk = true;
                }else
                {
                    MessageBox.Show("Se ha cencelado la compra");
                }                                                      
            }
            return todoOk;
        }

        
        
        protected Viajes obtenerViaje()
        {
            string nombre = cmbCrucero.SelectedItem.ToString();
            string  fecha = cmbFecha.SelectedItem.ToString();
            DateTime f = DateTime.Parse(fecha);
            Viajes viaje = null;
            foreach(Viajes v in Lista)
            {
                if (v.Crucero.Nombre == nombre && v.FechaSalida == f)
                { 
                    viaje = v;
                    break;
                }
            }
            return viaje;
        }

        public void IngresarString(KeyPressEventArgs e, string s)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        protected virtual bool ValidarDateTime(DateTimePicker d)
        {
            bool todoOk = true;

                if (d.Value == DateTime.Today)
                {
                    errorProvider1.SetError(d, "Rellene los campos correspondientes");
                    todoOk = false;
                }
                else if (d.Name == "txtNacimiento" || d.Name == "txtEmision")
                {
                    if (d.Value < new DateTime(1910 / 1 / 1) || d.Value >= DateTime.Today)
                    {
                        errorProvider1.SetError(d, "Fecha Incorrecta. (De 1910 en adelante y de la fecha actual para atras.)");
                        todoOk = false;

                        if (txtEmision.Value < txtNacimiento.Value)
                        {
                            errorProvider1.SetError(d, "Fecha Incorrecta. (La fecha de emision del pasaporte debe ser mas actual que la del nacimiento)");
                            todoOk = false;
                        }
                    }
                }
                else if (d.Name == "txtVencimiento")
                {
                    d.Enabled = false;
                    if (txtEmision.Value > txtNacimiento.Value) d.Enabled = true;

                    if (d.Value < txtEmision.Value)
                    {
                        errorProvider1.SetError(d, "Fecha Incorrecta. (La fecha de vencimiento debe ser mas grande que la de emision");
                        todoOk = false;
                    }
                    if (d.Value < DateTime.Today)
                    {
                        todoOk = false;
                        errorProvider1.SetError(d, "Fecha incorrecta. El pasaporte no puede estar vencido");
                    }
                }           
            return todoOk;
        }

        protected virtual bool ValidarComboBox(ComboBox c)
        {
            bool todoOk = true;
 
                if (c.SelectedItem == null)
                {
                    errorProvider1.SetError(c, "Rellene los campos correspondientes");
                    todoOk = false;
                }
                else
                {
                    Viajes viaje = obtenerViaje();
                    int capacidad = viaje.CalcularDisponibilidad();
                    if (capacidad < 1)
                    {
                        todoOk = false;
                        errorProvider1.SetError(btnValidar, "No queda espacio disponible en el crucero");
                    }
                    if (txtPremium.SelectedItem.ToString() == "Si")
                    {
                        int premium = viaje.calcularDisponibilidadPremium();
                        if (premium < 1)
                        {
                            todoOk = false;
                            errorProvider1.SetError(btnValidar, "No queda espacio disponible en los camarotes Premium");
                        }
                        else
                        {
                            int turista = viaje.CalcularDisponibilidadTurista();
                            if (turista < 1)
                            {
                                todoOk = false;
                                errorProvider1.SetError(btnValidar, "No queda espacio disponible en los camarotes Turistas");
                            }
                        }
                    }
                }           
            return todoOk;
        }


        protected virtual bool ValidarTextBox(TextBox t)
        {
            bool todoOk = true;

                if (t.Name != "txtEdad" && t.Name != "textBox1" && t.Name != "textBox2")
                {
                    if (t.Text == "")
                    {
                        errorProvider1.SetError(t, "Rellene los campos correspondientes");
                        todoOk = false;
                    }
                    else
                    {
                        Viajes viaje = obtenerViaje();
                        int equipaje;
                        bool pudo = int.TryParse(txtEquipaje.Text, out equipaje);
                        if (!pudo)
                        {
                            todoOk = false;
                            errorProvider1.SetError(txtEquipaje, "Rellene todos los campos correspondientes");
                        }

                        int bodega = viaje.CalcularEspacioBodega();
                        if (bodega < equipaje)
                        {
                            todoOk = false;
                            errorProvider1.SetError(btnValidar, "No queda espacio disponible en la bodega");
                        }

                        if (t.Name == "txtNombre" || t.Name == "txtApellido")
                        {
                            string s = t.Text;
                            if (s.Length > 25 || s.Length < 2)
                            {
                                errorProvider1.SetError(t, "El nombre y el Apellido Debe contener entre 2 y 25 caracteres");
                                todoOk = false;
                            }

                        }
                        else if (t.Name == "txtPais")
                        {
                            string s = t.Text;
                            if (s.Length != 3)
                            {
                                errorProvider1.SetError(txtPais, "Debe contener 3 digitos");
                                todoOk = false;
                            }
                        }
                        else if (t.Name == "txtDNI" || t.Name == "txtCodigoPas")
                        {
                            string s = t.Text;
                            if (s.Length != 8 && s.Length != 7)
                            {
                                errorProvider1.SetError(t, "Debe contener 7 u 8 caracteres");
                                todoOk = false;
                            }
                        }
                        else if (t.Name == "txtEquipaje")
                        {
                            if (t.Text == "")
                            {
                                errorProvider1.SetError(txtEquipaje, "Para poder rellenar este campo primero elija si sera Premium o no");
                            }
                            else
                            {
                                if (txtPremium.SelectedItem.ToString() == "Si")
                                {
                                    if (int.Parse(t.Text) > 50 || int.Parse(t.Text) < 0)
                                    {
                                        todoOk = false;
                                        errorProvider1.SetError(t, "EL peso del equipaje para pasajero Premium puede ser entre 0 y 50");
                                    }
                                }
                                if (txtPremium.SelectedItem.ToString() == "No")
                                {
                                    if (int.Parse(t.Text) > 25 || int.Parse(t.Text) < 0)
                                    {
                                        todoOk = false;
                                        errorProvider1.SetError(t, "El peso del equipaje para pasajero Turista puede ser entre 0 y 25");
                                    }
                                }
                            }
                        }
                    }
                }           
            return todoOk;
        }

        #endregion

       
    }
}
