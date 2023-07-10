using Application.ABSTRACTIONS;
using Application.BE;
using Application.BLL;
using Application.Services;
using Application.UI.Backup;
using Application.UI.Language;
using Application.UI.Negocio;
using Application.UI.Negocio.ABM;
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
        BLL.Permission permission;
        BLL.User user;

        Services.UserPermission userPermission;

        BLL.LanguageService language;

        public frmMain()
        {
            InitializeComponent();
            
            permission = new BLL.Permission();
            userPermission = new UserPermission();
            user = new BLL.User();
            language = new BLL.LanguageService();
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

        private void validatePermissions()
        {
            if (SessionManager.GetInstance.Usuario != null && SessionManager.GetInstance.Usuario.LoginName != "SysAdmin")
            {
                userPermission.Id = SessionManager.GetInstance.Usuario.Id;
                userPermission.Nombre = SessionManager.GetInstance.Usuario.Name;

                //foreach (ToolStripMenuItem menuItem in menu.Items)
                //{
                //    var m
                //    menuItem.Visible = permission.FindUserPermissions(PermissionType.(menuItem.Name).text, userPermission);
                //}

                //sesion
                menuLanguage.Visible = permission.FindUserPermissions(PermissionType.menuCambiarIdioma, userPermission);
                menuCambiarClave.Visible = permission.FindUserPermissions(PermissionType.menuCambiarClave, userPermission);

                //administrar
                menuAdministrar.Visible = permission.FindUserPermissions(PermissionType.menuAdministrar, userPermission);
                menuUsuarios.Visible = permission.FindUserPermissions(PermissionType.menuUsuarios, userPermission);
                menuPerfiles.Visible = permission.FindUserPermissions(PermissionType.menuPerfiles, userPermission);
                menuIdiomas.Visible = permission.FindUserPermissions(PermissionType.menuIdiomas, userPermission);
                menuBackupRestore.Visible = permission.FindUserPermissions(PermissionType.menuBackupRestore, userPermission);

                //maestros
                menuMaestros.Visible = permission.FindUserPermissions(PermissionType.menuMaestros, userPermission);
                menuSucursales.Visible = permission.FindUserPermissions(PermissionType.menuSucursales, userPermission);
                menuEspacios.Visible = permission.FindUserPermissions(PermissionType.menuEspacios, userPermission);
                menuClientes.Visible = permission.FindUserPermissions(PermissionType.menuClientes, userPermission);
                menuEspecialidades.Visible = permission.FindUserPermissions(PermissionType.menuEspecialidades, userPermission);
                menuEstudios.Visible = permission.FindUserPermissions(PermissionType.menuEstudios, userPermission);

                //turnos
                menuTurnos.Visible = permission.FindUserPermissions(PermissionType.menuTurnos, userPermission);
                menuRegistrarTurno.Visible = permission.FindUserPermissions(PermissionType.menuRegistrarTurno, userPermission);
                menuAgenda.Visible = permission.FindUserPermissions(PermissionType.menuAgenda, userPermission);

                //reportes
                menuReportes.Visible = permission.FindUserPermissions(PermissionType.menuReportes,userPermission);

                //ayuda
                menuAyuda.Visible = permission.FindUserPermissions(PermissionType.menuAyuda, userPermission);
            }
            //else if (SessionManager.GetInstance.Usuario.LoginName == "SysAdmin")
            //{
            //    //sesionToolStripMenuItem
            //    menuLanguage.Visible = true;

            //    gestionToolStripMenuItem.Visible = true;
            //    entidadesToolStripMenuItem.Visible = true;
            //    idiomasToolStripMenuItem.Visible = true;
            //    usuariosToolStripMenuItem.Visible = true;
            //    //espaciosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarEspacios, userPermission);

            //    seguridadToolStripMenuItem.Visible = true;
            //    rolesToolStripMenuItem.Visible = true;
            //    backupRestoreToolStripMenuItem.Visible = true;
            //    //seguridadUsuariosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.ConfigurarSeguridadUsuarios, userPermission);

            //    //negocioToolStripMenuItem (Este permiso se desglosará para cada tipo de role del negocio)
            //    negocioToolStripMenuItem.Visible = true;
            //}
        }

        private void CloseSesion()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != this)    //Cerramos todos los formularios menos el formulario principal que contiene el menú
                    frm.Close();
            }

            if (SessionManager.GetInstance.Usuario == null)
            {
                menuLanguage.Visible = false;
                menuCambiarClave.Visible = false;

                menuAdministrar.Visible = false;
                menuMaestros.Visible = false;
                menuTurnos.Visible = false;
                menuReportes.Visible = false;
                menuAyuda.Visible = false;
            }
        }

        public void ValidarForm()
        {
            this.menuLogout.Enabled = SessionManager.GetInstance.IsLogged;
            this.menuLogin.Enabled = !SessionManager.GetInstance.IsLogged;

            //this.menuLanguage.Enabled = SessionManager.GetInstance.IsLogged;

            if (SessionManager.GetInstance.IsLogged)
            {                
                this.lblEstado.Text = SessionManager.GetInstance.Usuario.LoginName;

                foreach (ToolStripMenuItem i in menuLanguage.DropDownItems)
                {
                    if (i.Text == SessionManager.GetInstance.Usuario.Language.Name)
                        i.Checked = true;
                    else 
                        i.Checked = false;
                }
                
                updateLanguage(SessionManager.GetInstance.language);
            }
            else
            {
                this.lblEstado.Text = "[Sesión no iniciada]";                
            }
            
            validatePermissions();
        }

        public void LoadComboLanguage()
        {
            menuLanguage.DropDown.Items.Clear();

            List<BE.Language> languages = language.GetLanguages();

            foreach (BE.Language item in languages)
            {
                ToolStripMenuItem i = new ToolStripMenuItem(item.Name);
                i.Tag = item;
                i.Click += languageChange_Click;
                if(SessionManager.GetInstance.Usuario != null)
                    i.Checked = (SessionManager.GetInstance.language.Name == item.Name) ? true : false;
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
            var newLang = language.GetLanguage(sender.ToString());
            SessionManager.GetInstance.ChangeLanguage(newLang);
            user.UserUpdate(SessionManager.GetInstance.Usuario);

            LoadComboLanguage();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirme",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                user.LogOut();
                CloseSesion();
                
                if (!SessionManager.GetInstance.IsLogged)
                {
                    CreateForm(typeof(frmLogin));
                }
                ValidarForm();
            }           
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmLogin));
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmLanguage));
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmUserChangePassword));
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmUser));
        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmUsersList));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void menuGestionEspacios_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmAreaList));
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmEntityList));
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmRegistrarTurno));
        }

        private void menuBackupRestore_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmBackupRestore));
        }

        private void menuPerfiles_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmRoles));
        }

        private void menuAgenda_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmAgenda));
        }

        private void crearPaciente_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmClient));
        }

        private void modificarPaciente_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmClientList));
        }
    }
}
