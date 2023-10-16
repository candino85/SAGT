namespace Application.UI.Digito_Verificador
{
    partial class frmDigitoVerificador
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
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.Location = new System.Drawing.Point(107, 31);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(306, 48);
            this.btnRecalcular.TabIndex = 0;
            this.btnRecalcular.Tag = "recalcular digitos";
            this.btnRecalcular.Text = "Recalcular Dígitos ";
            this.btnRecalcular.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(107, 101);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(306, 48);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Tag = "restaurar base de datos";
            this.btnRestore.Text = "Restaurar Base de Datos";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // frmDigitoVerificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 180);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnRecalcular);
            this.Name = "frmDigitoVerificador";
            this.Text = "frmDigitoVerificador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecalcular;
        private System.Windows.Forms.Button btnRestore;
    }
}