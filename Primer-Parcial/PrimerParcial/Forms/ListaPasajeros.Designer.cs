
namespace PrimerParcial.Forms
{
    partial class ListaPasajeros
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
            this.components = new System.ComponentModel.Container();
            this.cmbCrucero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPremium = new System.Windows.Forms.ComboBox();
            this.txtBolso = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPasaporte = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEmision = new System.Windows.Forms.DateTimePicker();
            this.txtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtGenero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtEquipaje = new System.Windows.Forms.TextBox();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.txtCodigoPas = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBoxNombre = new System.Windows.Forms.ComboBox();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.mAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCrucero
            // 
            this.cmbCrucero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrucero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCrucero.FormattingEnabled = true;
            this.cmbCrucero.Location = new System.Drawing.Point(71, 19);
            this.cmbCrucero.Name = "cmbCrucero";
            this.cmbCrucero.Size = new System.Drawing.Size(155, 40);
            this.cmbCrucero.TabIndex = 0;
            this.cmbCrucero.SelectedIndexChanged += new System.EventHandler(this.cmbCrucero_SelectedIndexChanged);
            this.cmbCrucero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCrucero_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de salida :";
            // 
            // grpDatos
            // 
            this.grpDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDatos.BackColor = System.Drawing.Color.Transparent;
            this.grpDatos.Controls.Add(this.label22);
            this.grpDatos.Controls.Add(this.label21);
            this.grpDatos.Controls.Add(this.txtPremium);
            this.grpDatos.Controls.Add(this.txtBolso);
            this.grpDatos.Controls.Add(this.label20);
            this.grpDatos.Controls.Add(this.txtPasaporte);
            this.grpDatos.Controls.Add(this.textBox1);
            this.grpDatos.Controls.Add(this.txtVencimiento);
            this.grpDatos.Controls.Add(this.textBox2);
            this.grpDatos.Controls.Add(this.txtEmision);
            this.grpDatos.Controls.Add(this.txtNacimiento);
            this.grpDatos.Controls.Add(this.txtGenero);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.button2);
            this.grpDatos.Controls.Add(this.btnValidar);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.txtDestino);
            this.grpDatos.Controls.Add(this.txtEquipaje);
            this.grpDatos.Controls.Add(this.txtCodigoPais);
            this.grpDatos.Controls.Add(this.txtCodigoPas);
            this.grpDatos.Controls.Add(this.txtPais);
            this.grpDatos.Controls.Add(this.txtDNI);
            this.grpDatos.Controls.Add(this.txtEdad);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.label19);
            this.grpDatos.Controls.Add(this.label18);
            this.grpDatos.Controls.Add(this.label17);
            this.grpDatos.Controls.Add(this.label16);
            this.grpDatos.Controls.Add(this.label15);
            this.grpDatos.Controls.Add(this.label14);
            this.grpDatos.Controls.Add(this.label13);
            this.grpDatos.Controls.Add(this.label12);
            this.grpDatos.Controls.Add(this.label11);
            this.grpDatos.Controls.Add(this.label10);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Location = new System.Drawing.Point(60, 126);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(800, 396);
            this.grpDatos.TabIndex = 10;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Enabled = false;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(806, 306);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 21);
            this.label22.TabIndex = 59;
            this.label22.Text = "Premium :";
            this.label22.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Enabled = false;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(486, 320);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 21);
            this.label21.TabIndex = 58;
            this.label21.Text = "Premium :";
            this.label21.Visible = false;
            // 
            // txtPremium
            // 
            this.txtPremium.Enabled = false;
            this.txtPremium.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPremium.FormattingEnabled = true;
            this.txtPremium.Location = new System.Drawing.Point(347, 78);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(133, 38);
            this.txtPremium.TabIndex = 16;
            this.txtPremium.SelectedIndexChanged += new System.EventHandler(this.txtPremium_SelectedIndexChanged);
            this.txtPremium.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPremium_KeyPress);
            // 
            // txtBolso
            // 
            this.txtBolso.Enabled = false;
            this.txtBolso.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBolso.FormattingEnabled = true;
            this.txtBolso.Location = new System.Drawing.Point(613, 142);
            this.txtBolso.Name = "txtBolso";
            this.txtBolso.Size = new System.Drawing.Size(133, 38);
            this.txtBolso.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(486, 300);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 21);
            this.label20.TabIndex = 55;
            this.label20.Text = "Premium :";
            this.label20.Visible = false;
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasaporte.FormattingEnabled = true;
            this.txtPasaporte.Location = new System.Drawing.Point(347, 269);
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(133, 38);
            this.txtPasaporte.TabIndex = 10;
            this.txtPasaporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasaporte_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(498, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 39);
            this.textBox1.TabIndex = 56;
            this.mAyuda.SetToolTip(this.textBox1, "Ingrese la edad (Solo numeros y menores a 120)");
            this.textBox1.Visible = false;
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Enabled = false;
            this.txtVencimiento.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimiento.Location = new System.Drawing.Point(613, 272);
            this.txtVencimiento.MaxDate = new System.DateTime(2080, 1, 1, 0, 0, 0, 0);
            this.txtVencimiento.MinDate = new System.DateTime(1913, 1, 1, 0, 0, 0, 0);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(133, 35);
            this.txtVencimiento.TabIndex = 15;
            this.mAyuda.SetToolTip(this.txtVencimiento, "Llene primero la fecha de emision.");
            this.txtVencimiento.Value = new System.DateTime(1913, 1, 1, 0, 0, 0, 0);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(498, 329);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 39);
            this.textBox2.TabIndex = 57;
            this.mAyuda.SetToolTip(this.textBox2, "Ingrese la edad (Solo numeros y menores a 120)");
            this.textBox2.Visible = false;
            // 
            // txtEmision
            // 
            this.txtEmision.Enabled = false;
            this.txtEmision.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEmision.Location = new System.Drawing.Point(613, 202);
            this.txtEmision.MaxDate = new System.DateTime(2060, 1, 1, 0, 0, 0, 0);
            this.txtEmision.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.txtEmision.Name = "txtEmision";
            this.txtEmision.Size = new System.Drawing.Size(133, 35);
            this.txtEmision.TabIndex = 14;
            this.txtEmision.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.txtEmision.ValueChanged += new System.EventHandler(this.txtEmision_ValueChanged);
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Enabled = false;
            this.txtNacimiento.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNacimiento.Location = new System.Drawing.Point(347, 202);
            this.txtNacimiento.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.txtNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(133, 35);
            this.txtNacimiento.TabIndex = 9;
            this.txtNacimiento.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtNacimiento.ValueChanged += new System.EventHandler(this.txtNacimiento_ValueChanged);
            // 
            // txtGenero
            // 
            this.txtGenero.Enabled = false;
            this.txtGenero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGenero.FormattingEnabled = true;
            this.txtGenero.Location = new System.Drawing.Point(81, 269);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(133, 38);
            this.txtGenero.TabIndex = 5;
            this.txtGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenero_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(35, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 52;
            this.label9.Text = "Dni : ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.button2.Location = new System.Drawing.Point(253, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 40);
            this.button2.TabIndex = 51;
            this.button2.Text = "Vender Pasaje";
            this.mAyuda.SetToolTip(this.button2, "Permite añadir un pasajero al viaje seleccionado");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.btnValidar.Enabled = false;
            this.btnValidar.Location = new System.Drawing.Point(540, 17);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(204, 40);
            this.btnValidar.TabIndex = 50;
            this.btnValidar.Text = "Validar Datos";
            this.mAyuda.SetToolTip(this.btnValidar, "Validar los datos ingresados ");
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Visible = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(250, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nacimiento :";
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDestino.Location = new System.Drawing.Point(611, 79);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(133, 39);
            this.txtDestino.TabIndex = 12;
            // 
            // txtEquipaje
            // 
            this.txtEquipaje.Enabled = false;
            this.txtEquipaje.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpProvider1.SetHelpString(this.txtEquipaje, "Para escribir aqui primero seleccione la opcion Premium");
            this.txtEquipaje.Location = new System.Drawing.Point(613, 329);
            this.txtEquipaje.MaxLength = 2;
            this.txtEquipaje.Name = "txtEquipaje";
            this.helpProvider1.SetShowHelp(this.txtEquipaje, true);
            this.txtEquipaje.Size = new System.Drawing.Size(133, 39);
            this.txtEquipaje.TabIndex = 44;
            this.mAyuda.SetToolTip(this.txtEquipaje, "Solo numeros enteros entre 1 y 50");
            this.txtEquipaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEquipaje_KeyPress);
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Enabled = false;
            this.txtCodigoPais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoPais.Location = new System.Drawing.Point(347, 140);
            this.txtCodigoPais.MaxLength = 3;
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(133, 39);
            this.txtCodigoPais.TabIndex = 8;
            this.mAyuda.SetToolTip(this.txtCodigoPais, "Codigo Numerico del pais solo 3 numeros.");
            this.txtCodigoPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPais_KeyPress);
            // 
            // txtCodigoPas
            // 
            this.txtCodigoPas.Enabled = false;
            this.txtCodigoPas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoPas.Location = new System.Drawing.Point(347, 329);
            this.txtCodigoPas.MaxLength = 8;
            this.txtCodigoPas.Name = "txtCodigoPas";
            this.txtCodigoPas.Size = new System.Drawing.Size(133, 39);
            this.txtCodigoPas.TabIndex = 11;
            this.mAyuda.SetToolTip(this.txtCodigoPas, "Codigo del pasaporte debe contener 8 o 7 digitos");
            this.txtCodigoPas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPas_KeyPress);
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPais.Location = new System.Drawing.Point(81, 140);
            this.txtPais.MaxLength = 3;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(133, 39);
            this.txtPais.TabIndex = 3;
            this.mAyuda.SetToolTip(this.txtPais, "Abreviatura del pais (3 letras MAYUS)");
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPais_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.Location = new System.Drawing.Point(81, 329);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(133, 39);
            this.txtDNI.TabIndex = 6;
            this.mAyuda.SetToolTip(this.txtDNI, "Solo numeros sin puntos (7 u 8 numeros)");
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEdad.Location = new System.Drawing.Point(81, 201);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(133, 39);
            this.txtEdad.TabIndex = 4;
            this.mAyuda.SetToolTip(this.txtEdad, "Ingrese la edad (Solo numeros y menores a 120)");
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(81, 79);
            this.txtApellido.MaxLength = 25;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(133, 39);
            this.txtApellido.TabIndex = 34;
            this.mAyuda.SetToolTip(this.txtApellido, "Ingres el apellido (solo letras)");
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(540, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 21);
            this.label19.TabIndex = 33;
            this.label19.Text = "Destino :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(262, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 21);
            this.label18.TabIndex = 32;
            this.label18.Text = "Premium :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(249, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 21);
            this.label17.TabIndex = 31;
            this.label17.Text = "Codigo Pais :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(557, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 21);
            this.label16.TabIndex = 30;
            this.label16.Text = "Bolso :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(514, 341);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 21);
            this.label15.TabIndex = 29;
            this.label15.Text = "Equipaje Kg :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(253, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "Pas Codigo :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(530, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Pas Venc. :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(510, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = " Pas Emision :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(262, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Pasaporte :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(34, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Pais :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Genero : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Edad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Apellido :";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(81, 18);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 39);
            this.txtNombre.TabIndex = 19;
            this.mAyuda.SetToolTip(this.txtNombre, "Ingrese el nombre (Solo letras)");
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre del pasajero :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Crucero :";
            // 
            // cmBoxNombre
            // 
            this.cmBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxNombre.Enabled = false;
            this.cmBoxNombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmBoxNombre.FormattingEnabled = true;
            this.cmBoxNombre.Location = new System.Drawing.Point(700, 18);
            this.cmBoxNombre.Name = "cmBoxNombre";
            this.cmBoxNombre.Size = new System.Drawing.Size(155, 40);
            this.cmBoxNombre.TabIndex = 15;
            this.cmBoxNombre.SelectedIndexChanged += new System.EventHandler(this.cmBoxNombre_SelectedIndexChanged);
            this.cmBoxNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmBoxNombre_MouseClick);
            // 
            // cmbFecha
            // 
            this.cmbFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFecha.Enabled = false;
            this.cmbFecha.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFecha.FormattingEnabled = true;
            this.cmbFecha.Location = new System.Drawing.Point(350, 19);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(155, 40);
            this.cmbFecha.TabIndex = 18;
            this.cmbFecha.SelectedIndexChanged += new System.EventHandler(this.cmbFecha_SelectedIndexChanged);
            this.cmbFecha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbFecha_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.button1.Location = new System.Drawing.Point(600, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 40);
            this.button1.TabIndex = 52;
            this.button1.Text = "Consultar grupo familiar";
            this.mAyuda.SetToolTip(this.button1, "Permite ver disponibilidad de viajes segun la cantidad del grupo familiar y los r" +
        "equisitos.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListaPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(937, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFecha);
            this.Controls.Add(this.cmBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCrucero);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(840, 465);
            this.Name = "ListaPasajeros";
            this.Text = "ListaPasajeros";
            this.Load += new System.EventHandler(this.ListaPasajeros_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox grpDatos;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.ComboBox cmbCrucero;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cmbFecha;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ComboBox cmBoxNombre;
        protected System.Windows.Forms.TextBox txtNombre;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.TextBox txtDestino;
        protected System.Windows.Forms.TextBox txtEquipaje;
        protected System.Windows.Forms.TextBox txtCodigoPais;
        protected System.Windows.Forms.TextBox txtCodigoPas;
        protected System.Windows.Forms.TextBox txtPais;
        protected System.Windows.Forms.TextBox txtEdad;
        protected System.Windows.Forms.TextBox txtApellido;
        protected System.Windows.Forms.Label label19;
        protected System.Windows.Forms.Label label18;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button btnValidar;
        protected System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtDNI;
        public System.Windows.Forms.ComboBox txtGenero;
        public System.Windows.Forms.DateTimePicker txtNacimiento;
        public System.Windows.Forms.DateTimePicker txtEmision;
        public System.Windows.Forms.DateTimePicker txtVencimiento;
        public System.Windows.Forms.ComboBox txtPremium;
        public System.Windows.Forms.ComboBox txtPasaporte;
        protected System.Windows.Forms.Label label20;
        protected System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.ComboBox txtBolso;
        protected System.Windows.Forms.Label label22;
        protected System.Windows.Forms.Label label21;
        protected System.Windows.Forms.ToolTip mAyuda;
        protected System.Windows.Forms.ErrorProvider errorProvider1;
        protected System.Windows.Forms.HelpProvider helpProvider1;
        protected System.Windows.Forms.Button button1;
    }
}