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
using Application.BLL;
using Application.Services;

namespace Application.UI
{
    public partial class frmLogin : Form, IObserver
    {
        LoginService _loginService;
        //BE.Usuario _usuarioBE;

        public frmLogin()
        {
            InitializeComponent();
            _loginService = new LoginService();
            txtPassword.PasswordChar = '*';
           //_usuarioBE = new BE.Usuario();            
        }

        public void NotifyObserver(ILanguage languageObserver)
        {
            foreach (Control control in this.Controls)
            {
                control.Text = languageObserver.SearchTranslate(control.Tag.ToString());
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                _loginService.Login(this.txtNombreUsuario.Text, this.txtPassword.Text);
                frmMain frm = (frmMain)this.MdiParent;
                //
                //SessionManager.GetInstance.SubscribeObserver(frm);
                // setear idioma del usuario
                //
                //frm.lblSession.Text = SessionManager.GetInstance.Usuario.LoginName.ToString();
                frm.ValidarForm();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
