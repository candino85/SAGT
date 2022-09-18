
namespace Application.UI.Negocio
{
    partial class frmClientList
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
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.gpbClientList = new System.Windows.Forms.GroupBox();
            this.btnCreateClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.gpbClientList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Tag = "buscar";
            this.label1.Text = "Buscar :";
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchClient.Location = new System.Drawing.Point(58, 19);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(337, 20);
            this.txtSearchClient.TabIndex = 2;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(6, 46);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(528, 302);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellDoubleClick);
            // 
            // gpbClientList
            // 
            this.gpbClientList.Controls.Add(this.btnCreateClient);
            this.gpbClientList.Controls.Add(this.label1);
            this.gpbClientList.Controls.Add(this.txtSearchClient);
            this.gpbClientList.Controls.Add(this.dgvClients);
            this.gpbClientList.Location = new System.Drawing.Point(12, 12);
            this.gpbClientList.Name = "gpbClientList";
            this.gpbClientList.Size = new System.Drawing.Size(540, 354);
            this.gpbClientList.TabIndex = 2;
            this.gpbClientList.TabStop = false;
            this.gpbClientList.Tag = "lista clientes";
            this.gpbClientList.Text = "Lista de clientes";
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(401, 16);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(133, 23);
            this.btnCreateClient.TabIndex = 4;
            this.btnCreateClient.Tag = "crear nuevo cliente";
            this.btnCreateClient.Text = "Crear nuevo cliente";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // frmClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 368);
            this.Controls.Add(this.gpbClientList);
            this.Name = "frmClientList";
            this.Text = "frmClientList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.gpbClientList.ResumeLayout(false);
            this.gpbClientList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.GroupBox gpbClientList;
        private System.Windows.Forms.Button btnCreateClient;
    }
}