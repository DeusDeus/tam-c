namespace SpectrumSuite.Riesgos.Formularios
{
    partial class frmPrueba
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
            this.tbcPersonas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTipoOperacion = new ComponentesGUI.ucLabel();
            this.lblArchivoXML = new ComponentesGUI.ucLabel();
            this.lblId = new ComponentesGUI.ucLabel();
            this.dgvPersonas = new ComponentesGUI.ucDataGridView();
            this.txtNombreBusca = new ComponentesGUI.ucTextBox();
            this.lblPaternoBuscar = new ComponentesGUI.ucLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdCancelar = new ComponentesGUI.ucButton();
            this.cmdGrabar = new ComponentesGUI.ucButton();
            this.txtMaterno = new ComponentesGUI.ucTextBox();
            this.txtPaterno = new ComponentesGUI.ucTextBox();
            this.txtNombres = new ComponentesGUI.ucTextBox();
            this.lblMaterno = new ComponentesGUI.ucLabel();
            this.lblPaterno = new ComponentesGUI.ucLabel();
            this.lblNombres = new ComponentesGUI.ucLabel();
            this.cmdNuevo = new ComponentesGUI.ucButton();
            this.cmdModificar = new ComponentesGUI.ucButton();
            this.cmdEliminar = new ComponentesGUI.ucButton();
            this.cmdSalir = new ComponentesGUI.ucButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPersonas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPersonas
            // 
            this.tbcPersonas.Controls.Add(this.tabPage1);
            this.tbcPersonas.Controls.Add(this.tabPage2);
            this.tbcPersonas.Location = new System.Drawing.Point(0, 0);
            this.tbcPersonas.Name = "tbcPersonas";
            this.tbcPersonas.SelectedIndex = 0;
            this.tbcPersonas.Size = new System.Drawing.Size(425, 247);
            this.tbcPersonas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTipoOperacion);
            this.tabPage1.Controls.Add(this.lblArchivoXML);
            this.tabPage1.Controls.Add(this.lblId);
            this.tabPage1.Controls.Add(this.dgvPersonas);
            this.tabPage1.Controls.Add(this.txtNombreBusca);
            this.tabPage1.Controls.Add(this.lblPaternoBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Persona";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.lblTipoOperacion.Location = new System.Drawing.Point(36, 35);
            this.lblTipoOperacion.Longitud = null;
            this.lblTipoOperacion.Name = "lblTipoOperacion";
            this.lblTipoOperacion.Nombre_Campo = null;
            this.lblTipoOperacion.Nombre_Control = null;
            this.lblTipoOperacion.NombreTagXML = null;
            this.lblTipoOperacion.Precision = null;
            this.lblTipoOperacion.Size = new System.Drawing.Size(24, 13);
            this.lblTipoOperacion.Solo_Lectura = false;
            this.lblTipoOperacion.TabIndex = 5;
            this.lblTipoOperacion.Text = "tipo";
            this.lblTipoOperacion.Tipo_Dato = null;
            this.lblTipoOperacion.Valor = null;
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
            this.lblArchivoXML.Location = new System.Drawing.Point(8, 35);
            this.lblArchivoXML.Longitud = null;
            this.lblArchivoXML.Name = "lblArchivoXML";
            this.lblArchivoXML.Nombre_Campo = null;
            this.lblArchivoXML.Nombre_Control = null;
            this.lblArchivoXML.NombreTagXML = null;
            this.lblArchivoXML.Precision = null;
            this.lblArchivoXML.Size = new System.Drawing.Size(22, 13);
            this.lblArchivoXML.Solo_Lectura = false;
            this.lblArchivoXML.TabIndex = 4;
            this.lblArchivoXML.Text = "xml";
            this.lblArchivoXML.Tipo_Dato = null;
            this.lblArchivoXML.Valor = null;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Calculo = null;
            this.lblId.Es_Calculado = false;
            this.lblId.Es_Obligatorio = false;
            this.lblId.Flag_BD = false;
            this.lblId.Formula = null;
            this.lblId.Indicador = false;
            this.lblId.IndicadorIdentity = null;
            this.lblId.IndicadorPK = null;
            this.lblId.IndicadorXML = false;
            this.lblId.IO = null;
            this.lblId.Location = new System.Drawing.Point(8, 19);
            this.lblId.Longitud = null;
            this.lblId.Name = "lblId";
            this.lblId.Nombre_Campo = null;
            this.lblId.Nombre_Control = null;
            this.lblId.NombreTagXML = null;
            this.lblId.Precision = null;
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.Solo_Lectura = false;
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            this.lblId.Tipo_Dato = null;
            this.lblId.Valor = null;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AllowUserToResizeColumns = false;
            this.dgvPersonas.AllowUserToResizeRows = false;
            this.dgvPersonas.Calculo = null;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPersonas.Es_Calculado = false;
            this.dgvPersonas.Es_Obligatorio = false;
            this.dgvPersonas.Flag_BD = false;
            this.dgvPersonas.Formula = null;
            this.dgvPersonas.Indicador = false;
            this.dgvPersonas.IndicadorIdentity = null;
            this.dgvPersonas.IndicadorPK = null;
            this.dgvPersonas.IndicadorXML = false;
            this.dgvPersonas.IO = null;
            this.dgvPersonas.Location = new System.Drawing.Point(11, 51);
            this.dgvPersonas.Longitud = null;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Nombre_Campo = null;
            this.dgvPersonas.Nombre_Control = null;
            this.dgvPersonas.NombreTagXML = null;
            this.dgvPersonas.Precision = null;
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(396, 150);
            this.dgvPersonas.Solo_Lectura = false;
            this.dgvPersonas.TabIndex = 2;
            this.dgvPersonas.Tipo_Dato = null;
            this.dgvPersonas.Valor = null;
            // 
            // txtNombreBusca
            // 
            this.txtNombreBusca.Calculo = null;
            this.txtNombreBusca.Es_Calculado = false;
            this.txtNombreBusca.Es_Obligatorio = false;
            this.txtNombreBusca.Flag_BD = false;
            this.txtNombreBusca.Formula = null;
            this.txtNombreBusca.Indicador = false;
            this.txtNombreBusca.IndicadorIdentity = null;
            this.txtNombreBusca.IndicadorPK = null;
            this.txtNombreBusca.IndicadorXML = false;
            this.txtNombreBusca.IO = null;
            this.txtNombreBusca.Location = new System.Drawing.Point(146, 12);
            this.txtNombreBusca.Longitud = null;
            this.txtNombreBusca.Name = "txtNombreBusca";
            this.txtNombreBusca.Nombre_Campo = null;
            this.txtNombreBusca.Nombre_Control = null;
            this.txtNombreBusca.NombreTagXML = null;
            this.txtNombreBusca.Precision = null;
            this.txtNombreBusca.Size = new System.Drawing.Size(194, 20);
            this.txtNombreBusca.Solo_Lectura = false;
            this.txtNombreBusca.TabIndex = 1;
            this.txtNombreBusca.Tipo_Dato = null;
            this.txtNombreBusca.Valor = null;
            // 
            // lblPaternoBuscar
            // 
            this.lblPaternoBuscar.AutoSize = true;
            this.lblPaternoBuscar.Calculo = null;
            this.lblPaternoBuscar.Es_Calculado = false;
            this.lblPaternoBuscar.Es_Obligatorio = false;
            this.lblPaternoBuscar.Flag_BD = false;
            this.lblPaternoBuscar.Formula = null;
            this.lblPaternoBuscar.Indicador = false;
            this.lblPaternoBuscar.IndicadorIdentity = null;
            this.lblPaternoBuscar.IndicadorPK = null;
            this.lblPaternoBuscar.IndicadorXML = false;
            this.lblPaternoBuscar.IO = null;
            this.lblPaternoBuscar.Location = new System.Drawing.Point(74, 15);
            this.lblPaternoBuscar.Longitud = null;
            this.lblPaternoBuscar.Name = "lblPaternoBuscar";
            this.lblPaternoBuscar.Nombre_Campo = null;
            this.lblPaternoBuscar.Nombre_Control = null;
            this.lblPaternoBuscar.NombreTagXML = null;
            this.lblPaternoBuscar.Precision = null;
            this.lblPaternoBuscar.Size = new System.Drawing.Size(66, 13);
            this.lblPaternoBuscar.Solo_Lectura = false;
            this.lblPaternoBuscar.TabIndex = 0;
            this.lblPaternoBuscar.Text = "Ap. Paterno:";
            this.lblPaternoBuscar.Tipo_Dato = null;
            this.lblPaternoBuscar.Valor = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdCancelar);
            this.tabPage2.Controls.Add(this.cmdGrabar);
            this.tabPage2.Controls.Add(this.txtMaterno);
            this.tabPage2.Controls.Add(this.txtPaterno);
            this.tabPage2.Controls.Add(this.txtNombres);
            this.tabPage2.Controls.Add(this.lblMaterno);
            this.tabPage2.Controls.Add(this.lblPaterno);
            this.tabPage2.Controls.Add(this.lblNombres);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.cmdCancelar.Location = new System.Drawing.Point(221, 174);
            this.cmdCancelar.Longitud = null;
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Nombre_Campo = null;
            this.cmdCancelar.Nombre_Control = null;
            this.cmdCancelar.NombreTagXML = null;
            this.cmdCancelar.Precision = null;
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.Solo_Lectura = false;
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Tipo_Dato = null;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Valor = null;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Calculo = null;
            this.cmdGrabar.Es_Calculado = false;
            this.cmdGrabar.Es_Obligatorio = false;
            this.cmdGrabar.Flag_BD = false;
            this.cmdGrabar.Formula = null;
            this.cmdGrabar.Indicador = false;
            this.cmdGrabar.IndicadorIdentity = null;
            this.cmdGrabar.IndicadorPK = null;
            this.cmdGrabar.IndicadorXML = false;
            this.cmdGrabar.IO = null;
            this.cmdGrabar.Location = new System.Drawing.Point(332, 174);
            this.cmdGrabar.Longitud = null;
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Nombre_Campo = null;
            this.cmdGrabar.Nombre_Control = null;
            this.cmdGrabar.NombreTagXML = null;
            this.cmdGrabar.Precision = null;
            this.cmdGrabar.Size = new System.Drawing.Size(75, 23);
            this.cmdGrabar.Solo_Lectura = false;
            this.cmdGrabar.TabIndex = 6;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.Tipo_Dato = null;
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Valor = null;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // txtMaterno
            // 
            this.txtMaterno.Calculo = null;
            this.txtMaterno.Es_Calculado = false;
            this.txtMaterno.Es_Obligatorio = false;
            this.txtMaterno.Flag_BD = false;
            this.txtMaterno.Formula = null;
            this.txtMaterno.Indicador = false;
            this.txtMaterno.IndicadorIdentity = null;
            this.txtMaterno.IndicadorPK = null;
            this.txtMaterno.IndicadorXML = false;
            this.txtMaterno.IO = null;
            this.txtMaterno.Location = new System.Drawing.Point(101, 110);
            this.txtMaterno.Longitud = null;
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Nombre_Campo = null;
            this.txtMaterno.Nombre_Control = null;
            this.txtMaterno.NombreTagXML = null;
            this.txtMaterno.Precision = null;
            this.txtMaterno.Size = new System.Drawing.Size(178, 20);
            this.txtMaterno.Solo_Lectura = false;
            this.txtMaterno.TabIndex = 5;
            this.txtMaterno.Tipo_Dato = null;
            this.txtMaterno.Valor = null;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Calculo = null;
            this.txtPaterno.Es_Calculado = false;
            this.txtPaterno.Es_Obligatorio = false;
            this.txtPaterno.Flag_BD = false;
            this.txtPaterno.Formula = null;
            this.txtPaterno.Indicador = false;
            this.txtPaterno.IndicadorIdentity = null;
            this.txtPaterno.IndicadorPK = null;
            this.txtPaterno.IndicadorXML = false;
            this.txtPaterno.IO = null;
            this.txtPaterno.Location = new System.Drawing.Point(101, 61);
            this.txtPaterno.Longitud = null;
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Nombre_Campo = null;
            this.txtPaterno.Nombre_Control = null;
            this.txtPaterno.NombreTagXML = null;
            this.txtPaterno.Precision = null;
            this.txtPaterno.Size = new System.Drawing.Size(178, 20);
            this.txtPaterno.Solo_Lectura = false;
            this.txtPaterno.TabIndex = 4;
            this.txtPaterno.Tipo_Dato = null;
            this.txtPaterno.Valor = null;
            // 
            // txtNombres
            // 
            this.txtNombres.Calculo = null;
            this.txtNombres.Es_Calculado = false;
            this.txtNombres.Es_Obligatorio = false;
            this.txtNombres.Flag_BD = false;
            this.txtNombres.Formula = null;
            this.txtNombres.Indicador = false;
            this.txtNombres.IndicadorIdentity = null;
            this.txtNombres.IndicadorPK = null;
            this.txtNombres.IndicadorXML = false;
            this.txtNombres.IO = null;
            this.txtNombres.Location = new System.Drawing.Point(101, 18);
            this.txtNombres.Longitud = null;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Nombre_Campo = null;
            this.txtNombres.Nombre_Control = null;
            this.txtNombres.NombreTagXML = null;
            this.txtNombres.Precision = null;
            this.txtNombres.Size = new System.Drawing.Size(178, 20);
            this.txtNombres.Solo_Lectura = false;
            this.txtNombres.TabIndex = 3;
            this.txtNombres.Tipo_Dato = null;
            this.txtNombres.Valor = null;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Calculo = null;
            this.lblMaterno.Es_Calculado = false;
            this.lblMaterno.Es_Obligatorio = false;
            this.lblMaterno.Flag_BD = false;
            this.lblMaterno.Formula = null;
            this.lblMaterno.Indicador = false;
            this.lblMaterno.IndicadorIdentity = null;
            this.lblMaterno.IndicadorPK = null;
            this.lblMaterno.IndicadorXML = false;
            this.lblMaterno.IO = null;
            this.lblMaterno.Location = new System.Drawing.Point(20, 113);
            this.lblMaterno.Longitud = null;
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Nombre_Campo = null;
            this.lblMaterno.Nombre_Control = null;
            this.lblMaterno.NombreTagXML = null;
            this.lblMaterno.Precision = null;
            this.lblMaterno.Size = new System.Drawing.Size(65, 13);
            this.lblMaterno.Solo_Lectura = false;
            this.lblMaterno.TabIndex = 2;
            this.lblMaterno.Text = "Ap. Materno";
            this.lblMaterno.Tipo_Dato = null;
            this.lblMaterno.Valor = null;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Calculo = null;
            this.lblPaterno.Es_Calculado = false;
            this.lblPaterno.Es_Obligatorio = false;
            this.lblPaterno.Flag_BD = false;
            this.lblPaterno.Formula = null;
            this.lblPaterno.Indicador = false;
            this.lblPaterno.IndicadorIdentity = null;
            this.lblPaterno.IndicadorPK = null;
            this.lblPaterno.IndicadorXML = false;
            this.lblPaterno.IO = null;
            this.lblPaterno.Location = new System.Drawing.Point(20, 64);
            this.lblPaterno.Longitud = null;
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Nombre_Campo = null;
            this.lblPaterno.Nombre_Control = null;
            this.lblPaterno.NombreTagXML = null;
            this.lblPaterno.Precision = null;
            this.lblPaterno.Size = new System.Drawing.Size(66, 13);
            this.lblPaterno.Solo_Lectura = false;
            this.lblPaterno.TabIndex = 1;
            this.lblPaterno.Text = "Ap. Paterno:";
            this.lblPaterno.Tipo_Dato = null;
            this.lblPaterno.Valor = null;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Calculo = null;
            this.lblNombres.Es_Calculado = false;
            this.lblNombres.Es_Obligatorio = false;
            this.lblNombres.Flag_BD = false;
            this.lblNombres.Formula = null;
            this.lblNombres.Indicador = false;
            this.lblNombres.IndicadorIdentity = null;
            this.lblNombres.IndicadorPK = null;
            this.lblNombres.IndicadorXML = false;
            this.lblNombres.IO = null;
            this.lblNombres.Location = new System.Drawing.Point(19, 21);
            this.lblNombres.Longitud = null;
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Nombre_Campo = null;
            this.lblNombres.Nombre_Control = null;
            this.lblNombres.NombreTagXML = null;
            this.lblNombres.Precision = null;
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.Solo_Lectura = false;
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres:";
            this.lblNombres.Tipo_Dato = null;
            this.lblNombres.Valor = null;
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
            this.cmdNuevo.Location = new System.Drawing.Point(12, 256);
            this.cmdNuevo.Longitud = null;
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Nombre_Campo = null;
            this.cmdNuevo.Nombre_Control = null;
            this.cmdNuevo.NombreTagXML = null;
            this.cmdNuevo.Precision = null;
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.Solo_Lectura = false;
            this.cmdNuevo.TabIndex = 1;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.Tipo_Dato = null;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Valor = null;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
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
            this.cmdModificar.Location = new System.Drawing.Point(93, 256);
            this.cmdModificar.Longitud = null;
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Nombre_Campo = null;
            this.cmdModificar.Nombre_Control = null;
            this.cmdModificar.NombreTagXML = null;
            this.cmdModificar.Precision = null;
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.Solo_Lectura = false;
            this.cmdModificar.TabIndex = 2;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.Tipo_Dato = null;
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Valor = null;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
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
            this.cmdEliminar.Location = new System.Drawing.Point(174, 256);
            this.cmdEliminar.Longitud = null;
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Nombre_Campo = null;
            this.cmdEliminar.Nombre_Control = null;
            this.cmdEliminar.NombreTagXML = null;
            this.cmdEliminar.Precision = null;
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.Solo_Lectura = false;
            this.cmdEliminar.TabIndex = 3;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.Tipo_Dato = null;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Valor = null;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
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
            this.cmdSalir.Location = new System.Drawing.Point(336, 256);
            this.cmdSalir.Longitud = null;
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Nombre_Campo = null;
            this.cmdSalir.Nombre_Control = null;
            this.cmdSalir.NombreTagXML = null;
            this.cmdSalir.Precision = null;
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.Solo_Lectura = false;
            this.cmdSalir.TabIndex = 5;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Tipo_Dato = null;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Valor = null;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ap. Paterno";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ap. Materno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombres";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 291);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.tbcPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            this.tbcPersonas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPersonas;
        private System.Windows.Forms.TabPage tabPage1;
        private ComponentesGUI.ucTextBox txtNombreBusca;
        private ComponentesGUI.ucLabel lblPaternoBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private ComponentesGUI.ucDataGridView dgvPersonas;
        private ComponentesGUI.ucTextBox txtMaterno;
        private ComponentesGUI.ucTextBox txtPaterno;
        private ComponentesGUI.ucTextBox txtNombres;
        private ComponentesGUI.ucLabel lblMaterno;
        private ComponentesGUI.ucLabel lblPaterno;
        private ComponentesGUI.ucLabel lblNombres;
        private ComponentesGUI.ucButton cmdNuevo;
        private ComponentesGUI.ucButton cmdModificar;
        private ComponentesGUI.ucButton cmdEliminar;
        private ComponentesGUI.ucButton cmdSalir;
        private ComponentesGUI.ucLabel lblId;
        private ComponentesGUI.ucButton cmdCancelar;
        private ComponentesGUI.ucButton cmdGrabar;
        private ComponentesGUI.ucLabel lblArchivoXML;
        private ComponentesGUI.ucLabel lblTipoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;


    }
}