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
    public partial class MostrarViajes : ListaPasajeros
    {
       

        public MostrarViajes()
        {
            InitializeComponent();
        }

        protected override void button2_Click(object sender, EventArgs e)
        {
            this.habilitarAdd();
        }


        protected override void deshabilitarAdd()
        {
            foreach(var item in grpDatos.Controls)
            {
                if (item is TextBox)
                {
                    TextBox i = item as TextBox;
                    i.BackColor = Color.White;
                }              
                if(item is ComboBox)
                {
                    ComboBox t = item as ComboBox;
                    t.BackColor = Color.White;
                }
            }
            txtNacimiento.Enabled = false;
            txtEmision.Enabled = false;
        }

        protected override bool Validar()
        {
            bool todoOk = true;
            string crucero = txtNombre.Text;
            int destino;
            DateTime fecha = txtNacimiento.Value;
            
            
            if(txtNacimiento.Value == DateTime.Today)
            {
                todoOk = false;
                errorProvider1.SetError(txtNacimiento, "Elija una fecha que no sea la actual.");
            }
            else
            {              
                DateTime salida = txtNacimiento.Value;

            }
            if (crucero == "")
            {
                todoOk = false;
                errorProvider1.SetError(txtNombre, "Rellene los campos correspondientes");
            }
            else 
            {
       
                if (!cmbCrucero.Items.Contains(crucero))
                {
                    todoOk = false;
                    errorProvider1.SetError(txtNombre, "No hay ningun Crucero con ese nombre");
                }
                    
            }
            if (txtPasaporte.SelectedIndex == -1)
            {
                todoOk = false;
                errorProvider1.SetError(txtPasaporte, "Seleccione un destino");
                destino = 0;
            }
            else destino = txtPasaporte.SelectedIndex -1;

            todoOk =  ValidarFecha(fecha,crucero, destino);

            return todoOk;
        }


        private bool ValidarFecha(DateTime fecha, string crucero,int  destino)
        {
            bool valida = true;

            if (fecha == DateTime.Today)
            {
                valida = false;
                errorProvider1.SetError(txtNacimiento, "Seleccione una fecha que no sea la actual");
            }
            else
            {
                foreach (Viajes v in base.Lista)
                {
                    if (v.Crucero.Nombre == crucero && v.FechaSalida == fecha)
                    {
                        valida = false;
                        errorProvider1.SetError(btnValidar, "Ya existe un viaje con este crucero en esa fecha.");
                    }
                    else if (v.Crucero.Nombre == crucero)
                    {
                        DateTime fechaFut;
                        DateTime fechaPas;
                        DateTime fechaSalidaViajeProgramado = v.FechaSalida;
                        if (destino < 11)
                        {
                            fechaPas = fechaSalidaViajeProgramado.AddDays(-15);
                            fechaFut = fechaSalidaViajeProgramado.AddDays(15);
                        }
                        else
                        {
                            fechaPas = fechaSalidaViajeProgramado.AddDays(-30);
                            fechaFut = fechaSalidaViajeProgramado.AddDays(30);
                        }
                        if (fechaSalidaViajeProgramado > fechaPas && fechaSalidaViajeProgramado < fechaFut)
                        {
                            errorProvider1.SetError(txtNacimiento, "El crucero no esta disponible en esa fecha.");
                        }
                    }

                }
            }
            return valida;
        }


        protected override void habilitarAdd()
        {
            //destino, fecha salida, crucero 
            txtPasaporte.Items.Clear();
            btnValidar.Enabled = true;
            btnValidar.Visible = true;
            txtNombre.Enabled = true;
            txtNacimiento.Enabled = true;
            txtDestino.Enabled = true;
            foreach (var item in grpDatos.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = item as TextBox;
                    if (t.Name != "txtNombre")
                    {
                        t.BackColor = Color.Black;
                        t.Enabled = false;
                        t.Text = "";
                    }
                    else t.Text = "";
                }
                if(item is ComboBox)
                {
                    ComboBox c = item as ComboBox;
                    if (c.Name != "txtPasaporte")
                    {
                        c.Enabled = false;
                        c.Text = "";
                        c.BackColor = Color.Black;
                    }
                    else
                    {
                        c.Enabled = true;
                        c.Text = "";
                    }
                }
                if(item is DateTimePicker)
                {
                    DateTimePicker d = item as DateTimePicker;
                    if(d.Name != "txtNacimiento")
                    {
                        d.Value = DateTime.Today;
                        d.Enabled = false;
                    }
                }             
            }
            txtNacimiento.Value = DateTime.Today;
            foreach (var i in Enum.GetValues(typeof(destinos)))
            {
                txtPasaporte.Items.Add(i);
            }
        }



        protected void Show(Viajes v)
        {
            string crucero = cmbCrucero.SelectedItem.ToString();
            string fecha = cmbFecha.SelectedItem.ToString();

            if (v.Crucero.Nombre == crucero && v.FechaSalida == DateTime.Parse(fecha))
            {
                string piscina;
                string cine;
                string gimnasio;
                string casino;
                if (v.Crucero.Piscina) piscina = "Si"; else piscina = "No";
                if (v.Crucero.Cine) cine = "Si"; else cine = "No";
                if (v.Crucero.Gimnasio) gimnasio = "Si"; else gimnasio= "No";
                if (v.Crucero.Casino) casino = "Si"; else casino = "No";
                txtNombre.Text = v.Crucero.Nombre;
                txtApellido.Text = v.Partida;
                txtPais.Text = v.Crucero.Camarotes.ToString();
                txtEdad.Text = v.CalcularDisponibilidadTurista().ToString();
                textBox1.Text = v.calcularDisponibilidadPremium().ToString();
                txtEquipaje.Text = v.CalcularDisponibilidad().ToString();
                txtCodigoPais.Text = v.DuracionViaje.ToString();
                txtNacimiento.Text = v.FechaSalida.ToShortDateString(); 
                txtCodigoPas.Text = v.CalcularPasajeroPremium().ToString() + " Pasajeros";
                textBox2.Text = v.Crucero.CapacidadPersonas.ToString() + " Pasajeros";
                txtEmision.Text = v.FechaRegreso.ToShortDateString();
                txtDNI.Text = v.CalcularPasajeroTurista().ToString() + " Pasajeros";
                txtGenero.Text = piscina;
                txtBolso.Text = cine;
                txtDestino.Text = gimnasio;
                txtPremium.Text = casino;                       
            }
        }

        protected override void showDestino(string d)
        {
            txtPasaporte.Text = d;
        }

        protected override void cmbFecha_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitarAdd();
        }

        protected override void cmbCrucero_MouseClick(object sender, MouseEventArgs e)
        {
            deshabilitarAdd();
        }

        protected  void cmbFecha_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Viajes v = this.obtenerViaje();
            Show(v);
        }

        protected override void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar) || (e.KeyChar == '\b')) { }      
            else e.Handled = true;
        }

        protected override void btnValidar_Click(object sender, EventArgs e)
        {
           bool valido = Validar();
        }

        private void MostrarViajes_Load(object sender, EventArgs e)
        {

        }
    }
}
