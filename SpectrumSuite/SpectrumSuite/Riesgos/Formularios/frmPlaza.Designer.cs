﻿namespace SpectrumSuite
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
            this.tbcPlaza = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCabecera = new ComponentesGUI.ucLabel();
            this.lblArchivoXML = new ComponentesGUI.ucLabel();
            this.lblTipoListaMoneda = new ComponentesGUI.ucLabel();
            this.dgvPlaza = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoUsuario = new ComponentesGUI.ucLabel();
            this.lblTipoOperacion = new ComponentesGUI.ucLabel();
            this.lblDescripcionMoneda = new ComponentesGUI.ucLabel();
            this.lblCodigoMoneda = new ComponentesGUI.ucLabel();
            this.lblDescripcionPlazaCorta = new ComponentesGUI.ucLabel();
            this.lblDescripcionPlaza = new ComponentesGUI.ucLabel();
            this.lblCodigoPlaza = new ComponentesGUI.ucLabel();
            this.lblTipoLista = new ComponentesGUI.ucLabel();
            this.txtDescripcion = new ComponentesGUI.ucTextBox();
            this.lblDescripcion = new ComponentesGUI.ucLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMoneda = new ComponentesGUI.ucDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cmdSalir = new ComponentesGUI.ucButton();
            this.cmdBuscar = new ComponentesGUI.ucButton();
            this.cmdEliminar = new ComponentesGUI.ucButton();
            this.cmdModificar = new ComponentesGUI.ucButton();
            this.cmdNuevo = new ComponentesGUI.ucButton();
            this.ucTextBox1 = new ComponentesGUI.ucTextBox();
            this.ucLabel1 = new ComponentesGUI.ucLabel();
            this.tbcPlaza.SuspendLayout();
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
            // tbcPlaza
            // 
            this.tbcPlaza.Controls.Add(this.tabPage1);
            this.tbcPlaza.Controls.Add(this.tabPage2);
            this.tbcPlaza.Location = new System.Drawing.Point(0, 0);
            this.tbcPlaza.Name = "tbcPlaza";
            this.tbcPlaza.SelectedIndex = 0;
            this.tbcPlaza.Size = new System.Drawing.Size(426, 421);
            this.tbcPlaza.TabIndex = 18;
            this.tbcPlaza.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcPlaza_Selecting);
            this.tbcPlaza.SelectedIndexChanged += new System.EventHandler(this.tbcPlaza_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCabecera);
            this.tabPage1.Controls.Add(this.lblArchivoXML);
            this.tabPage1.Controls.Add(this.lblTipoListaMoneda);
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
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Calculo = null;
            this.lblCabecera.Es_Calculado = false;
            this.lblCabecera.Es_Obligatorio = false;
            this.lblCabecera.Flag_BD = false;
            this.lblCabecera.Formula = null;
            this.lblCabecera.Indicador = false;
            this.lblCabecera.IndicadorIdentity = null;
            this.lblCabecera.IndicadorPK = null;
            this.lblCabecera.IndicadorXML = false;
            this.lblCabecera.IO = null;
            this.lblCabecera.Location = new System.Drawing.Point(273, 102);
            this.lblCabecera.Longitud = null;
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Nombre_Campo = null;
            this.lblCabecera.Nombre_Control = null;
            this.lblCabecera.NombreTagXML = null;
            this.lblCabecera.Precision = null;
            this.lblCabecera.Size = new System.Drawing.Size(53, 13);
            this.lblCabecera.Solo_Lectura = false;
            this.lblCabecera.TabIndex = 4;
            this.lblCabecera.Text = "Cabecera";
            this.lblCabecera.Tipo_Dato = null;
            this.lblCabecera.Valor = null;
            // 
            // lblArchivoXML
            // 
            this.lblArchivoXML.AutoSize = true;
            this.lblArchivoXML.Calculo = null;
            this.lblArchivoXML.Es_Calculado = false;
            this.lblArchivoXML.Es_Obligatorio = false;
            this.lblArchivoXML.Flag_BD = false;
            this.lblArchivoXML.Formula = null;
            this.lblArchivoXML.Indicador = false;
            this.lblArchivoXML.IndicadorIdentity = null;
            this.lblArchivoXML.IndicadorPK = null;
            this.lblArchivoXML.IndicadorXML = false;
            this.lblArchivoXML.IO = null;
            this.lblArchivoXML.Location = new System.Drawing.Point(355, 103);
            this.lblArchivoXML.Longitud = null;
            this.lblArchivoXML.Name = "lblArchivoXML";
            this.lblArchivoXML.Nombre_Campo = null;
            this.lblArchivoXML.Nombre_Control = null;
            this.lblArchivoXML.NombreTagXML = null;
            this.lblArchivoXML.Precision = null;
            this.lblArchivoXML.Size = new System.Drawing.Size(65, 13);
            this.lblArchivoXML.Solo_Lectura = false;
            this.lblArchivoXML.TabIndex = 3;
            this.lblArchivoXML.Text = "ArchivoXML";
            this.lblArchivoXML.Tipo_Dato = null;
            this.lblArchivoXML.Valor = null;
            // 
            // lblTipoListaMoneda
            // 
            this.lblTipoListaMoneda.AutoSize = true;
            this.lblTipoListaMoneda.Calculo = null;
            this.lblTipoListaMoneda.Es_Calculado = false;
            this.lblTipoListaMoneda.Es_Obligatorio = false;
            this.lblTipoListaMoneda.Flag_BD = false;
            this.lblTipoListaMoneda.Formula = null;
            this.lblTipoListaMoneda.Indicador = false;
            this.lblTipoListaMoneda.IndicadorIdentity = null;
            this.lblTipoListaMoneda.IndicadorPK = null;
            this.lblTipoListaMoneda.IndicadorXML = false;
            this.lblTipoListaMoneda.IO = null;
            this.lblTipoListaMoneda.Location = new System.Drawing.Point(14, 90);
            this.lblTipoListaMoneda.Longitud = null;
            this.lblTipoListaMoneda.Name = "lblTipoListaMoneda";
            this.lblTipoListaMoneda.Nombre_Campo = null;
            this.lblTipoListaMoneda.Nombre_Control = null;
            this.lblTipoListaMoneda.NombreTagXML = null;
            this.lblTipoListaMoneda.Precision = null;
            this.lblTipoListaMoneda.Size = new System.Drawing.Size(89, 13);
            this.lblTipoListaMoneda.Solo_Lectura = false;
            this.lblTipoListaMoneda.TabIndex = 2;
            this.lblTipoListaMoneda.Text = "TipoListaMoneda";
            this.lblTipoListaMoneda.Tipo_Dato = null;
            this.lblTipoListaMoneda.Valor = null;
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
            this.dgvPlaza.MultiSelect = false;
            this.dgvPlaza.Name = "dgvPlaza";
            this.dgvPlaza.RowHeadersWidth = 40;
            this.dgvPlaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaza.Size = new System.Drawing.Size(398, 266);
            this.dgvPlaza.TabIndex = 1;
            this.dgvPlaza.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigoUsuario);
            this.groupBox1.Controls.Add(this.lblTipoOperacion);
            this.groupBox1.Controls.Add(this.lblDescripcionMoneda);
            this.groupBox1.Controls.Add(this.lblCodigoMoneda);
            this.groupBox1.Controls.Add(this.lblDescripcionPlazaCorta);
            this.groupBox1.Controls.Add(this.lblDescripcionPlaza);
            this.groupBox1.Controls.Add(this.lblCodigoPlaza);
            this.groupBox1.Controls.Add(this.lblTipoLista);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Búsqueda";
            // 
            // lblCodigoUsuario
            // 
            this.lblCodigoUsuario.AutoSize = true;
            this.lblCodigoUsuario.Calculo = null;
            this.lblCodigoUsuario.Es_Calculado = false;
            this.lblCodigoUsuario.Es_Obligatorio = false;
            this.lblCodigoUsuario.Flag_BD = false;
            this.lblCodigoUsuario.Formula = null;
            this.lblCodigoUsuario.Indicador = false;
            this.lblCodigoUsuario.IndicadorIdentity = null;
            this.lblCodigoUsuario.IndicadorPK = null;
            this.lblCodigoUsuario.IndicadorXML = false;
            this.lblCodigoUsuario.IO = null;
            this.lblCodigoUsuario.Location = new System.Drawing.Point(348, 73);
            this.lblCodigoUsuario.Longitud = null;
            this.lblCodigoUsuario.Name = "lblCodigoUsuario";
            this.lblCodigoUsuario.Nombre_Campo = null;
            this.lblCodigoUsuario.Nombre_Control = null;
            this.lblCodigoUsuario.NombreTagXML = null;
            this.lblCodigoUsuario.Precision = null;
            this.lblCodigoUsuario.Size = new System.Drawing.Size(76, 13);
            this.lblCodigoUsuario.Solo_Lectura = false;
            this.lblCodigoUsuario.TabIndex = 3;
            this.lblCodigoUsuario.Text = "CodigoUsuario";
            this.lblCodigoUsuario.Tipo_Dato = null;
            this.lblCodigoUsuario.Valor = null;
            // 
            // lblTipoOperacion
            // 
            this.lblTipoOperacion.AutoSize = true;
            this.lblTipoOperacion.Calculo = null;
            this.lblTipoOperacion.Es_Calculado = false;
            this.lblTipoOperacion.Es_Obligatorio = false;
            this.lblTipoOperacion.Flag_BD = false;
            this.lblTipoOperacion.Formula = null;
            this.lblTipoOperacion.Indicador = false;
            this.lblTipoOperacion.IndicadorIdentity = null;
            this.lblTipoOperacion.IndicadorPK = null;
            this.lblTipoOperacion.IndicadorXML = false;
            this.lblTipoOperacion.IO = null;
            this.lblTipoOperacion.Location = new System.Drawing.Point(265, 73);
            this.lblTipoOperacion.Longitud = null;
            this.lblTipoOperacion.Name = "lblTipoOperacion";
            this.lblTipoOperacion.Nombre_Campo = null;
            this.lblTipoOperacion.Nombre_Control = null;
            this.lblTipoOperacion.NombreTagXML = null;
            this.lblTipoOperacion.Precision = null;
            this.lblTipoOperacion.Size = new System.Drawing.Size(77, 13);
            this.lblTipoOperacion.Solo_Lectura = false;
            this.lblTipoOperacion.TabIndex = 7;
            this.lblTipoOperacion.Text = "TipoOperacion";
            this.lblTipoOperacion.Tipo_Dato = null;
            this.lblTipoOperacion.Valor = null;
            // 
            // lblDescripcionMoneda
            // 
            this.lblDescripcionMoneda.AutoSize = true;
            this.lblDescripcionMoneda.Calculo = null;
            this.lblDescripcionMoneda.Es_Calculado = false;
            this.lblDescripcionMoneda.Es_Obligatorio = false;
            this.lblDescripcionMoneda.Flag_BD = false;
            this.lblDescripcionMoneda.Formula = null;
            this.lblDescripcionMoneda.Indicador = false;
            this.lblDescripcionMoneda.IndicadorIdentity = null;
            this.lblDescripcionMoneda.IndicadorPK = null;
            this.lblDescripcionMoneda.IndicadorXML = false;
            this.lblDescripcionMoneda.IO = null;
            this.lblDescripcionMoneda.Location = new System.Drawing.Point(157, 73);
            this.lblDescripcionMoneda.Longitud = null;
            this.lblDescripcionMoneda.Name = "lblDescripcionMoneda";
            this.lblDescripcionMoneda.Nombre_Campo = null;
            this.lblDescripcionMoneda.Nombre_Control = null;
            this.lblDescripcionMoneda.NombreTagXML = null;
            this.lblDescripcionMoneda.Precision = null;
            this.lblDescripcionMoneda.Size = new System.Drawing.Size(102, 13);
            this.lblDescripcionMoneda.Solo_Lectura = false;
            this.lblDescripcionMoneda.TabIndex = 2;
            this.lblDescripcionMoneda.Text = "DescripcionMoneda";
            this.lblDescripcionMoneda.Tipo_Dato = null;
            this.lblDescripcionMoneda.Valor = null;
            // 
            // lblCodigoMoneda
            // 
            this.lblCodigoMoneda.AutoSize = true;
            this.lblCodigoMoneda.Calculo = null;
            this.lblCodigoMoneda.Es_Calculado = false;
            this.lblCodigoMoneda.Es_Obligatorio = false;
            this.lblCodigoMoneda.Flag_BD = false;
            this.lblCodigoMoneda.Formula = null;
            this.lblCodigoMoneda.Indicador = false;
            this.lblCodigoMoneda.IndicadorIdentity = null;
            this.lblCodigoMoneda.IndicadorPK = null;
            this.lblCodigoMoneda.IndicadorXML = false;
            this.lblCodigoMoneda.IO = null;
            this.lblCodigoMoneda.Location = new System.Drawing.Point(72, 73);
            this.lblCodigoMoneda.Longitud = null;
            this.lblCodigoMoneda.Name = "lblCodigoMoneda";
            this.lblCodigoMoneda.Nombre_Campo = null;
            this.lblCodigoMoneda.Nombre_Control = null;
            this.lblCodigoMoneda.NombreTagXML = null;
            this.lblCodigoMoneda.Precision = null;
            this.lblCodigoMoneda.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoMoneda.Solo_Lectura = false;
            this.lblCodigoMoneda.TabIndex = 2;
            this.lblCodigoMoneda.Text = "CodigoMoneda";
            this.lblCodigoMoneda.Tipo_Dato = null;
            this.lblCodigoMoneda.Valor = null;
            // 
            // lblDescripcionPlazaCorta
            // 
            this.lblDescripcionPlazaCorta.AutoSize = true;
            this.lblDescripcionPlazaCorta.Calculo = null;
            this.lblDescripcionPlazaCorta.Es_Calculado = false;
            this.lblDescripcionPlazaCorta.Es_Obligatorio = false;
            this.lblDescripcionPlazaCorta.Flag_BD = false;
            this.lblDescripcionPlazaCorta.Formula = null;
            this.lblDescripcionPlazaCorta.Indicador = false;
            this.lblDescripcionPlazaCorta.IndicadorIdentity = null;
            this.lblDescripcionPlazaCorta.IndicadorPK = null;
            this.lblDescripcionPlazaCorta.IndicadorXML = false;
            this.lblDescripcionPlazaCorta.IO = null;
            this.lblDescripcionPlazaCorta.Location = new System.Drawing.Point(265, 58);
            this.lblDescripcionPlazaCorta.Longitud = null;
            this.lblDescripcionPlazaCorta.Name = "lblDescripcionPlazaCorta";
            this.lblDescripcionPlazaCorta.Nombre_Campo = null;
            this.lblDescripcionPlazaCorta.Nombre_Control = null;
            this.lblDescripcionPlazaCorta.NombreTagXML = null;
            this.lblDescripcionPlazaCorta.Precision = null;
            this.lblDescripcionPlazaCorta.Size = new System.Drawing.Size(114, 13);
            this.lblDescripcionPlazaCorta.Solo_Lectura = false;
            this.lblDescripcionPlazaCorta.TabIndex = 6;
            this.lblDescripcionPlazaCorta.Text = "DescripcionPlazaCorta";
            this.lblDescripcionPlazaCorta.Tipo_Dato = null;
            this.lblDescripcionPlazaCorta.Valor = null;
            // 
            // lblDescripcionPlaza
            // 
            this.lblDescripcionPlaza.AutoSize = true;
            this.lblDescripcionPlaza.Calculo = null;
            this.lblDescripcionPlaza.Es_Calculado = false;
            this.lblDescripcionPlaza.Es_Obligatorio = false;
            this.lblDescripcionPlaza.Flag_BD = false;
            this.lblDescripcionPlaza.Formula = null;
            this.lblDescripcionPlaza.Indicador = false;
            this.lblDescripcionPlaza.IndicadorIdentity = null;
            this.lblDescripcionPlaza.IndicadorPK = null;
            this.lblDescripcionPlaza.IndicadorXML = false;
            this.lblDescripcionPlaza.IO = null;
            this.lblDescripcionPlaza.Location = new System.Drawing.Point(157, 58);
            this.lblDescripcionPlaza.Longitud = null;
            this.lblDescripcionPlaza.Name = "lblDescripcionPlaza";
            this.lblDescripcionPlaza.Nombre_Campo = null;
            this.lblDescripcionPlaza.Nombre_Control = null;
            this.lblDescripcionPlaza.NombreTagXML = null;
            this.lblDescripcionPlaza.Precision = null;
            this.lblDescripcionPlaza.Size = new System.Drawing.Size(89, 13);
            this.lblDescripcionPlaza.Solo_Lectura = false;
            this.lblDescripcionPlaza.TabIndex = 5;
            this.lblDescripcionPlaza.Text = "DescripcionPlaza";
            this.lblDescripcionPlaza.Tipo_Dato = null;
            this.lblDescripcionPlaza.Valor = null;
            // 
            // lblCodigoPlaza
            // 
            this.lblCodigoPlaza.AutoSize = true;
            this.lblCodigoPlaza.Calculo = null;
            this.lblCodigoPlaza.Es_Calculado = false;
            this.lblCodigoPlaza.Es_Obligatorio = false;
            this.lblCodigoPlaza.Flag_BD = false;
            this.lblCodigoPlaza.Formula = null;
            this.lblCodigoPlaza.Indicador = false;
            this.lblCodigoPlaza.IndicadorIdentity = null;
            this.lblCodigoPlaza.IndicadorPK = null;
            this.lblCodigoPlaza.IndicadorXML = false;
            this.lblCodigoPlaza.IO = null;
            this.lblCodigoPlaza.Location = new System.Drawing.Point(72, 58);
            this.lblCodigoPlaza.Longitud = null;
            this.lblCodigoPlaza.Name = "lblCodigoPlaza";
            this.lblCodigoPlaza.Nombre_Campo = null;
            this.lblCodigoPlaza.Nombre_Control = null;
            this.lblCodigoPlaza.NombreTagXML = null;
            this.lblCodigoPlaza.Precision = null;
            this.lblCodigoPlaza.Size = new System.Drawing.Size(66, 13);
            this.lblCodigoPlaza.Solo_Lectura = false;
            this.lblCodigoPlaza.TabIndex = 4;
            this.lblCodigoPlaza.Text = "CodigoPlaza";
            this.lblCodigoPlaza.Tipo_Dato = null;
            this.lblCodigoPlaza.Valor = null;
            // 
            // lblTipoLista
            // 
            this.lblTipoLista.AutoSize = true;
            this.lblTipoLista.Calculo = null;
            this.lblTipoLista.Es_Calculado = false;
            this.lblTipoLista.Es_Obligatorio = false;
            this.lblTipoLista.Flag_BD = false;
            this.lblTipoLista.Formula = null;
            this.lblTipoLista.Indicador = false;
            this.lblTipoLista.IndicadorIdentity = null;
            this.lblTipoLista.IndicadorPK = null;
            this.lblTipoLista.IndicadorXML = false;
            this.lblTipoLista.IO = null;
            this.lblTipoLista.Location = new System.Drawing.Point(6, 58);
            this.lblTipoLista.Longitud = null;
            this.lblTipoLista.Name = "lblTipoLista";
            this.lblTipoLista.Nombre_Campo = null;
            this.lblTipoLista.Nombre_Control = null;
            this.lblTipoLista.NombreTagXML = null;
            this.lblTipoLista.Precision = null;
            this.lblTipoLista.Size = new System.Drawing.Size(50, 13);
            this.lblTipoLista.Solo_Lectura = false;
            this.lblTipoLista.TabIndex = 2;
            this.lblTipoLista.Text = "TipoLista";
            this.lblTipoLista.Tipo_Dato = null;
            this.lblTipoLista.Valor = "3";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Calculo = null;
            this.txtDescripcion.Es_Calculado = false;
            this.txtDescripcion.Es_Obligatorio = false;
            this.txtDescripcion.Flag_BD = false;
            this.txtDescripcion.Formula = null;
            this.txtDescripcion.Indicador = false;
            this.txtDescripcion.IndicadorIdentity = null;
            this.txtDescripcion.IndicadorPK = null;
            this.txtDescripcion.IndicadorXML = false;
            this.txtDescripcion.IO = null;
            this.txtDescripcion.Location = new System.Drawing.Point(75, 28);
            this.txtDescripcion.Longitud = null;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Nombre_Campo = null;
            this.txtDescripcion.Nombre_Control = null;
            this.txtDescripcion.NombreTagXML = null;
            this.txtDescripcion.Precision = null;
            this.txtDescripcion.Size = new System.Drawing.Size(317, 20);
            this.txtDescripcion.Solo_Lectura = false;
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Tipo_Dato = null;
            this.txtDescripcion.Valor = null;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Calculo = null;
            this.lblDescripcion.Es_Calculado = false;
            this.lblDescripcion.Es_Obligatorio = false;
            this.lblDescripcion.Flag_BD = false;
            this.lblDescripcion.Formula = null;
            this.lblDescripcion.Indicador = false;
            this.lblDescripcion.IndicadorIdentity = null;
            this.lblDescripcion.IndicadorPK = null;
            this.lblDescripcion.IndicadorXML = false;
            this.lblDescripcion.IO = null;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 31);
            this.lblDescripcion.Longitud = null;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Nombre_Campo = null;
            this.lblDescripcion.Nombre_Control = null;
            this.lblDescripcion.NombreTagXML = null;
            this.lblDescripcion.Precision = null;
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.Solo_Lectura = false;
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.Tipo_Dato = null;
            this.lblDescripcion.Valor = null;
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
            this.dgvMoneda.AllowUserToAddRows = false;
            this.dgvMoneda.AllowUserToDeleteRows = false;
            this.dgvMoneda.AllowUserToResizeColumns = false;
            this.dgvMoneda.AllowUserToResizeRows = false;
            this.dgvMoneda.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMoneda.Calculo = null;
            this.dgvMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvMoneda.Es_Calculado = false;
            this.dgvMoneda.Es_Obligatorio = false;
            this.dgvMoneda.Flag_BD = false;
            this.dgvMoneda.Formula = null;
            this.dgvMoneda.Indicador = false;
            this.dgvMoneda.IndicadorIdentity = null;
            this.dgvMoneda.IndicadorPK = null;
            this.dgvMoneda.IndicadorXML = false;
            this.dgvMoneda.IO = null;
            this.dgvMoneda.Location = new System.Drawing.Point(13, 57);
            this.dgvMoneda.Longitud = null;
            this.dgvMoneda.MultiSelect = false;
            this.dgvMoneda.Name = "dgvMoneda";
            this.dgvMoneda.Nombre_Campo = null;
            this.dgvMoneda.Nombre_Control = null;
            this.dgvMoneda.NombreTagXML = null;
            this.dgvMoneda.Precision = null;
            this.dgvMoneda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMoneda.Size = new System.Drawing.Size(260, 144);
            this.dgvMoneda.Solo_Lectura = false;
            this.dgvMoneda.TabIndex = 13;
            this.dgvMoneda.Tipo_Dato = null;
            this.dgvMoneda.Valor = null;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Calculo = null;
            this.cmdCancelar.Es_Calculado = false;
            this.cmdCancelar.Es_Obligatorio = false;
            this.cmdCancelar.Flag_BD = false;
            this.cmdCancelar.Formula = null;
            this.cmdCancelar.Indicador = false;
            this.cmdCancelar.IndicadorIdentity = null;
            this.cmdCancelar.IndicadorPK = null;
            this.cmdCancelar.IndicadorXML = false;
            this.cmdCancelar.IO = null;
            this.cmdCancelar.Location = new System.Drawing.Point(117, 207);
            this.cmdCancelar.Longitud = null;
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Nombre_Campo = null;
            this.cmdCancelar.Nombre_Control = null;
            this.cmdCancelar.NombreTagXML = null;
            this.cmdCancelar.Precision = null;
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.Solo_Lectura = false;
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Tipo_Dato = null;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Valor = null;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Calculo = null;
            this.cmdGuardar.Es_Calculado = false;
            this.cmdGuardar.Es_Obligatorio = false;
            this.cmdGuardar.Flag_BD = false;
            this.cmdGuardar.Formula = null;
            this.cmdGuardar.Indicador = false;
            this.cmdGuardar.IndicadorIdentity = null;
            this.cmdGuardar.IndicadorPK = null;
            this.cmdGuardar.IndicadorXML = false;
            this.cmdGuardar.IO = null;
            this.cmdGuardar.Location = new System.Drawing.Point(13, 207);
            this.cmdGuardar.Longitud = null;
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Nombre_Campo = null;
            this.cmdGuardar.Nombre_Control = null;
            this.cmdGuardar.NombreTagXML = null;
            this.cmdGuardar.Precision = null;
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.Solo_Lectura = false;
            this.cmdGuardar.TabIndex = 11;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Tipo_Dato = null;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Valor = null;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdEliminar2
            // 
            this.cmdEliminar2.Calculo = null;
            this.cmdEliminar2.Es_Calculado = false;
            this.cmdEliminar2.Es_Obligatorio = false;
            this.cmdEliminar2.Flag_BD = false;
            this.cmdEliminar2.Formula = null;
            this.cmdEliminar2.Indicador = false;
            this.cmdEliminar2.IndicadorIdentity = null;
            this.cmdEliminar2.IndicadorPK = null;
            this.cmdEliminar2.IndicadorXML = false;
            this.cmdEliminar2.IO = null;
            this.cmdEliminar2.Location = new System.Drawing.Point(279, 100);
            this.cmdEliminar2.Longitud = null;
            this.cmdEliminar2.Name = "cmdEliminar2";
            this.cmdEliminar2.Nombre_Campo = null;
            this.cmdEliminar2.Nombre_Control = null;
            this.cmdEliminar2.NombreTagXML = null;
            this.cmdEliminar2.Precision = null;
            this.cmdEliminar2.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar2.Solo_Lectura = false;
            this.cmdEliminar2.TabIndex = 10;
            this.cmdEliminar2.Text = "Eliminar";
            this.cmdEliminar2.Tipo_Dato = null;
            this.cmdEliminar2.UseVisualStyleBackColor = true;
            this.cmdEliminar2.Valor = null;
            this.cmdEliminar2.Click += new System.EventHandler(this.cmdEliminar2_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Calculo = null;
            this.cmdAgregar.Es_Calculado = false;
            this.cmdAgregar.Es_Obligatorio = false;
            this.cmdAgregar.Flag_BD = false;
            this.cmdAgregar.Formula = null;
            this.cmdAgregar.Indicador = false;
            this.cmdAgregar.IndicadorIdentity = null;
            this.cmdAgregar.IndicadorPK = null;
            this.cmdAgregar.IndicadorXML = false;
            this.cmdAgregar.IO = null;
            this.cmdAgregar.Location = new System.Drawing.Point(279, 58);
            this.cmdAgregar.Longitud = null;
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Nombre_Campo = null;
            this.cmdAgregar.Nombre_Control = null;
            this.cmdAgregar.NombreTagXML = null;
            this.cmdAgregar.Precision = null;
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.Solo_Lectura = false;
            this.cmdAgregar.TabIndex = 9;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.Tipo_Dato = null;
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Valor = null;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cboMoneda
            // 
            this.cboMoneda.Calculo = null;
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.Es_Calculado = false;
            this.cboMoneda.Es_Obligatorio = false;
            this.cboMoneda.Flag_BD = false;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Formula = null;
            this.cboMoneda.Indicador = false;
            this.cboMoneda.IndicadorIdentity = null;
            this.cboMoneda.IndicadorPK = null;
            this.cboMoneda.IndicadorXML = false;
            this.cboMoneda.IO = null;
            this.cboMoneda.Location = new System.Drawing.Point(83, 19);
            this.cboMoneda.Longitud = null;
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Nombre_Campo = null;
            this.cboMoneda.Nombre_Control = null;
            this.cboMoneda.NombreTagXML = null;
            this.cboMoneda.Precision = null;
            this.cboMoneda.Size = new System.Drawing.Size(190, 21);
            this.cboMoneda.Solo_Lectura = false;
            this.cboMoneda.TabIndex = 8;
            this.cboMoneda.Tipo_Dato = null;
            this.cboMoneda.Valor = null;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Calculo = null;
            this.lblMoneda.Es_Calculado = false;
            this.lblMoneda.Es_Obligatorio = false;
            this.lblMoneda.Flag_BD = false;
            this.lblMoneda.Formula = null;
            this.lblMoneda.Indicador = false;
            this.lblMoneda.IndicadorIdentity = null;
            this.lblMoneda.IndicadorPK = null;
            this.lblMoneda.IndicadorXML = false;
            this.lblMoneda.IO = null;
            this.lblMoneda.Location = new System.Drawing.Point(10, 25);
            this.lblMoneda.Longitud = null;
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Nombre_Campo = null;
            this.lblMoneda.Nombre_Control = null;
            this.lblMoneda.NombreTagXML = null;
            this.lblMoneda.Precision = null;
            this.lblMoneda.Size = new System.Drawing.Size(46, 13);
            this.lblMoneda.Solo_Lectura = false;
            this.lblMoneda.TabIndex = 7;
            this.lblMoneda.Text = "Moneda";
            this.lblMoneda.Tipo_Dato = null;
            this.lblMoneda.Valor = null;
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
            this.txtDescripcion2.Calculo = null;
            this.txtDescripcion2.Es_Calculado = false;
            this.txtDescripcion2.Es_Obligatorio = false;
            this.txtDescripcion2.Flag_BD = false;
            this.txtDescripcion2.Formula = null;
            this.txtDescripcion2.Indicador = false;
            this.txtDescripcion2.IndicadorIdentity = null;
            this.txtDescripcion2.IndicadorPK = null;
            this.txtDescripcion2.IndicadorXML = false;
            this.txtDescripcion2.IO = null;
            this.txtDescripcion2.Location = new System.Drawing.Point(83, 46);
            this.txtDescripcion2.Longitud = null;
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Nombre_Campo = null;
            this.txtDescripcion2.Nombre_Control = null;
            this.txtDescripcion2.NombreTagXML = null;
            this.txtDescripcion2.Precision = null;
            this.txtDescripcion2.Size = new System.Drawing.Size(281, 20);
            this.txtDescripcion2.Solo_Lectura = false;
            this.txtDescripcion2.TabIndex = 12;
            this.txtDescripcion2.Tipo_Dato = null;
            this.txtDescripcion2.Valor = null;
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.BackColor = System.Drawing.Color.White;
            this.txtAbreviatura.Calculo = null;
            this.txtAbreviatura.Es_Calculado = false;
            this.txtAbreviatura.Es_Obligatorio = false;
            this.txtAbreviatura.Flag_BD = false;
            this.txtAbreviatura.Formula = null;
            this.txtAbreviatura.Indicador = false;
            this.txtAbreviatura.IndicadorIdentity = null;
            this.txtAbreviatura.IndicadorPK = null;
            this.txtAbreviatura.IndicadorXML = false;
            this.txtAbreviatura.IO = null;
            this.txtAbreviatura.Location = new System.Drawing.Point(83, 80);
            this.txtAbreviatura.Longitud = null;
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Nombre_Campo = null;
            this.txtAbreviatura.Nombre_Control = null;
            this.txtAbreviatura.NombreTagXML = null;
            this.txtAbreviatura.Precision = null;
            this.txtAbreviatura.Size = new System.Drawing.Size(109, 20);
            this.txtAbreviatura.Solo_Lectura = false;
            this.txtAbreviatura.TabIndex = 11;
            this.txtAbreviatura.Tipo_Dato = null;
            this.txtAbreviatura.Valor = null;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Calculo = null;
            this.txtCodigo.Es_Calculado = false;
            this.txtCodigo.Es_Obligatorio = false;
            this.txtCodigo.Flag_BD = false;
            this.txtCodigo.Formula = null;
            this.txtCodigo.Indicador = false;
            this.txtCodigo.IndicadorIdentity = null;
            this.txtCodigo.IndicadorPK = null;
            this.txtCodigo.IndicadorXML = false;
            this.txtCodigo.IO = null;
            this.txtCodigo.Location = new System.Drawing.Point(83, 13);
            this.txtCodigo.Longitud = null;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Nombre_Campo = null;
            this.txtCodigo.Nombre_Control = null;
            this.txtCodigo.NombreTagXML = null;
            this.txtCodigo.Precision = null;
            this.txtCodigo.Size = new System.Drawing.Size(109, 20);
            this.txtCodigo.Solo_Lectura = true;
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.Tipo_Dato = null;
            this.txtCodigo.Valor = null;
            // 
            // lblAbreviatura
            // 
            this.lblAbreviatura.AutoSize = true;
            this.lblAbreviatura.Calculo = null;
            this.lblAbreviatura.Es_Calculado = false;
            this.lblAbreviatura.Es_Obligatorio = false;
            this.lblAbreviatura.Flag_BD = false;
            this.lblAbreviatura.Formula = null;
            this.lblAbreviatura.Indicador = false;
            this.lblAbreviatura.IndicadorIdentity = null;
            this.lblAbreviatura.IndicadorPK = null;
            this.lblAbreviatura.IndicadorXML = false;
            this.lblAbreviatura.IO = null;
            this.lblAbreviatura.Location = new System.Drawing.Point(10, 83);
            this.lblAbreviatura.Longitud = null;
            this.lblAbreviatura.Name = "lblAbreviatura";
            this.lblAbreviatura.Nombre_Campo = null;
            this.lblAbreviatura.Nombre_Control = null;
            this.lblAbreviatura.NombreTagXML = null;
            this.lblAbreviatura.Precision = null;
            this.lblAbreviatura.Size = new System.Drawing.Size(61, 13);
            this.lblAbreviatura.Solo_Lectura = false;
            this.lblAbreviatura.TabIndex = 9;
            this.lblAbreviatura.Text = "Abreviatura";
            this.lblAbreviatura.Tipo_Dato = null;
            this.lblAbreviatura.Valor = null;
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Calculo = null;
            this.lblDescripcion2.Es_Calculado = false;
            this.lblDescripcion2.Es_Obligatorio = false;
            this.lblDescripcion2.Flag_BD = false;
            this.lblDescripcion2.Formula = null;
            this.lblDescripcion2.Indicador = false;
            this.lblDescripcion2.IndicadorIdentity = null;
            this.lblDescripcion2.IndicadorPK = null;
            this.lblDescripcion2.IndicadorXML = false;
            this.lblDescripcion2.IO = null;
            this.lblDescripcion2.Location = new System.Drawing.Point(10, 49);
            this.lblDescripcion2.Longitud = null;
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Nombre_Campo = null;
            this.lblDescripcion2.Nombre_Control = null;
            this.lblDescripcion2.NombreTagXML = null;
            this.lblDescripcion2.Precision = null;
            this.lblDescripcion2.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion2.Solo_Lectura = false;
            this.lblDescripcion2.TabIndex = 8;
            this.lblDescripcion2.Text = "Descripción";
            this.lblDescripcion2.Tipo_Dato = null;
            this.lblDescripcion2.Valor = null;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Calculo = null;
            this.lblCodigo.Es_Calculado = false;
            this.lblCodigo.Es_Obligatorio = false;
            this.lblCodigo.Flag_BD = false;
            this.lblCodigo.Formula = null;
            this.lblCodigo.Indicador = false;
            this.lblCodigo.IndicadorIdentity = null;
            this.lblCodigo.IndicadorPK = null;
            this.lblCodigo.IndicadorXML = false;
            this.lblCodigo.IO = null;
            this.lblCodigo.Location = new System.Drawing.Point(10, 16);
            this.lblCodigo.Longitud = null;
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Nombre_Campo = null;
            this.lblCodigo.Nombre_Control = null;
            this.lblCodigo.NombreTagXML = null;
            this.lblCodigo.Precision = null;
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.Solo_Lectura = false;
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Tipo_Dato = null;
            this.lblCodigo.Valor = null;
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
            this.textDescrip.Size = new System.Drawing.Size(101, 20);
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
            // cmdSalir
            // 
            this.cmdSalir.Calculo = null;
            this.cmdSalir.Es_Calculado = false;
            this.cmdSalir.Es_Obligatorio = false;
            this.cmdSalir.Flag_BD = false;
            this.cmdSalir.Formula = null;
            this.cmdSalir.Indicador = false;
            this.cmdSalir.IndicadorIdentity = null;
            this.cmdSalir.IndicadorPK = null;
            this.cmdSalir.IndicadorXML = false;
            this.cmdSalir.IO = null;
            this.cmdSalir.Location = new System.Drawing.Point(334, 427);
            this.cmdSalir.Longitud = null;
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Nombre_Campo = null;
            this.cmdSalir.Nombre_Control = null;
            this.cmdSalir.NombreTagXML = null;
            this.cmdSalir.Precision = null;
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.Solo_Lectura = false;
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Tipo_Dato = null;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Valor = null;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Calculo = null;
            this.cmdBuscar.Es_Calculado = false;
            this.cmdBuscar.Es_Obligatorio = false;
            this.cmdBuscar.Flag_BD = false;
            this.cmdBuscar.Formula = null;
            this.cmdBuscar.Indicador = false;
            this.cmdBuscar.IndicadorIdentity = null;
            this.cmdBuscar.IndicadorPK = null;
            this.cmdBuscar.IndicadorXML = false;
            this.cmdBuscar.IO = null;
            this.cmdBuscar.Location = new System.Drawing.Point(253, 427);
            this.cmdBuscar.Longitud = null;
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Nombre_Campo = null;
            this.cmdBuscar.Nombre_Control = null;
            this.cmdBuscar.NombreTagXML = null;
            this.cmdBuscar.Precision = null;
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.Solo_Lectura = false;
            this.cmdBuscar.TabIndex = 22;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.Tipo_Dato = null;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Valor = null;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Calculo = null;
            this.cmdEliminar.Es_Calculado = false;
            this.cmdEliminar.Es_Obligatorio = false;
            this.cmdEliminar.Flag_BD = false;
            this.cmdEliminar.Formula = null;
            this.cmdEliminar.Indicador = false;
            this.cmdEliminar.IndicadorIdentity = null;
            this.cmdEliminar.IndicadorPK = null;
            this.cmdEliminar.IndicadorXML = false;
            this.cmdEliminar.IO = null;
            this.cmdEliminar.Location = new System.Drawing.Point(172, 427);
            this.cmdEliminar.Longitud = null;
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Nombre_Campo = null;
            this.cmdEliminar.Nombre_Control = null;
            this.cmdEliminar.NombreTagXML = null;
            this.cmdEliminar.Precision = null;
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.Solo_Lectura = false;
            this.cmdEliminar.TabIndex = 21;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.Tipo_Dato = null;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Valor = null;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Calculo = null;
            this.cmdModificar.Es_Calculado = false;
            this.cmdModificar.Es_Obligatorio = false;
            this.cmdModificar.Flag_BD = false;
            this.cmdModificar.Formula = null;
            this.cmdModificar.Indicador = false;
            this.cmdModificar.IndicadorIdentity = null;
            this.cmdModificar.IndicadorPK = null;
            this.cmdModificar.IndicadorXML = false;
            this.cmdModificar.IO = null;
            this.cmdModificar.Location = new System.Drawing.Point(91, 427);
            this.cmdModificar.Longitud = null;
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Nombre_Campo = null;
            this.cmdModificar.Nombre_Control = null;
            this.cmdModificar.NombreTagXML = null;
            this.cmdModificar.Precision = null;
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.Solo_Lectura = false;
            this.cmdModificar.TabIndex = 20;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.Tipo_Dato = null;
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Valor = null;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Calculo = null;
            this.cmdNuevo.Es_Calculado = false;
            this.cmdNuevo.Es_Obligatorio = false;
            this.cmdNuevo.Flag_BD = false;
            this.cmdNuevo.Formula = null;
            this.cmdNuevo.Indicador = false;
            this.cmdNuevo.IndicadorIdentity = null;
            this.cmdNuevo.IndicadorPK = null;
            this.cmdNuevo.IndicadorXML = false;
            this.cmdNuevo.IO = null;
            this.cmdNuevo.Location = new System.Drawing.Point(10, 427);
            this.cmdNuevo.Longitud = null;
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Nombre_Campo = null;
            this.cmdNuevo.Nombre_Control = null;
            this.cmdNuevo.NombreTagXML = null;
            this.cmdNuevo.Precision = null;
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.Solo_Lectura = false;
            this.cmdNuevo.TabIndex = 19;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.Tipo_Dato = null;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Valor = null;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.BackColor = System.Drawing.Color.White;
            this.ucTextBox1.Calculo = null;
            this.ucTextBox1.Es_Calculado = false;
            this.ucTextBox1.Es_Obligatorio = false;
            this.ucTextBox1.Flag_BD = false;
            this.ucTextBox1.Formula = null;
            this.ucTextBox1.Indicador = false;
            this.ucTextBox1.IndicadorIdentity = null;
            this.ucTextBox1.IndicadorPK = null;
            this.ucTextBox1.IndicadorXML = false;
            this.ucTextBox1.IO = null;
            this.ucTextBox1.Location = new System.Drawing.Point(75, 28);
            this.ucTextBox1.Longitud = null;
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Nombre_Campo = null;
            this.ucTextBox1.Nombre_Control = null;
            this.ucTextBox1.NombreTagXML = null;
            this.ucTextBox1.Precision = null;
            this.ucTextBox1.Size = new System.Drawing.Size(317, 20);
            this.ucTextBox1.Solo_Lectura = false;
            this.ucTextBox1.TabIndex = 3;
            this.ucTextBox1.Tipo_Dato = null;
            this.ucTextBox1.Valor = null;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Calculo = null;
            this.ucLabel1.Es_Calculado = false;
            this.ucLabel1.Es_Obligatorio = false;
            this.ucLabel1.Flag_BD = false;
            this.ucLabel1.Formula = null;
            this.ucLabel1.Indicador = false;
            this.ucLabel1.IndicadorIdentity = null;
            this.ucLabel1.IndicadorPK = null;
            this.ucLabel1.IndicadorXML = false;
            this.ucLabel1.IO = null;
            this.ucLabel1.Location = new System.Drawing.Point(6, 31);
            this.ucLabel1.Longitud = null;
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Nombre_Campo = null;
            this.ucLabel1.Nombre_Control = null;
            this.ucLabel1.NombreTagXML = null;
            this.ucLabel1.Precision = null;
            this.ucLabel1.Size = new System.Drawing.Size(63, 13);
            this.ucLabel1.Solo_Lectura = false;
            this.ucLabel1.TabIndex = 2;
            this.ucLabel1.Text = "Descripción";
            this.ucLabel1.Tipo_Dato = null;
            this.ucLabel1.Valor = null;
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
            this.Controls.Add(this.tbcPlaza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plazas";
            this.Load += new System.EventHandler(this.frmPlaza_Load);
            this.tbcPlaza.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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

        private System.Windows.Forms.TabControl tbcPlaza;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPlaza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private ComponentesGUI.ucTextBox txtCodigo;
        private ComponentesGUI.ucLabel lblAbreviatura;
        private ComponentesGUI.ucLabel lblDescripcion2;
        private ComponentesGUI.ucLabel lblCodigo;
        private ComponentesGUI.ucButton cmdCancelar;
        private ComponentesGUI.ucButton cmdGuardar;
        private ComponentesGUI.ucTextBox ucTextBox1;
        private ComponentesGUI.ucLabel ucLabel1;
        private ComponentesGUI.ucLabel lblTipoLista;
        private ComponentesGUI.ucLabel lblDescripcionPlazaCorta;
        private ComponentesGUI.ucLabel lblDescripcionPlaza;
        private ComponentesGUI.ucLabel lblCodigoPlaza;
        private ComponentesGUI.ucLabel lblTipoListaMoneda;
        private ComponentesGUI.ucLabel lblDescripcionMoneda;
        private ComponentesGUI.ucLabel lblCodigoMoneda;
        private ComponentesGUI.ucDataGridView dgvMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private ComponentesGUI.ucLabel lblTipoOperacion;
        private ComponentesGUI.ucLabel lblCodigoUsuario;
        private ComponentesGUI.ucLabel lblArchivoXML;
        private ComponentesGUI.ucLabel lblCabecera;
        private ComponentesGUI.ucTextBox txtAbreviatura;
        private System.Windows.Forms.TextBox textAbreviatura;


    }
}

