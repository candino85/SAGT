namespace Application.UI.Negocio
{
    partial class frmRegistrarMuestraQRPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarMuestraQRPreview));
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.btnImprimirQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(12, 12);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(300, 311);
            this.pbQR.TabIndex = 0;
            this.pbQR.TabStop = false;
            // 
            // btnImprimirQR
            // 
            this.btnImprimirQR.Location = new System.Drawing.Point(12, 329);
            this.btnImprimirQR.Name = "btnImprimirQR";
            this.btnImprimirQR.Size = new System.Drawing.Size(300, 43);
            this.btnImprimirQR.TabIndex = 1;
            this.btnImprimirQR.Tag = "imprimir etiqueta";
            this.btnImprimirQR.Text = "Imprimir Etiqueta";
            this.btnImprimirQR.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarMuestraQRPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 384);
            this.Controls.Add(this.btnImprimirQR);
            this.Controls.Add(this.pbQR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistrarMuestraQRPreview";
            this.Tag = "frmRegistrarMuestraQRPreview";
            this.Text = "Registrar Muestra QR Preview";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegistrarMuestraQRPreview_FormClosed);
            this.Load += new System.EventHandler(this.frmRegistrarMuestraQRPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Button btnImprimirQR;
    }
}