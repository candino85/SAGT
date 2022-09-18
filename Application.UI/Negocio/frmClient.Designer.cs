
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
            this.gpbClient = new System.Windows.Forms.GroupBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtAddress = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtID = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.txtLastname = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.txtName = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.gpbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbClient
            // 
            this.gpbClient.Controls.Add(this.chkActive);
            this.gpbClient.Controls.Add(this.btnRemove);
            this.gpbClient.Controls.Add(this.btnModify);
            this.gpbClient.Controls.Add(this.txtAddress);
            this.gpbClient.Controls.Add(this.btnCreate);
            this.gpbClient.Controls.Add(this.txtID);
            this.gpbClient.Controls.Add(this.txtLastname);
            this.gpbClient.Controls.Add(this.txtName);
            this.gpbClient.Location = new System.Drawing.Point(10, 7);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Size = new System.Drawing.Size(337, 316);
            this.gpbClient.TabIndex = 0;
            this.gpbClient.TabStop = false;
            this.gpbClient.Tag = "cliente";
            this.gpbClient.Text = "Cliente";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(137, 238);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 11;
            this.chkActive.Tag = "activo";
            this.chkActive.Text = "Activo";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(226, 282);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 28);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Tag = "eliminar socio";
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(115, 282);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(90, 28);
            this.btnModify.TabIndex = 8;
            this.btnModify.Tag = "modificar socio";
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.LabelText = "Direccion";
            this.txtAddress.Location = new System.Drawing.Point(6, 172);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 45);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextBoxText = "";
            // 
            // btnCreate
            // 
            this.btnCreate.AutoEllipsis = true;
            this.btnCreate.Location = new System.Drawing.Point(6, 282);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 28);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Tag = "crear cliente";
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.LabelText = "DNI";
            this.txtID.Location = new System.Drawing.Point(6, 121);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(187, 45);
            this.txtID.TabIndex = 2;
            this.txtID.TextBoxText = "";
            // 
            // txtLastname
            // 
            this.txtLastname.AutoSize = true;
            this.txtLastname.LabelText = "Apellido";
            this.txtLastname.Location = new System.Drawing.Point(6, 70);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(187, 45);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.TextBoxText = "";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.LabelText = "Nombre";
            this.txtName.Location = new System.Drawing.Point(6, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 45);
            this.txtName.TabIndex = 0;
            this.txtName.TextBoxText = "";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 335);
            this.Controls.Add(this.gpbClient);
            this.Name = "frmClient";
            this.Text = "frmCliente";
            this.gpbClient.ResumeLayout(false);
            this.gpbClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbClient;
        private Customs_Controls.TextBoxLabeled txtName;
        private Customs_Controls.TextBoxLabeled txtAddress;
        private Customs_Controls.TextBoxLabeled txtID;
        private Customs_Controls.TextBoxLabeled txtLastname;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox chkActive;
    }
}