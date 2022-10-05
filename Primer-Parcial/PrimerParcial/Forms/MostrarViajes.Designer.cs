
namespace PrimerParcial.Forms
{
    partial class MostrarViajes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(375, 338);
            this.label9.Visible = false;
            // 
            // cmbCrucero
            // 
            this.cmbCrucero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCrucero_MouseClick);
            // 
            // cmbFecha
            // 
            this.cmbFecha.SelectedIndexChanged += new System.EventHandler(this.cmbFecha_SelectedIndexChanged_1);
            this.cmbFecha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbFecha_MouseClick);
            // 
            // label2
            // 
            this.label2.Visible = false;
            // 
            // cmBoxNombre
            // 
            this.cmBoxNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 18);
            this.txtNombre.MaxLength = 15;
            this.mAyuda.SetToolTip(this.txtNombre, "Ingrese el nombre (Solo letras)");
            // 
            // label5
            // 
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.Text = "Crucero :";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-2, 209);
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.Text = "Camarotes T : ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 88);
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.Text = "Salida lugar :";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(-1, 268);
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.Text = "Camarotes P:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 152);
            this.label10.Size = new System.Drawing.Size(92, 21);
            this.label10.Text = "Camarotes :";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(262, 268);
            this.label11.Size = new System.Drawing.Size(0, 21);
            this.label11.Text = "";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(524, 152);
            this.label16.Size = new System.Drawing.Size(86, 21);
            this.label16.Text = "Pasajeros : ";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(242, 88);
            this.label15.Size = new System.Drawing.Size(117, 21);
            this.label15.Text = "Disponibilidad :";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(38, 304);
            this.label14.Size = new System.Drawing.Size(65, 21);
            this.label14.Text = "Piscina :";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(636, 304);
            this.label13.Size = new System.Drawing.Size(64, 21);
            this.label13.Text = "Casino :";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(545, 209);
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.Text = "Vuelta : ";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(435, 326);
            // 
            // txtEquipaje
            // 
            this.txtEquipaje.Location = new System.Drawing.Point(357, 76);
            this.mAyuda.SetToolTip(this.txtEquipaje, "Solo numeros enteros entre 1 y 50");
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Location = new System.Drawing.Point(357, 140);
            this.mAyuda.SetToolTip(this.txtCodigoPais, "Codigo Numerico del pais solo 3 numeros.");
            // 
            // txtCodigoPas
            // 
            this.txtCodigoPas.Location = new System.Drawing.Point(359, 256);
            this.mAyuda.SetToolTip(this.txtCodigoPas, "Codigo del pasaporte debe contener 8 o 7 digitos");
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(97, 141);
            this.mAyuda.SetToolTip(this.txtPais, "Abreviatura del pais (3 letras MAYUS)");
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(97, 198);
            this.mAyuda.SetToolTip(this.txtEdad, "Ingrese la edad (Solo numeros y menores a 120)");
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(97, 79);
            this.mAyuda.SetToolTip(this.txtApellido, "Ingres el apellido (solo letras)");
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(546, 265);
            this.label18.Size = new System.Drawing.Size(64, 21);
            this.label18.Text = "Turista :";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(273, 152);
            this.label17.Size = new System.Drawing.Size(80, 21);
            this.label17.Text = "Duracion :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(295, 211);
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.Text = "Salida :";
            // 
            // btnValidar
            // 
            this.mAyuda.SetToolTip(this.btnValidar, "Validar los datos ingresados ");
            // 
            // button2
            // 
            this.button2.Text = "Agregar Viaje";
            this.mAyuda.SetToolTip(this.button2, "Permite añadir un pasajero al viaje seleccionado");
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(613, 256);
            this.mAyuda.SetToolTip(this.txtDNI, "Solo numeros sin puntos (7 u 8 numeros)");
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(20, 328);
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Location = new System.Drawing.Point(357, 199);
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Location = new System.Drawing.Point(750, 304);
            this.txtVencimiento.Size = new System.Drawing.Size(10, 35);
            this.mAyuda.SetToolTip(this.txtVencimiento, "Llene primero la fecha de emision.");
            this.txtVencimiento.Visible = false;
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(611, 328);
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Enabled = false;
            this.txtPasaporte.Location = new System.Drawing.Point(611, 81);
            // 
            // label20
            // 
            this.label20.Enabled = true;
            this.label20.Location = new System.Drawing.Point(278, 265);
            this.label20.Visible = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(613, 141);
            this.textBox2.Size = new System.Drawing.Size(128, 39);
            this.mAyuda.SetToolTip(this.textBox2, "Ingrese la edad (Solo numeros y menores a 120)");
            this.textBox2.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 256);
            this.textBox1.Size = new System.Drawing.Size(133, 39);
            this.mAyuda.SetToolTip(this.textBox1, "Ingrese la edad (Solo numeros y menores a 120)");
            this.textBox1.Visible = true;
            // 
            // txtBolso
            // 
            this.txtBolso.Location = new System.Drawing.Point(214, 328);
            // 
            // label22
            // 
            this.label22.Enabled = true;
            this.label22.Location = new System.Drawing.Point(243, 304);
            this.label22.Size = new System.Drawing.Size(48, 21);
            this.label22.Text = "Cine :";
            this.label22.Visible = true;
            // 
            // label21
            // 
            this.label21.Enabled = true;
            this.label21.Location = new System.Drawing.Point(446, 304);
            this.label21.Size = new System.Drawing.Size(83, 21);
            this.label21.Text = "Gimnasio :";
            this.label21.Visible = true;
            // 
            // MostrarViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 465);
            this.Name = "MostrarViajes";
            this.Text = "MostrarViajes";
            this.Load += new System.EventHandler(this.MostrarViajes_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}