namespace SpectrumSuite
{
    partial class frmPlaza
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPlaza = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new ComponentesGUI.ucTextBox();
            this.lblDescripcion = new ComponentesGUI.ucLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMoneda = new System.Windows.Forms.DataGridView();
            this.cmdCancelar = new ComponentesGUI.ucButton();
            this.cmdGuardar = new ComponentesGUI.ucButton();
            this.cmdEliminar2 = new ComponentesGUI.ucButton();
            this.cmdAgregar = new ComponentesGUI.ucButton();
            this.cboMoneda = new ComponentesGUI.ucComboBox();
            this.lblMoneda = new ComponentesGUI.ucLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion2 = new ComponentesGUI.ucTextBox();
            this.txtAbreviatura = new ComponentesGUI.ucTextBox();
            this.txtCodigo = new ComponentesGUI.ucTextBox();
            this.lblAbreviatura = new ComponentesGUI.ucLabel();
            this.lblDescripcion2 = new ComponentesGUI.ucLabel();
            this.lblCodigo = new ComponentesGUI.ucLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textAbreviatura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDescrip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdNuevo = new ComponentesGUI.ucButton();
            this.cmdModificar = new ComponentesGUI.ucButton();
            this.cmdEliminar = new ComponentesGUI.ucButton();
            this.cmdBuscar = new ComponentesGUI.ucButton();
            this.cmdSalir = new ComponentesGUI.ucButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaza)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneda)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 421);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPlaza);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPlaza
            // 
            this.dgvPlaza.AllowUserToAddRows = false;
            this.dgvPlaza.AllowUserToDeleteRows = false;
            this.dgvPlaza.AllowUserToResizeColumns = false;
            this.dgvPlaza.AllowUserToResizeRows = false;
            this.dgvPlaza.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPlaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaza.Location = new System.Drawing.Point(8, 118);
            this.dgvPlaza.Name = "dgvPlaza";
            this.dgvPlaza.RowHeadersWidth = 40;
            this.dgvPlaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaza.Size = new System.Drawing.Size(398, 266);
            this.dgvPlaza.TabIndex = 1;
            this.dgvPlaza.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Búsqueda";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Es_Obligatorio = false;
            this.txtDescripcion.Flag_BD = false;
            this.txtDescripcion.Location = new System.Drawing.Point(75, 28);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Nombre_Campo = null;
            this.txtDescripcion.Nombre_Control = null;
            this.txtDescripcion.Size = new System.Drawing.Size(317, 20);
            this.txtDescripcion.Solo_Lectura = false;
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Tipo_Dato = ComponentesGUI.ucTextBox.TipoDato.Int;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Es_Obligatorio = false;
            this.lblDescripcion.Flag_BD = false;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 31);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Nombre_Campo = null;
            this.lblDescripcion.Nombre_Control = null;
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.Solo_Lectura = false;
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.Tipo_Dato = ComponentesGUI.ucLabel.TipoDato.Int;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Principales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMoneda);
            this.groupBox3.Controls.Add(this.cmdCancelar);
            this.groupBox3.Controls.Add(this.cmdGuardar);
            this.groupBox3.Controls.Add(this.cmdEliminar2);
            this.groupBox3.Controls.Add(this.cmdAgregar);
            this.groupBox3.Controls.Add(this.cboMoneda);
            this.groupBox3.Controls.Add(this.lblMoneda);
            this.groupBox3.Location = new System.Drawing.Point(15, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 251);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monedas";
            // 
            // dgvMoneda
            // 
            this.dgvMoneda.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoneda.Location = new System.Drawing.Point(13, 58);
            this.dgvMoneda.Name = "dgvMoneda";
            this.dgvMoneda.Size = new System.Drawing.Size(260, 143);
            this.dgvMoneda.TabIndex = 13;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Es_Obligatorio = false;
            this.cmdCancelar.Flag_BD = false;
            this.cmdCancelar.Location = new System.Drawing.Point(117, 207);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Nombre_Campo = null;
            this.cmdCancelar.Nombre_Control = null;
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.Solo_Lectura = false;
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Tipo_Dato = ComponentesGUI.ucButton.TipoDato.Int;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Es_Obligatorio = false;
            this.cmdGuardar.Flag_BD = false;
            this.cmdGuardar.Location = new System.Drawing.Point(13, 207);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Nombre_Campo = null;
            this.cmdGuardar.Nombre_Control = null;
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.Solo_Lectura = false;
            this.cmdGuardar.TabIndex = 11;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Tipo_Dato = ComponentesGUI.ucButton.TipoDato.Int;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // cmdEliminar2
            // 
            this.cmdEliminar2.Es_Obligatorio = false;
            this.cmdEliminar2.Flag_BD = false;
            this.cmdEliminar2.Location = new System.Drawing.Point(279, 100);
            this.cmdEliminar2.Name = "cmdEliminar2";
            this.cmdEliminar2.Nombre_Campo = null;
            this.cmdEliminar2.Nombre_Control = null;
            this.cmdEliminar2.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar2.Solo_Lectura = false;
            this.cmdEliminar2.TabIndex = 10;
            this.cmdEliminar2.Text = "Eliminar";
            this.cmdEliminar2.Tipo_Dato = ComponentesGUI.ucButton.TipoDato.Int;
            this.cmdEliminar2.UseVisualStyleBackColor = true;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Es_Obligatorio = false;
            this.cmdAgregar.Flag_BD = false;
            this.cmdAgregar.Location = new System.Drawing.Point(279, 58);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Nombre_Campo = null;
            this.cmdAgregar.Nombre_Control = null;
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.Solo_Lectura = false;
            this.cmdAgregar.TabIndex = 9;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.Tipo_Dato = ComponentesGUI.ucButton.TipoDato.Int;
            this.cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // cboMoneda
            // 
            this.cboMoneda.Es_Obligatorio = false;
            this.cboMoneda.Flag_BD = false;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(83, 19);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Nombre_Campo = null;
            this.cboMoneda.Nombre_Control = null;
            this.cboMoneda.Size = new System.Drawing.Size(190, 21);
            this.cboMoneda.Solo_Lectura = false;
            this.cboMoneda.TabIndex = 8;
            this.cboMoneda.Tipo_Dato = ComponentesGUI.ucComboBox.TipoDato.Int;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Es_Obligatorio = false;
            this.lblMoneda.Flag_BD = false;
            this.lblMoneda.Location = new System.Drawing.Point(10, 25);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Nombre_Campo = null;
            this.lblMoneda.Nombre_Control = null;
            this.lblMoneda.Size = new System.Drawing.Size(46, 13);
            this.lblMoneda.Solo_Lectura = false;
            this.lblMoneda.TabIndex = 7;
            this.lblMoneda.Text = "Moneda";
            this.lblMoneda.Tipo_Dato = ComponentesGUI.ucLabel.TipoDato.Int;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDescripcion2);
            this.groupBox4.Controls.Add(this.txtAbreviatura);
            this.groupBox4.Controls.Add(this.txtCodigo);
            this.groupBox4.Controls.Add(this.lblAbreviatura);
            this.groupBox4.Controls.Add(this.lblDescripcion2);
            this.groupBox4.Controls.Add(this.lblCodigo);
            this.groupBox4.Location = new System.Drawing.Point(15, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 112);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.BackColor = System.Drawing.Color.White;
            this.txtDescripcion2.Es_Obligatorio = false;
            this.txtDescripcion2.Flag_BD = false;
            this.txtDescripcion2.Location = new System.Drawing.Point(83, 46);
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Nombre_Campo = null;
            this.txtDescripcion2.Nombre_Control = null;
            this.txtDescripcion2.Size = new System.Drawing.Size(281, 20);
            this.txtDescripcion2.Solo_Lectura = false;
            this.txtDescripcion2.TabIndex = 12;
            this.txtDescripcion2.Tipo_Dato = ComponentesGUI.ucTextBox.TipoDato.Int;
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.BackColor = System.Drawing.Color.White;
            this.txtAbreviatura.Es_Obligatorio = false;
            this.txtAbreviatura.Flag_BD = false;
            this.txtAbreviatura.Location = new System.Drawing.Point(83, 80);
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Nombre_Campo = null;
            this.txtAbreviatura.Nombre_Control = null;
            this.txtAbreviatura.Size = new System.Drawing.Size(109, 20);
            this.txtAbreviatura.Solo_Lectura = false;
            this.txtAbreviatura.TabIndex = 11;
            this.txtAbreviatura.Tipo_Dato = ComponentesGUI.ucTextBox.TipoDato.Int;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Es_Obligatorio = false;
            this.txtCodigo.Flag_BD = false;
            this.txtCodigo.Location = new System.Drawing.Point(83, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Nombre_Campo = null;
            this.txtCodigo.Nombre_Control = null;
            this.txtCodigo.Size = new System.Drawing.Size(109, 20);
            this.txtCodigo.Solo_Lectura = false;
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.Tipo_Dato = ComponentesGUI.ucTextBox.TipoDato.Int;
            // 
            // lblAbreviatura
            // 
            this.lblAbreviatura.AutoSize = true;
            this.lblAbreviatura.Es_Obligatorio = false;
            this.lblAbreviatura.Flag_BD = false;
            this.lblAbreviatura.Location = new System.Drawing.Point(10, 83);
            this.lblAbreviatura.Name = "lblAbreviatura";
            this.lblAbreviatura.Nombre_Campo = null;
            this.lblAbreviatura.Nombre_Control = null;
            this.lblAbreviatura.Size = new System.Drawing.Size(61, 13);
            this.lblAbreviatura.Solo_Lectura = false;
            this.lblAbreviatura.TabIndex = 9;
            this.lblAbreviatura.Text = "Abreviatura";
            this.lblAbreviatura.Tipo_Dato = ComponentesGUI.ucLabel.TipoDato.Int;
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Es_Obligatorio = false;
            this.lblDescripcion2.Flag_BD = false;
            this.lblDescripcion2.Location = new System.Drawing.Point(10, 49);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Nombre_Campo = null;
            this.lblDescripcion2.Nombre_Control = null;
            this.lblDescripcion2.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion2.Solo_Lectura = false;
            this.lblDescripcion2.TabIndex = 8;
            this.lblDescripcion2.Text = "Descripción";
            this.lblDescripcion2.Tipo_Dato = ComponentesGUI.ucLabel.TipoDato.Int;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Es_Obligatorio = false;
            this.lblCodigo.Flag_BD = false;
            this.lblCodigo.Location = new System.Drawing.Point(10, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Nombre_Campo = null;
            this.lblCodigo.Nombre_Control = null;
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.Solo_Lectura = false;
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Tipo_Dato = ComponentesGUI.ucLabel.TipoDato.Int;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textAbreviatura);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textDescrip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textcodigo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 112);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // textAbreviatura
            // 
            this.textAbreviatura.Location = new System.Drawing.Point(83, 80);
            this.textAbreviatura.Name = "textAbreviatura";
            this.textAbreviatura.Size = new System.Drawing.Size(75, 20);
            this.textAbreviatura.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Abreviatura";
            // 
            // textDescrip
            // 
            this.textDescrip.Location = new System.Drawing.Point(83, 46);
            this.textDescrip.Name = "textDescrip";
            this.textDescrip.Size = new System.Drawing.Size(271, 20);
            this.textDescrip.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            // 
            // textcodigo
            // 
            this.textcodigo.Location = new System.Drawing.Point(83, 13);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(75, 20);
            this.textcodigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código";
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Es_Obligatorio = false;
            this.cmdNuevo.Flag_BD = false;
            this.cmdNuevo.Location = new System.Drawing.Point(10, 427);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Nombre_Campo = null;
            this.cmdNuevo.Nombre_Control = null;
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.Solo_Lectura = false;
            this.cmdNuevo.TabIndex = 19;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.Tipo_Dato = ComponentesGUI.ucButton.TipoDato.Int;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Es_Obligatorio = false;
            this.cmdModificar.Flag_BD = false;
            this.cmdModificar.Location = new System.Drawing.Point(91, 427);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Nombre_Campo = null;
            this.cmdModificar.Nombre_Control = null;
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.Solo_Lectura = false;
            this.cmdModificar.TabIndex = 20;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.Tipo_Dato = ComponentesGUI.ucButton.TipoDato.Int;
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Es_Obligatorio = false;
            this.cmdEliminar.Flag_BD = false;
            this.cmdEliminar.Location = new System.Drawing.Point(172, 427);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Nombre_Campo = null;
            this.cmdEliminar.Nombre_Control = null;
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.Solo_Lectura = false;
            this.cmdEliminar.TabIndex = 21;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.Tipo_Dato = ComponentesGUI.ucButton.TipoDato.Int;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Es_Obligatorio = false;
            this.cmdBuscar.Flag_BD = false;
            this.cmdBuscar.Location = new System.Drawing.Point(253, 427);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Nombre_Campo = null;
            this.cmdBuscar.Nombre_Control = null;
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.Solo_Lectura = false;
            this.cmdBuscar.TabIndex = 22;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.Tipo_Dato = ComponentesGUI.ucButton.TipoDato.Int;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Es_Obligatorio = false;
            this.cmdSalir.Flag_BD = false;
            this.cmdSalir.Location = new System.Drawing.Point(334, 427);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Nombre_Campo = null;
            this.cmdSalir.Nombre_Control = null;
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.Solo_Lectura = false;
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Tipo_Dato = ComponentesGUI.ucButton.TipoDato.Int;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmPlaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 455);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plazas";
            this.Load += new System.EventHandler(this.frmPlaza_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaza)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneda)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPlaza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textAbreviatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDescrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.Label label3;
        private ComponentesGUI.ucButton cmdNuevo;
        private ComponentesGUI.ucButton cmdModificar;
        private ComponentesGUI.ucButton cmdEliminar;
        private ComponentesGUI.ucButton cmdBuscar;
        private ComponentesGUI.ucButton cmdSalir;
        private ComponentesGUI.ucLabel lblDescripcion;
        private ComponentesGUI.ucTextBox txtDescripcion;
        private ComponentesGUI.ucButton cmdEliminar2;
        private ComponentesGUI.ucButton cmdAgregar;
        private ComponentesGUI.ucComboBox cboMoneda;
        private ComponentesGUI.ucLabel lblMoneda;
        private ComponentesGUI.ucTextBox txtDescripcion2;
        private ComponentesGUI.ucTextBox txtAbreviatura;
        private ComponentesGUI.ucTextBox txtCodigo;
        private ComponentesGUI.ucLabel lblAbreviatura;
        private ComponentesGUI.ucLabel lblDescripcion2;
        private ComponentesGUI.ucLabel lblCodigo;
        private ComponentesGUI.ucButton cmdCancelar;
        private ComponentesGUI.ucButton cmdGuardar;
        private System.Windows.Forms.DataGridView dgvMoneda;


    }
}

