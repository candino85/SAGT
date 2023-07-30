using Application.ABSTRACTIONS;
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

namespace Application.UI.Negocio.ABM
{
    public partial class frmEspecialidad : Form, ILanguageObserver
    {

        BLL.Especialidad especialidad_BLL;
        BE.Especialidad especialidad_BE;
        public frmEspecialidad()
        {
            InitializeComponent();
            especialidad_BLL = new BLL.Especialidad();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool ok = false;
            especialidad_BE = new BE.Especialidad { Descripcion = txtName.Text };
            ok = especialidad_BLL.EspecialidadCreate(especialidad_BE);

            if (ok)
            { 
                MessageBox.Show("La espscialidad se creó correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Hubo un problema al intentar crear la nueva especialidad.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmEspecialidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }
    }
}
