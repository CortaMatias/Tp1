
namespace PrimerParcial.Forms
{
    partial class Cruceros
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
            this.cmbNombreCrucero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbCrucero = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtViajes = new System.Windows.Forms.TextBox();
            this.txtCasino = new System.Windows.Forms.TextBox();
            this.txtCine = new System.Windows.Forms.TextBox();
            this.txtGimnasio = new System.Windows.Forms.TextBox();
            this.txtPiscina = new System.Windows.Forms.TextBox();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.txtTurista = new System.Windows.Forms.TextBox();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.txtCamarotes = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCrucero)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNombreCrucero
            // 
            this.cmbNombreCrucero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCrucero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbNombreCrucero.FormattingEnabled = true;
            this.cmbNombreCrucero.Location = new System.Drawing.Point(73, 11);
            this.cmbNombreCrucero.Name = "cmbNombreCrucero";
            this.cmbNombreCrucero.Size = new System.Drawing.Size(235, 40);
            this.cmbNombreCrucero.TabIndex = 0;
            this.cmbNombreCrucero.SelectedIndexChanged += new System.EventHandler(this.cmbNombreCrucero_SelectedIndexChanged);
            this.cmbNombreCrucero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbNombreCrucero_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre :";
            // 
            // pcbCrucero
            // 
            this.pcbCrucero.Image = global::PrimerParcial.Properties.Resources.CruceroDefault;
            this.pcbCrucero.Location = new System.Drawing.Point(12, 66);
            this.pcbCrucero.Name = "pcbCrucero";
            this.pcbCrucero.Size = new System.Drawing.Size(301, 322);
            this.pcbCrucero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCrucero.TabIndex = 2;
            this.pcbCrucero.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.button1.Location = new System.Drawing.Point(12, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 59);
            this.button1.TabIndex = 15;
            this.button1.Text = "Nuevo Crucero";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.grpDatos);
            this.panel1.Location = new System.Drawing.Point(319, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 452);
            this.panel1.TabIndex = 63;
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.Transparent;
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label14);
            this.grpDatos.Controls.Add(this.button2);
            this.grpDatos.Controls.Add(this.label13);
            this.grpDatos.Controls.Add(this.label12);
            this.grpDatos.Controls.Add(this.label11);
            this.grpDatos.Controls.Add(this.label10);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtHoras);
            this.grpDatos.Controls.Add(this.txtViajes);
            this.grpDatos.Controls.Add(this.txtCasino);
            this.grpDatos.Controls.Add(this.txtCine);
            this.grpDatos.Controls.Add(this.txtGimnasio);
            this.grpDatos.Controls.Add(this.txtPiscina);
            this.grpDatos.Controls.Add(this.txtPasajeros);
            this.grpDatos.Controls.Add(this.txtBodega);
            this.grpDatos.Controls.Add(this.txtTurista);
            this.grpDatos.Controls.Add(this.txtPremium);
            this.grpDatos.Controls.Add(this.txtCamarotes);
            this.grpDatos.Controls.Add(this.txtMatricula);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Location = new System.Drawing.Point(7, 10);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(487, 433);
            this.grpDatos.TabIndex = 40;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del crucero :";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(322, 386);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 29);
            this.txtNombre.TabIndex = 65;
            this.txtNombre.Visible = false;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(245, 390);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 64;
            this.label14.Text = "Nombre :";
            this.label14.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 34);
            this.button2.TabIndex = 63;
            this.button2.Text = "Validar Datos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(321, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 62;
            this.label13.Text = "Horas de viaje :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(163, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 61;
            this.label12.Text = "Viajes totales :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(321, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "Cine :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(163, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Gimnasio :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Piscina :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(321, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "N° Pasajeros :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(163, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Kg bodega :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Camarotes Turista :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(297, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Camarotes Premium :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(163, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Camarotes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Matricula :";
            // 
            // txtHoras
            // 
            this.txtHoras.Enabled = false;
            this.txtHoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoras.Location = new System.Drawing.Point(318, 322);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(110, 29);
            this.txtHoras.TabIndex = 51;
            // 
            // txtViajes
            // 
            this.txtViajes.Enabled = false;
            this.txtViajes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtViajes.Location = new System.Drawing.Point(163, 322);
            this.txtViajes.Name = "txtViajes";
            this.txtViajes.Size = new System.Drawing.Size(110, 29);
            this.txtViajes.TabIndex = 50;
            // 
            // txtCasino
            // 
            this.txtCasino.Enabled = false;
            this.txtCasino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCasino.Location = new System.Drawing.Point(12, 322);
            this.txtCasino.Name = "txtCasino";
            this.txtCasino.Size = new System.Drawing.Size(110, 29);
            this.txtCasino.TabIndex = 49;
            this.txtCasino.TextChanged += new System.EventHandler(this.txtCasino_TextChanged);
            // 
            // txtCine
            // 
            this.txtCine.Enabled = false;
            this.txtCine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCine.Location = new System.Drawing.Point(318, 235);
            this.txtCine.Name = "txtCine";
            this.txtCine.Size = new System.Drawing.Size(110, 29);
            this.txtCine.TabIndex = 48;
            this.txtCine.Validating += new System.ComponentModel.CancelEventHandler(this.txtCine_Validating);
            // 
            // txtGimnasio
            // 
            this.txtGimnasio.Enabled = false;
            this.txtGimnasio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGimnasio.Location = new System.Drawing.Point(163, 235);
            this.txtGimnasio.Name = "txtGimnasio";
            this.txtGimnasio.Size = new System.Drawing.Size(110, 29);
            this.txtGimnasio.TabIndex = 47;
            this.txtGimnasio.Validating += new System.ComponentModel.CancelEventHandler(this.txtGimnasio_Validating);
            // 
            // txtPiscina
            // 
            this.txtPiscina.Enabled = false;
            this.txtPiscina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPiscina.Location = new System.Drawing.Point(12, 235);
            this.txtPiscina.Name = "txtPiscina";
            this.txtPiscina.Size = new System.Drawing.Size(110, 29);
            this.txtPiscina.TabIndex = 46;
            this.txtPiscina.Validating += new System.ComponentModel.CancelEventHandler(this.txtPiscina_Validating);
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Enabled = false;
            this.txtPasajeros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasajeros.Location = new System.Drawing.Point(318, 141);
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(110, 29);
            this.txtPasajeros.TabIndex = 45;
            this.txtPasajeros.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasajeros_Validating);
            // 
            // txtBodega
            // 
            this.txtBodega.Enabled = false;
            this.txtBodega.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBodega.Location = new System.Drawing.Point(163, 141);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(110, 29);
            this.txtBodega.TabIndex = 44;
            this.txtBodega.Validating += new System.ComponentModel.CancelEventHandler(this.txtBodega_Validating);
            // 
            // txtTurista
            // 
            this.txtTurista.Enabled = false;
            this.txtTurista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTurista.Location = new System.Drawing.Point(12, 141);
            this.txtTurista.Name = "txtTurista";
            this.txtTurista.Size = new System.Drawing.Size(110, 29);
            this.txtTurista.TabIndex = 43;
            // 
            // txtPremium
            // 
            this.txtPremium.Enabled = false;
            this.txtPremium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPremium.Location = new System.Drawing.Point(318, 50);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(110, 29);
            this.txtPremium.TabIndex = 42;
            // 
            // txtCamarotes
            // 
            this.txtCamarotes.Enabled = false;
            this.txtCamarotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCamarotes.Location = new System.Drawing.Point(163, 50);
            this.txtCamarotes.Name = "txtCamarotes";
            this.txtCamarotes.Size = new System.Drawing.Size(110, 29);
            this.txtCamarotes.TabIndex = 41;
            this.txtCamarotes.Validating += new System.ComponentModel.CancelEventHandler(this.txtCamarotes_Validating);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.Location = new System.Drawing.Point(12, 50);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(110, 29);
            this.txtMatricula.TabIndex = 40;
            this.txtMatricula.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatricula_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Casino :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(841, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcbCrucero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNombreCrucero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(840, 465);
            this.Name = "Cruceros";
            this.Opacity = 0.9D;
            this.Load += new System.EventHandler(this.Cruceros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCrucero)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbNombreCrucero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbCrucero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtViajes;
        private System.Windows.Forms.TextBox txtCasino;
        private System.Windows.Forms.TextBox txtCine;
        private System.Windows.Forms.TextBox txtGimnasio;
        private System.Windows.Forms.TextBox txtPiscina;
        private System.Windows.Forms.TextBox txtPasajeros;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.TextBox txtTurista;
        private System.Windows.Forms.TextBox txtPremium;
        private System.Windows.Forms.TextBox txtCamarotes;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label14;
    }
}