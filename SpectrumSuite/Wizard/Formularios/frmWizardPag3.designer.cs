namespace Wizard.Formularios
{
    partial class frmWizardPag3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWizardPag3));
            this.cmdAtras = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdAgregar3 = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdQuitar = new System.Windows.Forms.Button();
            this.dgvDetalleServicio = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstServicios = new System.Windows.Forms.ListBox();
            this.gbxServicios = new System.Windows.Forms.GroupBox();
            this.cmdAgregar2 = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.lblServicios = new System.Windows.Forms.Label();
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.lblProcedures = new System.Windows.Forms.Label();
            this.cboProcedures = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleServicio)).BeginInit();
            this.gbxServicios.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(302, 337);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(75, 23);
            this.cmdAtras.TabIndex = 5;
            this.cmdAtras.Text = "< Atrás";
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(383, 337);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(75, 23);
            this.cmdSiguiente.TabIndex = 4;
            this.cmdSiguiente.Text = "Siguiente >";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 79);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(250, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Ingrese o modifique los Servicios de este formulario.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 19);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Mantenimiento de Servicios";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(502, 337);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmdAgregar3);
            this.panel2.Controls.Add(this.cmdGuardar);
            this.panel2.Controls.Add(this.cmdQuitar);
            this.panel2.Controls.Add(this.dgvDetalleServicio);
            this.panel2.Controls.Add(this.lstServicios);
            this.panel2.Controls.Add(this.gbxServicios);
            this.panel2.Location = new System.Drawing.Point(-1, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 250);
            this.panel2.TabIndex = 8;
            // 
            // cmdAgregar3
            // 
            this.cmdAgregar3.Location = new System.Drawing.Point(502, 132);
            this.cmdAgregar3.Name = "cmdAgregar3";
            this.cmdAgregar3.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar3.TabIndex = 15;
            this.cmdAgregar3.Text = "Agregar";
            this.cmdAgregar3.UseVisualStyleBackColor = true;
            this.cmdAgregar3.Click += new System.EventHandler(this.cmdAgregar3_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(504, 217);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 14;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // cmdQuitar
            // 
            this.cmdQuitar.Location = new System.Drawing.Point(502, 161);
            this.cmdQuitar.Name = "cmdQuitar";
            this.cmdQuitar.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitar.TabIndex = 13;
            this.cmdQuitar.Text = "Quitar";
            this.cmdQuitar.UseVisualStyleBackColor = true;
            this.cmdQuitar.Click += new System.EventHandler(this.cmdQuitar_Click);
            // 
            // dgvDetalleServicio
            // 
            this.dgvDetalleServicio.AllowUserToAddRows = false;
            this.dgvDetalleServicio.AllowUserToDeleteRows = false;
            this.dgvDetalleServicio.AllowUserToOrderColumns = true;
            this.dgvDetalleServicio.AllowUserToResizeColumns = false;
            this.dgvDetalleServicio.AllowUserToResizeRows = false;
            this.dgvDetalleServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDetalleServicio.Location = new System.Drawing.Point(271, 132);
            this.dgvDetalleServicio.MultiSelect = false;
            this.dgvDetalleServicio.Name = "dgvDetalleServicio";
            this.dgvDetalleServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleServicio.Size = new System.Drawing.Size(227, 108);
            this.dgvDetalleServicio.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nº";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 149;
            // 
            // lstServicios
            // 
            this.lstServicios.FormattingEnabled = true;
            this.lstServicios.Location = new System.Drawing.Point(15, 132);
            this.lstServicios.Name = "lstServicios";
            this.lstServicios.Size = new System.Drawing.Size(250, 108);
            this.lstServicios.TabIndex = 11;
            this.lstServicios.SelectedIndexChanged += new System.EventHandler(this.lstServicios_SelectedIndexChanged);
            this.lstServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstServicios_KeyPress);
            // 
            // gbxServicios
            // 
            this.gbxServicios.Controls.Add(this.cmdAgregar2);
            this.gbxServicios.Controls.Add(this.cmdAgregar);
            this.gbxServicios.Controls.Add(this.lblServicios);
            this.gbxServicios.Controls.Add(this.cboServicios);
            this.gbxServicios.Controls.Add(this.lblProcedures);
            this.gbxServicios.Controls.Add(this.cboProcedures);
            this.gbxServicios.Location = new System.Drawing.Point(11, 5);
            this.gbxServicios.Name = "gbxServicios";
            this.gbxServicios.Size = new System.Drawing.Size(566, 112);
            this.gbxServicios.TabIndex = 10;
            this.gbxServicios.TabStop = false;
            this.gbxServicios.Text = "Servicios";
            // 
            // cmdAgregar2
            // 
            this.cmdAgregar2.Location = new System.Drawing.Point(485, 62);
            this.cmdAgregar2.Name = "cmdAgregar2";
            this.cmdAgregar2.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar2.TabIndex = 11;
            this.cmdAgregar2.Text = "Agregar";
            this.cmdAgregar2.UseVisualStyleBackColor = true;
            this.cmdAgregar2.Click += new System.EventHandler(this.cmdAgregar2_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(485, 26);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 10;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(31, 30);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(115, 13);
            this.lblServicios.TabIndex = 8;
            this.lblServicios.Text = "Seleccione el Servicio:";
            // 
            // cboServicios
            // 
            this.cboServicios.DropDownHeight = 80;
            this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicios.DropDownWidth = 250;
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.IntegralHeight = false;
            this.cboServicios.Location = new System.Drawing.Point(210, 27);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(125, 21);
            this.cboServicios.TabIndex = 9;
            // 
            // lblProcedures
            // 
            this.lblProcedures.AutoSize = true;
            this.lblProcedures.Location = new System.Drawing.Point(31, 66);
            this.lblProcedures.Name = "lblProcedures";
            this.lblProcedures.Size = new System.Drawing.Size(160, 13);
            this.lblProcedures.TabIndex = 6;
            this.lblProcedures.Text = "Seleccione el Stored Procedure:";
            // 
            // cboProcedures
            // 
            this.cboProcedures.DropDownHeight = 80;
            this.cboProcedures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProcedures.DropDownWidth = 250;
            this.cboProcedures.FormattingEnabled = true;
            this.cboProcedures.IntegralHeight = false;
            this.cboProcedures.Location = new System.Drawing.Point(210, 63);
            this.cboProcedures.Name = "cboProcedures";
            this.cboProcedures.Size = new System.Drawing.Size(250, 21);
            this.cboProcedures.TabIndex = 7;
            // 
            // frmWizardPag3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 397);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.cmdSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmWizardPag3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Spectrum Wizard (Página 3 de 4)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleServicio)).EndInit();
            this.gbxServicios.ResumeLayout(false);
            this.gbxServicios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboProcedures;
        private System.Windows.Forms.Label lblProcedures;
        private System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.GroupBox gbxServicios;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.DataGridView dgvDetalleServicio;
        private System.Windows.Forms.ListBox lstServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button cmdQuitar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdAgregar2;
        private System.Windows.Forms.Button cmdAgregar3;
    }
}