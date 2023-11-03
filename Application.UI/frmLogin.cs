using Application.ABSTRACTIONS;
using Application.BLL;
using Application.Services;
using Application.UI.Digito_Verificador;
using Application.UI.Language;
using Microsoft.AnalysisServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Application.UI
{
    public partial class frmLogin : Form, ILanguageObserver
    {
        //readonly LoginService _loginService;
        readonly LanguageService _languageService;
        readonly BE.Language _language;
        readonly BLL.User _user;
        readonly BE.Bitacora _bitacora;
        IntegrityService integrityService;
        BLL.Permission permission;
        Services.UserPermission userPermission;

        public frmLogin()
        {
            InitializeComponent();
            //_loginService = new LoginService();
            _user = new BLL.User();
            txtPassword.PasswordChar = '*';

            _languageService = new LanguageService();
            _language = _languageService.GetLanguage(_languageService.GetLanguages().ToList().First(x => x.Default == true).Name);

            updateLanguage(_language);

            integrityService = new IntegrityService();
            permission = new BLL.Permission();
            userPermission = new UserPermission();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.UpdateLanguageRecursiveControls((BE.Language)_language, this.Controls);
        }

        public bool hasValues(List<Dictionary<string, string>> tablas)
        {
            bool hasValue = false;
            foreach (Dictionary<string, string> row in tablas)
            {
                foreach (var item in tablas)
                {
                    if (item.Any(x => x.Key == "DVV"))
                        hasValue = true;
                }
            }
            return hasValue;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_user.LogIn(this.txtNombreUsuario.Text, this.txtPassword.Text), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var integrityResult = integrityService.IntegrityCheck("Usuarios, Turno");

            if (SessionManager.GetInstance.IsLogged)
            {
                frmMain frm = (frmMain)this.MdiParent;
                if (!hasValues(integrityResult))
                {

                    frm.lblEstado.Text = SessionManager.GetInstance.Usuario.LoginName.ToString();
                    frm.ValidarForm();
                    this.Close();
                }
                else
                {
                    userPermission.Id = SessionManager.GetInstance.Usuario.Id;
                    userPermission.Nombre = SessionManager.GetInstance.Usuario.Name;

                    var hasPermissionToDV = permission.FindUserPermissions(PermissionType.menuDV, userPermission);
                    
                    if (hasPermissionToDV)
                    {                        
                        var msg = "*** ERROR EN LA COMPROBACIÓN DE INTEGRIDAD EN LA BASE DE DATOS ***";

                        foreach (var item in integrityResult)
                        {
                            var message = "";

                            if (item.Count != 0)
                            {
                                msg += $"\r\n\r\n{item["tabla"].ToUpper()}:\r\n";

                                foreach (KeyValuePair<string, string> key in item)
                                {
                                    if (key.Key != "tabla" && key.Key != "DVV")
                                    {
                                        message += $" {key.Key} ";
                                    }
                                }

                                msg += $"Error de integridad en los IDs: {message}\r\n";
                            }
                        }
                      
                        frmDigitoVerificador frmDigitoVerificador = new frmDigitoVerificador(msg);
                        frmDigitoVerificador.ShowDialog();
                        this.Close();
                    }
                    else
                    { 
                        MessageBox.Show("El sistema no está disponible en este momento, comuniquese con un administrador para reestablecer el servicio.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        _user.LogOut();
                    }
                }
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
