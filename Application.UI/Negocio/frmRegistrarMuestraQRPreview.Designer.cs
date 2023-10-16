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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImprimirQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 277);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnImprimirQR
            // 
            this.btnImprimirQR.Location = new System.Drawing.Point(12, 301);
            this.btnImprimirQR.Name = "btnImprimirQR";
            this.btnImprimirQR.Size = new System.Drawing.Size(340, 43);
            this.btnImprimirQR.TabIndex = 1;
            this.btnImprimirQR.Tag = "imprimir etiqueta";
            this.btnImprimirQR.Text = "Imprimir Etiqueta";
            this.btnImprimirQR.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarMuestraQRPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 356);
            this.Controls.Add(this.btnImprimirQR);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmRegistrarMuestraQRPreview";
            this.Tag = "frmRegistrarMuestraQRPreview";
            this.Text = "frmRegistrarMuestraQRPreview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImprimirQR;
    }
}