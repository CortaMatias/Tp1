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
       

        private  List<Crucero> listaCruceros = new();
        Crucero c1 = new Crucero("BA – 1 – 000 – 18", "Libertad", 5, 100, 100);
        Crucero c2 = new Crucero("BA – 2 – 001 – 19", "Felicidad", 8, 90, 150);
        Crucero c3 = new Crucero("BA – 3 – 014 – 23", "Alegria", 3, 200, 50);
        Crucero c4 = new Crucero("BA – 8 – 018 – 31", "Sorpresa", 10, 100, 200);
        Crucero c5 = new Crucero("BA – 15 – 032 – 44", "Peronito", 5, 90, 70);
        Crucero c6 = new Crucero("BA – 6 – 003 – 10", "Pepito", 20, 80, 500);
        Crucero c7 = new Crucero("BA – 4 – 099 – 28", "Julio", 6, 70, 150);

        public List<Crucero> ListaCruceros { get => listaCruceros; set => listaCruceros = value; }




        Pasajero p1 = new Pasajero(50, true, true, "Mariano", "Carrazco", "Masculino","4534534", "ARG", new(1980,1,27), 
            new Pasaporte(new(2019,5,20), new(2022,4,20), "LLMM9", 302, Tipo.Diplomatico.ToString()));    
        Pasajero p2 = new Pasajero(25, false, true, "Juan", "Alberto", "Masculino", "3834534", "PAR", new(1975, 6, 27),new Pasaporte(new(2022, 6, 25), new(2028, 6, 23), "JJKK5", 305, Tipo.Oficial.ToString()));
        Pasajero p3 = new Pasajero(50, true, true, "Maria", "Sanchez", "Femenino", "4634534", "ARG", new(1995, 3, 28),
            new Pasaporte(new(2020, 5, 20), new(2024, 9, 28), "SSDD4", 302, Tipo.Ordinario.ToString()));




        public Home()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ListaCruceros.Add(c1);
            ListaCruceros.Add(c2);
            ListaCruceros.Add(c3);
            ListaCruceros.Add(c4);
            ListaCruceros.Add(c5);
            ListaCruceros.Add(c6);
            ListaCruceros.Add(c7);
            Viajes v1 = new Viajes(destinos.Montevideo, new(2022, 10, 28), ListaCruceros[1]);
            Viajes v2 = new Viajes(destinos.IslaDePascua, new(2022, 10, 28), ListaCruceros[2]);
            Viajes v3 = new Viajes(destinos.IslaDePascua, new(2022, 8, 15), ListaCruceros[2]);
            Viajes v4 = new Viajes(destinos.Cartagena, new(2022, 3, 6), ListaCruceros[4]);
            Viajes v5 = new Viajes(destinos.IslaDePascua, new(2020, 9, 28), ListaCruceros[3]);
            Viajes v6 = new Viajes(destinos.Cartagena, new(2020, 8, 9), ListaCruceros[2]);

            panel3.BringToFront();
            panelHome fotos = new panelHome();
            OcultarFormPanel(fotos);
            label5.Text = fmrLogin.NombreUsuario;
            label2.ForeColor = Color.White;
            string date = DateTime.UtcNow.ToString("MM-dd-yy");
            label3.Text = $"Fecha: {date}";
            v1.Lista.Add(p1);
            v2.Lista.Add(p1);
            v3.Lista.Add(p1);
            v4.Lista.Add(p1);
            v6.Lista.Add(p1);
            v6.Lista.Add(p2);
            v4.Lista.Add(p2);
            v3.Lista.Add(p2);
            v6.Lista.Add(p3);
            v3.Lista.Add(p3);
            v2.Lista.Add(p3);

            listaViajes.Add(v1);
            listaViajes.Add(v2);
            listaViajes.Add(v3);
            listaViajes.Add(v4);
            ListaViajes.Add(v5);
            ListaViajes.Add(v6);
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

        private void OcultarFormPanel(Form f)
        {
            foreach(Form t in panel2.Controls)
            {
                if (f.Text != t.Text) f.Hide();
            }
            AbrirFormEnUnPanel(f);
        }

        #endregion

        #region #Eventos
        private void button2_Click(object sender, EventArgs e)
        {
            Cruceros formCrucero = new Cruceros(ListaCruceros, listaViajes);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListaPasajeros pasajeros = new ListaPasajeros();
            pasajeros.inicializarLista(ListaViajes);
            OcultarFormPanel(pasajeros);
        }
        #endregion


        #region #Tamaño

        ////METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        //private int tolerance = 15;
        //private const int WM_NCHITTEST = 132;
        //private const int HTBOTTOMRIGHT = 17;
        //private Rectangle sizeGripRectangle;

        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            base.WndProc(ref m);
        //            var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
        //            if (sizeGripRectangle.Contains(hitPoint))
        //                m.Result = new IntPtr(HTBOTTOMRIGHT);
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}

        ////----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //    var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
        //    sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
        //    region.Exclude(sizeGripRectangle);
        //    //this.pnl_contenedorP.Region = region;
        //    this.Invalidate();
        //}


        ////----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
        //    e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
        //    base.OnPaint(e);
        //    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        //}

        #endregion
    }
}
