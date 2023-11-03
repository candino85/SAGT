using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Language;
using System;
using System.Windows.Forms;

namespace Application.UI.Negocio.ABM
{
    public partial class frmEstudioList : Form, ILanguageObserver
    {
        BLL.Estudio estudio_BLL;
        public frmEstudioList()
        {
            InitializeComponent();

            estudio_BLL = new BLL.Estudio();
            Bind();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmEstudioList_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        public void Bind()
        {
            dgvEstudios.DataSource = null;
            dgvEstudios.DataSource = estudio_BLL.EstudioList();
            dgvEstudios.Columns["Id"].Visible = false;
        }

        private void frmEstudioList_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
            DataGridViewConfig();
        }

        private void DataGridViewConfig()
        {
            dgvEstudios.AllowUserToAddRows = false;
            dgvEstudios.AllowUserToDeleteRows = false;
            dgvEstudios.AllowUserToResizeRows = false;
            dgvEstudios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEstudios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEstudios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvEstudios.ReadOnly = true;
            dgvEstudios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudios.RowHeadersVisible = false;
            dgvEstudios.MultiSelect = false;
        }

        private void dgvEstudios_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEstudio formEstudio = new frmEstudio((BE.Estudio)dgvEstudios.Rows[e.RowIndex].DataBoundItem, this);
            frmMain formMain = (frmMain)this.MdiParent;
            formEstudio.Show();
            SessionManager.GetInstance.SubscribeObserver(formEstudio);
        }

        private void txtSearchEstudio_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchEstudio.Text))
            {
                dgvEstudios.DataSource = estudio_BLL.EstudioList();
            }
            else
            {
                dgvEstudios.DataSource = null;
                dgvEstudios.DataSource = estudio_BLL.EstudioList().FindAll(x => x.Nombre.ToUpper().Contains(txtSearchEstudio.Text.ToUpper()));
            }
        }
    }
}
