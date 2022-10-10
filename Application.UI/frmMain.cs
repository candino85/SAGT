using Application.ABSTRACTIONS;
using Application.BE;
using Application.BLL;
using Application.Services;
using Application.UI.Backup;
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

namespace Application.UI
{
    public partial class frmMain : Form, IObserver
    {
        LoginService _login;
        
        BLL.User user;
        BLL.Permission permission;
        UserPermission userPermission;

        BLL.Language _languageBLL;
        BE.Language _languageBE;
        BLL.Word _word;


        //TEST
        //Language language1 = new Language() { Id = 1, Nombre = "Español" };
        //Language language2 = new Language() { Id = 2, Nombre = "English" };
        public frmMain()
        {
            InitializeComponent();
            user = new BLL.User();
            permission = new BLL.Permission();
            userPermission = new UserPermission();          

            _login = new LoginService();
            _languageBLL = new BLL.Language();
            _languageBE = new BE.Language();
            _word = new BLL.Word();         
        }

        public void ValidatePermissions()
        {
            userPermission.Id = SessionManager.GetInstance.Usuario.Id;
            userPermission.Nombre = SessionManager.GetInstance.Usuario.Name;

            //sesionToolStripMenuItem
            menuLanguage.Visible = permission.FindUserPermissions(PermissionType.CambiarIdioma, userPermission);

            //gestionToolStripMenuItem
            entidadesToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarEntidades, userPermission);
            idiomasToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarIdioma, userPermission);
            usuariosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarUsuarios, userPermission);
            espaciosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.GestionarEspacios, userPermission);

            //seguridadToolStripMenuItem
            rolesToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.ConfigurarSeguridadRoles, userPermission);
            seguridadUsuariosToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.ConfigurarSeguridadUsuarios, userPermission);

            //negocioToolStripMenuItem (Este permiso se desglosará para cada tipo de role del negocio)
            negocioToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.ConfigurarNegocio, userPermission);

            //backupYRestoreToolStripMenuItem
            backupYRestoreToolStripMenuItem.Visible = permission.FindUserPermissions(PermissionType.BackupRestore, userPermission);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //AddAvailableLanguages();
            if (!SessionManager.GetInstance.IsLogged)
            {
                menuLogin_Click(sender, e);
            }

            ValidarForm();
        }

        public void ValidarForm()
        {
            //login menu settings
            this.menuLogin.Enabled = !SessionManager.GetInstance.IsLogged;
            this.menuLogout.Enabled = SessionManager.GetInstance.IsLogged;
            this.menuLanguage.Enabled = SessionManager.GetInstance.IsLogged;


            //
            if (SessionManager.GetInstance.IsLogged)
            {
                this.toolStripSesion.Text = SessionManager.GetInstance.Usuario.LoginName;

                //foreach (ToolStripMenuItem i in menuLanguage.DropDownItems)
                //{
                //    if (i.Text == SessionManager.GetInstance.Usuario.Idioma.Name)
                //        i.Checked = true;
                //}

                //NotifyObserver(SessionManager.GetInstance.Usuario.Idioma);
                
                ValidatePermissions();
            }
            else
                this.toolStripSesion.Text = "[ Sesión no iniciada ]";
        }

        /// <summary>
        /// This function cleans language's combobox from the menu and then bring the languages available and updated
        /// </summary>
        private void AddAvailableLanguages()
        {
            menuLanguage.DropDown.Items.Clear();
            _languageBLL = new BLL.Language();
            List<BE.Language> languages = _languageBLL.Listar();

            for (int i = 0; i < languages.Count; i++)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = languages[i].Id + languages[i].Name;
                item.Text = languages[i].Name;
                item.Click += new EventHandler(Language_Click);
                item.CheckOnClick = true;

                menuLanguage.DropDownItems.Add(item);
            }
        }

        private void Language_Click(object sender, EventArgs e)
        {
            if(sender.ToString() != SessionManager.GetInstance.Usuario.Idioma.Name)
            { 
                _languageBE = _languageBLL.GetLanguage(sender.ToString());
                
                SessionManager.GetInstance.Usuario.Idioma = _languageBE;
                user.UserUpdate(SessionManager.GetInstance.Usuario);
                
                NotifyObserver(SessionManager.GetInstance.Usuario.Idioma);

                frmMain_Load(null, EventArgs.Empty);
            }
            ValidarForm();
        }

        public void NotifyObserver(ILanguage languageObserver)
        {
            //tengo que traer las traducciones para el idioma seteado del usuario
            _languageBE = _languageBLL.GetLanguage(languageObserver.Name);

            foreach (Control control in this.Controls)
            {
                if (!string.IsNullOrEmpty(control.Text))
                    control.Text = _languageBE
                        .SearchTranslate(control.Tag.ToString());
                //control.Text = languageObserver.SearchTranslate(control.Tag.ToString());
            }
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.Show();            
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirme",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _login.Logout();
                ValidarForm();
                
                if (!SessionManager.GetInstance.IsLogged)
                {
                    menuLogin_Click(sender, e);
                }
            }           
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles frm = new frmRoles();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList frm = new frmUsersList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntityList frm = new frmEntityList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientList frm = new frmClientList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void backupYRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupRestore frm = new frmBackupRestore();
            frm.MdiParent = this;
            frm.Show();
        }

        //private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    _word = new BLL.Word();
        //    List<BE.Word> words = _word.GetWords();
        //    _languageBE = _languageBLL.GetLanguage("Español");
        //    SessionManager.GetInstance.ChangeLanguage(_languageBE);
        //}
        //private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    _word = new BLL.Word();
        //    List<BE.Word> words = _word.GetWords();
        //    _languageBE = _languageBLL.GetLanguage("English");
        //    SessionManager.GetInstance.ChangeLanguage(_languageBE);
        //}


        //private void tscbLanguages_VisibleChanged(object sender, EventArgs e)
        //{
        //    _languageBE = _languageBLL.GetLanguage(tscbLanguages.ComboBox.Text);
        //    SessionManager.GetInstance.Usuario.Idioma = _languageBE;
        //    frmMain_Load(null, EventArgs.Empty);
        //}

        //TEST
        //void GenerateTranslates()
        // {
        //     Word word1 = new Word() { Id = 1, Text = "Crear" };

        //     Translate translate1 = new Translate() { Id = 1, Word = word1, TranslateWord = "Crear" };
        //     Translate translate2 = new Translate() { Id = 2, Word = word1, TranslateWord = "Create" };

        //     Word word2 = new Word() { Id = 2, Text = "Editar" };

        //     Translate translate3 = new Translate() { Id = 3, Word = word2, TranslateWord = "Editar" };
        //     Translate translate4 = new Translate() { Id = 4, Word = word2, TranslateWord = "Edit" };

        //     Word word3 = new Word() { Id = 3, Text = "Eliminar" };

        //     Translate translate5 = new Translate() { Id = 5, Word = word3, TranslateWord = "Eliminar" };
        //     Translate translate6 = new Translate() { Id = 6, Word = word3, TranslateWord = "Delete" };

        //     Word word4 = new Word() { Id = 4, Text = "Estado" };

        //     Translate translate7 = new Translate() { Id = 7, Word = word4, TranslateWord = "Estado" };
        //     Translate translate8 = new Translate() { Id = 8, Word = word4, TranslateWord = "Status" };

        //     Word word5 = new Word() { Id = 5, Text = "DNI" };

        //     Translate translate9 = new Translate() { Id = 9, Word = word5, TranslateWord = "DNI" };
        //     Translate translate10 = new Translate() { Id = 10, Word = word5, TranslateWord = "ID" };

        //     Word word6 = new Word() { Id = 6, Text = "Nombre" };

        //     Translate translate11 = new Translate() { Id = 11, Word = word6, TranslateWord = "Nombre" };
        //     Translate translate12 = new Translate() { Id = 12, Word = word6, TranslateWord = "Name" };

        //     Word word7 = new Word() { Id = 7, Text = "Apellido" };

        //     Translate translate13 = new Translate() { Id = 13, Word = word7, TranslateWord = "Apellido" };
        //     Translate translate14 = new Translate() { Id = 14, Word = word7, TranslateWord = "Lastname" };

        //     Word word8 = new Word() { Id = 8, Text = "NombreUsuario" };

        //     Translate translate15 = new Translate() { Id = 15, Word = word8, TranslateWord = "Nombre Usuario" };
        //     Translate translate16 = new Translate() { Id = 16, Word = word8, TranslateWord = "Username" };

        //     Word word9 = new Word() { Id = 9, Text = "Password" };

        //     Translate translate17 = new Translate() { Id = 17, Word = word9, TranslateWord = "Password" };
        //     Translate translate18 = new Translate() { Id = 18, Word = word9, TranslateWord = "Password" };

        //     language1.AddTranslate(translate1);
        //     language1.AddTranslate(translate3);
        //     language1.AddTranslate(translate5);
        //     language1.AddTranslate(translate7);
        //     language1.AddTranslate(translate9);
        //     language1.AddTranslate(translate11);
        //     language1.AddTranslate(translate13);
        //     language1.AddTranslate(translate15);
        //     language1.AddTranslate(translate17);

        //     language2.AddTranslate(translate2);
        //     language2.AddTranslate(translate4);
        //     language2.AddTranslate(translate6);
        //     language2.AddTranslate(translate8);
        //     language2.AddTranslate(translate10);
        //     language2.AddTranslate(translate12);
        //     language2.AddTranslate(translate14);
        //     language2.AddTranslate(translate16);
        //     language2.AddTranslate(translate18);

        // }

        //public void NotifyObserver(ILanguage languageObserver)
        //{
        //    foreach (Control control in this.Controls)
        //    {
        //        control.Text = languageObserver.SearchTranslate(control.Tag.ToString());
        //    }
        //}

        //private void MostrarPermisos()
        //{
        //    Rol rolAdministrador = new Rol(1, "Administrador", null);
        //    Rol rolOperador = new Rol(2, "Operador", null);            

        //    Rol ABM_Clientes = new Rol(3, "ABM Clientes", rolOperador);
        //    Rol ABM_Entidades = new Rol(4, "ABM Entidades", rolAdministrador);

        //    Permiso AltaCliente = new Permiso(1, "Alta", ABM_Clientes);
        //    Permiso BajaCliente = new Permiso(1, "Baja", ABM_Clientes);
        //    Permiso ModificacionCliente = new Permiso(1, "Modificación", ABM_Clientes);

        //    Permiso AltaEntidad = new Permiso(1, "Alta", ABM_Entidades);
        //    Permiso BajaEntidad = new Permiso(1, "Baja", ABM_Entidades);
        //    Permiso ModificacionEntidad = new Permiso(1, "Modificación", ABM_Entidades);

        //    rolAdministrador.AddHijo(ABM_Entidades);

        //    rolOperador.AddHijo(ABM_Clientes);
        //    rolOperador.AddHijo(AltaCliente);

        //}

        //private void MostrarUsuario()
        //{
        //    if (_session.Equals(Guid.Empty))
        //        this.lblSession.Text = "Por favor, inicie session";
        //    else
        //    {
        //        this.lblSession.Text = _usuario.Application.BLL(Usuario);
        //    }
        //}
    }
}
