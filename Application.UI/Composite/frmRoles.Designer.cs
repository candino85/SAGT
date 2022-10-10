﻿
namespace Application.UI
{
    partial class frmRoles
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
            this.btnRemovePermission = new System.Windows.Forms.Button();
            this.btnAddPermission = new System.Windows.Forms.Button();
            this.tvRole = new System.Windows.Forms.TreeView();
            this.tvAvailablePermission = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPermissionTypes = new System.Windows.Forms.ComboBox();
            this.btnDeleteComponent = new System.Windows.Forms.Button();
            this.btnCreatePermission = new System.Windows.Forms.Button();
            this.txtPermissionName = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.gpbRoles = new System.Windows.Forms.GroupBox();
            this.txtRoleName = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.btnSaveSelectedRole = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpbRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemovePermission
            // 
            this.btnRemovePermission.Location = new System.Drawing.Point(244, 195);
            this.btnRemovePermission.Name = "btnRemovePermission";
            this.btnRemovePermission.Size = new System.Drawing.Size(116, 28);
            this.btnRemovePermission.TabIndex = 31;
            this.btnRemovePermission.Text = "<< Quitar";
            this.btnRemovePermission.UseVisualStyleBackColor = true;
            this.btnRemovePermission.Click += new System.EventHandler(this.btnRemovePermission_Click);
            // 
            // btnAddPermission
            // 
            this.btnAddPermission.Location = new System.Drawing.Point(244, 161);
            this.btnAddPermission.Name = "btnAddPermission";
            this.btnAddPermission.Size = new System.Drawing.Size(116, 28);
            this.btnAddPermission.TabIndex = 30;
            this.btnAddPermission.Tag = "agregar";
            this.btnAddPermission.Text = "Agregar >>";
            this.btnAddPermission.UseVisualStyleBackColor = true;
            this.btnAddPermission.Click += new System.EventHandler(this.btnAddToRole_Click);
            // 
            // tvRole
            // 
            this.tvRole.Location = new System.Drawing.Point(6, 115);
            this.tvRole.Name = "tvRole";
            this.tvRole.Size = new System.Drawing.Size(212, 244);
            this.tvRole.TabIndex = 29;
            this.tvRole.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRole_AfterSelect);
            // 
            // tvAvailablePermission
            // 
            this.tvAvailablePermission.Location = new System.Drawing.Point(6, 115);
            this.tvAvailablePermission.Name = "tvAvailablePermission";
            this.tvAvailablePermission.Size = new System.Drawing.Size(211, 210);
            this.tvAvailablePermission.TabIndex = 28;
            this.tvAvailablePermission.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAvailablePermission_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPermissionTypes);
            this.groupBox1.Controls.Add(this.btnDeleteComponent);
            this.groupBox1.Controls.Add(this.btnCreatePermission);
            this.groupBox1.Controls.Add(this.txtPermissionName);
            this.groupBox1.Controls.Add(this.cmbPermisos);
            this.groupBox1.Controls.Add(this.tvAvailablePermission);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 365);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "permisos";
            this.groupBox1.Text = "Permisos";
            // 
            // cmbPermissionTypes
            // 
            this.cmbPermissionTypes.FormattingEnabled = true;
            this.cmbPermissionTypes.Items.AddRange(new object[] {
            "Roles",
            "Permisos"});
            this.cmbPermissionTypes.Location = new System.Drawing.Point(6, 334);
            this.cmbPermissionTypes.Name = "cmbPermissionTypes";
            this.cmbPermissionTypes.Size = new System.Drawing.Size(211, 21);
            this.cmbPermissionTypes.TabIndex = 43;
            this.cmbPermissionTypes.SelectionChangeCommitted += new System.EventHandler(this.cmbPermissionTypes_SelectionChangeCommitted);
            // 
            // btnDeleteComponent
            // 
            this.btnDeleteComponent.Location = new System.Drawing.Point(111, 86);
            this.btnDeleteComponent.Name = "btnDeleteComponent";
            this.btnDeleteComponent.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteComponent.TabIndex = 42;
            this.btnDeleteComponent.Tag = "eliminar";
            this.btnDeleteComponent.Text = "Eliminar";
            this.btnDeleteComponent.UseVisualStyleBackColor = true;
            this.btnDeleteComponent.Click += new System.EventHandler(this.btnDeleteComponent_Click);
            // 
            // btnCreatePermission
            // 
            this.btnCreatePermission.Location = new System.Drawing.Point(6, 86);
            this.btnCreatePermission.Name = "btnCreatePermission";
            this.btnCreatePermission.Size = new System.Drawing.Size(99, 23);
            this.btnCreatePermission.TabIndex = 41;
            this.btnCreatePermission.Tag = "crear permiso";
            this.btnCreatePermission.Text = "Crear Permiso";
            this.btnCreatePermission.UseVisualStyleBackColor = true;
            this.btnCreatePermission.Click += new System.EventHandler(this.btnSavePermission_Click);
            // 
            // txtPermissionName
            // 
            this.txtPermissionName.LabelText = "Nombre permiso";
            this.txtPermissionName.Location = new System.Drawing.Point(6, 40);
            this.txtPermissionName.Name = "txtPermissionName";
            this.txtPermissionName.Size = new System.Drawing.Size(211, 40);
            this.txtPermissionName.TabIndex = 40;
            this.txtPermissionName.Tag = "nombre permiso";
            this.txtPermissionName.TextBoxText = "";
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Location = new System.Drawing.Point(6, 17);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(211, 21);
            this.cmbPermisos.TabIndex = 39;
            // 
            // gpbRoles
            // 
            this.gpbRoles.Controls.Add(this.txtRoleName);
            this.gpbRoles.Controls.Add(this.btnCreateRole);
            this.gpbRoles.Controls.Add(this.cmbRoles);
            this.gpbRoles.Controls.Add(this.tvRole);
            this.gpbRoles.Location = new System.Drawing.Point(366, 12);
            this.gpbRoles.Name = "gpbRoles";
            this.gpbRoles.Size = new System.Drawing.Size(224, 365);
            this.gpbRoles.TabIndex = 39;
            this.gpbRoles.TabStop = false;
            this.gpbRoles.Tag = "roles";
            this.gpbRoles.Text = "Roles";
            // 
            // txtRoleName
            // 
            this.txtRoleName.LabelText = "Nombre Rol";
            this.txtRoleName.Location = new System.Drawing.Point(6, 40);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(211, 40);
            this.txtRoleName.TabIndex = 46;
            this.txtRoleName.Tag = "nombre rol";
            this.txtRoleName.TextBoxText = "";
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Location = new System.Drawing.Point(6, 86);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(115, 23);
            this.btnCreateRole.TabIndex = 45;
            this.btnCreateRole.Tag = "crear";
            this.btnCreateRole.Text = "Crear role";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(6, 17);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(211, 21);
            this.cmbRoles.TabIndex = 42;
            this.cmbRoles.SelectionChangeCommitted += new System.EventHandler(this.cmbRoles_SelectionChangeCommitted);
            // 
            // btnSaveSelectedRole
            // 
            this.btnSaveSelectedRole.Location = new System.Drawing.Point(244, 277);
            this.btnSaveSelectedRole.Name = "btnSaveSelectedRole";
            this.btnSaveSelectedRole.Size = new System.Drawing.Size(116, 28);
            this.btnSaveSelectedRole.TabIndex = 40;
            this.btnSaveSelectedRole.Tag = "guardar rol";
            this.btnSaveSelectedRole.Text = "Guardar Rol";
            this.btnSaveSelectedRole.UseVisualStyleBackColor = true;
            this.btnSaveSelectedRole.Click += new System.EventHandler(this.btnSaveSelectedRole_Click);
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 389);
            this.Controls.Add(this.btnSaveSelectedRole);
            this.Controls.Add(this.btnRemovePermission);
            this.Controls.Add(this.btnAddPermission);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbRoles);
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.groupBox1.ResumeLayout(false);
            this.gpbRoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRemovePermission;
        private System.Windows.Forms.Button btnAddPermission;
        private System.Windows.Forms.TreeView tvRole;
        private System.Windows.Forms.TreeView tvAvailablePermission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreatePermission;
        private Customs_Controls.TextBoxLabeled txtPermissionName;
        private System.Windows.Forms.ComboBox cmbPermisos;
        private System.Windows.Forms.GroupBox gpbRoles;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnDeleteComponent;
        private Customs_Controls.TextBoxLabeled txtRoleName;
        private System.Windows.Forms.Button btnSaveSelectedRole;
        private System.Windows.Forms.ComboBox cmbPermissionTypes;
    }
}