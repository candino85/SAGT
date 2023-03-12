namespace Application.UI.Language
{
    partial class frmLanguageNew
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
            this.btnSaveNewLanguage = new System.Windows.Forms.Button();
            this.txtNewLanguageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveNewLanguage
            // 
            this.btnSaveNewLanguage.Location = new System.Drawing.Point(330, 112);
            this.btnSaveNewLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveNewLanguage.Name = "btnSaveNewLanguage";
            this.btnSaveNewLanguage.Size = new System.Drawing.Size(112, 35);
            this.btnSaveNewLanguage.TabIndex = 5;
            this.btnSaveNewLanguage.Tag = "crear";
            this.btnSaveNewLanguage.Text = "Crear";
            this.btnSaveNewLanguage.UseVisualStyleBackColor = true;
            this.btnSaveNewLanguage.Click += new System.EventHandler(this.btnSaveNewLanguage_Click);
            // 
            // txtNewLanguageName
            // 
            this.txtNewLanguageName.Location = new System.Drawing.Point(135, 36);
            this.txtNewLanguageName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewLanguageName.Name = "txtNewLanguageName";
            this.txtNewLanguageName.Size = new System.Drawing.Size(307, 26);
            this.txtNewLanguageName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Tag = "nombre";
            this.label1.Text = "Nombre";
            // 
            // frmLanguageNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 178);
            this.Controls.Add(this.btnSaveNewLanguage);
            this.Controls.Add(this.txtNewLanguageName);
            this.Controls.Add(this.label1);
            this.Name = "frmLanguageNew";
            this.Tag = "frmLanguageNew";
            this.Text = "Crear Nuevo Idioma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLanguageNew_FormClosed);
            this.Load += new System.EventHandler(this.frmLanguageNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveNewLanguage;
        private System.Windows.Forms.TextBox txtNewLanguageName;
        private System.Windows.Forms.Label label1;
    }
}