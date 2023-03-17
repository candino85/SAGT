using Application.ABSTRACTIONS;
using Application.BE;
using Application.BLL;
using Application.Services;
using Application.UI.Backup;
using Application.UI.Language;
using Application.UI.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Application.UI
{
    public partial class frmMain : Form, ILanguageObserver
    {
        LoginService _login;
        
        BLL.Permission permission;
        Services.UserPermission userPermission;

        BLL.LanguageService _languageBLL;

        public frmMain()
        {
            InitializeComponent();
            
            permission = new BLL.Permission();
            userPermission = new UserPermission();          

            _login = new LoginService();
            _languageBLL = new BLL.LanguageService();
        }

        private void frmMain_Load(object sender, EventArgs e)
        { 
            if (!SessionManager.GetInstance.IsLogged)
            {
                menuLogin_Click(sender, e);
                ValidarForm();
                SessionManager.GetInstance.SubscribeObserver(this);
            }

            LoadComboLanguage();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
            foreach (Form form in MdiChildren)
            {
                if (typeof(ILanguageObserver).IsAssignableFrom(form.GetType()))
                    SessionManager.GetInstance.UnsubscribeObserver((ILanguageObserver)form);
            }
        }

        private void validatePermissions()
        {
            if (SessionManager.GetInstance.Usuario != null && SessionManager.GetInstance.Usuario.LoginName != "SysAdmin")
            {
                userPermission.Id = SessionManager.GetInstance.Usuario.Id;
                userPermission.Nombre = SessionManager.GetInstance.Usuario.Name;

                //sesionToolStripMenuItem
                menuLanguage.Visible = permission.FindUserPermissions(PermissionType.CambiarIdioma, userPermission);                

                gestionToolStripMenuItem.Visible = true;
                entidadesToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarEntidades, userPermission);
                idiomasToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarIdioma, userPermission);
                usuariosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarUsuarios, userPermission);
                //espaciosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarEspacios, userPermission);

                seguridadToolStripMenuItem.Visible = true;
                rolesToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.ConfigurarSeguridadRoles, userPermission);
                backupRestoreToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.BackupRestore, userPermission);
                //seguridadUsuariosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.ConfigurarSeguridadUsuarios, userPermission);

                //negocioToolStripMenuItem (Este permiso se desglosará para cada tipo de role del negocio)
                negocioToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.ConfigurarNegocio, userPermission);
            }
            else if (SessionManager.GetInstance.Usuario.LoginName == "SysAdmin")
            {
                //sesionToolStripMenuItem
                menuLanguage.Visible = true;

                gestionToolStripMenuItem.Visible = true;
                entidadesToolStripMenuItem.Visible = true;
                idiomasToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
                //espaciosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarEspacios, userPermission);

                seguridadToolStripMenuItem.Visible = true;
                rolesToolStripMenuItem.Visible = true;
                backupRestoreToolStripMenuItem.Visible = true;
                //seguridadUsuariosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.ConfigurarSeguridadUsuarios, userPermission);

                //negocioToolStripMenuItem (Este permiso se desglosará para cada tipo de role del negocio)
                negocioToolStripMenuItem.Visible = true;
            }
        }

        private void CloseSesion()
        {
            if (SessionManager.GetInstance.Usuario == null)
            {
                menuLanguage.Visible = false;
                backupRestoreToolStripMenuItem.Visible = false;

                gestionToolStripMenuItem.Visible = false;
                seguridadToolStripMenuItem.Visible = false;
                negocioToolStripMenuItem.Visible = false;
                menuLogout.Visible = false;
            }
        }

        public void ValidarForm()
        {
            //login menu settings
            this.menuLogin.Enabled = !SessionManager.GetInstance.IsLogged;
            this.menuLogout.Enabled = SessionManager.GetInstance.IsLogged;
            this.menuLanguage.Enabled = SessionManager.GetInstance.IsLogged;


            if (SessionManager.GetInstance.IsLogged)
            {
                this.lblEstado.Text = SessionManager.GetInstance.Usuario.LoginName;

                foreach (ToolStripMenuItem i in menuLanguage.DropDownItems)
                {
                    if (i.Text == SessionManager.GetInstance.Usuario.Idioma.Name)
                        i.Checked = true;
                    else 
                        i.Checked = false;
                }
                
                updateLanguage(SessionManager.GetInstance.language);

                validatePermissions();
            }
            else
            {
                validatePermissions();
                this.lblEstado.Text = "[Sesión no iniciada]";
            }
        }

        public void LoadComboLanguage()
        {
            menuLanguage.DropDown.Items.Clear();
            List<BE.Language> languages = _languageBLL.GetLanguages();

            foreach (BE.Language item in languages)
            {
                ToolStripMenuItem i = new ToolStripMenuItem(item.Name);
                i.Tag = item;
                i.Click += languageChange_Click;
                i.Checked = item.Default;
                menuLanguage.DropDown.Items.Add(i);
            }
        }

        protected Form CreateForm(Type formType)
        {
            foreach (Form child in MdiChildren.ToList())
            {
                if (child.GetType() == formType)
                {
                    child.Focus();
                    return child;
                }
            }

            Form form = (Form)Activator.CreateInstance(formType);
            if (typeof(ILanguageObserver).IsAssignableFrom(form.GetType()))
            {
                SessionManager.GetInstance.SubscribeObserver((ILanguageObserver)form);
            }
            form.MdiParent = this;
            form.Show();
            return form;
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void languageChange_Click(object sender, EventArgs e)
        {
            SessionManager.GetInstance.language = _languageBLL.GetLanguage(sender.ToString());
            LoadComboLanguage();
            //TODO
            //MARCAR EL IDIOMA SELECCIONADO
            //SETEAR EL IDIOMA EN EL USUARIO
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirme",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _login.Logout();
                CloseSesion();
                
                if (!SessionManager.GetInstance.IsLogged)
                {
                    menuLogin_Click(sender, e);
                }
            }           
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmLogin));
            //frmLogin frm = new frmLogin();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmRoles));
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmUsersList));
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmEntityList));
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmClientList));
        }

        private void seguridadUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmBackupRestore));
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmLanguage));
        }

        private void gestionarEspaciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmAreaList));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
