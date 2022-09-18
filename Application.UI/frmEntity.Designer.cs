
namespace Application.UI
{
    partial class frmEntity
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbEntity = new System.Windows.Forms.GroupBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnCreateEntity = new System.Windows.Forms.Button();
            this.btnUpdateEntity = new System.Windows.Forms.Button();
            this.gpbEntity.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 90);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(154, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(6, 142);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(154, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(8, 196);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(152, 20);
            this.txtCuit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Tag = "nombre entidad";
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Tag = "direccion";
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Tag = "telefono";
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Tag = "Cuit";
            this.label4.Text = "Cuit";
            // 
            // gpbEntity
            // 
            this.gpbEntity.Controls.Add(this.chkActive);
            this.gpbEntity.Controls.Add(this.label4);
            this.gpbEntity.Controls.Add(this.txtCuit);
            this.gpbEntity.Controls.Add(this.txtNombre);
            this.gpbEntity.Controls.Add(this.label3);
            this.gpbEntity.Controls.Add(this.label2);
            this.gpbEntity.Controls.Add(this.txtDireccion);
            this.gpbEntity.Controls.Add(this.txtTelefono);
            this.gpbEntity.Location = new System.Drawing.Point(12, 12);
            this.gpbEntity.Name = "gpbEntity";
            this.gpbEntity.Size = new System.Drawing.Size(172, 299);
            this.gpbEntity.TabIndex = 8;
            this.gpbEntity.TabStop = false;
            this.gpbEntity.Tag = "informacion Entidad";
            this.gpbEntity.Text = "Información de Entidad";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(104, 248);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 10;
            this.chkActive.Tag = "activo";
            this.chkActive.Text = "Activo";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnCreateEntity
            // 
            this.btnCreateEntity.Location = new System.Drawing.Point(190, 23);
            this.btnCreateEntity.Name = "btnCreateEntity";
            this.btnCreateEntity.Size = new System.Drawing.Size(132, 28);
            this.btnCreateEntity.TabIndex = 9;
            this.btnCreateEntity.Tag = "crear entidad";
            this.btnCreateEntity.Text = "Crear entidad";
            this.btnCreateEntity.UseVisualStyleBackColor = true;
            this.btnCreateEntity.Click += new System.EventHandler(this.btnCreateEntity_Click);
            // 
            // btnUpdateEntity
            // 
            this.btnUpdateEntity.Location = new System.Drawing.Point(190, 57);
            this.btnUpdateEntity.Name = "btnUpdateEntity";
            this.btnUpdateEntity.Size = new System.Drawing.Size(132, 28);
            this.btnUpdateEntity.TabIndex = 10;
            this.btnUpdateEntity.Tag = "guardar cambios";
            this.btnUpdateEntity.Text = "Guardar cambios";
            this.btnUpdateEntity.UseVisualStyleBackColor = true;
            this.btnUpdateEntity.Click += new System.EventHandler(this.btnUpdateEntity_Click);
            // 
            // frmEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 342);
            this.Controls.Add(this.btnUpdateEntity);
            this.Controls.Add(this.btnCreateEntity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbEntity);
            this.Name = "frmEntity";
            this.Text = "frmEntity";
            this.gpbEntity.ResumeLayout(false);
            this.gpbEntity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbEntity;
        private System.Windows.Forms.Button btnCreateEntity;
        private System.Windows.Forms.Button btnUpdateEntity;
        private System.Windows.Forms.CheckBox chkActive;
    }
}