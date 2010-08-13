namespace ComponentesGUI
{
    partial class ucComboBox
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboControl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboControl
            // 
            this.cboControl.FormattingEnabled = true;
            this.cboControl.Location = new System.Drawing.Point(3, 3);
            this.cboControl.Name = "cboControl";
            this.cboControl.Size = new System.Drawing.Size(121, 21);
            this.cboControl.TabIndex = 0;
            // 
            // ucComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboControl);
            this.Name = "ucComboBox";
            this.Size = new System.Drawing.Size(126, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboControl;
    }
}
