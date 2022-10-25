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

        /// <summary>
        /// Compara dos usuarios por su usuario y contraseña 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator == (Vendedor v1, Vendedor v2)
        {
            return v1.usuario == v2.usuario && v1.contraseña == v2.contraseña;
        }

        public static bool operator !=(Vendedor v1, Vendedor v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Vendedor)
            {
                ret = this == ((Vendedor)obj);
            }
            return ret;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }    
}
