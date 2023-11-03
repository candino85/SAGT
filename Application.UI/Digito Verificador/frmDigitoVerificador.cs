using Application.BLL;
using Application.DLL;
using Application.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Application.UI.Digito_Verificador
{
    public partial class frmDigitoVerificador : Form
    {
        IntegrityService integrityService;
        BLL.BackupRestore backupRestore;
        BLL.User user;
        public frmDigitoVerificador()
        {
            InitializeComponent();
            integrityService = new IntegrityService();
            backupRestore = new BackupRestore();
            user = new User();
        }

        public frmDigitoVerificador(string msg)
        {
            InitializeComponent();
            integrityService = new IntegrityService();
            txtMessage.Text += $"\n{msg}";
            backupRestore = new BackupRestore();
            user = new User();
        }

        private void btnRecalcular_Click(object sender, System.EventArgs e)
        {
            try 
            { 
                integrityService.SetDVH("Usuarios");
                integrityService.SetDVH("Turno");

                MessageBox.Show("La integridad de las bases de dato se ha restaurado correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SessionManager.GetInstance.Logout();
                this.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();   
                
            }
        }

        private void btnRestore_Click(object sender, System.EventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                Title = "Buscar respaldo de la base de datos",
                Filter = "Archivos de Respaldo|*.bak",
                InitialDirectory = @"C:\Users\andin\OneDrive\Escritorio",
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                backupRestore.RestoreDatabase(dialog.FileName);
                MessageBox.Show("Restauración finalizada. Ahora el sistema se cerrará.");
                user.LogOut();                
                this.Close();
            }
        }
    }
}
