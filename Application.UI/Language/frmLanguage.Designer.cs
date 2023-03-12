namespace Application.UI.Language
{
    partial class frmLanguage
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
            this.dgvTranslations = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTranslationText = new System.Windows.Forms.TextBox();
            this.btnCreateNewLanguage = new System.Windows.Forms.Button();
            this.btnUpdateTranslate = new System.Windows.Forms.Button();
            this.btnCreateTranslation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslations)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTranslations
            // 
            this.dgvTranslations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranslations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTranslations.Location = new System.Drawing.Point(0, 114);
            this.dgvTranslations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTranslations.Name = "dgvTranslations";
            this.dgvTranslations.RowHeadersWidth = 62;
            this.dgvTranslations.Size = new System.Drawing.Size(1016, 464);
            this.dgvTranslations.TabIndex = 6;
            this.dgvTranslations.SelectionChanged += new System.EventHandler(this.dgvTranslations_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTranslationText);
            this.panel2.Controls.Add(this.btnCreateNewLanguage);
            this.panel2.Controls.Add(this.btnUpdateTranslate);
            this.panel2.Controls.Add(this.btnCreateTranslation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 578);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 111);
            this.panel2.TabIndex = 5;
            // 
            // txtTranslationText
            // 
            this.txtTranslationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTranslationText.Location = new System.Drawing.Point(583, 41);
            this.txtTranslationText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTranslationText.Name = "txtTranslationText";
            this.txtTranslationText.Size = new System.Drawing.Size(195, 26);
            this.txtTranslationText.TabIndex = 3;
            // 
            // btnCreateNewLanguage
            // 
            this.btnCreateNewLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateNewLanguage.Location = new System.Drawing.Point(18, 37);
            this.btnCreateNewLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateNewLanguage.Name = "btnCreateNewLanguage";
            this.btnCreateNewLanguage.Size = new System.Drawing.Size(176, 35);
            this.btnCreateNewLanguage.TabIndex = 0;
            this.btnCreateNewLanguage.Tag = "crearIdioma";
            this.btnCreateNewLanguage.Text = "Crear Idioma";
            this.btnCreateNewLanguage.UseVisualStyleBackColor = true;
            this.btnCreateNewLanguage.Click += new System.EventHandler(this.btnCreateNewLanguage_Click);
            // 
            // btnUpdateTranslate
            // 
            this.btnUpdateTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateTranslate.Location = new System.Drawing.Point(786, 5);
            this.btnUpdateTranslate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateTranslate.Name = "btnUpdateTranslate";
            this.btnUpdateTranslate.Size = new System.Drawing.Size(212, 35);
            this.btnUpdateTranslate.TabIndex = 2;
            this.btnUpdateTranslate.TabStop = false;
            this.btnUpdateTranslate.Tag = "actualizarTraduccion";
            this.btnUpdateTranslate.Text = "Actualizar Traduccion";
            this.btnUpdateTranslate.UseVisualStyleBackColor = true;
            this.btnUpdateTranslate.Click += new System.EventHandler(this.btnUpdateTranslate_Click);
            // 
            // btnCreateTranslation
            // 
            this.btnCreateTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTranslation.Location = new System.Drawing.Point(786, 37);
            this.btnCreateTranslation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateTranslation.Name = "btnCreateTranslation";
            this.btnCreateTranslation.Size = new System.Drawing.Size(212, 35);
            this.btnCreateTranslation.TabIndex = 1;
            this.btnCreateTranslation.TabStop = false;
            this.btnCreateTranslation.Tag = "crearTraduccion";
            this.btnCreateTranslation.Text = "Crear Traduccion";
            this.btnCreateTranslation.UseVisualStyleBackColor = true;
            this.btnCreateTranslation.Click += new System.EventHandler(this.btnCreateTranslation_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 114);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Tag = "traducciones";
            this.label2.Text = "Traducciones";
            // 
            // frmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 689);
            this.Controls.Add(this.dgvTranslations);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLanguage";
            this.Tag = "frmLanguage";
            this.Text = "Administración de Lenguaje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLanguage_FormClosed);
            this.Load += new System.EventHandler(this.frmLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslations)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTranslations;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTranslationText;
        private System.Windows.Forms.Button btnCreateNewLanguage;
        private System.Windows.Forms.Button btnUpdateTranslate;
        private System.Windows.Forms.Button btnCreateTranslation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}