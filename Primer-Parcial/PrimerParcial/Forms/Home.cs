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
    public partial class Home : Form
    {

        private List<Viajes> listaViajes = new List<Viajes>();       
        private  List<Crucero> listaCruceros = new();
     

        public List<Crucero> ListaCruceros { get => listaCruceros; set => listaCruceros = value; }
        public List<Viajes> ListaViajes { get => listaViajes; set => listaViajes = value; }

        public Home()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            ListaViajes = Hardcodeo.ListaViajes;
            ListaCruceros = Hardcodeo.ListaCruceros;
            InitializeComponent();
        }
      
        #region #Metodos
        private void AbrirFormEnUnPanel(object formhija)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }

        internal void OcultarFormPanel(Form f)
        {
            foreach(Form t in panel2.Controls)
            {
                if (f.Text != t.Text) f.Hide();
            }
            AbrirFormEnUnPanel(f);
        }

        #endregion

        #region #Eventos

        private void Home_Load(object sender, EventArgs e)
        {
            panelHome fotos = new panelHome();
            OcultarFormPanel(fotos);
            label5.Text = fmrLogin.NombreUsuario;
            label2.ForeColor = Color.White;
            string date = DateTime.UtcNow.ToString("MM-dd-yy");
            label3.Text = $"Fecha: {date}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cruceros formCrucero = new Cruceros(ListaCruceros, listaViajes);
            OcultarFormPanel(formCrucero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarViajes formViajes = new MostrarViajes();
            formViajes.inicializarLista(ListaViajes, ListaCruceros);
            OcultarFormPanel(formViajes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelHome fotos = new panelHome();
            OcultarFormPanel(fotos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Historial formHistorial = new Historial(ListaViajes);
            OcultarFormPanel(formHistorial);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListaPasajeros pasajeros = new ListaPasajeros();
            pasajeros.inicializarLista(ListaViajes, ListaCruceros);
            OcultarFormPanel(pasajeros);
        }

        private int clickX = 0, clickY = 0;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        //Permite arrastrar el formulario apretando sobre el panel
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                clickX = e.X;
                clickY = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - clickX);
                this.Top = this.Top + (e.Y - clickY);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la aplicacion?", "Cerrar aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Se cancelo el cierre de la aplicacion");
            }

        }


        #endregion
    }
}
