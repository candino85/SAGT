using Application.ABSTRACTIONS;
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

namespace Application.UI.Language
{
    public partial class frmLanguageNew : Form, ILanguageObserver
    {
        LanguageService languageService;

        private frmLanguage _frmLanguage;
        public frmLanguageNew()
        {
            InitializeComponent();
            languageService = new LanguageService();
            _frmLanguage = new frmLanguage();
        }

        private void btnSaveNewLanguage_Click(object sender, EventArgs e)
        {
            var newLanguage = languageService.GetLanguage(txtNewLanguageName.Text);
            if (newLanguage.Name is null)
            {
                try
                {
                    languageService.CreateNewLanguage(txtNewLanguageName.Text);
                    //*QUE HACEMOS DESPUES DE AGREGAR EL NUEVO LENGUAGE?

                    _frmLanguage.RefreshDataGrid();
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
                MessageBox.Show("El idioma que intenta agregar ya existe", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmLanguageNew_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmLanguageNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }
    }
}
