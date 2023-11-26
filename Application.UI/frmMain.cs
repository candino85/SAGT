using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Backup;
using Application.UI.Bitacora;
using Application.UI.Digito_Verificador;
using Application.UI.Language;
using Application.UI.Negocio;
using Application.UI.Negocio.ABM;
using Application.UI.Negocio.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Application.UI
{
    public partial class frmMain : Form, ILanguageObserver
    {
        BLL.Permission permission;
        BLL.User user;
        BLL.LanguageService language;
        Services.UserPermission userPermission;

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
            if (SessionManager.GetInstance.Usuario != null && SessionManager.GetInstance.Usuario.LoginName != "sysadmin") //&& SessionManager.GetInstance.Usuario.LoginName != "SysAdmin")
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
                menuBitacora.Visible = permission.FindUserPermissions(PermissionType.menuBitacora, userPermission);
                //menuDV.Visible = permission.FindUserPermissions(PermissionType.menuDV, userPermission);

                //maestros
                menuMaestros.Visible = permission.FindUserPermissions(PermissionType.menuMaestros, userPermission);
                menuSucursales.Visible = permission.FindUserPermissions(PermissionType.menuSucursales, userPermission);
                menuEspacios.Visible = permission.FindUserPermissions(PermissionType.menuEspacios, userPermission);
                menuClientes.Visible = permission.FindUserPermissions(PermissionType.menuClientes, userPermission);
                menuEspecialidades.Visible = permission.FindUserPermissions(PermissionType.menuEspecialidades, userPermission);
                menuEstudios.Visible = permission.FindUserPermissions(PermissionType.menuEstudios, userPermission);

                //turnos
                menuRegistrar.Visible = permission.FindUserPermissions(PermissionType.menuRegistrar, userPermission);
                menuTurno.Visible = permission.FindUserPermissions(PermissionType.menuTurno, userPermission);
                menuAgenda.Visible = permission.FindUserPermissions(PermissionType.menuAgenda, userPermission);
                menuMuestra.Visible = permission.FindUserPermissions(PermissionType.menuMuestra, userPermission);
                menuHistoricoDeCambios.Visible = permission.FindUserPermissions(PermissionType.menuHistoricoDeCambios, userPermission);

                //reportes
                menuReportes.Visible = permission.FindUserPermissions(PermissionType.menuReportes, userPermission);

                //ayuda
                menuAyuda.Visible = permission.FindUserPermissions(PermissionType.menuAyuda, userPermission);
            }
            else if (SessionManager.GetInstance.Usuario.LoginName == "sysadmin")
            {

                //sesion
                menuLanguage.Visible = true;
                menuCambiarClave.Visible = true;

                //administrar
                menuAdministrar.Visible = true;
                menuUsuarios.Visible = true;
                menuPerfiles.Visible = true;
                menuIdiomas.Visible = true;
                menuBackupRestore.Visible = true;
                menuBitacora.Visible = true;
                menuDV.Visible = true;

                //maestros
                menuMaestros.Visible = true;
                menuSucursales.Visible = true;
                menuEspacios.Visible = true;
                menuClientes.Visible = true;
                menuEspecialidades.Visible = true;
                menuEstudios.Visible = true;

                //turnos
                menuRegistrar.Visible = true;
                menuTurno.Visible = true;
                menuAgenda.Visible = true;
                menuMuestra.Visible = true;
                menuHistoricoDeCambios.Visible = true;

                //reportes
                menuReportes.Visible = true;

                //ayuda
                menuAyuda.Visible = true;

                //sesionToolStripMenuItem
                menuLanguage.Visible = true;
            }
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
                menuRegistrar.Visible = false;
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

            if (SessionManager.GetInstance.IsLogged)
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
                if (SessionManager.GetInstance.Usuario != null)
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
            user.UserUpdate(SessionManager.GetInstance.Usuario, "Cambio de idioma");

            LoadComboLanguage();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
            foreach (Form form in MdiChildren)
            {
                if (typeof(ILanguageObserver).IsAssignableFrom(form.GetType()))
                    SessionManager.GetInstance.UnsubscribeObserver((ILanguageObserver)form);
            }
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

        private void menuReportesTurnos_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmReport1));
        }

        private void crearEstudio_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmEstudio));
        }

        private void menuBitacora_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(FrmBitacora));
        }

        private void modificarEstudio_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmEstudioList));
        }

        private void menuTurno_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmRegistrarTurno));
        }

        private void menuSucursales_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmEntityList));
        }

        private void menuCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarUsuario_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmUsersList));
        }

        private void crearUsuario_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmUser));
        }

        private void menuCambiarClave_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmUserChangePassword));
        }

        private void menuIdiomas_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmLanguage));
        }

        private void menuEspacios_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmAreaList));
        }

        private void menuHistoricoDeCambios_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmBitacoraCambios));
        }

        private void menuDV_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmDigitoVerificador));
        }

        private void reporteDeCadenaDeCustodiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmReport2));
        }

        private void crearEspecialidad_Click(object sender, EventArgs e)
        {
            CreateForm(typeof(frmEspecialidad));
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"Resources\Ayuda.chm");
        }
    }
}
