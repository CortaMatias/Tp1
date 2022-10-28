
namespace PrimerParcial.Forms
{
    partial class GrupoFamiliar
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
            this.btnConsutar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaViajes = new System.Windows.Forms.ListBox();
            this.checkGimnasio = new System.Windows.Forms.CheckBox();
            this.checkCine = new System.Windows.Forms.CheckBox();
            this.checkCasino = new System.Windows.Forms.CheckBox();
            this.checkPiscina = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsutar
            // 
            this.btnConsutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.btnConsutar.Location = new System.Drawing.Point(12, 181);
            this.btnConsutar.Name = "btnConsutar";
            this.btnConsutar.Size = new System.Drawing.Size(151, 38);
            this.btnConsutar.TabIndex = 0;
            this.btnConsutar.Text = "Consultar";
            this.btnConsutar.UseVisualStyleBackColor = false;
            this.btnConsutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 141);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(151, 23);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad personas :";
            // 
            // listaViajes
            // 
            this.listaViajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.listaViajes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listaViajes.FormattingEnabled = true;
            this.listaViajes.HorizontalScrollbar = true;
            this.listaViajes.ItemHeight = 21;
            this.listaViajes.Location = new System.Drawing.Point(188, 20);
            this.listaViajes.Name = "listaViajes";
            this.listaViajes.Size = new System.Drawing.Size(440, 193);
            this.listaViajes.TabIndex = 4;
            // 
            // checkGimnasio
            // 
            this.checkGimnasio.AutoSize = true;
            this.checkGimnasio.Location = new System.Drawing.Point(12, 92);
            this.checkGimnasio.Name = "checkGimnasio";
            this.checkGimnasio.Size = new System.Drawing.Size(76, 19);
            this.checkGimnasio.TabIndex = 6;
            this.checkGimnasio.Text = "Gimnasio";
            this.checkGimnasio.UseVisualStyleBackColor = true;
            // 
            // checkCine
            // 
            this.checkCine.AutoSize = true;
            this.checkCine.Location = new System.Drawing.Point(12, 67);
            this.checkCine.Name = "checkCine";
            this.checkCine.Size = new System.Drawing.Size(50, 19);
            this.checkCine.TabIndex = 7;
            this.checkCine.Text = "Cine";
            this.checkCine.UseVisualStyleBackColor = true;
            // 
            // checkCasino
            // 
            this.checkCasino.AutoSize = true;
            this.checkCasino.Location = new System.Drawing.Point(12, 42);
            this.checkCasino.Name = "checkCasino";
            this.checkCasino.Size = new System.Drawing.Size(62, 19);
            this.checkCasino.TabIndex = 8;
            this.checkCasino.Text = "Casino";
            this.checkCasino.UseVisualStyleBackColor = true;
            // 
            // checkPiscina
            // 
            this.checkPiscina.AutoSize = true;
            this.checkPiscina.Location = new System.Drawing.Point(12, 17);
            this.checkPiscina.Name = "checkPiscina";
            this.checkPiscina.Size = new System.Drawing.Size(63, 19);
            this.checkPiscina.TabIndex = 9;
            this.checkPiscina.Text = "Piscina";
            this.checkPiscina.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GrupoFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(640, 231);
            this.Controls.Add(this.checkPiscina);
            this.Controls.Add(this.checkCasino);
            this.Controls.Add(this.checkCine);
            this.Controls.Add(this.checkGimnasio);
            this.Controls.Add(this.listaViajes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnConsutar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(656, 270);
            this.MinimumSize = new System.Drawing.Size(656, 270);
            this.Name = "GrupoFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrupoFamiliar";
            this.Load += new System.EventHandler(this.GrupoFamiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsutar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaViajes;
        private System.Windows.Forms.CheckBox checkGimnasio;
        private System.Windows.Forms.CheckBox checkCine;
        private System.Windows.Forms.CheckBox checkCasino;
        private System.Windows.Forms.CheckBox checkPiscina;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}