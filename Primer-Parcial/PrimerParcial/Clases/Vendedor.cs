using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    public class Vendedor
    {
        private string usuario;
        private string contraseña;

        public Vendedor(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        public static bool operator == (Vendedor v1, Vendedor v2)
        {
            return v1.usuario == v2.usuario && v1.contraseña == v2.contraseña;
        }

        public static bool operator !=(Vendedor v1, Vendedor v2)
        {
            return !(v1 == v2);
        }

    }    
}
