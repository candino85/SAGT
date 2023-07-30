namespace Application.UI.Negocio.ABM
{
    partial class frmEstudioList
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchEstudio = new System.Windows.Forms.TextBox();
            this.dgvEstudios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 10;
            this.label1.Tag = "buscar";
            this.label1.Text = "Buscar :";
            // 
            // txtSearchEstudio
            // 
            this.txtSearchEstudio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchEstudio.Location = new System.Drawing.Point(91, 17);
            this.txtSearchEstudio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchEstudio.Name = "txtSearchEstudio";
            this.txtSearchEstudio.Size = new System.Drawing.Size(714, 26);
            this.txtSearchEstudio.TabIndex = 9;
            this.txtSearchEstudio.TextChanged += new System.EventHandler(this.txtSearchEstudio_TextChanged);
            // 
            // dgvEstudios
            // 
            this.dgvEstudios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudios.Location = new System.Drawing.Point(13, 66);
            this.dgvEstudios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEstudios.Name = "dgvEstudios";
            this.dgvEstudios.ReadOnly = true;
            this.dgvEstudios.RowHeadersVisible = false;
            this.dgvEstudios.RowHeadersWidth = 62;
            this.dgvEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudios.Size = new System.Drawing.Size(792, 465);
            this.dgvEstudios.TabIndex = 8;
            this.dgvEstudios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudios_CellMouseDoubleClick);
            // 
            // frmEstudioList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchEstudio);
            this.Controls.Add(this.dgvEstudios);
            this.Name = "frmEstudioList";
            this.Text = "frmEstudioList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchEstudio;
        private System.Windows.Forms.DataGridView dgvEstudios;
    }
}