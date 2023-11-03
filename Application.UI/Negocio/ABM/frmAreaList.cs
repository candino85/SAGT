using Application.ABSTRACTIONS;
using Application.Services;
using System;
using System.Windows.Forms;

namespace Application.UI.Negocio
{
    public partial class frmAreaList : Form
    {
        BLL.Area area;
        public frmAreaList()
        {
            InitializeComponent();
            area = new BLL.Area();
            Bind();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmArea formArea = new frmArea(this);
            frmMain frmMain = (frmMain)this.MdiParent;
            formArea.Show();
        }

        public void Bind()
        {
            dgv.DataSource = null;
            dgv.DataSource = area.AreaList();
            dgv.Columns["Id"].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dgv.DataSource = area.AreaList();
            }
            else
            {
                dgv.DataSource = null;
                dgv.DataSource = area.AreaList().FindAll(x => x.Description.ToUpper().Contains(txtSearch.Text.ToUpper())); ;
                dgv.Columns["Id"].Visible = false;
            }
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmArea formArea = new frmArea((BE.Area)dgv.Rows[e.RowIndex].DataBoundItem, this);
            frmMain formMain = (frmMain)this.MdiParent;
            formArea.Show();
            SessionManager.GetInstance.SubscribeObserver((ILanguageObserver)formArea);
        }
    }
}
