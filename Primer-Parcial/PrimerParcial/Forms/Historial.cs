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
    public partial class Historial : Form
    {
        private List<Viajes> lista;

        public List<Viajes> Lista { get => lista; set => lista = value; }

        public Historial(List<Viajes> lista)
        {
            this.Lista = lista;
            InitializeComponent();
        }

        #region #Eventos

        private void Historial_Load(object sender, EventArgs e)
        {
            string destinos = "Destinos x Facturacion";
            string pasajeros = "Pasajeros frecuentes";
            string todos = "Todos los pasajeros";
            string elegido = "Destino mas elegido";
            float regionales = 0;
            float extraRegionales = 0;
            float total = 0;
            comboFiltro.Items.Add(destinos);
            comboFiltro.Items.Add(elegido);
            comboFiltro.Items.Add(pasajeros);
            comboFiltro.Items.Add(todos);
            foreach(Viajes v in lista)
            {
                 regionales += v.CalcularGananciasRegionales();
                 extraRegionales += v.CalcularGananciasExtraRegionales();
            }
            total = regionales + extraRegionales;
            txtRegional.Text = regionales.ToString();
            txtExtraRegional.Text = extraRegionales.ToString();
            txtTotal.Text = total.ToString();        
        }

        private void checkDni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDni.Checked == true)
            {
                txtDni.Enabled = true;
                txtDni.Visible = true;
            }
            else
            {
                txtDni.Enabled = false;
                txtDni.Visible = false;
            }
        }

        private void chechPasaporte_CheckedChanged(object sender, EventArgs e)
        {
            if (chechPasaporte.Checked == true)
            {
                txtPasaporte.Enabled = true;
                txtPasaporte.Visible = true;
            }
            else
            {
                txtPasaporte.Enabled = false;
                txtPasaporte.Visible = false;
            }
        }

        private void checkApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (checkApellido.Checked == true)
            {
                txtApellido.Enabled = true;
                txtApellido.Visible = true;
            }
            else
            {
                txtApellido.Enabled = false;
                txtApellido.Visible = false;
            }
        }

        private void checkEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdad.Checked == true)
            {
                txtEdad.Enabled = true;
                txtEdad.Visible = true;
            }
            else
            {
                txtEdad.Enabled = false;
                txtEdad.Visible = false;
            }
        }

        private void txtPasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            listDatos.Items.Clear();
            string codigo = txtPasaporte.Text;
            listDatos.Items.Clear();

            if (Char.IsLetter(e.KeyChar) || Char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                if (codigo.Length == 1 && e.KeyChar == '\b')
                {
                    foreach (Viajes v in Lista)
                        foreach (Pasajero p in v.Lista)
                            listDatos.Items.Add(p.MostrarPasajero( v.Destino.ToString(), v.FechaSalida.ToString()));
                }
                else
                {
                    foreach (Viajes v in Lista)
                    {
                        List<Pasajero> x = v.Lista.Where(usuario => usuario.Pasaporte.Codigo.Contains(codigo)).ToList();
                        foreach (Pasajero p in x)
                            listDatos.Items.Add(p.MostrarPasajero( v.Destino.ToString(), v.FechaSalida.ToString()));
                    }
                }
                for (int i = 0; i < listDatos.Items.Count - 2; i++)
                {
                    for (int j = listDatos.Items.Count - 1; j > i; j--)
                    {
                        if (listDatos.Items[i].ToString() == listDatos.Items[j].ToString()) listDatos.Items.RemoveAt(j);
                    }
                }
            }
            else e.Handled = true;
        }


        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            listDatos.Items.Clear();
            string codigo = txtApellido.Text;
            listDatos.Items.Clear();
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b')
            {
                if (codigo.Length == 1 && e.KeyChar == '\b')
                {
                    foreach (Viajes v in Lista)
                        foreach (Pasajero p in v.Lista)
                            listDatos.Items.Add(p.MostrarPasajero( v.Destino.ToString(), v.FechaSalida.ToString()));
                }
                else
                {
                    foreach (Viajes v in Lista)
                    {
                        List<Pasajero> x = v.Lista.Where(usuario => usuario.Apellido.Contains(codigo)).ToList();
                        foreach (Pasajero p in x)

                            listDatos.Items.Add(p.MostrarPasajero( v.Destino.ToString(), v.FechaSalida.ToString()));
                    }
                }
                for (int i = 0; i < listDatos.Items.Count - 2; i++)
                {
                    for (int j = listDatos.Items.Count - 1; j > i; j--)
                    {
                        if (listDatos.Items[i].ToString() == listDatos.Items[j].ToString()) listDatos.Items.RemoveAt(j);
                    }
                }
            }
            else e.Handled = true;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            listDatos.Items.Clear();
            if (Char.IsNumber(e.KeyChar)|| e.KeyChar == '\b')
            {
                string dni = txtDni.Text;
                listDatos.Items.Clear();

                if (dni.Length == 1 && e.KeyChar == '\b')
                {
                    foreach (Viajes v in Lista)
                        foreach (Pasajero p in v.Lista)
                            listDatos.Items.Add(p.MostrarPasajero( v.Destino.ToString(), v.FechaSalida.ToString()));
                }
                else
                {
                    foreach (Viajes v in Lista)
                    {
                        List<Pasajero> x = v.Lista.Where(usuario => usuario.Dni.Contains(dni)).ToList();
                        foreach (Pasajero p in x)
                        listDatos.Items.Add(p.MostrarPasajero( v.Destino.ToString(), v.FechaSalida.ToString()));
                    }
                }
                for (int i = 0; i < listDatos.Items.Count - 2; i++)
                {
                    for (int j = listDatos.Items.Count - 1; j > i; j--)
                    {
                        if (listDatos.Items[i].ToString() == listDatos.Items[j].ToString()) listDatos.Items.RemoveAt(j);
                    }
                }
            }
            else e.Handled = true;

           
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtEdad.Text;
            listDatos.Items.Clear();
            int edad;
            if ((int.TryParse(codigo, out edad)))
            {
                    foreach (Viajes v in Lista)
                    {
                        List<Pasajero> x = v.Lista.Where(usuario => codigo.Length >= 2 ? usuario.Edad.Equals(codigo) : usuario.Edad.Contains(codigo)).ToList();
                        foreach (Pasajero p in x)
                            listDatos.Items.Add(p.MostrarPasajero(v.Destino.ToString(), v.FechaSalida.ToString()));
                    }         
                for (int i = 0; i < listDatos.Items.Count - 2; i++)
                {
                    for (int j = listDatos.Items.Count - 1; j > i; j--)
                    {
                        if (listDatos.Items[i].ToString() == listDatos.Items[j].ToString()) listDatos.Items.RemoveAt(j);
                    }
                }
            }
            else
            {
                foreach (Viajes v in Lista)
                    foreach (Pasajero p in v.Lista)
                        listDatos.Items.Add(p.MostrarPasajero(v.Destino.ToString(), v.FechaSalida.ToString()));
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {          
        }



        private void comboFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboFiltro.SelectedItem.ToString() == "Todos los pasajeros")
            {
                listDatos.Items.Clear();
                listarPasajeros();
            }

            else if (comboFiltro.SelectedItem.ToString() == "Destinos x Facturacion")
            {
                listDatos.Items.Clear();
                DestinoXFacturacion();
            }
            else if (comboFiltro.SelectedItem.ToString() == "Destino mas elegido")
            {
                listDatos.Items.Clear();
                listDatos.Items.Add(DestinoMasElegido());
            }
            else
            {
                listDatos.Items.Clear();
                PasajeroFrecuente();
            }
        }

        #endregion

        #region #Metodos

        public string DestinoMasElegido()
        {
            StringBuilder sb = new();
            destinos maximoValorKey;
            Dictionary<destinos, int> destino = new Dictionary<destinos, int>();
            foreach (var i in Enum.GetValues(typeof(destinos))) destino.Add((destinos)i, 0);
            foreach (Viajes v in Lista)
            {
                destino[v.Destino] += 1;
            }          
            maximoValorKey = destino.OrderByDescending(x => x.Value).First().Key;
            sb.Append($"El destino mas elegido es  {maximoValorKey.ToString()} y se eligio {destino[maximoValorKey]} veces");
            return sb.ToString();
        }

        private void PasajeroFrecuente()
        {      
            Dictionary<Pasajero, int> frecuente = new Dictionary<Pasajero, int>();
            foreach (Viajes v in Lista)
            {
                foreach (Pasajero p in v.Lista)
                {
                    if (frecuente.ContainsKey(p)) frecuente[p] += 1;
                    else frecuente.Add(p, 1);
                }
            }
            Pasajero masFrecuente = frecuente.OrderByDescending(x => x.Value).First().Key;
            Pasajero dosMasFrecuente = frecuente.OrderByDescending(x => x.Value).Skip(1).First().Key;
            Pasajero tresMasFrecuente = frecuente.OrderByDescending(x => x.Value).Skip(2).First().Key;
            listDatos.Items.Add($"El pasajero mas frecuente es {masFrecuente.Nombre}  su Dni es {masFrecuente.Dni.ToString()} y esta en {frecuente[masFrecuente]} viajes");
            listDatos.Items.Add($"El segundo pasajero mas frecuente es {dosMasFrecuente.Nombre}  su Dni es {dosMasFrecuente.Dni.ToString()} y esta en {frecuente[dosMasFrecuente]} viajes");
            listDatos.Items.Add($"El tercero pasajero mas frecuente es {tresMasFrecuente.Nombre}  su Dni es {tresMasFrecuente.Dni.ToString()} y esta en {frecuente[tresMasFrecuente]} viajes");
        }

        public string DestinoXFacturacion()
        {
            float precioBruto;
            StringBuilder sb = new();
            Dictionary<destinos, float> destino = new Dictionary<destinos, float>();
            foreach (var i in Enum.GetValues(typeof(destinos))) destino.Add((destinos)i, 0);
            foreach (Viajes v in Lista) 
            {
                foreach (Pasajero p in v.Lista)
                {
                    precioBruto = v.CalcularPrecioViaje(p);
                    destino[v.Destino] += precioBruto;
                }
            }
            Dictionary<destinos, float> x = destino.OrderByDescending(x => x.Value).ToDictionary( x => x.Key, x => x.Value);
            foreach(var item in x)
            {
                listDatos.Items.Add($"Destino: {item.Key}  - Facturacion Total(sin iva): {item.Value.ToString("0.##")}  - Facturacion con iva: {(item.Value * 1.21).ToString("0.##")}");
            }
            return sb.ToString();
        }


        private void listarPasajeros()
        {
            grpFiltrarPasajeros.Visible = true;
            grpFiltrarPasajeros.Enabled = true;
            string destino;
            string salida;
            foreach (Viajes v in Lista)
            {
                salida = v.FechaSalida.ToString();
                destino = v.Destino.ToString();
                foreach (Pasajero p in v.Lista)
                {
                    listDatos.Items.Add(p.MostrarPasajero(salida, destino));
                }
            }
            for (int i = 0; i < listDatos.Items.Count - 2; i++)
            {
                for (int j = listDatos.Items.Count - 1; j > i; j--)
                {
                    if (listDatos.Items[i].ToString() == listDatos.Items[j].ToString()) listDatos.Items.RemoveAt(j);
                }
            }
        }
        #endregion 
    }
}
