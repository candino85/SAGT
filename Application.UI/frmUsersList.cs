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

namespace Application.UI
{
    public partial class frmUsersList : Form, ILanguageObserver
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

        //private void btnCreateUser_Click(object sender, EventArgs e)
        //{
        //    frmUser frmUser = new frmUser(this);
        //    frmMain frmMain = (frmMain)this.MdiParent;
        //    frmUser.Show();

        //    Bind();
        //}

        public void Bind()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = usuario_BLL.UserList();
            dgvUsers.Columns["Id"].Visible = false;
            dgvUsers.Columns["CreationDate"].Visible = false;
            dgvUsers.Columns["FullName"].Visible = false;
            dgvUsers.Columns["Password"].Visible = false;
            dgvUsers.Columns["Role"].Visible = false;
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchUser.Text))
            {
                dgvUsers.DataSource = usuario_BLL.UserList();
            }
            else
            {
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = usuario_BLL.UserList().FindAll(x => x.FullName.ToUpper().Contains(txtSearchUser.Text.ToUpper())); ;
                dgvUsers.Columns["Id"].Visible = false;
                dgvUsers.Columns["CreationDate"].Visible = false;
                dgvUsers.Columns["FullName"].Visible = false;
                dgvUsers.Columns["Password"].Visible = false;
                dgvUsers.Columns["Role"].Visible = false;
            }
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmUsersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }
    }
}
