namespace Application.UI.Negocio.ABM
{
    partial class frmEstudio
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
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtTiempo = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.txtName = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(212, 275);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(78, 24);
            this.chkActive.TabIndex = 27;
            this.chkActive.Tag = "activo";
            this.chkActive.Text = "Activo";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(303, 325);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 43);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Tag = "eliminar socio";
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(160, 325);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(135, 43);
            this.btnModify.TabIndex = 26;
            this.btnModify.Tag = "modificar socio";
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoEllipsis = true;
            this.btnCreate.Location = new System.Drawing.Point(20, 325);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 43);
            this.btnCreate.TabIndex = 25;
            this.btnCreate.Tag = "crear cliente";
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.AutoSize = true;
            this.txtTiempo.LabelText = "Tiempo";
            this.txtTiempo.Location = new System.Drawing.Point(15, 174);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.PasswordChar = '\0';
            this.txtTiempo.Size = new System.Drawing.Size(280, 69);
            this.txtTiempo.TabIndex = 22;
            this.txtTiempo.Tag = "tiempo";
            this.txtTiempo.TextBoxText = "";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.LabelText = "Nombre";
            this.txtName.Location = new System.Drawing.Point(15, 17);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Size = new System.Drawing.Size(280, 69);
            this.txtName.TabIndex = 20;
            this.txtName.Tag = "nombre";
            this.txtName.TextBoxText = "";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(15, 135);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(275, 28);
            this.cmbEspecialidad.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 29;
            this.label1.Tag = "especialidad";
            this.label1.Text = "Especialidad";
            // 
            // frmEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtName);
            this.Name = "frmEstudio";
            this.Text = "frmEstudio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreate;
        private Customs_Controls.TextBoxLabeled txtTiempo;
        private Customs_Controls.TextBoxLabeled txtName;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label1;
    }
}