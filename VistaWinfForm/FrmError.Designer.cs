namespace VistaWinfForm
{
    partial class FrmError
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.btnCerrarError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Error!";
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeError.Location = new System.Drawing.Point(12, 54);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(484, 223);
            this.lblMensajeError.TabIndex = 1;
            this.lblMensajeError.Text = "Mensaje de error";
            // 
            // btnCerrarError
            // 
            this.btnCerrarError.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarError.Location = new System.Drawing.Point(208, 280);
            this.btnCerrarError.Name = "btnCerrarError";
            this.btnCerrarError.Size = new System.Drawing.Size(116, 48);
            this.btnCerrarError.TabIndex = 2;
            this.btnCerrarError.Text = "Aceptar";
            this.btnCerrarError.UseVisualStyleBackColor = true;
            this.btnCerrarError.Click += new System.EventHandler(this.btnCerrarError_Click);
            // 
            // FrmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 340);
            this.Controls.Add(this.btnCerrarError);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.label1);
            this.Name = "FrmError";
            this.Text = "FrmError";
            this.Load += new System.EventHandler(this.FrmError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensajeError;
        private System.Windows.Forms.Button btnCerrarError;
    }
}