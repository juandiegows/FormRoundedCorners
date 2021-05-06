namespace FormRoundedCorners
{
    partial class FormExample
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ellipseComponentFormExample = new FormRoundedCorners.Components.EllipseComponent();
            this.ellipseControl1 = new FormRoundedCorners.Controls.EllipseControl();
            this.SuspendLayout();
            // 
            // ellipseComponentFormExample
            // 
            this.ellipseComponentFormExample.CornerRadius = 60;
            this.ellipseComponentFormExample.TargetControl = this;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ellipseControl1.CornerRadius = 80;
            this.ellipseControl1.Location = new System.Drawing.Point(252, 108);
            this.ellipseControl1.Name = "ellipseControl1";
            this.ellipseControl1.Size = new System.Drawing.Size(269, 187);
            this.ellipseControl1.TabIndex = 0;
            this.ellipseControl1.Text = "ellipseControl";
            // 
            // FormExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ellipseControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExample";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.EllipseComponent ellipseComponentFormExample;
        private Controls.EllipseControl ellipseControl1;
    }
}

