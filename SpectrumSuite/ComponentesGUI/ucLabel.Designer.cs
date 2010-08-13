namespace ComponentesGUI
{
    partial class ucLabel
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
            this.lblControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(3, 0);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(35, 13);
            this.lblControl.TabIndex = 0;
            this.lblControl.Text = "label1";
            // 
            // ucLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblControl);
            this.Name = "ucLabel";
            this.Size = new System.Drawing.Size(39, 16);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControl;
    }
}
