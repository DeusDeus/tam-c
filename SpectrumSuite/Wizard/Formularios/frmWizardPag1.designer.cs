namespace Wizard.Formularios
{
    partial class frmWizardPag1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWizardPag1));
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFormularios = new System.Windows.Forms.ComboBox();
            this.lblContenido4 = new System.Windows.Forms.Label();
            this.cboModulos = new System.Windows.Forms.ComboBox();
            this.lblContenido3 = new System.Windows.Forms.Label();
            this.lblContenido2 = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Enabled = false;
            this.cmdSiguiente.Location = new System.Drawing.Point(383, 337);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(75, 23);
            this.cmdSiguiente.TabIndex = 0;
            this.cmdSiguiente.Text = "Siguiente >";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboFormularios);
            this.panel1.Controls.Add(this.lblContenido4);
            this.panel1.Controls.Add(this.cboModulos);
            this.panel1.Controls.Add(this.lblContenido3);
            this.panel1.Controls.Add(this.lblContenido2);
            this.panel1.Controls.Add(this.lblContenido);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 315);
            this.panel1.TabIndex = 1;
            // 
            // cboFormularios
            // 
            this.cboFormularios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormularios.FormattingEnabled = true;
            this.cboFormularios.Location = new System.Drawing.Point(278, 199);
            this.cboFormularios.Name = "cboFormularios";
            this.cboFormularios.Size = new System.Drawing.Size(121, 21);
            this.cboFormularios.TabIndex = 7;
            this.cboFormularios.SelectedIndexChanged += new System.EventHandler(this.cboFormularios_SelectedIndexChanged);
            // 
            // lblContenido4
            // 
            this.lblContenido4.AutoSize = true;
            this.lblContenido4.Location = new System.Drawing.Point(144, 202);
            this.lblContenido4.Name = "lblContenido4";
            this.lblContenido4.Size = new System.Drawing.Size(125, 13);
            this.lblContenido4.TabIndex = 6;
            this.lblContenido4.Text = "Seleccione el Formulario:";
            // 
            // cboModulos
            // 
            this.cboModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModulos.FormattingEnabled = true;
            this.cboModulos.Location = new System.Drawing.Point(278, 144);
            this.cboModulos.Name = "cboModulos";
            this.cboModulos.Size = new System.Drawing.Size(121, 21);
            this.cboModulos.TabIndex = 5;
            this.cboModulos.SelectedIndexChanged += new System.EventHandler(this.cboModulos_SelectedIndexChanged);
            // 
            // lblContenido3
            // 
            this.lblContenido3.AutoSize = true;
            this.lblContenido3.Location = new System.Drawing.Point(144, 147);
            this.lblContenido3.Name = "lblContenido3";
            this.lblContenido3.Size = new System.Drawing.Size(115, 13);
            this.lblContenido3.TabIndex = 4;
            this.lblContenido3.Text = "Seleccione el Módulo: ";
            // 
            // lblContenido2
            // 
            this.lblContenido2.AutoSize = true;
            this.lblContenido2.Location = new System.Drawing.Point(144, 102);
            this.lblContenido2.Name = "lblContenido2";
            this.lblContenido2.Size = new System.Drawing.Size(301, 13);
            this.lblContenido2.TabIndex = 3;
            this.lblContenido2.Text = "Servicios (de negocio y de base de datos)  de Spectrum Suite.";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(144, 80);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(355, 13);
            this.lblContenido.TabIndex = 2;
            this.lblContenido.Text = "El asistente de desarrollo lo guiará para el mantenimiento de la Metadata y";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(143, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(387, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Bienvenido al Asistente de Desarrollo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(502, 337);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmWizardPag1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 372);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmWizardPag1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spectrum Wizard (Página 1 de 4)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContenido2;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ComboBox cboModulos;
        private System.Windows.Forms.Label lblContenido3;
        private System.Windows.Forms.ComboBox cboFormularios;
        private System.Windows.Forms.Label lblContenido4;
    }
}