namespace AdministradorTablas
{
    partial class frmPrueba
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrueba));
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAtributos = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbxAuditoria = new System.Windows.Forms.CheckBox();
            this.cbxStoredProcedure = new System.Windows.Forms.CheckBox();
            this.tbcTablas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdAgregarQuitarTrigger = new System.Windows.Forms.Button();
            this.cmdAgregarQuitarSP = new System.Windows.Forms.Button();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.lblNombreTabla = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).BeginInit();
            this.tbcTablas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 20);
            this.txtNombre.TabIndex = 1;
            this.Tip.SetToolTip(this.txtNombre, "Ingrese nombre de la tabla");
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(565, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 3;
            this.Tip.SetToolTip(this.button1, "Agregar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(565, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 4;
            this.Tip.SetToolTip(this.button2, "Quitar");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(565, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 23);
            this.button5.TabIndex = 7;
            this.Tip.SetToolTip(this.button5, "Desplazar hacia arriba");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(565, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 23);
            this.button6.TabIndex = 8;
            this.Tip.SetToolTip(this.button6, "Desplazar hacia abajo");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Tabla:";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nulidad";
            this.Column3.Items.AddRange(new object[] {
            "null",
            "not null",
            "identity"});
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PK";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tamaño";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo de Dato";
            this.Column2.Items.AddRange(new object[] {
            "char",
            "datetime",
            "float",
            "int",
            "text",
            "varchar",
            "xml"});
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de Atributo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // dgvAtributos
            // 
            this.dgvAtributos.AllowUserToAddRows = false;
            this.dgvAtributos.AllowUserToDeleteRows = false;
            this.dgvAtributos.AllowUserToOrderColumns = true;
            this.dgvAtributos.AllowUserToResizeColumns = false;
            this.dgvAtributos.AllowUserToResizeRows = false;
            this.dgvAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column3});
            this.dgvAtributos.Location = new System.Drawing.Point(46, 75);
            this.dgvAtributos.MultiSelect = false;
            this.dgvAtributos.Name = "dgvAtributos";
            this.dgvAtributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAtributos.Size = new System.Drawing.Size(513, 150);
            this.dgvAtributos.TabIndex = 2;
            this.dgvAtributos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtributos_CellValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(373, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbxAuditoria
            // 
            this.cbxAuditoria.AutoSize = true;
            this.cbxAuditoria.Checked = true;
            this.cbxAuditoria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAuditoria.Location = new System.Drawing.Point(422, 20);
            this.cbxAuditoria.Name = "cbxAuditoria";
            this.cbxAuditoria.Size = new System.Drawing.Size(110, 17);
            this.cbxAuditoria.TabIndex = 9;
            this.cbxAuditoria.Text = "Realizar Auditoría";
            this.cbxAuditoria.UseVisualStyleBackColor = true;
            // 
            // cbxStoredProcedure
            // 
            this.cbxStoredProcedure.AutoSize = true;
            this.cbxStoredProcedure.Location = new System.Drawing.Point(422, 43);
            this.cbxStoredProcedure.Name = "cbxStoredProcedure";
            this.cbxStoredProcedure.Size = new System.Drawing.Size(137, 17);
            this.cbxStoredProcedure.TabIndex = 10;
            this.cbxStoredProcedure.Text = "Crear Stored Procedure";
            this.cbxStoredProcedure.UseVisualStyleBackColor = true;
            this.cbxStoredProcedure.Visible = false;
            // 
            // tbcTablas
            // 
            this.tbcTablas.Controls.Add(this.tabPage1);
            this.tbcTablas.Controls.Add(this.tabPage2);
            this.tbcTablas.Location = new System.Drawing.Point(-1, 0);
            this.tbcTablas.Name = "tbcTablas";
            this.tbcTablas.SelectedIndex = 0;
            this.tbcTablas.Size = new System.Drawing.Size(666, 299);
            this.tbcTablas.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdAgregarQuitarTrigger);
            this.tabPage1.Controls.Add(this.cmdAgregarQuitarSP);
            this.tabPage1.Controls.Add(this.dgvTablas);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tablas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdAgregarQuitarTrigger
            // 
            this.cmdAgregarQuitarTrigger.Location = new System.Drawing.Point(500, 127);
            this.cmdAgregarQuitarTrigger.Name = "cmdAgregarQuitarTrigger";
            this.cmdAgregarQuitarTrigger.Size = new System.Drawing.Size(148, 23);
            this.cmdAgregarQuitarTrigger.TabIndex = 4;
            this.cmdAgregarQuitarTrigger.Text = "button12";
            this.cmdAgregarQuitarTrigger.UseVisualStyleBackColor = true;
            this.cmdAgregarQuitarTrigger.Click += new System.EventHandler(this.cmdAgregarQuitarTrigger_Click);
            // 
            // cmdAgregarQuitarSP
            // 
            this.cmdAgregarQuitarSP.Location = new System.Drawing.Point(500, 89);
            this.cmdAgregarQuitarSP.Name = "cmdAgregarQuitarSP";
            this.cmdAgregarQuitarSP.Size = new System.Drawing.Size(148, 23);
            this.cmdAgregarQuitarSP.TabIndex = 3;
            this.cmdAgregarQuitarSP.Text = "button11";
            this.cmdAgregarQuitarSP.UseVisualStyleBackColor = true;
            this.cmdAgregarQuitarSP.Click += new System.EventHandler(this.cmdAgregarQuitarSP_Click);
            // 
            // dgvTablas
            // 
            this.dgvTablas.AllowUserToAddRows = false;
            this.dgvTablas.AllowUserToDeleteRows = false;
            this.dgvTablas.AllowUserToResizeColumns = false;
            this.dgvTablas.AllowUserToResizeRows = false;
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvTablas.Location = new System.Drawing.Point(9, 89);
            this.dgvTablas.MultiSelect = false;
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablas.Size = new System.Drawing.Size(476, 169);
            this.dgvTablas.TabIndex = 2;
            this.dgvTablas.SelectionChanged += new System.EventHandler(this.dgvTablas_SelectionChanged);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nombre";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 232;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stored Procedure";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Auditable";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "NombreSP";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreTabla);
            this.groupBox1.Controls.Add(this.lblNombreTabla);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(138, 23);
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(234, 20);
            this.txtNombreTabla.TabIndex = 1;
            this.txtNombreTabla.TextChanged += new System.EventHandler(this.txtNombreTabla_TextChanged);
            // 
            // lblNombreTabla
            // 
            this.lblNombreTabla.AutoSize = true;
            this.lblNombreTabla.Location = new System.Drawing.Point(95, 26);
            this.lblNombreTabla.Name = "lblNombreTabla";
            this.lblNombreTabla.Size = new System.Drawing.Size(37, 13);
            this.lblNombreTabla.TabIndex = 0;
            this.lblNombreTabla.Text = "Tabla:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbxStoredProcedure);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.cbxAuditoria);
            this.tabPage2.Controls.Add(this.dgvAtributos);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(12, 306);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.TabIndex = 13;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(576, 306);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 14;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(107, 306);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 15;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 337);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.tbcTablas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrueba";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba: Administrador de Tablas 2.0";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).EndInit();
            this.tbcTablas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip Tip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvAtributos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox cbxAuditoria;
        private System.Windows.Forms.CheckBox cbxStoredProcedure;
        private System.Windows.Forms.TabControl tbcTablas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdAgregarQuitarTrigger;
        private System.Windows.Forms.Button cmdAgregarQuitarSP;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreTabla;
        private System.Windows.Forms.Label lblNombreTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

