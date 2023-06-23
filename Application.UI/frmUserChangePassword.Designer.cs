namespace Application.UI
{
    partial class frmUserChangePassword
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
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.txtClaveNueva2 = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.txtClaveNueva = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.txtClaveActual = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Location = new System.Drawing.Point(13, 249);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(152, 32);
            this.btnCambiarClave.TabIndex = 3;
            this.btnCambiarClave.Tag = "cambiarClave";
            this.btnCambiarClave.Text = "Cambiar Clave";
            this.btnCambiarClave.UseVisualStyleBackColor = true;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // txtClaveNueva2
            // 
            this.txtClaveNueva2.LabelText = "Clave Nueva";
            this.txtClaveNueva2.Location = new System.Drawing.Point(13, 157);
            this.txtClaveNueva2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClaveNueva2.Name = "txtClaveNueva2";
            this.txtClaveNueva2.PasswordChar = '\0';
            this.txtClaveNueva2.Size = new System.Drawing.Size(319, 62);
            this.txtClaveNueva2.TabIndex = 2;
            this.txtClaveNueva2.Tag = "claveNueva";
            this.txtClaveNueva2.TextBoxText = "";
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.LabelText = "Clave Nueva";
            this.txtClaveNueva.Location = new System.Drawing.Point(13, 85);
            this.txtClaveNueva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.PasswordChar = '\0';
            this.txtClaveNueva.Size = new System.Drawing.Size(319, 62);
            this.txtClaveNueva.TabIndex = 1;
            this.txtClaveNueva.Tag = "claveNueva";
            this.txtClaveNueva.TextBoxText = "";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.LabelText = "Clave Actual";
            this.txtClaveActual.Location = new System.Drawing.Point(13, 13);
            this.txtClaveActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '\0';
            this.txtClaveActual.Size = new System.Drawing.Size(319, 62);
            this.txtClaveActual.TabIndex = 0;
            this.txtClaveActual.Tag = "claveActual";
            this.txtClaveActual.TextBoxText = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Tag = "cancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmUserChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 302);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarClave);
            this.Controls.Add(this.txtClaveNueva2);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.txtClaveActual);
            this.Name = "frmUserChangePassword";
            this.Text = "frmUserChangePassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserChangePassword_FormClosed);
            this.Load += new System.EventHandler(this.frmUserChangePassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Customs_Controls.TextBoxLabeled txtClaveActual;
        private Customs_Controls.TextBoxLabeled txtClaveNueva;
        private Customs_Controls.TextBoxLabeled txtClaveNueva2;
        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.Button btnCancelar;
    }
}