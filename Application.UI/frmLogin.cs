using System;
using System.Linq;
using System.Windows.Forms;
using Application.ABSTRACTIONS;
using Application.BE;
using Application.BLL;
using Application.Services;
using Application.UI.Language;

namespace Application.UI
{
    public partial class frmLogin : Form, ILanguageObserver
    {
        //readonly LoginService _loginService;
        readonly LanguageService _languageService;
        readonly BE.Language _language;

        readonly BLL.User _user;

        public frmLogin()
        {  
            InitializeComponent();
            //_loginService = new LoginService();
            _user = new BLL.User();
            txtPassword.PasswordChar = '*';

            _languageService = new LanguageService();
            _language = _languageService.GetLanguage(_languageService.GetLanguages().ToList().First(x => x.Default == true).Name);

            updateLanguage(_language);
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.UpdateLanguageRecursiveControls((BE.Language)_language,this.Controls);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_user.LogIn(this.txtNombreUsuario.Text, this.txtPassword.Text), "Bievenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (SessionManager.GetInstance.IsLogged)
            {                 
                frmMain frm = (frmMain)this.MdiParent;            
                frm.lblEstado.Text = SessionManager.GetInstance.Usuario.LoginName.ToString();
                frm.ValidarForm();
                this.Close();
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
