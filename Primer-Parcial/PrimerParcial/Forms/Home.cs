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
        public List<Viajes> ListaViajes { get => listaViajes; set => listaViajes = value; }
        public Crucero[] Cruceros { get => cruceros; set => cruceros = value; }

        Pasajero p1 = new Pasajero(50, true, true, "Mariano", "Carrazco", "Masculino",4534534, "ARG", new(1980,1,27), 
            new Pasaporte(new(2019,5,20), new(2022,4,20), "JLASKDJ32", 302, Tipo.Diplomatico.ToString()));    
        Pasajero p2 = new Pasajero(25, false, true, "Juan", "Alberto", "Masculino", 3834534, "PAR", new(1975, 6, 27),
            new Pasaporte(new(2022, 6, 25), new(2028, 6, 23), "ASDASD2", 305, Tipo.Oficial.ToString()));
        Pasajero p3 = new Pasajero(50, true, true, "Maria", "Sanchez", "Femenino", 4634534, "ARG", new(1995, 3, 28),
            new Pasaporte(new(2020, 5, 20), new(2024, 9, 28), "SSAADKDJ32", 302, Tipo.Ordinario.ToString()));


        Viajes v1 = new Viajes(regional.Montevideo.ToString(),new(2022, 10, 28),cruceros[0],45,80, 75);
        Viajes v2 = new Viajes(regional.Cartagena.ToString(), new(2022, 10, 28), cruceros[3], 90, 40, 60);
        Viajes v3 = new Viajes(regional.IslaDePascua.ToString(), new(2022, 8, 15), cruceros[5], 90, 40, 60);
        Viajes v4 = new Viajes(regional.Montevideo.ToString(), new(2022, 3, 6), cruceros[1], 90, 40, 60);


        private static Crucero[] cruceros = {
            new Crucero("BA – 1 – 000 – 18", "Libertad",5,1,100),
            new Crucero("BA – 2 – 001 – 19", "Felicidad",8,2,150),
            new Crucero("BA – 3 – 014 – 23", "Alegria",3,1,50),
            new Crucero("BA – 8 – 018 – 31", "Sorpresa", 10, 2, 200),
            new Crucero("BA – 15 – 032 – 44", "Peronito", 5,1,70),
            new Crucero("BA – 6 – 003 – 10","Pepito", 20, 3, 500),
            new Crucero("BA – 4 – 099 – 28", "Julio", 6,2,150)};
       
        public Home()
        {
            InitializeComponent();
        } 

        private void Home_Load(object sender, EventArgs e)
        {
            label2.Text = fmrLogin.NombreUsuario;
            label2.ForeColor = Color.White;
            string date = DateTime.UtcNow.ToString("MM-dd-yy");
            label3.Text = $"Fecha: {date}";
            v1.Lista.Add(p1);
            v1.Lista.Add(p2);
            v2.Lista.Add(p1);
            v2.Lista.Add(p2);
            v3.Lista.Add(p1);
            v3.Lista.Add(p2);
            v4.Lista.Add(p1);
            v4.Lista.Add(p2);
            listaViajes.Add(v1);
            listaViajes.Add(v2);
            listaViajes.Add(v3);
            listaViajes.Add(v4);
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
            ListaPasajeros pasajeros = new ListaPasajeros(listaViajes);
            AbrirFormEnUnPanel(pasajeros);
        }

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

 
    }
}
