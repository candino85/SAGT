namespace Application.UI.Negocio.ABM
{
    partial class frmEspecialidad
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 42;
            this.label2.Tag = "nombre";
            this.label2.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 26);
            this.txtName.TabIndex = 41;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoEllipsis = true;
            this.btnCreate.Location = new System.Drawing.Point(24, 102);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 43);
            this.btnCreate.TabIndex = 36;
            this.btnCreate.Tag = "crear cliente";
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(307, 102);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 43);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Tag = "eliminar socio";
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(164, 102);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(135, 43);
            this.btnModify.TabIndex = 37;
            this.btnModify.Tag = "modificar socio";
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // frmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmEspecialidad";
            this.Tag = "frmEspecialidad";
            this.Text = "Especialidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEspecialidad_FormClosed);
            this.Load += new System.EventHandler(this.frmEspecialidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
    }
}