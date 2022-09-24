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
        private Crucero[] cruceros = {
            new Crucero("BA – 1 – 000 – 18", "Libertad",5,1,100),
            new Crucero("BA – 2 – 001 – 19", "Felicidad",8,2,150),
            new Crucero("BA – 3 – 014 – 23", "Alegria",3,1,50),
            new Crucero("BA – 8 – 018 – 31", "Sorpresa", 10, 2, 200),
            new Crucero("BA – 15 – 032 – 44", "Peronito", 5,1,70),
            new Crucero("BA – 6 – 003 – 10","Pepito", 20, 3, 500),
            new Crucero("BA – 4 – 099 – 28", "Julio", 6,2,150)};

        private List<Viajes> listaViajes;
        public List<Viajes> ListaViajes { get => listaViajes; set => listaViajes = value; }
        public Crucero[] Cruceros { get => cruceros; set => cruceros = value; }

        public Home()
        {
            InitializeComponent();
        } 

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
            lista.Show();
            this.Hide();
        }
    }
}
