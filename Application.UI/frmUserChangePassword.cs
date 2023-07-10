using Application.ABSTRACTIONS;
using Application.BE;
using Application.BLL;
using Application.Services;
using Application.UI.Language;
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
    public partial class frmUserChangePassword : Form, ILanguageObserver
    {
        BLL.User user;

        public frmUserChangePassword()
        {
            InitializeComponent();
            user = new BLL.User();

            updateLanguage(SessionManager.GetInstance.language);

            txtClaveActual.PasswordChar = '*';
            txtClaveNueva.PasswordChar = '*';
            txtClaveNueva2.PasswordChar = '*';
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmUserChangePassword_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmUserChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            string ctrl =  checkControls(txtClaveActual.TextBoxText, txtClaveNueva.TextBoxText, txtClaveNueva2.TextBoxText);

            switch (ctrl)
            {
                case "ICA":
                    MessageBox.Show("Ingrese su clave actual");
                    break;
                case "CN1O2I":
                    MessageBox.Show("Ingrese la nueva clave");
                    break;
                case "CNNC":
                    MessageBox.Show("La nueva clave y la confirmación no coinciden");
                    break;
                case "OK":

                        var msg = user.UpdatePassword(txtClaveActual.TextBoxText, txtClaveNueva.TextBoxText);
                        string  msgtoshw = "";
                        if (msg == "CM")
                            msgtoshw = "La contraseña fue modificada con éxito.";
                        else if (msg == "HP")
                            msgtoshw = "Hubo un problema al modificar la contraseña.";
                        else if (msg == "CI")
                            msgtoshw = "La contraseña actual es incorrecta.";

                        MessageBox.Show(msgtoshw, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if (msg == "HP" || msg == "CI" || msg == "CM")
                            this.Close();
                    break;
            }             
        }

        private string checkControls(string claveActual, string claveNueva1, string claveNueva2)
        {
            if (string.IsNullOrEmpty(claveActual))
                return "ICA";                   //ingresar clave actual
            else if (string.IsNullOrEmpty(claveNueva1) || string.IsNullOrEmpty(claveNueva2))
                return "CN1O2I";                //ingresar clave nueva
            else if (claveNueva1 != claveNueva2)
                return "CNNC";                  //nuevas claves no coinciden
            else 
                return "OK";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
