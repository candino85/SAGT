using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Language;
using System;
using System.Windows.Forms;

namespace Application.UI.Negocio
{
    public partial class frmClientList : Form, ILanguageObserver
    {
        BE.Client cliente_BE;
        BLL.Client cliente_BLL;
        public frmClientList()
        {
            InitializeComponent();

            cliente_BLL = new BLL.Client();
            Bind();
        }


        //private void btnCreateClient_Click(object sender, EventArgs e)
        //{
        //    //suscribirlo en los observers
        //    frmClient frmClient = new frmClient(this);
        //    frmMain frmMain = (frmMain)this.MdiParent;
        //    frmClient.Show();
        //}

        public void Bind()
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = cliente_BLL.ClientList();
            dgvClients.Columns["Id"].Visible = false;
            dgvClients.Columns["CreationDate"].Visible = false;
            dgvClients.Columns["FullName"].Visible = false;
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchClient.Text))
            {
                dgvClients.DataSource = cliente_BLL.ClientList();
            }
            else
            {
                dgvClients.DataSource = null;
                dgvClients.DataSource = cliente_BLL.ClientList().FindAll(x => x.FullName.ToUpper().Contains(txtSearchClient.Text.ToUpper()));
                dgvClients.Columns["Id"].Visible = false;
                dgvClients.Columns["CreationDate"].Visible = false;
                dgvClients.Columns["FullName"].Visible = false;
            }
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmClientList_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        private void dgvClients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmClient formClient = new frmClient((BE.Client)dgvClients.Rows[e.RowIndex].DataBoundItem, this);
            frmMain formMain = (frmMain)this.MdiParent;
            formClient.Show();
            SessionManager.GetInstance.SubscribeObserver(formClient);
        }

        private void frmClientList_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void DataGridViewConfig()
        {
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AllowUserToResizeRows = false;
            dgvClients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvClients.ReadOnly = true;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.RowHeadersVisible = false;
            dgvClients.MultiSelect = false;
        }
    }
}
