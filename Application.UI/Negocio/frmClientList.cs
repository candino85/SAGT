using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI.Negocio
{
    public partial class frmClientList : Form
    {
        BE.Client cliente_BE;
        BLL.Client cliente_BLL;
        public frmClientList()
        {
            InitializeComponent();
            
            cliente_BLL = new BLL.Client();
            
            Bind();
        }


        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            frmClient frmClient = new frmClient(this);
            frmMain frmMain = (frmMain)this.MdiParent;
            frmClient.Show();
        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmClient frmClient = new frmClient((BE.Client)dgvClients.Rows[e.RowIndex].DataBoundItem, this);
            frmMain frmMain = (frmMain)this.MdiParent;
            frmClient.Show();
        }

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
                dgvClients.DataSource = cliente_BLL.ClientList().FindAll(x => x.FullName.ToUpper().Contains(txtSearchClient.Text.ToUpper())); ;
                dgvClients.Columns["Id"].Visible = false;
                dgvClients.Columns["CreationDate"].Visible = false;
                dgvClients.Columns["FullName"].Visible = false;
            }
        }
    }
}
