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
         new Vendedor("Facundo Rocha", "facu1234"), new Vendedor("Felipe Bustos", "feli1234")};

        public fmrLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text;
            string contraseña = txtContraseña.Text;

            if (ValidarUsuario(usuario, contraseña)) 
            {
                this.Hide();
                Home home = new Home();    
                

            }

        }

        private bool ValidarUsuario(string usuario, string contraseña)
        {
            
            foreach(Vendedor v1 in vendedores)
            {
                if (v1 == new Vendedor(usuario, contraseña))
                {
                    return true;
                }
                else 
                {
                    MessageBox.Show(this, "Usuario Incorrecto", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            return false;
        }

    }


       
    
}
