
namespace Application.UI
{
    partial class frmEntityList
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
            this.grpEntitiesList = new System.Windows.Forms.GroupBox();
            this.dgvEntities = new System.Windows.Forms.DataGridView();
            this.btnCreateEntity = new System.Windows.Forms.Button();
            this.grpEntitiesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEntitiesList
            // 
            this.grpEntitiesList.Controls.Add(this.dgvEntities);
            this.grpEntitiesList.Location = new System.Drawing.Point(12, 41);
            this.grpEntitiesList.Name = "grpEntitiesList";
            this.grpEntitiesList.Size = new System.Drawing.Size(776, 401);
            this.grpEntitiesList.TabIndex = 23;
            this.grpEntitiesList.TabStop = false;
            this.grpEntitiesList.Text = "Lista de entidades";
            // 
            // dgvEntities
            // 
            this.dgvEntities.AllowUserToAddRows = false;
            this.dgvEntities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntities.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEntities.Location = new System.Drawing.Point(6, 19);
            this.dgvEntities.MultiSelect = false;
            this.dgvEntities.Name = "dgvEntities";
            this.dgvEntities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntities.Size = new System.Drawing.Size(764, 376);
            this.dgvEntities.TabIndex = 5;
            this.dgvEntities.Tag = "";
            this.dgvEntities.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntities_CellDoubleClick);
            // 
            // btnCreateEntity
            // 
            this.btnCreateEntity.Location = new System.Drawing.Point(12, 9);
            this.btnCreateEntity.Name = "btnCreateEntity";
            this.btnCreateEntity.Size = new System.Drawing.Size(134, 26);
            this.btnCreateEntity.TabIndex = 24;
            this.btnCreateEntity.Tag = "crear entidad";
            this.btnCreateEntity.Text = "Crear nueva entidad";
            this.btnCreateEntity.UseVisualStyleBackColor = true;
            this.btnCreateEntity.Click += new System.EventHandler(this.btnCreateEntity_Click);
            // 
            // frmEntityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEntitiesList);
            this.Controls.Add(this.btnCreateEntity);
            this.Name = "frmEntityList";
            this.Text = "frmEntityList";
            this.grpEntitiesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEntitiesList;
        private System.Windows.Forms.DataGridView dgvEntities;
        private System.Windows.Forms.Button btnCreateEntity;
    }
}