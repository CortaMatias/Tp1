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
        private static Crucero[] cruceros = {
            new Crucero("BA – 1 – 000 – 18", "Libertad",5,1,100),
            new Crucero("BA – 2 – 001 – 19", "Felicidad",8,2,150),
            new Crucero("BA – 3 – 014 – 23", "Alegria",3,1,50),
            new Crucero("BA – 8 – 018 – 31", "Sorpresa", 10, 2, 200),
            new Crucero("BA – 15 – 032 – 44", "Peronito", 5,1,70),
            new Crucero("BA – 6 – 003 – 10","Pepito", 20, 3, 500),
            new Crucero("BA – 4 – 099 – 28", "Julio", 6,2,150)};
      
        
        public List<Viajes> ListaViajes { get => listaViajes; set => listaViajes = value; }
        public Crucero[] Cruceros { get => cruceros; set => cruceros = value; }

        Pasajero p1 = new Pasajero(50, true, true, "Mariano", "Carrazco", "Masculino",4534534, "ARG", new(1980,1,27), 
            new Pasaporte(new(2019,5,20), new(2022,4,20), "JLASKDJ32", 302, Tipo.Diplomatico.ToString()));    
        Pasajero p2 = new Pasajero(25, false, true, "Juan", "Alberto", "Masculino", 3834534, "PAR", new(1975, 6, 27),
            new Pasaporte(new(2022, 6, 25), new(2028, 6, 23), "ASDASD2", 305, Tipo.Oficial.ToString()));
        Pasajero p3 = new Pasajero(50, true, true, "Maria", "Sanchez", "Femenino", 4634534, "ARG", new(1995, 3, 28),
            new Pasaporte(new(2020, 5, 20), new(2024, 9, 28), "SSAADKDJ32", 302, Tipo.Ordinario.ToString()));


        Viajes v1 = new Viajes(destinos.Montevideo.ToString(),new(2022, 10, 28),cruceros[0],45,80 );
        Viajes v2 = new Viajes(destinos.Cartagena.ToString(), new(2022, 10, 28), cruceros[3], 90, 40);
        Viajes v3 = new Viajes(destinos.IslaDePascua.ToString(), new(2022, 8, 15), cruceros[5], 90, 40);
        Viajes v4 = new Viajes(destinos.Montevideo.ToString(), new(2022, 3, 6), cruceros[1], 90, 40);
        Viajes v5 = new Viajes(destinos.IslaDePascua.ToString(), new(2020, 9, 28), cruceros[5], 90, 40);
        Viajes v6 = new Viajes(destinos.Montevideo.ToString(), new(2020, 8, 9), cruceros[1], 90, 40);

        public Home()
        {
            InitializeComponent();
        }

        #region #Eventos
        private void Home_Load(object sender, EventArgs e)
        {
            panelHome fotos = new panelHome();
            OcultarFormPanel(fotos);
            label5.Text = fmrLogin.NombreUsuario;
            label2.ForeColor = Color.White;
            string date = DateTime.UtcNow.ToString("MM-dd-yy");
            label3.Text = $"Fecha: {date}";
            v1.Lista.Add(p1);
            v1.Lista.Add(p2);
            v2.Lista.Add(p1);
            v2.Lista.Add(p2);
            v3.Lista.Add(p1);
            v3.Lista.Add(p2);
            v3.Lista.Add(p3);
            v4.Lista.Add(p1);
            v4.Lista.Add(p2);
            v4.Lista.Add(p3);
            v4.Lista.Add(p1);
            v4.Lista.Add(p3);
            listaViajes.Add(v1);
            listaViajes.Add(v2);
            listaViajes.Add(v3);
            listaViajes.Add(v4);
            ListaViajes.Add(v5);
            ListaViajes.Add(v6);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Cruceros formCrucero = new Cruceros(cruceros, listaViajes);
            OcultarFormPanel(formCrucero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarViajes formViajes = new MostrarViajes();
            formViajes.inicializarLista(ListaViajes);
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

        private int clickX = 0, clickY = 0;

        private void pictureBox5_Click(object sender, EventArgs e)
        {

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
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListaPasajeros pasajeros = new ListaPasajeros();
            pasajeros.inicializarLista(ListaViajes);
            OcultarFormPanel(pasajeros);
        }
        #endregion


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

        private void OcultarFormPanel(Form f)
        {
            foreach(Form t in panel2.Controls)
            {
                if (f.Text != t.Text) f.Hide();
            }
            AbrirFormEnUnPanel(f);
        }

        #endregion
    }
}
