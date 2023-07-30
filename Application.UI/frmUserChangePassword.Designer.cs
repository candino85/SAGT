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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveNueva2 = new System.Windows.Forms.TextBox();
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
            // txtClaveActual
            // 
            this.txtClaveActual.Location = new System.Drawing.Point(12, 41);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.Size = new System.Drawing.Size(320, 26);
            this.txtClaveActual.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 6;
            this.label1.Tag = "clave actual";
            this.label1.Text = "Clave Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Tag = "clave nueva";
            this.label2.Text = "Clave Nueva";
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Location = new System.Drawing.Point(13, 121);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.Size = new System.Drawing.Size(320, 26);
            this.txtClaveNueva.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 10;
            this.label3.Tag = "clave nueva";
            this.label3.Text = "Clave Nueva";
            // 
            // txtClaveNueva2
            // 
            this.txtClaveNueva2.Location = new System.Drawing.Point(14, 206);
            this.txtClaveNueva2.Name = "txtClaveNueva2";
            this.txtClaveNueva2.Size = new System.Drawing.Size(320, 26);
            this.txtClaveNueva2.TabIndex = 9;
            // 
            // frmUserChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClaveNueva2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarClave);
            this.Name = "frmUserChangePassword";
            this.Tag = "frmUserChangePassword";
            this.Text = "Cambio de Clave";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserChangePassword_FormClosed);
            this.Load += new System.EventHandler(this.frmUserChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveNueva2;
    }
}