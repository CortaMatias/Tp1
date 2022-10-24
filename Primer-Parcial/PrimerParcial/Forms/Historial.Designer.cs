
namespace PrimerParcial.Forms
{
    partial class Historial
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
            this.txtExtraRegional = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegional = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpFiltrarPasajeros = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtPasaporte = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.checkEdad = new System.Windows.Forms.CheckBox();
            this.checkApellido = new System.Windows.Forms.CheckBox();
            this.chechPasaporte = new System.Windows.Forms.CheckBox();
            this.checkDni = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.listDatos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.grpFiltrarPasajeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtExtraRegional
            // 
            this.txtExtraRegional.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExtraRegional.Location = new System.Drawing.Point(215, 64);
            this.txtExtraRegional.Name = "txtExtraRegional";
            this.txtExtraRegional.Size = new System.Drawing.Size(125, 33);
            this.txtExtraRegional.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Regionales :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(215, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ExtraRegionales :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(415, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Totales :";
            // 
            // txtRegional
            // 
            this.txtRegional.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegional.Location = new System.Drawing.Point(52, 64);
            this.txtRegional.Name = "txtRegional";
            this.txtRegional.Size = new System.Drawing.Size(125, 33);
            this.txtRegional.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(397, 64);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 33);
            this.txtTotal.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtRegional);
            this.groupBox1.Controls.Add(this.txtExtraRegional);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 157);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ganancias";
            // 
            // grpFiltrarPasajeros
            // 
            this.grpFiltrarPasajeros.Controls.Add(this.txtEdad);
            this.grpFiltrarPasajeros.Controls.Add(this.txtApellido);
            this.grpFiltrarPasajeros.Controls.Add(this.txtPasaporte);
            this.grpFiltrarPasajeros.Controls.Add(this.txtDni);
            this.grpFiltrarPasajeros.Controls.Add(this.checkEdad);
            this.grpFiltrarPasajeros.Controls.Add(this.checkApellido);
            this.grpFiltrarPasajeros.Controls.Add(this.chechPasaporte);
            this.grpFiltrarPasajeros.Controls.Add(this.checkDni);
            this.grpFiltrarPasajeros.Location = new System.Drawing.Point(590, 283);
            this.grpFiltrarPasajeros.Name = "grpFiltrarPasajeros";
            this.grpFiltrarPasajeros.Size = new System.Drawing.Size(223, 149);
            this.grpFiltrarPasajeros.TabIndex = 10;
            this.grpFiltrarPasajeros.TabStop = false;
            this.grpFiltrarPasajeros.Text = "Filtrar por :";
            this.grpFiltrarPasajeros.Visible = false;
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(116, 121);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 23);
            this.txtEdad.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtEdad, "Ingrese la edad (Solo numeros)");
            this.txtEdad.Visible = false;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(116, 92);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtApellido, "Ingrese el apellido (Solo letras) ");
            this.txtApellido.Visible = false;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Enabled = false;
            this.txtPasaporte.Location = new System.Drawing.Point(116, 63);
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(100, 23);
            this.txtPasaporte.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtPasaporte, "Ingrese el codigo del pasaporte (Letras y numeros)");
            this.txtPasaporte.Visible = false;
            this.txtPasaporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasaporte_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(116, 34);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtDni, "Ingrese solo numeros sin puntos");
            this.txtDni.Visible = false;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // checkEdad
            // 
            this.checkEdad.AutoSize = true;
            this.checkEdad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEdad.Location = new System.Drawing.Point(9, 115);
            this.checkEdad.Name = "checkEdad";
            this.checkEdad.Size = new System.Drawing.Size(73, 29);
            this.checkEdad.TabIndex = 3;
            this.checkEdad.Text = "Edad";
            this.checkEdad.UseVisualStyleBackColor = true;
            this.checkEdad.CheckedChanged += new System.EventHandler(this.checkEdad_CheckedChanged);
            // 
            // checkApellido
            // 
            this.checkApellido.AutoSize = true;
            this.checkApellido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkApellido.Location = new System.Drawing.Point(9, 86);
            this.checkApellido.Name = "checkApellido";
            this.checkApellido.Size = new System.Drawing.Size(101, 29);
            this.checkApellido.TabIndex = 2;
            this.checkApellido.Text = "Apellido";
            this.checkApellido.UseVisualStyleBackColor = true;
            this.checkApellido.CheckedChanged += new System.EventHandler(this.checkApellido_CheckedChanged);
            // 
            // chechPasaporte
            // 
            this.chechPasaporte.AutoSize = true;
            this.chechPasaporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chechPasaporte.Location = new System.Drawing.Point(6, 58);
            this.chechPasaporte.Name = "chechPasaporte";
            this.chechPasaporte.Size = new System.Drawing.Size(114, 29);
            this.chechPasaporte.TabIndex = 1;
            this.chechPasaporte.Text = "Pasaporte";
            this.chechPasaporte.UseVisualStyleBackColor = true;
            this.chechPasaporte.CheckedChanged += new System.EventHandler(this.chechPasaporte_CheckedChanged);
            // 
            // checkDni
            // 
            this.checkDni.AutoSize = true;
            this.checkDni.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDni.Location = new System.Drawing.Point(6, 28);
            this.checkDni.Name = "checkDni";
            this.checkDni.Size = new System.Drawing.Size(63, 29);
            this.checkDni.TabIndex = 0;
            this.checkDni.Text = "DNI";
            this.checkDni.UseVisualStyleBackColor = true;
            this.checkDni.CheckedChanged += new System.EventHandler(this.checkDni_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grpFiltrarPasajeros);
            this.panel1.Controls.Add(this.comboFiltro);
            this.panel1.Controls.Add(this.listDatos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 441);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿ Que desea saber ?";
            // 
            // comboFiltro
            // 
            this.comboFiltro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(315, 12);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(199, 29);
            this.comboFiltro.TabIndex = 2;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboFiltro_SelectedIndexChanged_1);
            // 
            // listDatos
            // 
            this.listDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.listDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listDatos.ForeColor = System.Drawing.Color.White;
            this.listDatos.FormattingEnabled = true;
            this.listDatos.HorizontalScrollbar = true;
            this.listDatos.ItemHeight = 21;
            this.listDatos.Location = new System.Drawing.Point(13, 63);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(793, 193);
            this.listDatos.TabIndex = 1;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(840, 465);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(840, 465);
            this.Name = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFiltrarPasajeros.ResumeLayout(false);
            this.grpFiltrarPasajeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtExtraRegional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegional;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpFiltrarPasajeros;
        private System.Windows.Forms.CheckBox checkEdad;
        private System.Windows.Forms.CheckBox checkApellido;
        private System.Windows.Forms.CheckBox chechPasaporte;
        private System.Windows.Forms.CheckBox checkDni;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtPasaporte;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFiltro;
        public System.Windows.Forms.ListBox listDatos;
    }
}