namespace ComponentesGUI
{
    partial class ucDateTimePicker
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
            this.dtpControl = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpControl
            // 
            this.dtpControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpControl.Location = new System.Drawing.Point(0, 0);
            this.dtpControl.Name = "dtpControl";
            this.dtpControl.Size = new System.Drawing.Size(83, 20);
            this.dtpControl.TabIndex = 0;
            // 
            // ucDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpControl);
            this.Name = "ucDateTimePicker";
            this.Size = new System.Drawing.Size(84, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpControl;
    }
}
