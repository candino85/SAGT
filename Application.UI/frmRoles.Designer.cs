
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
            this.lblPermisosDisponibles = new System.Windows.Forms.Label();
            this.lblPermisosActuales = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tvPermisosDisponibles = new System.Windows.Forms.TreeView();
            this.tvPermisosActuales = new System.Windows.Forms.TreeView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPermisosDisponibles
            // 
            this.lblPermisosDisponibles.AutoSize = true;
            this.lblPermisosDisponibles.Location = new System.Drawing.Point(377, 65);
            this.lblPermisosDisponibles.Name = "lblPermisosDisponibles";
            this.lblPermisosDisponibles.Size = new System.Drawing.Size(106, 13);
            this.lblPermisosDisponibles.TabIndex = 33;
            this.lblPermisosDisponibles.Text = "Permisos Disponibles";
            // 
            // lblPermisosActuales
            // 
            this.lblPermisosActuales.AutoSize = true;
            this.lblPermisosActuales.Location = new System.Drawing.Point(12, 65);
            this.lblPermisosActuales.Name = "lblPermisosActuales";
            this.lblPermisosActuales.Size = new System.Drawing.Size(93, 13);
            this.lblPermisosActuales.TabIndex = 32;
            this.lblPermisosActuales.Text = "Permisos Actuales";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(229, 240);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(146, 46);
            this.btnQuitar.TabIndex = 31;
            this.btnQuitar.Text = ">> Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(229, 153);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 46);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "<< Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tvPermisosDisponibles
            // 
            this.tvPermisosDisponibles.Location = new System.Drawing.Point(380, 81);
            this.tvPermisosDisponibles.Name = "tvPermisosDisponibles";
            this.tvPermisosDisponibles.Size = new System.Drawing.Size(209, 262);
            this.tvPermisosDisponibles.TabIndex = 29;
            // 
            // tvPermisosActuales
            // 
            this.tvPermisosActuales.Location = new System.Drawing.Point(12, 81);
            this.tvPermisosActuales.Name = "tvPermisosActuales";
            this.tvPermisosActuales.Size = new System.Drawing.Size(211, 262);
            this.tvPermisosActuales.TabIndex = 28;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(228, 8);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(146, 30);
            this.btnCrear.TabIndex = 26;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(228, 44);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 30);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(228, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 30);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(15, 33);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(207, 20);
            this.txtRol.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre Rol";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblPermisosDisponibles);
            this.Controls.Add(this.lblPermisosActuales);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tvPermisosDisponibles);
            this.Controls.Add(this.tvPermisosActuales);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPermisosDisponibles;
        private System.Windows.Forms.Label lblPermisosActuales;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TreeView tvPermisosDisponibles;
        private System.Windows.Forms.TreeView tvPermisosActuales;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label label1;
    }
}