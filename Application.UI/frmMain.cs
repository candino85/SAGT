using Application.ABSTRACTIONS;
using Application.BE;
using Application.BLL;
using Application.Services;
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
    public partial class frmMain : Form//, IObserver
    {
        LoginService _login;
        BLL.Language _languageBLL;
        BE.Language _languageBE;
        BLL.Word _word;

        //TEST
        //Language language1 = new Language() { Id = 1, Nombre = "Español" };
        //Language language2 = new Language() { Id = 2, Nombre = "English" };
        public frmMain()
        {
            InitializeComponent();           
            _login = new LoginService();
            _languageBLL = new BLL.Language();            
            _languageBE = new BE.Language();            
            _word = new BLL.Word();

            ValidarForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            //GenerateTranslates();
            //if (SessionManager.GetInstance.IsLogged)
            //    NotifyObserver(SessionManager.GetInstance.Usuario.Idioma);
            AddAvailableLanguages();
        }

        public void ValidarForm()
        {            
            this.menuLogin.Enabled = !SessionManager.GetInstance.IsLogged;
            this.menuLogout.Enabled = SessionManager.GetInstance.IsLogged;
            this.menuLanguage.Enabled = SessionManager.GetInstance.IsLogged;
        }

        public void AddAvailableLanguages()
        {
            _languageBLL = new BLL.Language();

            List<BE.Language> languages = _languageBLL.Listar();
            foreach (BE.Language language in languages)
            {
                menuLanguage.DropDownItems.Add(language.Name);
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
            _login.Logout();
            lblSession.Text = null;
            ValidarForm();
        }

        private void aBMUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermission frm = new frmPermission();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles frm = new frmRoles();
            frm.MdiParent = this;
            frm.Show();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _word = new BLL.Word();
            List<BE.Word> words = _word.GetWords();
            _languageBE = _languageBLL.GetLanguage("Español");
            SessionManager.GetInstance.ChangeLanguage(_languageBE);
        }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _word = new BLL.Word();
            List<BE.Word> words = _word.GetWords();
            _languageBE = _languageBLL.GetLanguage("English");
            SessionManager.GetInstance.ChangeLanguage(_languageBE);
        }

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
