
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
            this.txtBackupDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRestoreBackup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGoBackup
            // 
            this.btnGoBackup.Location = new System.Drawing.Point(519, 45);
            this.btnGoBackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoBackup.Name = "btnGoBackup";
            this.btnGoBackup.Size = new System.Drawing.Size(124, 35);
            this.btnGoBackup.TabIndex = 2;
            this.btnGoBackup.Tag = "goBackup";
            this.btnGoBackup.Text = "Resguardar";
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
            this.btnGoRestore.Tag = "goRestore";
            this.btnGoRestore.Text = "Restaurar";
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
            // txtBackupDatabase
            // 
            this.txtBackupDatabase.Enabled = false;
            this.txtBackupDatabase.Location = new System.Drawing.Point(21, 49);
            this.txtBackupDatabase.Name = "txtBackupDatabase";
            this.txtBackupDatabase.Size = new System.Drawing.Size(442, 26);
            this.txtBackupDatabase.TabIndex = 6;
            this.txtBackupDatabase.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 7;
            this.label1.Tag = "backupDatabase";
            this.label1.Text = "Resguardar Base de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 9;
            this.label2.Tag = "restoreDatabase";
            this.label2.Text = "Restaurar Base de Datos";
            // 
            // txtRestoreBackup
            // 
            this.txtRestoreBackup.Enabled = false;
            this.txtRestoreBackup.Location = new System.Drawing.Point(21, 139);
            this.txtRestoreBackup.Name = "txtRestoreBackup";
            this.txtRestoreBackup.Size = new System.Drawing.Size(442, 26);
            this.txtRestoreBackup.TabIndex = 8;
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 202);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRestoreBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBackupDatabase);
            this.Controls.Add(this.btnBackupFolder);
            this.Controls.Add(this.btnGoRestore);
            this.Controls.Add(this.btnRestoreFolder);
            this.Controls.Add(this.btnGoBackup);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBackupRestore";
            this.Tag = "frmBackupRestore";
            this.Text = "Respaldar / Restaurar Base de Datos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBackupRestore_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGoBackup;
        private System.Windows.Forms.Button btnRestoreFolder;
        private System.Windows.Forms.Button btnGoRestore;
        private System.Windows.Forms.Button btnBackupFolder;
        private System.Windows.Forms.TextBox txtBackupDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRestoreBackup;
    }
}