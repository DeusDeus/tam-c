namespace ComponentesGUI
{
    partial class ucCheckBox
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
            this.cbControl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbControl
            // 
            this.cbControl.AutoSize = true;
            this.cbControl.Location = new System.Drawing.Point(3, 3);
            this.cbControl.Name = "cbControl";
            this.cbControl.Size = new System.Drawing.Size(80, 17);
            this.cbControl.TabIndex = 0;
            this.cbControl.Text = "checkBox1";
            this.cbControl.UseVisualStyleBackColor = true;
            // 
            // ucCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbControl);
            this.Name = "ucCheckBox";
            this.Size = new System.Drawing.Size(81, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbControl;
    }
}
