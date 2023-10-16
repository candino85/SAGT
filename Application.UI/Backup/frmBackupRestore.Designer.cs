
namespace Application.UI.Backup
{
    partial class frmBackupRestore
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
            this.btnGoBackup = new System.Windows.Forms.Button();
            this.btnRestoreFolder = new System.Windows.Forms.Button();
            this.btnGoRestore = new System.Windows.Forms.Button();
            this.btnBackupFolder = new System.Windows.Forms.Button();
            this.txtRestoreBackup = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.txtBackupDatabase = new Application.UI.Customs_Controls.TextBoxLabeled();
            this.SuspendLayout();
            // 
            // btnGoBackup
            // 
            this.btnGoBackup.Location = new System.Drawing.Point(519, 45);
            this.btnGoBackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoBackup.Name = "btnGoBackup";
            this.btnGoBackup.Size = new System.Drawing.Size(124, 35);
            this.btnGoBackup.TabIndex = 2;
            this.btnGoBackup.Tag = "iniciar backup";
            this.btnGoBackup.Text = "Iniciar Backup";
            this.btnGoBackup.UseVisualStyleBackColor = true;
            this.btnGoBackup.Click += new System.EventHandler(this.btnGoBackup_Click);
            // 
            // btnRestoreFolder
            // 
            this.btnRestoreFolder.Location = new System.Drawing.Point(470, 135);
            this.btnRestoreFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestoreFolder.Name = "btnRestoreFolder";
            this.btnRestoreFolder.Size = new System.Drawing.Size(40, 35);
            this.btnRestoreFolder.TabIndex = 3;
            this.btnRestoreFolder.Text = "...";
            this.btnRestoreFolder.UseVisualStyleBackColor = true;
            this.btnRestoreFolder.Click += new System.EventHandler(this.btnRestoreFolder_Click_1);
            // 
            // btnGoRestore
            // 
            this.btnGoRestore.Location = new System.Drawing.Point(519, 134);
            this.btnGoRestore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoRestore.Name = "btnGoRestore";
            this.btnGoRestore.Size = new System.Drawing.Size(124, 35);
            this.btnGoRestore.TabIndex = 4;
            this.btnGoRestore.Tag = "iniciar restore";
            this.btnGoRestore.Text = "Iniciar Restore";
            this.btnGoRestore.UseVisualStyleBackColor = true;
            this.btnGoRestore.Click += new System.EventHandler(this.btnGoRestore_Click);
            // 
            // btnBackupFolder
            // 
            this.btnBackupFolder.Location = new System.Drawing.Point(470, 46);
            this.btnBackupFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackupFolder.Name = "btnBackupFolder";
            this.btnBackupFolder.Size = new System.Drawing.Size(40, 35);
            this.btnBackupFolder.TabIndex = 5;
            this.btnBackupFolder.Text = "...";
            this.btnBackupFolder.UseVisualStyleBackColor = true;
            this.btnBackupFolder.Click += new System.EventHandler(this.btnBackupFolder_Click);
            // 
            // txtRestoreBackup
            // 
            this.txtRestoreBackup.LabelText = "Restaurar Backup";
            this.txtRestoreBackup.Location = new System.Drawing.Point(18, 108);
            this.txtRestoreBackup.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtRestoreBackup.Name = "txtRestoreBackup";
            this.txtRestoreBackup.Size = new System.Drawing.Size(442, 62);
            this.txtRestoreBackup.TabIndex = 1;
            this.txtRestoreBackup.Tag = "restaurar backup";
            this.txtRestoreBackup.TextBoxText = "";
            // 
            // txtBackupDatabase
            // 
            this.txtBackupDatabase.LabelText = "Backup Database";
            this.txtBackupDatabase.Location = new System.Drawing.Point(18, 18);
            this.txtBackupDatabase.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBackupDatabase.Name = "txtBackupDatabase";
            this.txtBackupDatabase.Size = new System.Drawing.Size(442, 62);
            this.txtBackupDatabase.TabIndex = 0;
            this.txtBackupDatabase.TextBoxText = "";
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 202);
            this.Controls.Add(this.btnBackupFolder);
            this.Controls.Add(this.btnGoRestore);
            this.Controls.Add(this.btnRestoreFolder);
            this.Controls.Add(this.btnGoBackup);
            this.Controls.Add(this.txtRestoreBackup);
            this.Controls.Add(this.txtBackupDatabase);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBackupRestore";
            this.Text = "frmBackup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBackupRestore_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Customs_Controls.TextBoxLabeled txtBackupDatabase;
        private Customs_Controls.TextBoxLabeled txtRestoreBackup;
        private System.Windows.Forms.Button btnGoBackup;
        private System.Windows.Forms.Button btnRestoreFolder;
        private System.Windows.Forms.Button btnGoRestore;
        private System.Windows.Forms.Button btnBackupFolder;
    }
}