using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        LoginService _loginService;
        LanguageService _languageService;
        BE.Language _language;

        public frmLogin()
        {  
            InitializeComponent();
            _loginService = new LoginService();
            txtPassword.PasswordChar = '*';

            _languageService = new LanguageService();
            _language = _languageService.GetLanguage(_languageService.GetLanguages().ToList().Where(x => x.Default == true).First().Name);

            updateLanguage(_language);
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.UpdateLanguageRecursiveControls((BE.Language)_language,this.Controls);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                _loginService.Login(this.txtNombreUsuario.Text, this.txtPassword.Text);
                
                frmMain frm = (frmMain)this.MdiParent;
                
                frm.lblEstado.Text = SessionManager.GetInstance.Usuario.LoginName.ToString();
                frm.ValidarForm();
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
