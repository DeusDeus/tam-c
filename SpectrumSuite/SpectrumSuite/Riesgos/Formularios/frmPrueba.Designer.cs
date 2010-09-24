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
            this.cmdPrueba = new ComponentesGUI.ucButton();
            this.cboPrueba = new ComponentesGUI.ucComboBox();
            this.lblPrueba = new ComponentesGUI.ucLabel();
            this.SuspendLayout();
            // 
            // cmdPrueba
            // 
            this.cmdPrueba.Calculo = null;
            this.cmdPrueba.Es_Calculado = false;
            this.cmdPrueba.Es_Obligatorio = false;
            this.cmdPrueba.Flag_BD = false;
            this.cmdPrueba.Formula = null;
            this.cmdPrueba.Indicador = false;
            this.cmdPrueba.IndicadorXML = false;
            this.cmdPrueba.IO = null;
            this.cmdPrueba.Location = new System.Drawing.Point(193, 86);
            this.cmdPrueba.Longitud = null;
            this.cmdPrueba.Name = "cmdPrueba";
            this.cmdPrueba.Nombre_Campo = null;
            this.cmdPrueba.Nombre_Control = null;
            this.cmdPrueba.NombreTagXML = null;
            this.cmdPrueba.Precision = null;
            this.cmdPrueba.Size = new System.Drawing.Size(75, 23);
            this.cmdPrueba.Solo_Lectura = false;
            this.cmdPrueba.TabIndex = 0;
            this.cmdPrueba.Text = "ucButton1";
            this.cmdPrueba.Tipo_Dato = null;
            this.cmdPrueba.UseVisualStyleBackColor = true;
            this.cmdPrueba.Valor = null;
            // 
            // cboPrueba
            // 
            this.cboPrueba.Calculo = null;
            this.cboPrueba.Es_Calculado = false;
            this.cboPrueba.Es_Obligatorio = false;
            this.cboPrueba.Flag_BD = false;
            this.cboPrueba.FormattingEnabled = true;
            this.cboPrueba.Formula = null;
            this.cboPrueba.Indicador = false;
            this.cboPrueba.IndicadorXML = false;
            this.cboPrueba.IO = null;
            this.cboPrueba.Location = new System.Drawing.Point(37, 128);
            this.cboPrueba.Longitud = null;
            this.cboPrueba.Name = "cboPrueba";
            this.cboPrueba.Nombre_Campo = null;
            this.cboPrueba.Nombre_Control = null;
            this.cboPrueba.NombreTagXML = null;
            this.cboPrueba.Precision = null;
            this.cboPrueba.Size = new System.Drawing.Size(121, 21);
            this.cboPrueba.Solo_Lectura = false;
            this.cboPrueba.TabIndex = 1;
            this.cboPrueba.Tipo_Dato = null;
            this.cboPrueba.Valor = null;
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Calculo = null;
            this.lblPrueba.Es_Calculado = false;
            this.lblPrueba.Es_Obligatorio = false;
            this.lblPrueba.Flag_BD = false;
            this.lblPrueba.Formula = null;
            this.lblPrueba.Indicador = false;
            this.lblPrueba.IndicadorXML = false;
            this.lblPrueba.IO = null;
            this.lblPrueba.Location = new System.Drawing.Point(52, 46);
            this.lblPrueba.Longitud = null;
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Nombre_Campo = null;
            this.lblPrueba.Nombre_Control = null;
            this.lblPrueba.NombreTagXML = null;
            this.lblPrueba.Precision = null;
            this.lblPrueba.Size = new System.Drawing.Size(51, 13);
            this.lblPrueba.Solo_Lectura = false;
            this.lblPrueba.TabIndex = 2;
            this.lblPrueba.Text = "ucLabel1";
            this.lblPrueba.Tipo_Dato = null;
            this.lblPrueba.Valor = null;
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.cboPrueba);
            this.Controls.Add(this.cmdPrueba);
            this.Name = "frmPrueba";
            this.Text = "frmPrueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentesGUI.ucButton cmdPrueba;
        private ComponentesGUI.ucComboBox cboPrueba;
        private ComponentesGUI.ucLabel lblPrueba;
    }
}