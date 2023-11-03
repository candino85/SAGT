using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Language;
using System;
using System.Windows.Forms;

namespace Application.UI.Negocio.ABM
{
    public partial class frmEstudio : Form, ILanguageObserver
    {
        BE.Estudio estudio_BE;
        BLL.Estudio estudio_BLL;

        BLL.Especialidad especialidad_BLL = new BLL.Especialidad();

        private frmEstudioList _frmEstudioList;
        private frmRegistrarTurno _frmRegistrarTurno;

        public frmEstudio()
        {
            InitializeComponent();

            estudio_BLL = new BLL.Estudio();

            estudio_BLL = new BLL.Estudio();
            especialidad_BLL = new BLL.Especialidad();

            cmbEspecialidad.DataSource = especialidad_BLL.EspecialidadList();
            cmbEspecialidad.ValueMember = "Id";
            cmbEspecialidad.DisplayMember = "Descripcion";
            cmbEspecialidad.SelectedValue = -1;

            btnModify.Enabled = false;
            btnRemove.Enabled = false;
        }

        public frmEstudio(BE.Estudio estudio, frmEstudioList frmEstudioList)
        {
            InitializeComponent();
            estudio_BE = estudio;

            _frmEstudioList = frmEstudioList;

            btnCreate.Enabled = false;
            btnModify.Enabled = true;
            btnRemove.Enabled = false;

            txtName.Text = estudio_BE.Nombre;

            cmbEspecialidad.DataSource = especialidad_BLL.EspecialidadList();
            cmbEspecialidad.ValueMember = "Id";
            cmbEspecialidad.DisplayMember = "Descripcion";
            cmbEspecialidad.SelectedValue = estudio_BE.Especialidad.Id;

            cmbTiempo.SelectedItem = estudio_BE.Tiempo.ToString();
        }

        public frmEstudio(frmRegistrarTurno frmRegistrarTurno)
        {
            InitializeComponent();
            _frmRegistrarTurno = frmRegistrarTurno;

            estudio_BLL = new BLL.Estudio();
            especialidad_BLL = new BLL.Especialidad();

            cmbEspecialidad.DataSource = especialidad_BLL.EspecialidadList();
            cmbEspecialidad.ValueMember = "Id";
            cmbEspecialidad.DisplayMember = "Descripcion";
            cmbEspecialidad.SelectedValue = -1;

            btnModify.Enabled = false;
            btnRemove.Enabled = false;

            cmbTiempo.Enabled = false;
            chkActive.Enabled = false;

        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedValue != null)
            {
                estudio_BE = new BE.Estudio()
                {
                    Nombre = txtName.Text,
                    Especialidad = especialidad_BLL.GetEspecialidadById((int)cmbEspecialidad.SelectedValue),
                    Tiempo = int.Parse(cmbTiempo.SelectedItem.ToString()),
                    Activo = chkActive.Checked
                };
            }
            else
                MessageBox.Show("Seleccione una Especialidad!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bool operation = estudio_BLL.EstudioCreate(estudio_BE);

            if (!operation)
                throw new Exception("Error al crear el cliente");
            else
                MessageBox.Show("El nueo estudio se guardó correctamente para futuros reportes", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void frmEstudio_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmEstudio_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }
    }
}
