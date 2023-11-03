
namespace Application.UI.Negocio
{
    partial class frmClient
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
            this.txtAddress = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtID = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.txtLastname = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.txtName = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(21, 410);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(78, 24);
            this.chkActive.TabIndex = 19;
            this.chkActive.Tag = "activo";
            this.chkActive.Text = "Activo";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(263, 452);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 41);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Tag = "eliminar socio";
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(138, 452);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(115, 41);
            this.btnModify.TabIndex = 18;
            this.btnModify.Tag = "modificar socio";
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.LabelText = "Direccion";
            this.txtAddress.Location = new System.Drawing.Point(15, 319);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.Size = new System.Drawing.Size(362, 69);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.TextBoxText = "";
            // 
            // btnCreate
            // 
            this.btnCreate.AutoEllipsis = true;
            this.btnCreate.Location = new System.Drawing.Point(15, 452);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 41);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Tag = "crear cliente";
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.LabelText = "DNI";
            this.txtID.Location = new System.Drawing.Point(15, 158);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.Size = new System.Drawing.Size(362, 69);
            this.txtID.TabIndex = 14;
            this.txtID.TextBoxText = "";
            // 
            // txtLastname
            // 
            this.txtLastname.AutoSize = true;
            this.txtLastname.LabelText = "Apellido";
            this.txtLastname.Location = new System.Drawing.Point(15, 86);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.Size = new System.Drawing.Size(362, 69);
            this.txtLastname.TabIndex = 13;
            this.txtLastname.TextBoxText = "";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.LabelText = "Nombre";
            this.txtName.Location = new System.Drawing.Point(15, 11);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Size = new System.Drawing.Size(362, 69);
            this.txtName.TabIndex = 12;
            this.txtName.Tag = "nombre";
            this.txtName.TextBoxText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 30);
            this.label1.TabIndex = 20;
            this.label1.Tag = "email";
            this.label1.Text = "Correo Electrónico";
            // 
            // txtEmail
            // 
            this.txtEmail.CausesValidation = false;
            this.txtEmail.Location = new System.Drawing.Point(15, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(362, 26);
            this.txtEmail.TabIndex = 21;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 343);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClient";
            this.Tag = "frmCliente";
            this.Text = "Ficha de Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClient_FormClosed);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private Customs_Controls.TextBoxLabeled txtAddress;
        private System.Windows.Forms.Button btnCreate;
        private Customs_Controls.TextBoxLabeled txtID;
        private Customs_Controls.TextBoxLabeled txtLastname;
        private Customs_Controls.TextBoxLabeled txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
    }
}