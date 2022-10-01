
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
            this.listDatos = new System.Windows.Forms.ListBox();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtraRegional = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegional = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpFiltrarPasajeros = new System.Windows.Forms.GroupBox();
            this.checkEdad = new System.Windows.Forms.CheckBox();
            this.checkApellido = new System.Windows.Forms.CheckBox();
            this.chechPasaporte = new System.Windows.Forms.CheckBox();
            this.checkDni = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grpFiltrarPasajeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDatos
            // 
            this.listDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.listDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listDatos.ForeColor = System.Drawing.Color.White;
            this.listDatos.FormattingEnabled = true;
            this.listDatos.ItemHeight = 21;
            this.listDatos.Location = new System.Drawing.Point(25, 41);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(517, 256);
            this.listDatos.TabIndex = 0;
            // 
            // comboFiltro
            // 
            this.comboFiltro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(220, 6);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(199, 29);
            this.comboFiltro.TabIndex = 1;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboFiltro_SelectedIndexChanged);
            this.comboFiltro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboFiltro_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿ Que desea saber ?";
            // 
            // txtExtraRegional
            // 
            this.txtExtraRegional.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExtraRegional.Location = new System.Drawing.Point(317, 53);
            this.txtExtraRegional.Name = "txtExtraRegional";
            this.txtExtraRegional.Size = new System.Drawing.Size(125, 33);
            this.txtExtraRegional.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Regionales :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(317, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ExtraRegionales :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(584, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Totales :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtRegional
            // 
            this.txtRegional.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegional.Location = new System.Drawing.Point(32, 53);
            this.txtRegional.Name = "txtRegional";
            this.txtRegional.Size = new System.Drawing.Size(125, 33);
            this.txtRegional.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(584, 53);
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
            this.groupBox1.Location = new System.Drawing.Point(25, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ganancias";
            // 
            // grpFiltrarPasajeros
            // 
            this.grpFiltrarPasajeros.Controls.Add(this.checkEdad);
            this.grpFiltrarPasajeros.Controls.Add(this.checkApellido);
            this.grpFiltrarPasajeros.Controls.Add(this.chechPasaporte);
            this.grpFiltrarPasajeros.Controls.Add(this.checkDni);
            this.grpFiltrarPasajeros.Location = new System.Drawing.Point(562, 41);
            this.grpFiltrarPasajeros.Name = "grpFiltrarPasajeros";
            this.grpFiltrarPasajeros.Size = new System.Drawing.Size(226, 274);
            this.grpFiltrarPasajeros.TabIndex = 10;
            this.grpFiltrarPasajeros.TabStop = false;
            this.grpFiltrarPasajeros.Text = "Filtrar por :";
            this.grpFiltrarPasajeros.Visible = false;
            // 
            // checkEdad
            // 
            this.checkEdad.AutoSize = true;
            this.checkEdad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEdad.Location = new System.Drawing.Point(47, 217);
            this.checkEdad.Name = "checkEdad";
            this.checkEdad.Size = new System.Drawing.Size(73, 29);
            this.checkEdad.TabIndex = 3;
            this.checkEdad.Text = "Edad";
            this.checkEdad.UseVisualStyleBackColor = true;
            // 
            // checkApellido
            // 
            this.checkApellido.AutoSize = true;
            this.checkApellido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkApellido.Location = new System.Drawing.Point(47, 155);
            this.checkApellido.Name = "checkApellido";
            this.checkApellido.Size = new System.Drawing.Size(101, 29);
            this.checkApellido.TabIndex = 2;
            this.checkApellido.Text = "Apellido";
            this.checkApellido.UseVisualStyleBackColor = true;
            // 
            // chechPasaporte
            // 
            this.chechPasaporte.AutoSize = true;
            this.chechPasaporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chechPasaporte.Location = new System.Drawing.Point(47, 92);
            this.chechPasaporte.Name = "chechPasaporte";
            this.chechPasaporte.Size = new System.Drawing.Size(114, 29);
            this.chechPasaporte.TabIndex = 1;
            this.chechPasaporte.Text = "Pasaporte";
            this.chechPasaporte.UseVisualStyleBackColor = true;
            // 
            // checkDni
            // 
            this.checkDni.AutoSize = true;
            this.checkDni.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDni.Location = new System.Drawing.Point(47, 40);
            this.checkDni.Name = "checkDni";
            this.checkDni.Size = new System.Drawing.Size(63, 29);
            this.checkDni.TabIndex = 0;
            this.checkDni.Text = "DNI";
            this.checkDni.UseVisualStyleBackColor = true;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpFiltrarPasajeros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.listDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFiltrarPasajeros.ResumeLayout(false);
            this.grpFiltrarPasajeros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Label label1;
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
        public System.Windows.Forms.ListBox listDatos;
    }
}