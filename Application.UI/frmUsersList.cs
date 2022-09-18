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
    public partial class frmUsersList : Form
    {
        BLL.User usuario_BLL;

        public frmUsersList()
        {
            InitializeComponent();
            usuario_BLL = new BLL.User();
            Bind();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUser frmUser = new frmUser((BE.User)dgvUsers.Rows[e.RowIndex].DataBoundItem,this);
            frmMain frmMain = (frmMain)this.MdiParent;
            frmUser.Show();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser(this);
            frmMain frmMain = (frmMain)this.MdiParent;
            frmUser.Show();
        }

        public void Bind()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = usuario_BLL.UserList();
            dgvUsers.Columns["GUID"].Visible = false;
            dgvUsers.Columns["Id"].Visible = false;
            dgvUsers.Columns["Password"].Visible = false;
        }
    }
}
