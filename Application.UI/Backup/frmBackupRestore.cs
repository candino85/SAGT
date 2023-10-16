using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI.Backup
{
    public partial class frmBackupRestore : Form, ILanguageObserver
    {
        BLL.BackupRestore backupRestore;
        public frmBackupRestore()
        {
            InitializeComponent();
            backupRestore = new BLL.BackupRestore();
        }


        private void btnBackupFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (dialog.SelectedPath != string.Empty)
            {
                txtBackupDatabase.TextBoxText = dialog.SelectedPath;               
            }
        }

        private void btnRestoreFolder_Click_1(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "database backup files (*.bak)|*.bak|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
                txtRestoreBackup.TextBoxText = filePath;
            }

        }

        private void btnGoBackup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBackupDatabase.TextBoxText))
                MessageBox.Show(backupRestore.BackupDatabase(txtBackupDatabase.TextBoxText));
            else
                MessageBox.Show("Seleccione la ruta donde guardar el backup");
        }

        private void btnGoRestore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRestoreBackup.TextBoxText))
            {                
                MessageBox.Show(backupRestore.RestoreDatabase(txtRestoreBackup.TextBoxText));
            }
            else
                MessageBox.Show("Seleccione el archivo de backup que desea restaurar");
        }

        private void frmBackupRestore_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }
    }
}
