using PrimerParcial.Clases;
using PrimerParcial.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class fmrLogin : Form
    {          
         private Vendedor[] vendedores = { new Vendedor("Matias Corta", "mati1234"),
         new Vendedor("Maximiliano Neiner", "maxi1234"),
         new Vendedor("Facundo Rocha", "facu1234"), 
         new Vendedor("Felipe Bustos", "feli1234")};

      
        private static string nombreUsuario;
        public static string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }

        public fmrLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            if (txtNombre.Text != "Usuario")
            {
                if (txtContraseña.Text != "Contraseña")
                {
                    if (ValidarUsuario(usuario, contraseña))
                    {
                        this.Hide();
                        Home home = new Home();
                        home.Show();
                    }else msgError("Usuario invalido");
                }else msgError("Ingrese una contraseña");               
            }else msgError("Ingrese un usuario");        
        }

        private bool ValidarUsuario(string usuario, string contraseña)
        {
            NombreUsuario = usuario;
            foreach (Vendedor v1 in vendedores)
            {
                if (v1 == new Vendedor(usuario, contraseña)) return true;
                else break;
            }
            return false;
        }

        private void msgError(string msg)
        { 
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.FromArgb(45, 60, 80);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.FromArgb(37, 54, 75);
        }





        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "Usuario")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "Usuario";

            }
        }        
        private void txtNombre_MouseEnter(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.FromArgb(45, 60, 80);
        }

        private void txtNombre_MouseLeave(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.FromArgb(37, 54,75);
        }

        private void txtContraseña_MouseEnter(object sender, EventArgs e)
        {
            txtContraseña.BackColor = Color.FromArgb(45, 60, 80);
        }

        private void txtContraseña_MouseLeave(object sender, EventArgs e)
        {
            txtContraseña.BackColor = Color.FromArgb(37, 54, 75);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtContraseña_Enter_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {           
            if (pictureBox2.Image == imageList1.Images[0]) pictureBox2.Image = imageList1.Images[1];
            else pictureBox2.Image = imageList1.Images[0];

            if(txtContraseña.UseSystemPasswordChar == true) txtContraseña.UseSystemPasswordChar = false;
            else txtContraseña.UseSystemPasswordChar = true;
        }
    }


       
    
}
