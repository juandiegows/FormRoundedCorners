namespace FormRoundedCorners
{
    partial class Form1
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
            this.ellipseComponent1 = new FormRoundedCorners.Components.EllipseComponent();
            this.ellipseControl1 = new FormRoundedCorners.Controls.EllipseControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ellipseComponent1
            // 
            this.ellipseComponent1.CornerRadius = 60;
            this.ellipseComponent1.TargetControl = this;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ellipseControl1.CornerRadius = 80;
            this.ellipseControl1.Location = new System.Drawing.Point(252, 108);
            this.ellipseControl1.Name = "ellipseControl1";
            this.ellipseControl1.Size = new System.Drawing.Size(269, 187);
            this.ellipseControl1.TabIndex = 0;
            this.ellipseControl1.Text = "ellipseControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ellipseControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.EllipseComponent ellipseComponent1;
        private Controls.EllipseControl ellipseControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

